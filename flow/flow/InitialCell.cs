using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flow
{
    public class InitialCell : Cell
    {
		public PipeDirection PipeDirection { get; set; }

        public InitialCell(int row, int col, int countInRowCol, int maxWidthHeight, char colorValue) : base(row, col, countInRowCol, maxWidthHeight, colorValue)
        {
        }

        public override void Draw(Graphics formGraphics)
        {
			Pipes.Graphics = formGraphics;
			switch (PipeDirection)
			{
				case PipeDirection.Medium:
					Pipes.Medium(Point.X, Point.Y, Width, Height, Color);
					break;
				case PipeDirection.Up:
					Pipes.Up(Point.X, Point.Y, Width, Height, Color);
					break;
				case PipeDirection.Down:
					Pipes.Down(Point.X, Point.Y, Width, Height, Color);
					break;
				case PipeDirection.Left:
					Pipes.Left(Point.X, Point.Y, Width, Height, Color);
					break;
				case PipeDirection.Right:
					Pipes.Right(Point.X, Point.Y, Width, Height, Color);
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}
        }

        public override string ToString()
        {
            //return base.ToString();
			return $"{Row}, {Col}, {Color}, {String.Join(",", PipeDirection)}";
		}
    }
}
