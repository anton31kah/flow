using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flow
{
    public partial class Coloring : Form
    {
        public Coloring()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();

            /*
             * widthCell && heightCell -> 100
             * Rectangle(x, y, width, height)
             * 
             */ 
            // big
			//Pipes pipes = new Pipes();

			Pipes.Graphics = graphics;
			Pipes.Big(0, 0, 100, 100, Color.Blue);
			Pipes.Down(0, 0, 100, 100, Color.Blue);
			Pipes.Up(0, 100, 100, 100, Color.Blue);
			Pipes.Medium(0, 100, 100, 100, Color.Blue);
			//         graphics.FillEllipse(new SolidBrush(Color.Red), new Rectangle(100 / 6, 100 / 6, 2 * 100 / 3, 2 * 100 / 3));
			//         graphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(0, 0, 100, 100));

			//         // small
			//         graphics.FillEllipse(new SolidBrush(Color.Red), new Rectangle(100 / 3, 100 + 100 / 3, 100 / 3, 100 / 3));
			//         graphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(0, 100, 100, 100));

			//// medium
			//graphics.FillEllipse(new SolidBrush(Color.Red), new Rectangle(100 / 4, 200 + 100 / 4, 100 / 2, 100 / 2));
			//graphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(0, 200, 100, 100));

			//// up
			//graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(100 / 3, 300, 100 / 3, 100 / 2));
			//         graphics.FillEllipse(new SolidBrush(Color.Red), new Rectangle(100 / 3, 300 + 100 / 3, 100 / 3, 100 / 3));
			//         graphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(0, 300, 100, 100));

			//         // up right
			//         graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(100 / 3, 400, 100 / 3, 100 / 2)); // up
			//         graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(100 / 2, 400 + 100 / 3, 100 / 2, 100 / 3)); // right
			//         graphics.FillEllipse(new SolidBrush(Color.Red), new Rectangle(100 / 3, 400 + 100 / 3, 100 / 3, 100 / 3));
			//         graphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(0, 400, 100, 100));

			//         // up left
			//         graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(100 / 3, 500, 100 / 3, 100 / 2)); // up
			//         graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(0, 500 + 100 / 3, 100 / 2, 100 / 3)); // left
			//         graphics.FillEllipse(new SolidBrush(Color.Red), new Rectangle(100 / 3, 500 + 100 / 3, 100 / 3, 100 / 3));
			//         graphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(0, 500, 100, 100));
		}
	}
}
