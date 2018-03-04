using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    Cells[i][j] = new Cell(i * width / n, j * height / n, i, j, width / n, height / n);
                }
            }
        }

        public void Draw(Cell specialCell = null)
        {
            SolidBrush brush = new SolidBrush(Cell.colors[0]);
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    var cell = Cells[i][j];
                    formGraphics.FillRectangle(new SolidBrush(Cell.colors[0]), new Rectangle(cell.y, cell.x, cell.width, cell.height));
					formGraphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(cell.y, cell.x, cell.width, cell.height));
				}
            }
			//if (specialCell != null)
			//{
			//	formGraphics.FillRectangle(new SolidBrush(specialCell.color), new Rectangle(specialCell.y, specialCell.x, specialCell.width, specialCell.height));
			//	formGraphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(specialCell.y, specialCell.x, specialCell.width, specialCell.height));
			//}
			foreach (Cell cell in initialCells)
            {
                brush.Color = cell.color;
				Cells[cell.row][cell.col] = cell;
                formGraphics.FillRectangle(brush, new Rectangle(cell.y, cell.x, cell.width, cell.height));
				formGraphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(cell.y, cell.x, cell.width, cell.height));
            }

			foreach (Cell cell in DrawnCells)
			{
				brush.Color = cell.color;
				Cells[cell.row][cell.col] = cell;
				formGraphics.FillRectangle(brush, new Rectangle(cell.y, cell.x, cell.width, cell.height));
				formGraphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(cell.y, cell.x, cell.width, cell.height));
			}
            //formGraphics.Dispose();
        }

		public Cell GetCellUnderMouse(int x, int y)
		{
			int cellWidth = Width / Size;
			int col = x / cellWidth;
			int row = y / cellWidth;
			return Cells[row][col];
		}

		public bool isInitinal(Cell cell)
		{
			return initialCells.Contains(cell);
		}

		public Point GetColAndRowUnderMouse(int x, int y)
		{
			int cellWidth = Width / Size;
			int col = x / cellWidth;
			int row = y / cellWidth;
			return new Point(row, col);
		}
    }
}
