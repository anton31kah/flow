using System.Drawing;

namespace flow
{
	internal class Pipes
    {
        public Graphics Graphics { get; set; }
		private readonly Pen _pen = new Pen(Color.Black, 2);

		public void Border(int x, int y, int width, int height)
		{
			Graphics.DrawRectangle(_pen, new Rectangle(x, y, width, height));
		}

		public void Big(int x, int y, int width, int height, Color color)
		{
			Brush brush = new SolidBrush(color);
			Graphics.FillEllipse(brush, new Rectangle(x + width / 6, y + height / 6, 2 * width / 3, 2 * height / 3));
			Border(x, y, width, height);
		}

		public void Small(int x, int y, int width, int height, Color color)
		{
			Brush brush = new SolidBrush(color);
			Graphics.FillEllipse(brush, new Rectangle(x + width / 3, y + height / 3, width / 3, height / 3));
			Border(x, y, width, height);
		}

		public void Medium(int x, int y, int width, int height, Color color)
		{
			Brush brush = new SolidBrush(color);
			Graphics.FillEllipse(brush, new Rectangle(x + width / 4, y + height / 4, width / 2, height / 2));
			Border(x, y, width, height);
		}
		public void Up(int x, int y, int width, int height, Color color)
        {
			Small(x, y, width, height, color);
            Graphics.FillRectangle(new SolidBrush(color), new Rectangle(x + width / 3, y, width / 3, height / 2));
            Border(x, y, width, height);
        }

		public void Down(int x, int y, int width, int height, Color color)
		{
			Small(x, y, width, height, color);
			Graphics.FillRectangle(new SolidBrush(color), new Rectangle(x + width / 3, y + height / 2, width / 3, height / 2));
			Border(x, y, width, height);
		}
		public void Left(int x, int y, int width, int height, Color color)
		{
			Small(x, y, width, height, color);
			Graphics.FillRectangle(new SolidBrush(color), new Rectangle(x, y + height / 3, width / 2, height / 3));
			Border(x, y, width, height);
		}
		public void Right(int x, int y, int width, int height, Color color)
		{
			Small(x, y, width, height, color);
			Graphics.FillRectangle(new SolidBrush(color), new Rectangle(x + width / 2, y + height / 3, width / 2, height / 3));
			Border(x, y, width, height);
		}
		public void UpLeft(int x, int y, int width, int height, Color color)
		{
			Up(x, y, width, height, color);
			Left(x, y, width, height, color);
		}
		public void UpRight(int x, int y, int width, int height, Color color)
		{
			Up(x, y, width, height, color);
			Right(x, y, width, height, color);
		}
		public void DownLeft(int x, int y, int width, int height, Color color)
		{
			Down(x, y, width, height, color);
			Left(x, y, width, height, color);
		}
		public void DownRight(int x, int y, int width, int height, Color color)
		{
			Down(x, y, width, height, color);
			Right(x, y, width, height, color);
		}

		public void UpDown(int x, int y, int width, int height, Color color)
		{
			Up(x, y, width, height, color);
			Down(x, y, width, height, color);
		}

		public void LeftRight(int x, int y, int width, int height, Color color)
		{
			Left(x, y, width, height, color);
			Right(x, y, width, height, color);
		}
	}
}
