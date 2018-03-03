using System.Collections.Generic;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace flow
{
	public partial class Form1 : Form
	{
		Dictionary<int, Color> colors = new Dictionary<int, Color>
		{
			{0, Color.White },
			{1, Color.Red },
			{2, Color.Green },
			{3,Color.Blue },
			{4,Color.Yellow },
			{5, Color.Orange }
		};
		private static Label[][] matrix;
		private Timer timer;
		private string value;
		private bool clicked;

		public Form1()
		{
			InitializeComponent();
			matrix = new[]
			{
				new[]
				{
					label1,
					label2,
					label3,
					label4,
					label5
				},
				new[]
				{
					label6,
					label7,
					label8,
					label9,
					label10
				},
				new[]
				{
					label11,
					label12,
					label13,
					label14,
					label15
				},
				new[]
				{
					label16,
					label17,
					label18,
					label19,
					label20
				},
				new[]
				{
					label21,
					label22,
					label23,
					label24,
					label25
				}
			};
			for (int i = 0; i < 5; i++)
				for (int j = 0; j < 5; j++)
					matrix[i][j].Text = "0";
			matrix[0][0].Text = matrix[4][1].Text = "1";
			matrix[0][2].Text = matrix[3][1].Text = "2";
			matrix[1][2].Text = matrix[4][2].Text = "3";
			matrix[0][4].Text = matrix[3][3].Text = "4";
			matrix[1][4].Text = matrix[4][3].Text = "5";

			timer = new Timer();
			timer.Elapsed += mouse_down;
		}

		private void mouse_down(object sender, ElapsedEventArgs e)
		{
			if (MouseButtons == MouseButtons.Left)
			{
				TableLayoutPanelCellPosition pos = GetCellPosotion(tableLayoutPanel1);
				var labelUnderMouse = tableLayoutPanel1.GetControlFromPosition(pos.Column, pos.Row);
				//if (labelUnderMouse.Text == value)
				//{
				//	labelUnderMouse.BackColor = colors[0];
				//	labelUnderMouse.Text = 0.ToString();
				//}
				//else
				//{
					labelUnderMouse.BackColor = colors[int.Parse(value)];
					labelUnderMouse.Text = value;
				//}
				
			}
		}

		private void tableLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
		{
			timer.Enabled = true;
			TableLayoutPanelCellPosition pos = GetCellPosotion(tableLayoutPanel1);
			var labelUnderMouse = tableLayoutPanel1.GetControlFromPosition(pos.Column, pos.Row);
			value = labelUnderMouse.Text;
			if (value == 0.ToString())
				timer.Enabled = false;
		}

		private void tableLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
		{
			timer.Enabled = false;
			clicked = false;
		}

		private TableLayoutPanelCellPosition GetCellPosotion(TableLayoutPanel panel)
		{
			//mouse position
			Point p = panel.PointToClient(Control.MousePosition);
			//Cell position
			TableLayoutPanelCellPosition pos = new TableLayoutPanelCellPosition(0, 0);
			//Panel size.
			Size size = panel.Size;
			//average cell size.
			SizeF cellAutoSize = new SizeF(size.Width / panel.ColumnCount, size.Height / panel.RowCount);

			//Get the cell row.
			//y coordinate
			float y = 0;
			for (int i = 0; i < panel.RowCount; i++)
			{
				//Calculate the summary of the row heights.
				SizeType type = panel.RowStyles[i].SizeType;
				float height = panel.RowStyles[i].Height;
				switch (type)
				{
					case SizeType.Absolute:
						y += height;
						break;
					case SizeType.Percent:
						y += height / 100 * size.Height;
						break;
					case SizeType.AutoSize:
						y += cellAutoSize.Height;
						break;
				}
				//Check the mouse position to decide if the cell is in current row.
				if ((int)y > p.Y)
				{
					pos.Row = i;
					break;
				}
			}

			//Get the cell column.
			//x coordinate
			float x = 0;
			for (int i = 0; i < panel.ColumnCount; i++)
			{
				//Calculate the summary of the row widths.
				SizeType type = panel.ColumnStyles[i].SizeType;
				float width = panel.ColumnStyles[i].Width;
				switch (type)
				{
					case SizeType.Absolute:
						x += width;
						break;
					case SizeType.Percent:
						x += width / 100 * size.Width;
						break;
					case SizeType.AutoSize:
						x += cellAutoSize.Width;
						break;
				}
				//Check the mouse position to decide if the cell is in current column.
				if ((int)x > p.X)
				{
					pos.Column = i;
					break;
				}
			}

			//return the mouse position.
			return pos;
		}

		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			tableLayoutPanel1_MouseDown(sender, e);
		}

		private void label1_MouseUp(object sender, MouseEventArgs e)
		{
			tableLayoutPanel1_MouseUp(sender, e);
		}
	}
}