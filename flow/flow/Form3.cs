using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flow
{
	public partial class Form3 : Form
	{
        public Grid Grid { get; set; } = Grid.Empty;
        public bool MouseIsDown { get; set; }
        public Color FirstColor { get; set; }
        public bool GridIsSet { get; set; }
        public int PreviousLevel { get; set; }
        public LinkedListNode<Cell> LastVisitedCell { get; set; }
	    public Cell PrevCell { get; set; }
	    public Graphics GraphicsTest { get; set; }
		public int UpDownStart { get; set; } // 1 up, -1 down

        public Form3()
		{
			InitializeComponent();
            this.DoubleBuffered = true;
		}

		private void Form3_Paint(object sender, PaintEventArgs e)
		{
		    GraphicsTest = e.Graphics;
            e.Graphics.Clear(Color.Black);
            Grid.formGraphics = e.Graphics;
			Grid.Draw();
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || e.X > 500 || !GridIsSet)
                return;
            var Cell = Grid.GetCellUnderMouse(e.X, e.Y);
            if (Cell.Color == Color.Black)
                return;
            MouseIsDown = true;
            FirstColor = Cell.Color;
            LastVisitedCell = Grid.Paths[FirstColor].LastAddedCell;
            PrevCell = Cell;

			if (Cell is InitialCell && Grid.Paths[FirstColor].PathList.Count > 2)
			{
				var node = Grid.Paths[FirstColor].PathList.First;
				while (node != null)
				{
					var next = node.Next;
					if (node.Value is InitialCell)
					{
						foreach (Cell[] row in Grid.Cells)
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
						Grid.Paths[FirstColor].PathList.Remove(node);
						foreach (Cell[] row in Grid.Cells)
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
			else if (Grid.Paths[FirstColor].PathList.Count > 2) // started
			{
				if (UpDownStart == 1) // clear down
				{
					var node = Grid.Paths[FirstColor].PathList.Find(Cell)?.Next;
					while (node?.Value is NormalCell)
					{
						var next = node.Next;
						Grid.Paths[FirstColor].PathList.Remove(node);
						foreach (Cell[] row in Grid.Cells)
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
					var node = Grid.Paths[FirstColor].PathList.Find(Cell)?.Previous;
					while (node?.Value is NormalCell)
					{
						var prev = node.Previous;
						Grid.Paths[FirstColor].PathList.Remove(node);
						foreach (Cell[] row in Grid.Cells)
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


			if (Equals(Cell, Grid.Paths[FirstColor].PathList.First.Value))
				UpDownStart = 1;
			else if (Equals(Cell, Grid.Paths[FirstColor].PathList.Last.Value))
				UpDownStart = -1;
		}

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            MouseIsDown = false;
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = PreviousLevel.ToString();
            if (MouseIsDown)
            {
                var Cell = Grid.GetCellUnderMouse(e.X, e.Y);

				Color beforeColor = Cell.Color;

				// clear on touch another
				if (beforeColor != Color.Black && beforeColor != FirstColor)
				{
					var node = Grid.Paths[beforeColor].PathList.First;
					while (node != null)
					{
						var next = node.Next;
						if (node.Value is InitialCell)
						{
							foreach (Cell[] row in Grid.Cells)
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
							Grid.Paths[beforeColor].PathList.Remove(node);
							foreach (Cell[] row in Grid.Cells)
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

				if (!Grid.AreAdjacent(PrevCell, Cell))
					return;

				// TODO ERROR
				// clear on touch self
				if (Cell is NormalCell &&
					beforeColor != Color.Black && 
					beforeColor == FirstColor && 
					Grid.Paths[FirstColor].PathList.Contains(Cell) &&
					!Equals(Grid.Paths[FirstColor].PathList.First.Next?.Value, Cell) &&
					!Equals(Grid.Paths[FirstColor].PathList.Last.Previous?.Value, Cell))
				{
					if (UpDownStart == 1) // clear down
					{
						var node = Grid.Paths[FirstColor].PathList.Find(Cell)?.Next;
						while (node?.Value is NormalCell)
						{
							var next = node.Next;
							Grid.Paths[FirstColor].PathList.Remove(node);
							foreach (Cell[] row in Grid.Cells)
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
						var node = Grid.Paths[FirstColor].PathList.Find(Cell)?.Previous;
						while (node?.Value is NormalCell)
						{
							var prev = node.Previous;
							Grid.Paths[FirstColor].PathList.Remove(node);
							foreach (Cell[] row in Grid.Cells)
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

				

				if (!(Cell is InitialCell) && !Grid.Paths[FirstColor].PathList.Contains(Cell))
                {
                    Cell.Color = FirstColor;

					if (UpDownStart == 1)
						LastVisitedCell = Grid.Paths[FirstColor].PathList.AddBefore(Grid.Paths[FirstColor].PathList.Last, Cell);
					else
						LastVisitedCell = Grid.Paths[FirstColor].PathList.AddAfter(Grid.Paths[FirstColor].PathList.First, Cell);

					Grid.Paths[FirstColor].Update();
                    label2.Text = Grid.Paths[FirstColor].ToString();
                    
                    PrevCell = Cell;
                    Invalidate();
                    Pipes.Graphics = Grid.formGraphics;

                }

				if (Cell is InitialCell && Grid.Paths[FirstColor].PathList.Count > 2 && (Grid.Paths[FirstColor].PathList.Last.Value.Equals(Cell) || Grid.Paths[FirstColor].PathList.First.Value.Equals(Cell)))
				{
					label2.Text = "OVER";
					Invalidate();
				}
			}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int level))
            {
				GridIsSet = true;
				Grid = Levels.RegularLevels[6][1];
            }
            else
            {
                GridIsSet = true;
                Grid = Levels.RegularLevels[6][level];
                if (PreviousLevel != 0 && level != PreviousLevel)
                {
					//MessageBox.Show($"previous {PreviousLevel}, level {level}");
					Levels.RegularLevels[6][PreviousLevel].Reset();

                }
            }
            PreviousLevel = level;
            Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PreviousLevel == 0)
                PreviousLevel = 1;
			Levels.RegularLevels[6][PreviousLevel].Reset();
            label2.Text = "";
            Invalidate();
        }
    }
}
