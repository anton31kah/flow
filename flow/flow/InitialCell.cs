using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flow
{
    public class InitialCell : Cell
    {
		//public PipeDirection PipeDirection { get; set; }

        public InitialCell(int row, int col, int countInRowCol, int maxWidthHeight, Color color) : base(row, col, countInRowCol, maxWidthHeight, color)
        {
            PipeDirection = new Queue<PipeDirection>(1);
            NumberOfPipes = 1;
        }

        public override void Draw(Graphics formGraphics)
        {
			
            Pipes.Graphics = formGraphics;
            Pipes.Big(Point.X, Point.Y, Width, Height, Color);
            //formGraphics.DrawString($"{String.Join(",", PipeDirection)}", SystemFonts.MessageBoxFont, Brushes.White, 500, 200);
            if (PipeDirection.Any())
            {
                switch (PipeDirection.Peek())
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
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        public override string ToString()
        {
            //return base.ToString();
			return $"{Row}, {Col}, initial, {Color}, {String.Join(",", PipeDirection)}, {PipeDirection.Count}";
		}

        public override void AddPipe(PipeDirection pipeDirection)
        {
            if (PipeDirection.Contains(pipeDirection)) return;
            if (PipeDirection.Count == 1)
                PipeDirection.Dequeue();
            PipeDirection.Enqueue(pipeDirection);
		}
    }
}
