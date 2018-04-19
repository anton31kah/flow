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
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void Form3_Paint(object sender, PaintEventArgs e)
		{
			//currentGrid = Levels.Levels6[0];
			Grid empty = Grid.Empty;
			empty.formGraphics = e.Graphics;
			empty.Draw();
			//Levels.Levels6[0].formGraphics = e.Graphics;
			//Levels.Levels6[0].Draw();
		}
	}
}
