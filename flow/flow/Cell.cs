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

		
        public Color Color { get; set; }

        public int NumberOfPipes { get; set; }
        public Point Point { get; set; }
        public int Row { get; set; }
		public int Col { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
		public int CountInRowCol { get; set; }
		public int MaxWidthHeight { get; set; }
		public bool IsConnected { get; set; }
        public Queue<PipeDirection> PipeDirection { get; set; }

        public LinkedList<Cell> Path { get; set; }


        protected Cell(int row, int col, int countInRowCol, int maxWidthHeight, Color color)
        {
            Row = row;
            Col = col;
            CountInRowCol = countInRowCol;
            MaxWidthHeight = maxWidthHeight;
            Color = color;
            Point = new Point { X = Col * MaxWidthHeight / CountInRowCol + 200, Y = Row * MaxWidthHeight / CountInRowCol };
            Width = Height = MaxWidthHeight / CountInRowCol;
            Path = new LinkedList<Cell>();
        }

        public virtual void Draw(Graphics formGraphics)
        {

        }

		public override string ToString()
		{
			return Color + " " + (this is InitialCell) + $" {Row}, {Col}";
		}
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

		public override bool Equals(object obj)
		{
			return obj is Cell cell &&
				   Row == cell.Row &&
				   Col == cell.Col;
		}

		public override int GetHashCode()
		{
			var hashCode = 1084646500;
			hashCode = hashCode * -1521134295 + Row.GetHashCode();
			hashCode = hashCode * -1521134295 + Col.GetHashCode();
			return hashCode;
		}

        public virtual void AddPipe(PipeDirection pipeDirection)
        {
        }
    }
}
