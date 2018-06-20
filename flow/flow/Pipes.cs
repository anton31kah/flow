using System.Drawing;

namespace flow
{
    public enum PipeDirection
    {
        Medium,
        Up,
        Down,
        Left,
        Right,
        UpLeft,
        UpRight,
        DownLeft,
        DownRight,
        UpDown,
        LeftRight
    }

    public static class Pipes
    {
        public static Graphics Graphics { get; set; }
        private static readonly Pen Pen = new Pen(Color.YellowGreen, 2);

        public static void Border(int x, int y, int width, int height)
        {
            Graphics.DrawRectangle(Pen, new Rectangle(x, y, width, height));
        }

        public static void Big(int x, int y, int width, int height, Color color)
        {
            Graphics.FillEllipse(new SolidBrush(color),
                                 new Rectangle(x + width / 6, y + height / 6, 2 * width / 3, 2 * height / 3));
            Border(x, y, width, height);
        }

        public static void Small(int x, int y, int width, int height, Color color)
        {
            Graphics.FillEllipse(new SolidBrush(color),
                                 new Rectangle(x + width / 3, y + height / 3, width / 3, height / 3));
            Border(x, y, width, height);
        }

        public static void Medium(int x, int y, int width, int height, Color color)
        {
            Graphics.FillEllipse(new SolidBrush(color),
                                 new Rectangle(x + width / 4, y + height / 4, width / 2, height / 2));
            Border(x, y, width, height);
        }

        public static void Up(int x, int y, int width, int height, Color color)
        {
            Small(x, y, width, height, color);
            Graphics.FillRectangle(new SolidBrush(color), new Rectangle(x + width / 3, y, width / 3, height / 2));
            Border(x, y, width, height);
        }

        public static void Down(int x, int y, int width, int height, Color color)
        {
            Small(x, y, width, height, color);
            Graphics.FillRectangle(new SolidBrush(color),
                                   new Rectangle(x + width / 3, y + height / 2, width / 3, height / 2));
            Border(x, y, width, height);
        }

        public static void Left(int x, int y, int width, int height, Color color)
        {
            Small(x, y, width, height, color);
            Graphics.FillRectangle(new SolidBrush(color), new Rectangle(x, y + height / 3, width / 2, height / 3));
            Border(x, y, width, height);
        }

        public static void Right(int x, int y, int width, int height, Color color)
        {
            Small(x, y, width, height, color);
            Graphics.FillRectangle(new SolidBrush(color),
                                   new Rectangle(x + width / 2, y + height / 3, width / 2, height / 3));
            Border(x, y, width, height);
        }

        public static void UpLeft(int x, int y, int width, int height, Color color)
        {
            Up(x, y, width, height, color);
            Left(x, y, width, height, color);
        }

        public static void UpRight(int x, int y, int width, int height, Color color)
        {
            Up(x, y, width, height, color);
            Right(x, y, width, height, color);
        }

        public static void DownLeft(int x, int y, int width, int height, Color color)
        {
            Down(x, y, width, height, color);
            Left(x, y, width, height, color);
        }

        public static void DownRight(int x, int y, int width, int height, Color color)
        {
            Down(x, y, width, height, color);
            Right(x, y, width, height, color);
        }

        public static void UpDown(int x, int y, int width, int height, Color color)
        {
            Up(x, y, width, height, color);
            Down(x, y, width, height, color);
        }

        public static void LeftRight(int x, int y, int width, int height, Color color)
        {
            Left(x, y, width, height, color);
            Right(x, y, width, height, color);
        }
    }
}