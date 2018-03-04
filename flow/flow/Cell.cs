using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace flow
{
    class Cell
    {
		/*
		 * x -> col
		 * y -> row
		 */


        public Rectangle rectangle { get; set; }
        public bool initial { get; set; }
        public Color color { get; set; }
        public string value { get; set; }
        public int x { get; set; }
        public int y { get; set; }
		public int row { get; set; }
		public int col { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public static Dictionary<int, Color> colors = new Dictionary<int, Color>
        {
            {0, Color.White },
            {1, Color.Red },
            {2, Color.Green },
            {3, Color.Blue },
            {4, Color.Yellow },
            {5, Color.Orange },
			{6, Color.Aqua },
			{7, Color.BlueViolet }
        };

        public Cell(int x, int y, int col, int row, int width, int height, string value = "0", bool initial = false)
        {
            this.initial = initial;
            this.value = value;
            this.color = colors[int.Parse(value)];
            this.x = x;
            this.y = y;
			this.row = row;
			this.col = col;
            this.width = width;
            this.height = height;

        }
    }
}
