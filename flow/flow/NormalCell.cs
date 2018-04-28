using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flow
{
    public class NormalCell : Cell
    {
		public Queue<PipeDirection> PipeDirection { get; set; } = new Queue<PipeDirection>(2);

		public NormalCell(int row, int col, int countInRowCol, int maxWidthHeight, char colorValue) : base(row, col, countInRowCol, maxWidthHeight, colorValue)
        {
        }

        public override void Draw(Graphics formGraphics)
		{
			Pipes.Graphics = formGraphics;
			foreach (PipeDirection pipeDirection in PipeDirection)
			{
				switch (pipeDirection)
				{
					case flow.PipeDirection.Medium:
						Pipes.Medium(Point.X, Point.Y, Width, Height, Color);
						break;
					case flow.PipeDirection.Up:
						Pipes.Up(Point.X, Point.Y, Width, Height, Color);
						break;
					case flow.PipeDirection.Down:
						Pipes.Down(Point.X, Point.Y, Width, Height, Color);
						break;
					case flow.PipeDirection.Left:
						Pipes.Left(Point.X, Point.Y, Width, Height, Color);
						break;
					case flow.PipeDirection.Right:
						Pipes.Right(Point.X, Point.Y, Width, Height, Color);
						break;
					case flow.PipeDirection.UpLeft:
						Pipes.UpLeft(Point.X, Point.Y, Width, Height, Color);
						break;
					case flow.PipeDirection.UpRight:
						Pipes.UpRight(Point.X, Point.Y, Width, Height, Color);
						break;
					case flow.PipeDirection.DownLeft:
						Pipes.DownLeft(Point.X, Point.Y, Width, Height, Color);
						break;
					case flow.PipeDirection.DownRight:
						Pipes.DownRight(Point.X, Point.Y, Width, Height, Color);
						break;
					case flow.PipeDirection.UpDown:
						Pipes.UpDown(Point.X, Point.Y, Width, Height, Color);
						break;
					case flow.PipeDirection.LeftRight:
						Pipes.LeftRight(Point.X, Point.Y, Width, Height, Color);
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}
        }

		public void AddPipe(PipeDirection pipeDirection)
		{
			if (PipeDirection.Count == 2)
				PipeDirection.Dequeue();
			PipeDirection.Enqueue(pipeDirection);
			//if (PipeDirection[0] == flow.PipeDirection.Medium)
			//{
			//	PipeDirection[0] = pipeDirection;
			//}
			//else if (PipeDirection[0] == flow.PipeDirection.Medium)
			//{
			//	PipeDirection[1] = pipeDirection;
			//}
			//else
			//{
			//	PipeDirection[0] = PipeDirection[1];
			//	PipeDirection[1] = pipeDirection;
			//}
		}

        public override string ToString()
        {
            return $"{Row}, {Col}, {Color}, {String.Join(",", PipeDirection)}";
        }
    }
}
