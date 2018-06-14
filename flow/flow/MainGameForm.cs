using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace flow
{
	public partial class MainGameForm : Form
	{
		public User UserPlayer { get; set; }
		public bool MouseIsDown { get; set; }
		public bool GridIsSet { get; set; }
		public int PreviousLevel { get; set; }
		public LinkedListNode<Cell> LastVisitedCell { get; set; }
		public Cell PrevCell { get; set; }
		public int UpDownStart { get; set; } // 1 up, -1 down
		public Timer Timer { get; set; }
		public bool ExitForReal { get; set; } = true;

		public MainGameForm(User user)
		{
			InitializeComponent();
			this.DoubleBuffered = true;
			UserPlayer = user;
			Text = $"Flow - {UserPlayer.Name}";
			UserPlayer.MyGame.TimeElapsed = new Stopwatch();
		}

		private void Form3_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.Clear(Color.Black);
			UserPlayer.MyGame.Grid.FormGraphics = e.Graphics;
			UserPlayer.MyGame.Grid.Draw();
			UserPlayer.Levels.Draw(e.Graphics, UserPlayer.MyGame.LevelGroup, UserPlayer.MyGame.LevelNumber,
				UserPlayer.SolvedLevels);

		}

		private void Form3_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.X > 500) // level choosing
			{
				int groupOrLevel = UserPlayer.Levels.IsGroupOrLevelUnderMouse(e.X, e.Y, out int groupLevel);
				if (groupOrLevel > 0)
				{
					UserPlayer.MyGame.LevelGroup = groupLevel;
					UserPlayer.MyGame.LevelNumber = 1;
				}
				else if (groupOrLevel < 0)
					UserPlayer.MyGame.LevelNumber = groupLevel;

				if (UserPlayer.MyGame.LevelGroup * UserPlayer.MyGame.LevelNumber != 0)
				{
					UserPlayer.MyGame.Grid =
						UserPlayer.Levels.RegularLevels[UserPlayer.MyGame.LevelGroup][UserPlayer.MyGame.LevelNumber];
					GridIsSet = true;
					connectedPipesLabel.Text =
						$"Flows: {UserPlayer.MyGame.Grid.CompletedPipes.Values.Count(v => v)}/{UserPlayer.MyGame.Grid.Paths.Count}";
					pipeFinishedLabel.Text = $"Pipe: {UserPlayer.MyGame.Grid.FinishedPercent}%";
					if (Timer != null)
						Timer.Tick -= Timer_Tick;
					Timer = new Timer {Interval = 1000};
					Timer.Tick += Timer_Tick;
					elapsedTimeLabel.Text = "Time: 00:00";
					UserPlayer.MyGame.TimeElapsed.Reset();
					UserPlayer.MyGame.TimeElapsed.Start();
					Timer.Start();
					Invalidate();
				}

				return;
			}



			if (e.Button != MouseButtons.Left || !GridIsSet)
				return;
			var Cell = UserPlayer.MyGame.Grid.GetCellUnderMouse(e.X, e.Y);
			if (Cell.Color == Color.Black)
				return;
			MouseIsDown = true;
			UserPlayer.MyGame.FirstColor = Cell.Color;
			LastVisitedCell = UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].LastAddedCell;
			PrevCell = Cell;

			if (Cell is InitialCell && UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Count > 2)
			{
				var node = UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.First;
				while (node != null)
				{
					var next = node.Next;
					if (node.Value is InitialCell)
					{
						foreach (Cell[] row in UserPlayer.MyGame.Grid.Cells)
						{
							foreach (Cell cell in row)
							{
								if (Equals(cell, node.Value))
								{
									node.Value.PipeDirection.Clear();
									node.Value.IsConnected = false;
									node.Value.NumberOfPipes = 0;
									goto Outside;
								}
							}
						}
					}

					if (node.Value is NormalCell)
					{
						UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Remove(node);
						foreach (Cell[] row in UserPlayer.MyGame.Grid.Cells)
						{
							foreach (Cell cell in row)
							{
								if (Equals(cell, node.Value))
								{
									node.Value.PipeDirection.Clear();
									node.Value.Color = Color.Black;
									node.Value.IsConnected = false;
									node.Value.NumberOfPipes = 0;
									goto Outside;
								}
							}
						}
					}

					Outside:

					node = next;
					Invalidate();
				}
			}
			else if (UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Count > 2) // started
			{
				if (UpDownStart == 1) // clear down
				{
					var node = UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Find(Cell)?.Next;
					while (node?.Value is NormalCell)
					{
						var next = node.Next;
						UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Remove(node);
						foreach (Cell[] row in UserPlayer.MyGame.Grid.Cells)
						{
							foreach (Cell cell in row)
							{
								if (Equals(cell, node.Value))
								{
									node.Value.PipeDirection.Clear();
									node.Value.Color = Color.Black;
									node.Value.IsConnected = false;
									node.Value.NumberOfPipes = 0;
									goto Outside;
								}
							}
						}

						Outside:
						node = next;
					}

					//Invalidate();
				}
				else // clear up
				{
					var node = UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Find(Cell)?.Previous;
					while (node?.Value is NormalCell)
					{
						var prev = node.Previous;
						UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Remove(node);
						foreach (Cell[] row in UserPlayer.MyGame.Grid.Cells)
						{
							foreach (Cell cell in row)
							{
								if (Equals(cell, node.Value))
								{
									node.Value.PipeDirection.Clear();
									node.Value.Color = Color.Black;
									node.Value.IsConnected = false;
									node.Value.NumberOfPipes = 0;
									goto Outside;
								}
							}
						}

						Outside:
						node = prev;
					}
				}
			}


			if (Equals(Cell, UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.First.Value))
				UpDownStart = 1;
			else if (Equals(Cell, UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Last.Value))
				UpDownStart = -1;
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			elapsedTimeLabel.Text = $"Time: {UserPlayer.MyGame.TimeElapsed.Elapsed:mm\\:ss}";
		}

		private void Form3_MouseUp(object sender, MouseEventArgs e)
		{
			MouseIsDown = false;
		}

		private void Form3_MouseMove(object sender, MouseEventArgs e)
		{
			//label1.Text = PreviousLevel.ToString();
			if (MouseIsDown)
			{
				var Cell = UserPlayer.MyGame.Grid.GetCellUnderMouse(e.X, e.Y);

				Color beforeColor = Cell.Color;

				// clear on touch another
				if (beforeColor != Color.Black && beforeColor != UserPlayer.MyGame.FirstColor)
				{
					var node = UserPlayer.MyGame.Grid.Paths[beforeColor].PathList.First;
					while (node != null)
					{
						var next = node.Next;
						if (node.Value is InitialCell)
						{
							foreach (Cell[] row in UserPlayer.MyGame.Grid.Cells)
							{
								foreach (Cell cell in row)
								{
									if (Equals(cell, node.Value))
									{
										node.Value.PipeDirection.Clear();
										node.Value.IsConnected = false;
										node.Value.NumberOfPipes = 0;
										goto Outside;
									}
								}
							}
						}

						if (node.Value is NormalCell)
						{
							UserPlayer.MyGame.Grid.Paths[beforeColor].PathList.Remove(node);
							foreach (Cell[] row in UserPlayer.MyGame.Grid.Cells)
							{
								foreach (Cell cell in row)
								{
									if (Equals(cell, node.Value))
									{
										node.Value.PipeDirection.Clear();
										node.Value.Color = Color.Black;
										node.Value.IsConnected = false;
										node.Value.NumberOfPipes = 0;
										goto Outside;
									}
								}
							}
						}

						Outside:

						node = next;
						Invalidate();
					}
				}

				if (!UserPlayer.MyGame.Grid.AreAdjacent(PrevCell, Cell))
					return;

				if (Cell is NormalCell &&
					beforeColor != Color.Black &&
					beforeColor == UserPlayer.MyGame.FirstColor &&
					UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Contains(Cell) &&
					!Equals(UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.First.Next?.Value, Cell) &&
					!Equals(UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Last.Previous?.Value, Cell))
				{
					if (UpDownStart == 1) // clear down
					{
						var node = UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Find(Cell)?.Next;
						while (node?.Value is NormalCell)
						{
							var next = node.Next;
							UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Remove(node);
							foreach (Cell[] row in UserPlayer.MyGame.Grid.Cells)
							{
								foreach (Cell cell in row)
								{
									if (Equals(cell, node.Value))
									{
										node.Value.PipeDirection.Clear();
										node.Value.Color = Color.Black;
										node.Value.IsConnected = false;
										node.Value.NumberOfPipes = 0;
										goto Outside;
									}
								}
							}

							Outside:
							node = next;
						}

						//Invalidate();
					}
					else // clear up
					{
						var node = UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Find(Cell)?.Previous;
						while (node?.Value is NormalCell)
						{
							var prev = node.Previous;
							UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Remove(node);
							foreach (Cell[] row in UserPlayer.MyGame.Grid.Cells)
							{
								foreach (Cell cell in row)
								{
									if (Equals(cell, node.Value))
									{
										node.Value.PipeDirection.Clear();
										node.Value.Color = Color.Black;
										node.Value.IsConnected = false;
										node.Value.NumberOfPipes = 0;
										goto Outside;
									}
								}
							}

							Outside:
							node = prev;
						}
					}
				}



				if (!(Cell is InitialCell) && !UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Contains(Cell))
				{
					Cell.Color = UserPlayer.MyGame.FirstColor;

					if (UpDownStart == 1)
						LastVisitedCell = UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList
							.AddBefore(UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Last, Cell);
					else
						LastVisitedCell = UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList
							.AddAfter(UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.First, Cell);

					UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].Update();
					pipeFinishedLabel.Text = $"Pipe: {UserPlayer.MyGame.Grid.FinishedPercent}%";
					//label2.Text = UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].ToString();

					PrevCell = Cell;
					Invalidate();
					Pipes.Graphics = UserPlayer.MyGame.Grid.FormGraphics;

				}

				if (Cell is InitialCell && UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Count > 2 &&
					(UserPlayer.MyGame.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.Last.Value.Equals(Cell) || UserPlayer.MyGame
						.Grid.Paths[UserPlayer.MyGame.FirstColor].PathList.First.Value.Equals(Cell)))
				{
					//label2.Text = "OVER";
					UserPlayer.MyGame.Grid.CompletedPipes[UserPlayer.MyGame.FirstColor] = true;
					connectedPipesLabel.Text =
						$"Flows: {UserPlayer.MyGame.Grid.CompletedPipes.Values.Count(v => v)}/{UserPlayer.MyGame.Grid.Paths.Count}";
					if (UserPlayer.MyGame.Grid.CompletedPipes.Values.Count(v => v) == UserPlayer.MyGame.Grid.Paths.Count)
					{
						if (!UserPlayer.SolvedLevels.ContainsKey(UserPlayer.MyGame.LevelGroup))
							UserPlayer.SolvedLevels[UserPlayer.MyGame.LevelGroup] = new HashSet<int>();
						UserPlayer.SolvedLevels[UserPlayer.MyGame.LevelGroup].Add(UserPlayer.MyGame.LevelNumber);
					}

					Text = UserPlayer.ToString();

					Invalidate();
				}
			}
		}

		private void resetButton_Click(object sender, EventArgs e)
		{
			UserPlayer.Levels.RegularLevels[UserPlayer.MyGame.LevelGroup][UserPlayer.MyGame.LevelNumber].Reset();
			//label2.Text = "";
			connectedPipesLabel.Text = $"Flows: 0/{UserPlayer.MyGame.Grid.Paths.Count}";
			elapsedTimeLabel.Text = "Time: 00:00";
			pipeFinishedLabel.Text = $"Pipe: {UserPlayer.MyGame.Grid.FinishedPercent}%";
			UserPlayer.MyGame.TimeElapsed.Reset();
			UserPlayer.MyGame.TimeElapsed.Start();
			UserPlayer.SolvedLevels[UserPlayer.MyGame.LevelGroup].Remove(UserPlayer.MyGame.LevelNumber);

			Invalidate();
		}

		private void MainGameForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (ExitForReal)
				Application.Exit();
		}

		public void SaveFile()
		{
			string fileName = UserPlayer.Name;
			BinaryFormatter formatter = new BinaryFormatter();
			using (FileStream file = File.Create("../../SaveGames/" + fileName + ".flw"))
				formatter.Serialize(file, UserPlayer);
		}

		private void MainGameForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (UserPlayer.ChangedSomething)
				e.Cancel = MessageBox.Show(
								"Are you sure you want to close the game without saving? Unsaved changes will be lost",
								"Exit without save?", MessageBoxButtons.YesNo) == DialogResult.No;
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			SaveFile();
		}

		private void logOutButton_Click(object sender, EventArgs e)
		{
			var loginForm = new LoginForm();
			loginForm.Show();
			ExitForReal = false;
			Close();
		}
	}
}
