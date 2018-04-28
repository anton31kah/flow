using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public int PreviousLevel { get; set; } = -1;
        public LinkedListNode<Cell> LastVisitedCell { get; set; }

        public Form3()
		{
			InitializeComponent();
            this.DoubleBuffered = true;
		}

		private void Form3_Paint(object sender, PaintEventArgs e)
		{
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
                if (!(Cell is InitialCell) && !Grid.Paths[FirstColor].PathList.Contains(Cell))
                {
                    Cell.Color = FirstColor;

                    //LastVisitedCell = Grid.Paths[FirstColor].PathList.AddAfter(LastVisitedCell, Cell);
					LastVisitedCell = Grid.Paths[FirstColor].AddAfter(LastVisitedCell, Cell);
					label2.Text = Grid.Paths[FirstColor].ToString();
                    Invalidate();
                }

				if (Cell is InitialCell && Grid.Paths[FirstColor].PathList.Count > 2 && (Grid.Paths[FirstColor].PathList.Last.Value.Equals(Cell) || Grid.Paths[FirstColor].PathList.First.Value.Equals(Cell)))
				{
					label2.Text = "OVER";
					Invalidate();
				}
            }
            //if (GridIsSet && e.X < 500)
            //{
            //    label1.Text = (Grid.GetCellUnderMouse(e.X, e.Y) is InitialCell).ToString();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int level))
            {
				GridIsSet = true;
				Grid = Levels.Levels6[0];
            }
            else
            {
                
                GridIsSet = true;
                Grid = Levels.Levels6[level - 1];
                if (PreviousLevel != -1 && level != PreviousLevel)
                {
					//MessageBox.Show($"previous {PreviousLevel}, level {level}");
                    Levels.Levels6[PreviousLevel].Reset();
                }
            }
            PreviousLevel = level;
            Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Levels.Levels6[0].Reset();
            Invalidate();
        }
    }
}
