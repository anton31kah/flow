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
         *  Reactangle(x, y, width, height);
         *  x && y -> gore levo tockite
         *  width -> sirinata na eden cell
         *  height -> visina na eden cell
         * 
         */

        private Cell[][] Cells;
        private List<Cell> initialCells;
        private int width { get; set; }
		private int height { get; set; }
		private int size { get; set; }
        public Graphics formGraphics { get; set; }

        public Grid(int n, int width, int height, List<Cell> initialCells = null)
        {
            this.width = width;
            this.height = height;
            //this.formGraphics = graphics;
            this.size = n;
            this.initialCells = initialCells;
            Cells = new Cell[n][];
            for (int i = 0; i < n; i++)
            {
                Cells[i] = new Cell[n];
                for (int j = 0; j < n; j++)
                {
                    Cells[i][j] = new Cell(i * width / n, j * height / n, width / n, height / n);
                }
            }
        }

        public void Draw()
        {
            SolidBrush brush = new SolidBrush(Cell.colors[0]);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    var cell = Cells[i][j];
                    formGraphics.FillRectangle(new SolidBrush(Cell.colors[0]), new Rectangle(cell.x, cell.y, cell.width, cell.height));
                }
            }
            foreach (Cell cell in initialCells)
            {
                brush.Color = cell.color;
                formGraphics.FillRectangle(brush, new Rectangle(cell.x, cell.y, cell.width, cell.height));
            }
            //formGraphics.Dispose();
        }
    }
}
