using System;
using System.Drawing;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace flow
{
    public partial class Form2 : Form
	{
		private Timer timer;
		private Grid currentGrid;
		private Point currentPoint;
		private long idx = 0;
		private Cell startingCell;
		private Cell previousCell;
		private Cell currentCell;
        public static Graphics FormGraphics;

		public Form2()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            timer = new Timer();
            timer.Interval = 33.3333333333333D; // 30 fps
            timer.Elapsed += mouse_down;
        }

		private void mouse_down(object sender, ElapsedEventArgs e)
		{
			label7.Text = startingCell.Color.ToString();
			label8.Text = previousCell.Color.ToString();
			label9.Text = currentCell?.Color.ToString();
			label10.Text = $"{startingCell.Row} {startingCell.Col}";
			label11.Text = $"{previousCell.Row} {previousCell.Col}";
			label12.Text = $"{currentCell?.Row} {currentCell?.Col}";
			if (MouseButtons == MouseButtons.Left)
			{
                currentCell = currentGrid.GetCellUnderMouse(currentPoint.X, currentPoint.Y);
                Color previousColor = currentCell.Color;
				//label5.Text = currentGrid.Cells[0][4].color.ToString();
				//label5.Text = currentGrid.GetCellUnderMouse(currentPoint.X, currentPoint.Y).color.ToString();

				label13.Text = (currentCell != startingCell && (!(currentCell is InitialCell) || previousCell.Color == currentCell.Color) &&
								(currentGrid.AreAdjacentOrSame(currentCell, startingCell) || currentGrid.AreAdjacent(currentCell, previousCell)))
					.ToString();

                if (currentCell.Color != startingCell.Color && currentCell is InitialCell)
                {
                    Form2_MouseUp(null, null);
                }
                if (currentCell.Color != startingCell.Color && currentCell.Color != Cell.Colors['w'])
                {
                    //Cell.ClearPath(currentGrid.GetInitialCellByColor(previousColor));
                }

				if (currentCell != startingCell && (!(currentCell is InitialCell) || previousCell.Color == currentCell.Color) &&
					(currentGrid.AreAdjacentOrSame(currentCell, startingCell) || currentGrid.AreAdjacent(currentCell, previousCell)))
				{
                    //if (currentCell.Color == previousCell.Color && (!previousCell is InitialCell && !currentCell is InitialCell))
                    //{
                    //    previousCell.Color = Cell.Colors['w'];
                    //    previousCell.IsConnected = false;
                    //    previousCell.Draw(Form2.FormGraphics);
                    //    startingCell.Path.Remove(previousCell);
                    //}
					currentCell.Color = startingCell.Color;
					currentGrid.DrawnCells.Add(currentCell);
					currentCell.IsConnected = true;
                    startingCell.Path.AddLast(currentCell);
                    previousCell = currentCell;
					label6.Text = currentGrid.Validate().ToString();
					label5.Text = currentCell.Color.ToString();
					currentGrid.ShowValidation(leftCellsToColorListBox);
                    currentCell.Draw(Form2.FormGraphics);
                    label3.Text = $"{idx++}";
				}
                
			}
		}

		private void Form2_MouseDown(object sender, MouseEventArgs e)
		{
			if (timer != null && e.X < 500)
			{
				timer.Enabled = true;
				startingCell = currentGrid.GetCellUnderMouse(e.X, e.Y);
				startingCell.IsConnected = true;
                if (startingCell is InitialCell)
                {
                    Cell OtherCell = currentGrid.GetOtherEnd(startingCell);
                    if (OtherCell.Path.Any())
                    {
                        //Cell.ClearPath(OtherCell);
                        OtherCell.Path.Clear();
                    }
                }
				previousCell = startingCell;
				label4.Text = currentGrid.GetCellUnderMouse(e.X, e.Y).Color.ToString();
				//if (currentGrid.GetCellUnderMouse(e.X, e.Y).color != Color.White)
				
			}
		}

		private void Form2_MouseUp(object sender, MouseEventArgs e)
		{
            if (timer != null && currentGrid.Validate())
            {
                timer.Stop();
                timer = null;
                MessageBox.Show("Level Finished");
            }
            //timer.Enabled = false;
			label3.Text = "";
		}

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            FormGraphics = formGraphics;
			//formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, 200, 300));
			//formGraphics.Dispose();
			if (int.TryParse(textBox1.Text, out int lvl))
			{

                Levels.Levels5[lvl - 1].formGraphics = formGraphics;
                Levels.Levels5[lvl - 1].Draw();
            }
			else
			{
				currentGrid = Levels.Levels6[0];
				Levels.Levels6[0].formGraphics = formGraphics;
				Levels.Levels6[0].Draw();
			}
			//Grid grid = new Grid(5, 500, 500, formGraphics);
            //grid.Draw();
        }

		public void draw(object sender, EventArgs e)
		{
			button1_Click(sender, e);
		}

		private void Form2_MouseMove(object sender, MouseEventArgs e)
		{
			//label3.Text = "working too";
			currentPoint = e.Location;
			label1.Text = $@"{e.X} {e.Y}";
			//label2.Text = 
			if (int.TryParse(textBox1.Text, out int lvl))
				label2.Text = Levels.Levels6[lvl - 1].GetRowAndColUnderMouse(e.X, e.Y).ToString();
			else
				label2.Text = Levels.Levels6[0].GetRowAndColUnderMouse(e.X, e.Y).ToString();
		}

        private void Form2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
