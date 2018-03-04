using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
		private Cell currentCell;

		public Form2()
        {
            InitializeComponent();
			timer = new Timer();
			timer.Interval = 33.3333333333333D; // 30 fps
			timer.Elapsed += mouse_down;
		}

		private void mouse_down(object sender, ElapsedEventArgs e)
		{
			if (MouseButtons == MouseButtons.Left)
			{
				currentCell = currentGrid.GetCellUnderMouse(currentPoint.X, currentPoint.Y);
				//label5.Text = currentGrid.Cells[0][4].color.ToString();
				//label5.Text = currentGrid.GetCellUnderMouse(currentPoint.X, currentPoint.Y).color.ToString();
				
				if (currentCell != startingCell)
				{
					currentCell.Color = startingCell.Color;
					currentGrid.DrawnCells.Add(currentCell);
					label5.Text = currentCell.Color.ToString();
					//currentGrid.Draw(currentCell);
					currentGrid.Draw();
					label3.Text = $"{idx++}";
				}
				
			}
		}

		private void Form2_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.X < 500)
			{
				timer.Enabled = true;
				startingCell = currentGrid.GetCellUnderMouse(e.X, e.Y);
				label4.Text = currentGrid.GetCellUnderMouse(e.X, e.Y).Color.ToString();
				//if (currentGrid.GetCellUnderMouse(e.X, e.Y).color != Color.White)
				
			}
		}

		private void Form2_MouseUp(object sender, MouseEventArgs e)
		{
			timer.Enabled = false;
			label3.Text = "";
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			
		}

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics formGraphics;
            formGraphics = this.CreateGraphics();
			//formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, 200, 300));
			//formGraphics.Dispose();
			if (int.TryParse(textBox1.Text, out int lvl))
			{
				
				//Levels.levels5[lvl - 1].formGraphics = formGraphics;
				//Levels.levels5[lvl - 1].Draw();
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
				label2.Text = Levels.Levels6[lvl - 1].GetColAndRowUnderMouse(e.X, e.Y).ToString();
			else
				label2.Text = Levels.Levels6[0].GetColAndRowUnderMouse(e.X, e.Y).ToString();
		}

		
	}
}
