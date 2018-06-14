using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flow
{
	[Serializable]
	public class NormalCell : Cell
    {
		//public Queue<PipeDirection> PipeDirection { get; set; } = new Queue<PipeDirection>(2);

		public NormalCell(int row, int col, int countInRowCol, int maxWidthHeight, Color color) : base(row, col, countInRowCol, maxWidthHeight, color)
        {
            PipeDirection = new Queue<PipeDirection>(2);
        }

        public override void Draw(Graphics formGraphics)
		{
			Pipes.Graphics = formGraphics;
			//Pipes.Blank(Point.X, Point.Y, Width, Height);
            Pipes.Border(Point.X, Point.Y, Width, Height);
			foreach (PipeDirection pipeDirection in PipeDirection)
			{
				switch (pipeDirection)
				{
					case flow.PipeDirection.Medium:
						Pipes.Medium(Point.X, Point.Y, Width, Height, Color);
					    NumberOfPipes++;
                        break;
					case flow.PipeDirection.Up:
						Pipes.Up(Point.X, Point.Y, Width, Height, Color);
					    NumberOfPipes++;
                        break;
					case flow.PipeDirection.Down:
						Pipes.Down(Point.X, Point.Y, Width, Height, Color);
					    NumberOfPipes++;
                        break;
					case flow.PipeDirection.Left:
						Pipes.Left(Point.X, Point.Y, Width, Height, Color);
					    NumberOfPipes++;
                        break;
					case flow.PipeDirection.Right:
						Pipes.Right(Point.X, Point.Y, Width, Height, Color);
					    NumberOfPipes++;
                        break;
					case flow.PipeDirection.UpLeft:
						Pipes.UpLeft(Point.X, Point.Y, Width, Height, Color);
					    NumberOfPipes++;
                        break;
					case flow.PipeDirection.UpRight:
						Pipes.UpRight(Point.X, Point.Y, Width, Height, Color);
					    NumberOfPipes++;
                        break;
					case flow.PipeDirection.DownLeft:
						Pipes.DownLeft(Point.X, Point.Y, Width, Height, Color);
					    NumberOfPipes++;
                        break;
					case flow.PipeDirection.DownRight:
						Pipes.DownRight(Point.X, Point.Y, Width, Height, Color);
					    NumberOfPipes++;
                        break;
					case flow.PipeDirection.UpDown:
						Pipes.UpDown(Point.X, Point.Y, Width, Height, Color);
					    NumberOfPipes++;
                        break;
					case flow.PipeDirection.LeftRight:
						Pipes.LeftRight(Point.X, Point.Y, Width, Height, Color);
					    NumberOfPipes++;
                        break;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}
        }

		public override void AddPipe(PipeDirection pipeDirection)
		{
            if (PipeDirection.Contains(pipeDirection)) return;
			if (PipeDirection.Count == 2)
				PipeDirection.Dequeue();
			PipeDirection.Enqueue(pipeDirection);
		}

        public override string ToString()
        {
            return $"{Row}, {Col}, {Color}, {String.Join(",", PipeDirection)}";
        }
    }
}
