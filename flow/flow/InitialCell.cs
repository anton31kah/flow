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
        public InitialCell(int row, int col, int countInRowCol, int maxWidthHeight, char colorValue) : base(row, col, countInRowCol, maxWidthHeight, colorValue)
        {
        }

        public override void Draw(Graphics formGraphics)
        {
            Pipe.Graphics = formGraphics;
            Pipe.Big(Point.X, Point.Y, Width, Height, Color);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
