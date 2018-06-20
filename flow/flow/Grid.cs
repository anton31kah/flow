using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace flow
{
    [Serializable]
    public class Grid
    {
        /*
         *  Reactangle(x, y, Width, height);
         *  x && y -> gore levo tockite
         *  Width -> sirinata na eden cell
         *  height -> visina na eden cell
         * 
         */

        public readonly TimeSpan DefaultTick = new TimeSpan(0, 0, 1);

        [NonSerialized] private Graphics _formGraphics;

        public Dictionary<Color, Path> Paths { get; set; }
        public Cell[][] Cells;
        private List<Cell> initialCells;
        private int Width { get; }
        private int Height { get; }
        private int Size { get; }

        public TimeSpan TimeElapsed { get; set; }

        public Graphics FormGraphics
        {
            get => _formGraphics;
            set => _formGraphics = value;
        }

        public static Grid Empty { get; } = new Grid(5, 500, 500);

        public Dictionary<Color, bool> BetterCompletedPipes => Paths.ToDictionary(p => p.Key,
                                                                                  p =>
                                                                                  {
                                                                                      bool valid = true;
                                                                                      LinkedList<Cell> pathList =
                                                                                          p.Value.PathList;

                                                                                      if (pathList.Count <= 2)
                                                                                          return false;
                                                                                      LinkedListNode<Cell> current =
                                                                                          pathList.First;

                                                                                      while (current != pathList.Last)
                                                                                      {
                                                                                          if (
                                                                                              Math.Abs(current
                                                                                                       .Value.Row -
                                                                                                       current
                                                                                                           .Next.Value
                                                                                                           .Row) +
                                                                                              Math.Abs(current
                                                                                                       .Value.Col -
                                                                                                       current
                                                                                                           .Next.Value
                                                                                                           .Col) != 1)
                                                                                          {
                                                                                              valid = false;

                                                                                              break;
                                                                                          }

                                                                                          current = current.Next;
                                                                                      }

                                                                                      return valid;
                                                                                  });

        public int ConnectedCells => Paths.Select(p => p.Value.PathList.Count).Sum();
        public int FinishedPercent => (int) (1.0 * ConnectedCells / (Size * Size) * 100);
        public Dictionary<Color, int> ColorUpDownStart { get; set; }

        public Grid(int n, int width, int height, List<Cell> initialCells = null)
        {
            Paths = new Dictionary<Color, Path>();
            ColorUpDownStart = new Dictionary<Color, int>();
            Width = width;
            Height = height;
            Size = n;
            this.initialCells = initialCells;
            Cells = new Cell[n][];

            for (int i = 0; i < n; i++)
            {
                Cells[i] = new Cell[n];

                for (int j = 0; j < n; j++)
                {
                    if (initialCells != null && initialCells.Any(c => c.Row == i && c.Col == j))
                    {
                        var cell = initialCells.First(c => c.Row == i && c.Col == j);
                        Cells[i][j] = cell;

                        if (!Paths.ContainsKey(cell.Color))
                        {
                            var last = initialCells.Last(c => c.Color == cell.Color);
                            Paths[cell.Color] = new Path(cell, last);
                            ColorUpDownStart[cell.Color] = 0;
                        }
                    }
                    else Cells[i][j] = new NormalCell(i, j, n, width, Color.Black);
                }
            }
        }

        public void Reset()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Cells[i][j].IsConnected = false;
                    Cells[i][j].NumberOfPipes = 0;

                    if (Cells[i][j] is NormalCell)
                    {
                        if (Cells[i][j].Color != Color.Black)
                        {
                            Cells[i][j].PipeDirection.Clear();
                            Paths[Cells[i][j].Color].PathList.Remove(Cells[i][j]);
                            Cells[i][j].Color = Color.Black;
                        }
                    }
                    else
                        Cells[i][j].PipeDirection.Clear();
                }
            }
        }

        public void Draw()
        {
            foreach (Cell[] cells in Cells)
                foreach (Cell cell in cells)
                    cell.Draw(FormGraphics);
        }

        public Cell GetCellUnderMouse(int x, int y)
        {
            int cellWidth = Width / Size;
            int col = Math.Max(0, Math.Min(x / cellWidth, Size - 1));
            int row = Math.Max(0, Math.Min(y / cellWidth, Size - 1));

            return Cells[row][col];
        }

        public bool AreAdjacent(Cell one, Cell two)
        {
            return Math.Abs(one.Col - two.Col) + Math.Abs(one.Row - two.Row) <= 1;
        }
    }
}