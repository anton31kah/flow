using System.Collections.Generic;
using System.Drawing;

namespace flow
{
    class Cell
    {
		// x -> col
		// y -> row

		public static Dictionary<char, Color> Colors = new Dictionary<char, Color>
		{
			{'w', Color.White },
			{'r', Color.Red },
			{'g', Color.Green },
			{'b', Color.Blue },
			{'y', Color.Yellow },
			{'o', Color.Orange },
			{'a', Color.Aqua },
			{'c', Color.Cyan },
			{'m', Color.Magenta},
			{'p', Color.Purple },
			{'n', Color.Brown }
		};
		public bool IsInitial { get; set; }
        public Color Color { get; set; }
        public char ColorValue { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
		public int Row { get; set; }
		public int Col { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
		public int CountInRowCol { get; set; }
		public int MaxWidthHeight { get; set; }
		public bool IsConnected { get; set; }

		public Cell(int row, int col, int countInRowCol, int maxWidthHeight, char colorValue = 'w', bool isInitial = false)
		{
			Row = row;
			Col = col;
			CountInRowCol = countInRowCol;
			MaxWidthHeight = maxWidthHeight;
			ColorValue = colorValue;
			Color = Colors[ColorValue];
			IsInitial = isInitial;
			X = Col * MaxWidthHeight / CountInRowCol;
			Y = Row * MaxWidthHeight / CountInRowCol;
			Width = Height = MaxWidthHeight / CountInRowCol;
		}

		public void Draw(Graphics formGraphics)
		{
			formGraphics.FillRectangle(new SolidBrush(Color), new Rectangle(X, Y, Width, Height));
			formGraphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(X, Y, Width, Height));
		}

		public override string ToString()
		{
			return Color + " " + IsInitial;
		}
	}
}
