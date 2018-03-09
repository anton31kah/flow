using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace flow
{
    class Pipes
    {
        public Graphics Graphics { get; set; }
        public void Up(int x, int y, int width, int height, Color color)
        {
            // WORK HERE
            Graphics.FillRectangle(new SolidBrush(color), new Rectangle(x + width / 3, y, 100 / 3, 100 / 2));
            Graphics.FillEllipse(new SolidBrush(color), new Rectangle(100 / 3, 300 + 100 / 3, 100 / 3, 100 / 3));
            Graphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(0, 300, 100, 100));
        }
        //public void /*Draw*/
        //public 
    }
}
