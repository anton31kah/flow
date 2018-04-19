using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flow
{
	class Grid
	{
		/*
         *  Reactangle(x, y, Width, height);
         *  x && y -> gore levo tockite
         *  Width -> sirinata na eden cell
         *  height -> visina na eden cell
         * 
         */

		public Cell[][] Cells;
		private List<Cell> initialCells;
		public List<Cell> DrawnCells;
		private int Width { get; set; }
		private int Height { get; set; }
		private int Size { get; set; }
		public Graphics formGraphics { get; set; }
		public static Grid Empty { get; } = new Grid(5, 500, 500);

		public Grid(int n, int width, int height, List<Cell> initialCells = null)
		{
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
					Cells[i][j] = new Cell(i, j, n, width);
				}
			}
			if (this.initialCells == null) return;
			foreach (Cell initialCell in initialCells)
			{
				Cells[initialCell.Row][initialCell.Col] = initialCell;
			}
		}

		/*
        public void Draw(Cell specialCell = null)
        {
            SolidBrush brush = new SolidBrush(Cell.Colors['w']);
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    var cell = Cells[i][j];
                    formGraphics.FillRectangle(new SolidBrush(Cell.Colors['w']), new Rectangle(cell.Y, cell.X, cell.Width, cell.Height));
					formGraphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(cell.Y, cell.X, cell.Width, cell.Height));
				}
            }
			//if (specialCell != null)
			//{
			//	formGraphics.FillRectangle(new SolidBrush(specialCell.color), new Rectangle(specialCell.y, specialCell.x, specialCell.width, specialCell.height));
			//	formGraphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(specialCell.y, specialCell.x, specialCell.width, specialCell.height));
			//}
			foreach (Cell cell in initialCells)
            {
                brush.Color = cell.Color;
				Cells[cell.Row][cell.Col] = cell;
                formGraphics.FillRectangle(brush, new Rectangle(cell.Y, cell.X, cell.Width, cell.Height));
				formGraphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(cell.Y, cell.X, cell.Width, cell.Height));
            }

			foreach (Cell cell in DrawnCells)
			{
				brush.Color = cell.Color;
				Cells[cell.Row][cell.Col] = cell;
				formGraphics.FillRectangle(brush, new Rectangle(cell.Y, cell.X, cell.Width, cell.Height));
				formGraphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(cell.Y, cell.X, cell.Width, cell.Height));
			}
            //formGraphics.Dispose();
			
	}
	*/
		public void Draw()
		{
			foreach (Cell[] cells in Cells)
			foreach (Cell cell in cells)
				cell.Draw(formGraphics);
		}

		public Cell GetCellUnderMouse(int x, int y)
		{
			int cellWidth = Width / Size;
			int col = x / cellWidth;
			int row = y / cellWidth;
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
			return cell.IsInitial;
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
			if (Cells.All(cells => cells.All(cell => cell.Color != Cell.Colors['w'])))
			{
				foreach (Cell initialCell in initialCells)
					initialCell.IsConnected = true;
				return true;
			}

			return false;
		}

		public bool AreAdjacent(Cell one, Cell two)
		{
			return Math.Abs(one.Col - two.Col) == 1 || Math.Abs(one.Row - two.Row) == 1;
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
