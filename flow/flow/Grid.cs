﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flow
{
    public class Grid
    {
        /*
         *  Reactangle(x, y, Width, height);
         *  x && y -> gore levo tockite
         *  Width -> sirinata na eden cell
         *  height -> visina na eden cell
         * 
         */


        public Dictionary<Color, Path> Paths { get; set; }
        public Cell[][] Cells;
        private List<Cell> initialCells;
        public List<Cell> DrawnCells;
        private int Width { get; set; }
        private int Height { get; set; }
        private int Size { get; set; }
        public Graphics formGraphics { get; set; }
        public static Grid Empty { get; } = new Grid(5, 500, 500);
        public int CompletedPipes { get; set; }

        public Grid(int n, int width, int height, List<Cell> initialCells = null)
        {
            Paths = new Dictionary<Color, Path>();
            this.DrawnCells = new List<Cell>();
            this.Width = width;
            this.Height = height;
            //this.formGraphics = graphics;
            this.Size = n;
            this.initialCells = initialCells;
            Cells = new Cell[n][];
            for (int i = 0; i < n; i++)
            {
                Cells[i] = new Cell[n];
                for (int j = 0; j < n; j++)
                {
                    if (this.initialCells != null && initialCells.Any(c => c.Row == i && c.Col == j))
                    {
                        var cell = initialCells.First(c => c.Row == i && c.Col == j);
						Cells[i][j] = cell;
						if (!Paths.ContainsKey(cell.Color))
						{
							var last = initialCells.Last(c => c.Color == cell.Color);
							Paths[cell.Color] = new Path(cell, last);
						}
					}
                    else Cells[i][j] = new NormalCell(i, j, n, width, Color.Black);
                }
            }
        }

		public void Reset()
		{
			for (int i = 0; i < Size; i++)
			{
				for (int j = 0; j < Size; j++)
				{
					Cells[i][j].IsConnected = false;
					Cells[i][j].NumberOfPipes = 0;
					if (Cells[i][j] is NormalCell)
					{
						if (Cells[i][j].Color != Color.Black)
						{
							Cells[i][j].PipeDirection.Clear();
							Paths[Cells[i][j].Color].PathList.Remove(Cells[i][j]);
							Cells[i][j].Color = Color.Black;
						}
					}
					else
						Cells[i][j].PipeDirection.Clear();
				}
			}
		}

		public void Draw()
        {
            foreach (Cell[] cells in Cells)
                foreach (Cell cell in cells)
                    cell.Draw(formGraphics);
        }

		public Cell GetCellUnderMouse(int x, int y)
		{
			int cellWidth = Width / Size;
			int col = Math.Min(x / cellWidth, Size - 1);
			int row = Math.Min(y / cellWidth, Size - 1);
			return Cells[row][col];
		}


		public Point GetRowAndColUnderMouse(int x, int y)
        {
            int cellWidth = Width / Size;
            int col = x / cellWidth;
            int row = y / cellWidth;
            return new Point(row, col);
        }

        public bool isInitinal(Cell cell)
        {
            return cell is InitialCell;
        }

        public bool Validate()
        {
            //return FixLast() && Cells.All(cells => cells.All(cell => cell.IsConnected));
            return Cells.All(cells => cells.All(cell => cell.IsConnected));
        }

        public bool FixLast()
        {
            // ova go staviv zosto so IsAdjacent i IsAdjacentOrSame sto gi napraviv se raboti kako sto
            // treba OSVEN factot deka poslednata cell od sekoj color ne se boj (pagja na isInitial delot
            // od if-ot vo form2 vo mouse_down) taka da ovoj metod go resava toa, ako site se naboeni, ova
            // gi pravi poslednite cells connected za da mozi da vrati Validate true

            // NEW UPDATE
            // nema potreba veke od ovoj metod zosto so previousCell.Color == currentCell.Color vo ifot veke 
            // go resava ova
            if (Cells.All(cells => cells.All(cell => cell.Color != Color.White)))
            {
                foreach (Cell initialCell in initialCells)
                    initialCell.IsConnected = true;
                return true;
            }

            return false;
        }

        public bool AreAdjacent(Cell one, Cell two)
        {
            return Math.Abs(one.Col - two.Col) + Math.Abs(one.Row - two.Row) <= 1;
            //return Math.Abs(one.Col - two.Col) == 1 || Math.Abs(one.Row - two.Row) == 1;
        }

        public bool AreAdjacentOrSame(Cell one, Cell two)
        {
            return AreAdjacent(one, two) || one.Col - two.Col == 0 && one.Row - two.Row == 0;
        }

        public void ShowValidation(ListBox listBox1)
        {
            listBox1.Items.Clear();
            foreach (Cell[] cells in Cells)
                foreach (Cell cell in cells)
                    if (!cell.IsConnected)
                        listBox1.Items.Add($"{cell.Row} {cell.Col}");
        }

        public Cell GetOtherEnd(Cell cell)
        {
            return initialCells.Where(c => c.Color == cell.Color && c != cell).First();
        }

        public Cell GetInitialCellByColor(Color color)
        {
            return initialCells.Where(c => c.Color == color).First();
        }
    }
}
