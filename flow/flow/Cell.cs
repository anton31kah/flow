using System.Collections.Generic;
using System.Drawing;

namespace flow
{
    public enum Triangle
    {
        North, South, East, West
    }
    public abstract class Cell
    {
        // x -> col
        // y -> row

		public static Dictionary<char, Color> Colors = new Dictionary<char, Color>
		{
			{'d', Color.Black},
			{'r', Color.Red },
			{'g', Color.Green },
			{'b', Color.Blue },
			{'y', Color.Yellow },
			{'o', Color.Orange },
			{'a', Color.Aqua },
			{'c', Color.Cyan },
			{'m', Color.Magenta},
			{'p', Color.Purple },
			{'n', Color.Brown }
		};
		//public bool IsInitial { get; set; }
        public Color Color { get; set; }
        public char ColorValue { get; set; }
        //public int X { get; set; }
        //public int Y { get; set; }
        public Point Point { get; set; }
        public int Row { get; set; }
		public int Col { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
		public int CountInRowCol { get; set; }
		public int MaxWidthHeight { get; set; }
		public bool IsConnected { get; set; }
        public Pipes Pipe { get; set; } = new Pipes();

        public LinkedList<Cell> Path { get; set; }


        protected Cell(int row, int col, int countInRowCol, int maxWidthHeight, char colorValue = 'd')
        {
            Row = row;
            Col = col;
            CountInRowCol = countInRowCol;
            MaxWidthHeight = maxWidthHeight;
            ColorValue = colorValue;
            Color = Colors[ColorValue];
            Point = new Point { X = Col * MaxWidthHeight / CountInRowCol, Y = Row * MaxWidthHeight / CountInRowCol };
            Width = Height = MaxWidthHeight / CountInRowCol;
            Path = new LinkedList<Cell>();
        }

        public virtual void Draw(Graphics formGraphics)
        {

        }

		public override string ToString()
		{
			return Color + " " + (this is InitialCell);
		}
        //public static void ClearPath(Cell cell)
        //{
        //    if (cell is InitialCell)
        //    {
        //        foreach (Cell c in cell.Path)
        //        {
        //            if (!c.IsInitial)
        //            {
        //                c.IsConnected = false;
        //                c.Color = Colors['w'];
        //                c.Draw(Form2.FormGraphics);
        //            }
        //        }
        //    }
        //}
        public Triangle GetTriangle(int x, int y)
        {
            if (x > y && (x + y) < Width)
            {
                return Triangle.North;
            }
            else if (x < y && (x + y) > Width)
            {
                return Triangle.South;
            }
            else if (x > y && (x + y) > Width)
            {
                return Triangle.East;
            }
            else // if (x < y && (x + y) < Width)
            {
                return Triangle.West;
            }
        }

        public static Triangle GetTriangleForCell(Cell cell, int x, int y)
        {
            return cell.GetTriangle(x, y);
        }
	}
}
