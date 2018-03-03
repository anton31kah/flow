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
    public partial class Form2 : Form
	{
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
		{
			
		}

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics formGraphics;
            formGraphics = this.CreateGraphics();
			//formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, 200, 300));
			//formGraphics.Dispose();
			if (int.TryParse(textBox1.Text, out int lvl))
			{
				Levels.levels5[lvl - 1].formGraphics = formGraphics;
				Levels.levels5[lvl - 1].Draw();
			}
			else
			{
				Levels.levels5[1].formGraphics = formGraphics;
				Levels.levels5[1].Draw();
			}
			//Grid grid = new Grid(5, 500, 500, formGraphics);
            //grid.Draw();
        }

		public void draw(object sender, EventArgs e)
		{
			button1_Click(sender, e);
		}
    }
}
