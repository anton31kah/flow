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
	    public Cell PrevCell { get; set; }
	    public Graphics GraphicsTest { get; set; }

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

                if (!Grid.AreAdjacent(PrevCell, Cell))
                    return;

                //if (PrevCell.Color == Cell.Color && Grid.AreAdjacent(PrevCell, Cell) && !(PrevCell is InitialCell))
                //{
                //    Grid.Paths[FirstColor].PathList.Remove(Cell);
                //    Cell.Color = Color.Black;
                //    Cell.PipeDirection.Clear();
                //}

                if (!(Cell is InitialCell) && (/*Cell.NumberOfPipes != 2 &&*/ !Grid.Paths[FirstColor].PathList.Contains(Cell)))
                {
                    
                    /*if (PrevCell is InitialCell)
                    {
                        Pipes.Graphics = Grid.formGraphics;
                        if (PrevCell.Row == Cell.Row)
                        {
                            if (Cell.Col < PrevCell.Col)
                            {
                                Pipes.Right(PrevCell.Row, PrevCell.Col, PrevCell.Width, PrevCell.Height, PrevCell.Color);

                                //Cell.AddPipe(PipeDirection.Right);
                                //PrevCell.AddPipe(PipeDirection.Left);
                            }
                            else if (Cell.Col > PrevCell.Col)
                            {
                                Pipes.Left(PrevCell.Row, PrevCell.Col, PrevCell.Width, PrevCell.Height, PrevCell.Color);

                                //Cell.AddPipe(PipeDirection.Left);
                                //PrevCell.AddPipe(PipeDirection.Right);
                            }
                        }
                        if (PrevCell.Col == Cell.Col)
                        {
                            if (PrevCell.Row < Cell.Row)
                            {
                                Graphics Graphics = CreateGraphics();
                                Graphics.FillRectangle(new SolidBrush(PrevCell.Color), new Rectangle(PrevCell.Point.X + PrevCell.Width / 3, PrevCell.Point.Y + PrevCell.Height/ 2, PrevCell.Width/ 3, PrevCell.Height/ 2));
                                Graphics.Dispose();
                                //PrevCell.AddPipe(PipeDirection.Down);
                                //Cell.AddPipe(PipeDirection.Up);
                            }
                            else if (PrevCell.Row > Cell.Row)
                            {
                                Pipes.Up(PrevCell.Row, PrevCell.Col, PrevCell.Width, PrevCell.Height, PrevCell.Color);

                                //PrevCell.AddPipe(PipeDirection.Up);
                                //Cell.AddPipe(PipeDirection.Down);
                            }
                        }

                        //Grid.formGraphics.DrawString(
                        //    $"Pipes: {String.Join(",", PrevCell.PipeDirection)}", 
                        //    SystemFonts.MessageBoxFont, 
                        //    Brushes.White, 
                        //    500.0f, 
                        //    200.0f
                        //    );
                    }*/

                    Cell.Color = FirstColor;

                    //LastVisitedCell = Grid.Paths[FirstColor].PathList.AddAfter(LastVisitedCell, Cell);
					LastVisitedCell = Grid.Paths[FirstColor].AddBefore(LastVisitedCell, Cell);
                    //LastVisitedCell = Grid.Paths[FirstColor].AddAfter(LastVisitedCell, Cell);
                    Grid.Paths[FirstColor].Update();
                    label2.Text = Grid.Paths[FirstColor].ToString();
                    
                    PrevCell = Cell;
                    Invalidate();
                    Pipes.Graphics = Grid.formGraphics;
                    if (PrevCell.Row == Cell.Row)
                    {
                        if (Cell.Col < PrevCell.Col)
                        {
                            Pipes.Right(PrevCell.Row, PrevCell.Col, PrevCell.Width, PrevCell.Height, PrevCell.Color);

                            //Cell.AddPipe(PipeDirection.Right);
                            //PrevCell.AddPipe(PipeDirection.Left);
                        }
                        else if (Cell.Col > PrevCell.Col)
                        {
                            Pipes.Left(PrevCell.Row, PrevCell.Col, PrevCell.Width, PrevCell.Height, PrevCell.Color);

                            //Cell.AddPipe(PipeDirection.Left);
                            //PrevCell.AddPipe(PipeDirection.Right);
                        }
                    }
                    if (PrevCell.Col == Cell.Col)
                    {
                        if (PrevCell.Row < Cell.Row)
                        {
                            Graphics Graphics = CreateGraphics();
                            Graphics.FillRectangle(new SolidBrush(PrevCell.Color), new Rectangle(PrevCell.Point.X + PrevCell.Width / 3, PrevCell.Point.Y + PrevCell.Height / 2, PrevCell.Width / 3, PrevCell.Height / 2));
                            Graphics.Dispose();
                            //PrevCell.AddPipe(PipeDirection.Down);
                            //Cell.AddPipe(PipeDirection.Up);
                        }
                        else if (PrevCell.Row > Cell.Row)
                        {
                            Pipes.Up(PrevCell.Row, PrevCell.Col, PrevCell.Width, PrevCell.Height, PrevCell.Color);

                            //PrevCell.AddPipe(PipeDirection.Up);
                            //Cell.AddPipe(PipeDirection.Down);
                        }
                    }

                }

				if (Cell is InitialCell && Grid.Paths[FirstColor].PathList.Count > 2 && (Grid.Paths[FirstColor].PathList.Last.Value.Equals(Cell) || Grid.Paths[FirstColor].PathList.First.Value.Equals(Cell)))
				{
					label2.Text = "OVER";
					Invalidate();
				}
                //Invalidate();
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
            if (PreviousLevel == 0)
                PreviousLevel = 1;
            Levels.Levels6[PreviousLevel - 1].Reset();
            label2.Text = "";
            Invalidate();
        }
    }
}
