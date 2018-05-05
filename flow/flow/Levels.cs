using System.Collections.Generic;
using System.Drawing;

namespace flow
{
    class Levels
    {
        public static int Width = 500;

        public static List<Grid> Levels5 = new List<Grid>
        {
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 5, Width, Color.Red),
                new InitialCell(0, 2, 5, Width, Color.Green),
                new InitialCell(0, 4, 5, Width, Color.Yellow),
                new InitialCell(1, 2, 5, Width, Color.Blue),
                new InitialCell(1, 4, 5, Width, Color.Orange),
                new InitialCell(3, 1, 5, Width, Color.Green),
                new InitialCell(3, 3, 5, Width, Color.Yellow),
                new InitialCell(4, 1, 5, Width, Color.Red),
                new InitialCell(4, 2, 5, Width, Color.Blue),
                new InitialCell(4, 3, 5, Width, Color.Orange)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 5, Width, Color.Yellow),
                new InitialCell(2, 2, 5, Width, Color.Green),
                new InitialCell(3, 0, 5, Width, Color.Blue),
                new InitialCell(3, 1, 5, Width, Color.Green),
                new InitialCell(3, 2, 5, Width, Color.Red),
                new InitialCell(3, 4, 5, Width, Color.Yellow),
                new InitialCell(4, 0, 5, Width, Color.Red),
                new InitialCell(4, 4, 5, Width, Color.Blue)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 5, Width, Color.Yellow),
                new InitialCell(0, 2, 5, Width, Color.Blue),
                new InitialCell(0, 3, 5, Width, Color.Green),
                new InitialCell(1, 3, 5, Width, Color.Red),
                new InitialCell(2, 2, 5, Width, Color.Red),
                new InitialCell(3, 0, 5, Width, Color.Yellow),
                new InitialCell(3, 3, 5, Width, Color.Orange),
                new InitialCell(4, 0, 5, Width, Color.Blue),
                new InitialCell(4, 2, 5, Width, Color.Orange),
                new InitialCell(4, 3, 5, Width, Color.Green)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 3, 5, Width, Color.Red),
                new InitialCell(0, 4, 5, Width, Color.Green),
                new InitialCell(1, 0, 5, Width, Color.Red),
                new InitialCell(2, 2, 5, Width, Color.Yellow),
                new InitialCell(3, 3, 5, Width, Color.Blue),
                new InitialCell(4, 0, 5, Width, Color.Green),
                new InitialCell(4, 1, 5, Width, Color.Blue),
                new InitialCell(4, 2, 5, Width, Color.Yellow)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 3, 5, Width, Color.Red),
                new InitialCell(0, 4, 5, Width, Color.Green),
                new InitialCell(1, 1, 5, Width, Color.Yellow),
                new InitialCell(1, 2, 5, Width, Color.Blue),
                new InitialCell(1, 3, 5, Width, Color.Green),
                new InitialCell(3, 4, 5, Width, Color.Blue),
                new InitialCell(4, 2, 5, Width, Color.Red),
                new InitialCell(4, 4, 5, Width, Color.Yellow)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 5, Width, Color.Yellow),
                new InitialCell(0, 2, 5, Width, Color.Blue),
                new InitialCell(0, 3, 5, Width, Color.Red),
                new InitialCell(0, 4, 5, Width, Color.Green),
                new InitialCell(2, 3, 5, Width, Color.Green),
                new InitialCell(3, 1, 5, Width, Color.Blue),
                new InitialCell(3, 4, 5, Width, Color.Red),
                new InitialCell(4, 4, 5, Width, Color.Yellow)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 5, Width, Color.Blue),
                new InitialCell(0, 3, 5, Width, Color.Yellow),
                new InitialCell(1, 0, 5, Width, Color.Green),
                new InitialCell(2, 0, 5, Width, Color.Yellow),
                new InitialCell(2, 2, 5, Width, Color.Green),
                new InitialCell(2, 3, 5, Width, Color.Blue),
                new InitialCell(3, 1, 5, Width, Color.Red),
                new InitialCell(3, 3, 5, Width, Color.Red)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 5, Width, Color.Blue),
                new InitialCell(0, 3, 5, Width, Color.Red),
                new InitialCell(0, 4, 5, Width, Color.Orange),
                new InitialCell(1, 3, 5, Width, Color.Yellow),
                new InitialCell(2, 2, 5, Width, Color.Yellow),
                new InitialCell(3, 1, 5, Width, Color.Red),
                new InitialCell(3, 2, 5, Width, Color.Orange),
                new InitialCell(3, 4, 5, Width, Color.Green),
                new InitialCell(4, 1, 5, Width, Color.Blue),
                new InitialCell(4, 2, 5, Width, Color.Green)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 3, 5, Width, Color.Red),
                new InitialCell(1, 1, 5, Width, Color.Yellow),
                new InitialCell(1, 2, 5, Width, Color.Blue),
                new InitialCell(1, 3, 5, Width, Color.Green),
                new InitialCell(2, 2, 5, Width, Color.Yellow),
                new InitialCell(4, 0, 5, Width, Color.Blue),
                new InitialCell(4, 1, 5, Width, Color.Green),
                new InitialCell(4, 2, 5, Width, Color.Red)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(1, 0, 5, Width, Color.Green),
                new InitialCell(1, 3, 5, Width, Color.Red),
                new InitialCell(2, 0, 5, Width, Color.Blue),
                new InitialCell(2, 1, 5, Width, Color.Red),
                new InitialCell(2, 2, 5, Width, Color.Blue),
                new InitialCell(2, 3, 5, Width, Color.Yellow),
                new InitialCell(4, 0, 5, Width, Color.Yellow),
                new InitialCell(4, 4, 5, Width, Color.Green)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 5, Width, Color.Blue),
                new InitialCell(0, 1, 5, Width, Color.Yellow),
                new InitialCell(0, 2, 5, Width, Color.Red),
                new InitialCell(2, 1, 5, Width, Color.Blue),
                new InitialCell(2, 2, 5, Width, Color.Green),
                new InitialCell(4, 0, 5, Width, Color.Green),
                new InitialCell(4, 1, 5, Width, Color.Yellow),
                new InitialCell(4, 4, 5, Width, Color.Red)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 3, 5, Width, Color.Red),
                new InitialCell(0, 4, 5, Width, Color.Green),
                new InitialCell(1, 2, 5, Width, Color.Blue),
                new InitialCell(1, 3, 5, Width, Color.Green),
                new InitialCell(2, 0, 5, Width, Color.Red),
                new InitialCell(3, 0, 5, Width, Color.Orange),
                new InitialCell(3, 1, 5, Width, Color.Blue),
                new InitialCell(3, 3, 5, Width, Color.Yellow),
                new InitialCell(3, 4, 5, Width, Color.Orange),
                new InitialCell(4, 4, 5, Width, Color.Yellow)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 5, Width, Color.Green),
                new InitialCell(0, 1, 5, Width, Color.Yellow),
                new InitialCell(0, 3, 5, Width, Color.Yellow),
                new InitialCell(0, 4, 5, Width, Color.Orange),
                new InitialCell(2, 0, 5, Width, Color.Red),
                new InitialCell(2, 2, 5, Width, Color.Orange),
                new InitialCell(2, 3, 5, Width, Color.Blue),
                new InitialCell(3, 3, 5, Width, Color.Green),
                new InitialCell(4, 3, 5, Width, Color.Red),
                new InitialCell(4, 4, 5, Width, Color.Blue)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 2, 5, Width, Color.Green),
                new InitialCell(0, 3, 5, Width, Color.Yellow),
                new InitialCell(0, 4, 5, Width, Color.Blue),
                new InitialCell(2, 0, 5, Width, Color.Green),
                new InitialCell(2, 3, 5, Width, Color.Orange),
                new InitialCell(3, 3, 5, Width, Color.Red),
                new InitialCell(3, 4, 5, Width, Color.Blue),
                new InitialCell(4, 0, 5, Width, Color.Yellow),
                new InitialCell(4, 1, 5, Width, Color.Orange),
                new InitialCell(4, 4, 5, Width, Color.Red)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 5, Width, Color.Blue),
                new InitialCell(0, 1, 5, Width, Color.Yellow),
                new InitialCell(1, 2, 5, Width, Color.Green),
                new InitialCell(2, 0, 5, Width, Color.Red),
                new InitialCell(2, 2, 5, Width, Color.Blue),
                new InitialCell(4, 0, 5, Width, Color.Red),
                new InitialCell(4, 1, 5, Width, Color.Green),
                new InitialCell(4, 2, 5, Width, Color.Yellow)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(1, 0, 5, Width, Color.Yellow),
                new InitialCell(1, 1, 5, Width, Color.Green),
                new InitialCell(1, 3, 5, Width, Color.Green),
                new InitialCell(2, 0, 5, Width, Color.Blue),
                new InitialCell(3, 1, 5, Width, Color.Yellow),
                new InitialCell(3, 2, 5, Width, Color.Red),
                new InitialCell(3, 4, 5, Width, Color.Red),
                new InitialCell(4, 4, 5, Width, Color.Blue)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 5, Width, Color.Red),
                new InitialCell(0, 4, 5, Width, Color.Red),
                new InitialCell(1, 1, 5, Width, Color.Blue),
                new InitialCell(1, 2, 5, Width, Color.Green),
                new InitialCell(1, 3, 5, Width, Color.Blue),
                new InitialCell(1, 4, 5, Width, Color.Yellow),
                new InitialCell(3, 1, 5, Width, Color.Green),
                new InitialCell(4, 3, 5, Width, Color.Yellow)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(1, 1, 5, Width, Color.Yellow),
                new InitialCell(1, 3, 5, Width, Color.Blue),
                new InitialCell(2, 2, 5, Width, Color.Blue),
                new InitialCell(3, 2, 5, Width, Color.Red),
                new InitialCell(3, 4, 5, Width, Color.Green),
                new InitialCell(4, 0, 5, Width, Color.Red),
                new InitialCell(4, 1, 5, Width, Color.Yellow),
                new InitialCell(4, 2, 5, Width, Color.Green)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(1, 0, 5, Width, Color.Red),
                new InitialCell(1, 1, 5, Width, Color.Blue),
                new InitialCell(1, 3, 5, Width, Color.Blue),
                new InitialCell(2, 3, 5, Width, Color.Green),
                new InitialCell(3, 0, 5, Width, Color.Green),
                new InitialCell(3, 3, 5, Width, Color.Yellow),
                new InitialCell(4, 0, 5, Width, Color.Yellow),
                new InitialCell(4, 2, 5, Width, Color.Red)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 5, Width, Color.Red),
                new InitialCell(0, 2, 5, Width, Color.Green),
                new InitialCell(0, 3, 5, Width, Color.Yellow),
                new InitialCell(0, 4, 5, Width, Color.Blue),
                new InitialCell(1, 0, 5, Width, Color.Blue),
                new InitialCell(2, 2, 5, Width, Color.Green),
                new InitialCell(3, 2, 5, Width, Color.Red),
                new InitialCell(3, 3, 5, Width, Color.Yellow)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(1, 1, 5, Width, Color.Green),
                new InitialCell(1, 2, 5, Width, Color.Red),
                new InitialCell(1, 4, 5, Width, Color.Yellow),
                new InitialCell(2, 4, 5, Width, Color.Orange),
                new InitialCell(3, 0, 5, Width, Color.Yellow),
                new InitialCell(3, 1, 5, Width, Color.Blue),
                new InitialCell(3, 3, 5, Width, Color.Red),
                new InitialCell(4, 0, 5, Width, Color.Blue),
                new InitialCell(4, 2, 5, Width, Color.Green),
                new InitialCell(4, 3, 5, Width, Color.Orange)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 5, Width, Color.Red),
                new InitialCell(1, 1, 5, Width, Color.Orange),
                new InitialCell(1, 3, 5, Width, Color.Blue),
                new InitialCell(2, 0, 5, Width, Color.Red),
                new InitialCell(2, 1, 5, Width, Color.Yellow),
                new InitialCell(2, 2, 5, Width, Color.Blue),
                new InitialCell(3, 2, 5, Width, Color.Orange),
                new InitialCell(4, 0, 5, Width, Color.Yellow),
                new InitialCell(4, 1, 5, Width, Color.Green),
                new InitialCell(4, 4, 5, Width, Color.Green)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(1, 0, 5, Width, Color.Blue),
                new InitialCell(1, 1, 5, Width, Color.Green),
                new InitialCell(1, 3, 5, Width, Color.Green),
                new InitialCell(2, 0, 5, Width, Color.Red),
                new InitialCell(3, 1, 5, Width, Color.Blue),
                new InitialCell(3, 3, 5, Width, Color.Red),
                new InitialCell(3, 4, 5, Width, Color.Yellow),
                new InitialCell(4, 3, 5, Width, Color.Yellow)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 5, Width, Color.Red),
                new InitialCell(0, 4, 5, Width, Color.Red),
                new InitialCell(2, 1, 5, Width, Color.Blue),
                new InitialCell(2, 2, 5, Width, Color.Yellow),
                new InitialCell(2, 4, 5, Width, Color.Green),
                new InitialCell(3, 4, 5, Width, Color.Yellow),
                new InitialCell(4, 1, 5, Width, Color.Green),
                new InitialCell(4, 4, 5, Width, Color.Blue)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 5, Width, Color.Green),
                new InitialCell(0, 1, 5, Width, Color.Red),
                new InitialCell(0, 4, 5, Width, Color.Red),
                new InitialCell(2, 3, 5, Width, Color.Orange),
                new InitialCell(2, 4, 5, Width, Color.Green),
                new InitialCell(3, 0, 5, Width, Color.Orange),
                new InitialCell(3, 3, 5, Width, Color.Blue),
                new InitialCell(3, 4, 5, Width, Color.Yellow),
                new InitialCell(4, 0, 5, Width, Color.Blue),
                new InitialCell(4, 2, 5, Width, Color.Yellow)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(1, 1, 5, Width, Color.Red),
                new InitialCell(1, 3, 5, Width, Color.Red),
                new InitialCell(2, 4, 5, Width, Color.Blue),
                new InitialCell(3, 0, 5, Width, Color.Blue),
                new InitialCell(3, 2, 5, Width, Color.Green),
                new InitialCell(3, 4, 5, Width, Color.Yellow),
                new InitialCell(4, 0, 5, Width, Color.Yellow),
                new InitialCell(4, 4, 5, Width, Color.Green)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 2, 5, Width, Color.Green),
                new InitialCell(0, 4, 5, Width, Color.Red),
                new InitialCell(1, 1, 5, Width, Color.Red),
                new InitialCell(1, 4, 5, Width, Color.Yellow),
                new InitialCell(2, 1, 5, Width, Color.Blue),
                new InitialCell(2, 3, 5, Width, Color.Blue),
                new InitialCell(3, 1, 5, Width, Color.Yellow),
                new InitialCell(4, 4, 5, Width, Color.Green)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(1, 0, 5, Width, Color.Orange),
                new InitialCell(1, 1, 5, Width, Color.Red),
                new InitialCell(1, 3, 5, Width, Color.Red),
                new InitialCell(1, 4, 5, Width, Color.Orange),
                new InitialCell(2, 0, 5, Width, Color.Yellow),
                new InitialCell(3, 1, 5, Width, Color.Blue),
                new InitialCell(3, 3, 5, Width, Color.Green),
                new InitialCell(4, 0, 5, Width, Color.Yellow),
                new InitialCell(4, 1, 5, Width, Color.Green),
                new InitialCell(4, 3, 5, Width, Color.Blue)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 5, Width, Color.Green),
                new InitialCell(1, 0, 5, Width, Color.Orange),
                new InitialCell(1, 1, 5, Width, Color.Red),
                new InitialCell(1, 3, 5, Width, Color.Red),
                new InitialCell(2, 3, 5, Width, Color.Orange),
                new InitialCell(2, 4, 5, Width, Color.Green),
                new InitialCell(3, 0, 5, Width, Color.Blue),
                new InitialCell(3, 3, 5, Width, Color.Blue),
                new InitialCell(3, 4, 5, Width, Color.Yellow),
                new InitialCell(4, 0, 5, Width, Color.Yellow)
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 5, Width, Color.Blue),
                new InitialCell(0, 4, 5, Width, Color.Yellow),
                new InitialCell(2, 1, 5, Width, Color.Red),
                new InitialCell(2, 2, 5, Width, Color.Green),
                new InitialCell(3, 2, 5, Width, Color.Blue),
                new InitialCell(4, 0, 5, Width, Color.Green),
                new InitialCell(4, 1, 5, Width, Color.Red),
                new InitialCell(4, 2, 5, Width, Color.Yellow),
            })
        };

        public static List<Grid> Levels6 = new List<Grid>
        {
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 6, Width, Color.Green),
                new InitialCell(0, 1, 6, Width, Color.Yellow),
                new InitialCell(0, 2, 6, Width, Color.Cyan),
                new InitialCell(0, 4, 6, Width, Color.Red),
                new InitialCell(0, 5, 6, Width, Color.Blue),
                new InitialCell(1, 4, 6, Width, Color.Orange),
                new InitialCell(2, 2, 6, Width, Color.Cyan),
                new InitialCell(3, 2, 6, Width, Color.Red),
                new InitialCell(4, 0, 6, Width, Color.Green),
                new InitialCell(4, 2, 6, Width, Color.Orange),
                new InitialCell(5, 0, 6, Width, Color.Yellow),
                new InitialCell(5, 2, 6, Width, Color.Blue)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 6, Width, Color.Orange),
                new InitialCell(0, 2, 6, Width, Color.Blue),
                new InitialCell(0, 5, 6, Width, Color.Green),
                new InitialCell(2, 2, 6, Width, Color.Yellow),
                new InitialCell(2, 3, 6, Width, Color.Red),
                new InitialCell(2, 5, 6, Width, Color.Green),
                new InitialCell(3, 3, 6, Width, Color.Cyan),
                new InitialCell(3, 5, 6, Width, Color.Blue),
                new InitialCell(4, 1, 6, Width, Color.Red),
                new InitialCell(4, 2, 6, Width, Color.Yellow),
                new InitialCell(4, 4, 6, Width, Color.Cyan),
                new InitialCell(4, 5, 6, Width, Color.Orange)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(1, 1, 6, Width, Color.Yellow),
                new InitialCell(1, 4, 6, Width, Color.Green),
                new InitialCell(2, 3, 6, Width, Color.Red),
                new InitialCell(4, 2, 6, Width, Color.Yellow),
                new InitialCell(4, 3, 6, Width, Color.Blue),
                new InitialCell(4, 4, 6, Width, Color.Green),
                new InitialCell(5, 2, 6, Width, Color.Blue),
                new InitialCell(5, 3, 6, Width, Color.Red)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 6, Width, Color.Yellow),
                new InitialCell(3, 0, 6, Width, Color.Red),
                new InitialCell(3, 1, 6, Width, Color.Green),
                new InitialCell(3, 2, 6, Width, Color.Blue),
                new InitialCell(3, 3, 6, Width, Color.Green),
                new InitialCell(4, 0, 6, Width, Color.Yellow),
                new InitialCell(4, 1, 6, Width, Color.Blue),
                new InitialCell(4, 3, 6, Width, Color.Red)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 6, Width, Color.Green),
                new InitialCell(2, 0, 6, Width, Color.Yellow),
                new InitialCell(2, 3, 6, Width, Color.Red),
                new InitialCell(2, 4, 6, Width, Color.Yellow),
                new InitialCell(3, 4, 6, Width, Color.Blue),
                new InitialCell(4, 1, 6, Width, Color.Blue),
                new InitialCell(4, 4, 6, Width, Color.Red),
                new InitialCell(5, 4, 6, Width, Color.Green)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 3, 6, Width, Color.Red),
                new InitialCell(0, 5, 6, Width, Color.Green),
                new InitialCell(1, 1, 6, Width, Color.Orange),
                new InitialCell(1, 3, 6, Width, Color.Yellow),
                new InitialCell(2, 4, 6, Width, Color.Red),
                new InitialCell(2, 5, 6, Width, Color.Green),
                new InitialCell(3, 2, 6, Width, Color.Blue),
                new InitialCell(3, 3, 6, Width, Color.Yellow),
                new InitialCell(3, 4, 6, Width, Color.Cyan),
                new InitialCell(3, 5, 6, Width, Color.Orange),
                new InitialCell(4, 2, 6, Width, Color.Cyan),
                new InitialCell(5, 0, 6, Width, Color.Blue)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 2, 6, Width, Color.Blue),
                new InitialCell(0, 3, 6, Width, Color.Yellow),
                new InitialCell(1, 1, 6, Width, Color.Orange),
                new InitialCell(1, 2, 6, Width, Color.Green),
                new InitialCell(1, 5, 6, Width, Color.Yellow),
                new InitialCell(2, 3, 6, Width, Color.Blue),
                new InitialCell(2, 5, 6, Width, Color.Red),
                new InitialCell(3, 2, 6, Width, Color.Orange),
                new InitialCell(4, 0, 6, Width, Color.Red),
                new InitialCell(4, 4, 6, Width, Color.Green)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 4, 6, Width, Color.Blue),
                new InitialCell(0, 5, 6, Width, Color.Green),
                new InitialCell(1, 2, 6, Width, Color.Red),
                new InitialCell(2, 2, 6, Width, Color.Orange),
                new InitialCell(3, 2, 6, Width, Color.Yellow),
                new InitialCell(3, 3, 6, Width, Color.Green),
                new InitialCell(4, 1, 6, Width, Color.Red),
                new InitialCell(4, 4, 6, Width, Color.Blue),
                new InitialCell(5, 1, 6, Width, Color.Orange),
                new InitialCell(5, 2, 6, Width, Color.Yellow)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 6, Width, Color.Red),
                new InitialCell(0, 1, 6, Width, Color.Green),
                new InitialCell(0, 5, 6, Width, Color.Green),
                new InitialCell(1, 2, 6, Width, Color.Cyan),
                new InitialCell(1, 5, 6, Width, Color.Cyan),
                new InitialCell(2, 0, 6, Width, Color.Orange),
                new InitialCell(2, 5, 6, Width, Color.Red),
                new InitialCell(3, 1, 6, Width, Color.Yellow),
                new InitialCell(3, 5, 6, Width, Color.Yellow),
                new InitialCell(4, 1, 6, Width, Color.Blue),
                new InitialCell(4, 5, 6, Width, Color.Blue),
                new InitialCell(5, 5, 6, Width, Color.Orange)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 6, Width, Color.Red),
                new InitialCell(1, 3, 6, Width, Color.Orange),
                new InitialCell(1, 4, 6, Width, Color.Blue),
                new InitialCell(1, 5, 6, Width, Color.Red),
                new InitialCell(2, 3, 6, Width, Color.Yellow),
                new InitialCell(2, 5, 6, Width, Color.Green),
                new InitialCell(3, 2, 6, Width, Color.Green),
                new InitialCell(4, 1, 6, Width, Color.Yellow),
                new InitialCell(4, 2, 6, Width, Color.Orange),
                new InitialCell(4, 4, 6, Width, Color.Blue)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(1, 1, 6, Width, Color.Blue),
                new InitialCell(1, 2, 6, Width, Color.Orange),
                new InitialCell(1, 4, 6, Width, Color.Orange),
                new InitialCell(1, 5, 6, Width, Color.Red),
                new InitialCell(2, 5, 6, Width, Color.Blue),
                new InitialCell(3, 4, 6, Width, Color.Red),
                new InitialCell(3, 5, 6, Width, Color.Green),
                new InitialCell(4, 0, 6, Width, Color.Green),
                new InitialCell(4, 1, 6, Width, Color.Yellow),
                new InitialCell(4, 4, 6, Width, Color.Yellow)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 6, Width, Color.Green),
                new InitialCell(0, 2, 6, Width, Color.Yellow),
                new InitialCell(1, 1, 6, Width, Color.Blue),
                new InitialCell(1, 2, 6, Width, Color.Red),
                new InitialCell(2, 3, 6, Width, Color.Blue),
                new InitialCell(3, 3, 6, Width, Color.Green),
                new InitialCell(5, 0, 6, Width, Color.Red),
                new InitialCell(5, 1, 6, Width, Color.Yellow)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 2, 6, Width, Color.Blue),
                new InitialCell(1, 1, 6, Width, Color.Green),
                new InitialCell(1, 2, 6, Width, Color.Red),
                new InitialCell(1, 4, 6, Width, Color.Yellow),
                new InitialCell(2, 0, 6, Width, Color.Blue),
                new InitialCell(2, 5, 6, Width, Color.Red),
                new InitialCell(4, 0, 6, Width, Color.Yellow),
                new InitialCell(4, 1, 6, Width, Color.Orange),
                new InitialCell(4, 4, 6, Width, Color.Green),
                new InitialCell(5, 0, 6, Width, Color.Orange)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 4, 6, Width, Color.Orange),
                new InitialCell(1, 2, 6, Width, Color.Green),
                new InitialCell(1, 4, 6, Width, Color.Blue),
                new InitialCell(3, 3, 6, Width, Color.Red),
                new InitialCell(4, 5, 6, Width, Color.Orange),
                new InitialCell(5, 0, 6, Width, Color.Yellow),
                new InitialCell(5, 1, 6, Width, Color.Green),
                new InitialCell(5, 2, 6, Width, Color.Yellow),
                new InitialCell(5, 3, 6, Width, Color.Red),
                new InitialCell(5, 5, 6, Width, Color.Blue)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 6, Width, Color.Yellow),
                new InitialCell(1, 0, 6, Width, Color.Blue),
                new InitialCell(2, 0, 6, Width, Color.Red),
                new InitialCell(2, 1, 6, Width, Color.Blue),
                new InitialCell(2, 3, 6, Width, Color.Green),
                new InitialCell(2, 4, 6, Width, Color.Cyan),
                new InitialCell(4, 3, 6, Width, Color.Orange),
                new InitialCell(4, 4, 6, Width, Color.Green),
                new InitialCell(5, 0, 6, Width, Color.Red),
                new InitialCell(5, 1, 6, Width, Color.Cyan),
                new InitialCell(5, 2, 6, Width, Color.Orange),
                new InitialCell(5, 3, 6, Width, Color.Yellow)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 2, 6, Width, Color.Cyan),
                new InitialCell(0, 3, 6, Width, Color.Blue),
                new InitialCell(1, 0, 6, Width, Color.Cyan),
                new InitialCell(1, 4, 6, Width, Color.Yellow),
                new InitialCell(2, 3, 6, Width, Color.Green),
                new InitialCell(2, 4, 6, Width, Color.Orange),
                new InitialCell(3, 1, 6, Width, Color.Green),
                new InitialCell(3, 3, 6, Width, Color.Red),
                new InitialCell(4, 0, 6, Width, Color.Yellow),
                new InitialCell(4, 1, 6, Width, Color.Red),
                new InitialCell(4, 4, 6, Width, Color.Orange),
                new InitialCell(5, 0, 6, Width, Color.Blue)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 6, Width, Color.Yellow),
                new InitialCell(0, 5, 6, Width, Color.Red),
                new InitialCell(1, 1, 6, Width, Color.Red),
                new InitialCell(1, 3, 6, Width, Color.Blue),
                new InitialCell(2, 1, 6, Width, Color.Cyan),
                new InitialCell(2, 3, 6, Width, Color.Green),
                new InitialCell(2, 4, 6, Width, Color.Orange),
                new InitialCell(3, 2, 6, Width, Color.Cyan),
                new InitialCell(4, 0, 6, Width, Color.Green),
                new InitialCell(4, 2, 6, Width, Color.Yellow),
                new InitialCell(4, 4, 6, Width, Color.Orange),
                new InitialCell(5, 4, 6, Width, Color.Blue)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 5, 6, Width, Color.Orange),
                new InitialCell(1, 1, 6, Width, Color.Green),
                new InitialCell(1, 5, 6, Width, Color.Yellow),
                new InitialCell(2, 1, 6, Width, Color.Red),
                new InitialCell(2, 3, 6, Width, Color.Red),
                new InitialCell(4, 2, 6, Width, Color.Blue),
                new InitialCell(4, 4, 6, Width, Color.Blue),
                new InitialCell(5, 0, 6, Width, Color.Orange),
                new InitialCell(5, 2, 6, Width, Color.Green),
                new InitialCell(5, 3, 6, Width, Color.Yellow)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 6, Width, Color.Green),
                new InitialCell(0, 1, 6, Width, Color.Orange),
                new InitialCell(0, 5, 6, Width, Color.Blue),
                new InitialCell(1, 5, 6, Width, Color.Red),
                new InitialCell(2, 2, 6, Width, Color.Blue),
                new InitialCell(2, 3, 6, Width, Color.Red),
                new InitialCell(2, 4, 6, Width, Color.Green),
                new InitialCell(3, 4, 6, Width, Color.Orange),
                new InitialCell(4, 1, 6, Width, Color.Yellow),
                new InitialCell(4, 4, 6, Width, Color.Yellow)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 6, Width, Color.Blue),
                new InitialCell(2, 4, 6, Width, Color.Yellow),
                new InitialCell(3, 2, 6, Width, Color.Yellow),
                new InitialCell(3, 3, 6, Width, Color.Green),
                new InitialCell(3, 4, 6, Width, Color.Red),
                new InitialCell(4, 1, 6, Width, Color.Green),
                new InitialCell(4, 3, 6, Width, Color.Red),
                new InitialCell(5, 3, 6, Width, Color.Blue)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 6, Width, Color.Blue),
                new InitialCell(0, 1, 6, Width, Color.Red),
                new InitialCell(0, 3, 6, Width, Color.Orange),
                new InitialCell(0, 4, 6, Width, Color.Cyan),
                new InitialCell(0, 5, 6, Width, Color.Green),
                new InitialCell(1, 1, 6, Width, Color.Blue),
                new InitialCell(2, 0, 6, Width, Color.Yellow),
                new InitialCell(2, 1, 6, Width, Color.Red),
                new InitialCell(2, 3, 6, Width, Color.Orange),
                new InitialCell(3, 3, 6, Width, Color.Yellow),
                new InitialCell(5, 0, 6, Width, Color.Cyan),
                new InitialCell(5, 1, 6, Width, Color.Green)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 6, Width, Color.Blue),
                new InitialCell(0, 5, 6, Width, Color.Red),
                new InitialCell(1, 0, 6, Width, Color.Yellow),
                new InitialCell(2, 0, 6, Width, Color.Orange),
                new InitialCell(2, 1, 6, Width, Color.Green),
                new InitialCell(3, 2, 6, Width, Color.Green),
                new InitialCell(3, 3, 6, Width, Color.Yellow),
                new InitialCell(4, 0, 6, Width, Color.Red),
                new InitialCell(4, 2, 6, Width, Color.Orange),
                new InitialCell(4, 3, 6, Width, Color.Blue)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 5, 6, Width, Color.Green),
                new InitialCell(1, 5, 6, Width, Color.Blue),
                new InitialCell(2, 2, 6, Width, Color.Yellow),
                new InitialCell(2, 4, 6, Width, Color.Yellow),
                new InitialCell(2, 5, 6, Width, Color.Red),
                new InitialCell(3, 2, 6, Width, Color.Red),
                new InitialCell(4, 5, 6, Width, Color.Blue),
                new InitialCell(5, 5, 6, Width, Color.Green)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 6, Width, Color.Green),
                new InitialCell(0, 2, 6, Width, Color.Red),
                new InitialCell(0, 5, 6, Width, Color.Cyan),
                new InitialCell(1, 0, 6, Width, Color.Orange),
                new InitialCell(1, 2, 6, Width, Color.Green),
                new InitialCell(1, 3, 6, Width, Color.Orange),
                new InitialCell(3, 1, 6, Width, Color.Yellow),
                new InitialCell(3, 2, 6, Width, Color.Blue),
                new InitialCell(4, 1, 6, Width, Color.Blue),
                new InitialCell(4, 3, 6, Width, Color.Red),
                new InitialCell(4, 4, 6, Width, Color.Yellow),
                new InitialCell(5, 5, 6, Width, Color.Cyan)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 6, Width, Color.Green),
                new InitialCell(0, 2, 6, Width, Color.Orange),
                new InitialCell(0, 5, 6, Width, Color.Orange),
                new InitialCell(1, 5, 6, Width, Color.Red),
                new InitialCell(2, 2, 6, Width, Color.Cyan),
                new InitialCell(2, 3, 6, Width, Color.Blue),
                new InitialCell(2, 5, 6, Width, Color.Blue),
                new InitialCell(3, 3, 6, Width, Color.Yellow),
                new InitialCell(3, 4, 6, Width, Color.Cyan),
                new InitialCell(4, 4, 6, Width, Color.Yellow),
                new InitialCell(5, 0, 6, Width, Color.Green),
                new InitialCell(5, 1, 6, Width, Color.Red)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 6, Width, Color.Red),
                new InitialCell(1, 0, 6, Width, Color.Green),
                new InitialCell(2, 3, 6, Width, Color.Orange),
                new InitialCell(3, 0, 6, Width, Color.Orange),
                new InitialCell(3, 3, 6, Width, Color.Blue),
                new InitialCell(4, 2, 6, Width, Color.Yellow),
                new InitialCell(4, 3, 6, Width, Color.Green),
                new InitialCell(5, 0, 6, Width, Color.Blue),
                new InitialCell(5, 1, 6, Width, Color.Yellow),
                new InitialCell(5, 3, 6, Width, Color.Red)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 6, Width, Color.Orange),
                new InitialCell(1, 0, 6, Width, Color.Yellow),
                new InitialCell(1, 4, 6, Width, Color.Red),
                new InitialCell(1, 5, 6, Width, Color.Green),
                new InitialCell(2, 4, 6, Width, Color.Blue),
                new InitialCell(4, 1, 6, Width, Color.Orange),
                new InitialCell(4, 4, 6, Width, Color.Red),
                new InitialCell(5, 2, 6, Width, Color.Yellow),
                new InitialCell(5, 3, 6, Width, Color.Green),
                new InitialCell(5, 4, 6, Width, Color.Blue)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 6, Width, Color.Yellow),
                new InitialCell(0, 1, 6, Width, Color.Red),
                new InitialCell(1, 1, 6, Width, Color.Blue),
                new InitialCell(2, 3, 6, Width, Color.Yellow),
                new InitialCell(4, 1, 6, Width, Color.Green),
                new InitialCell(4, 4, 6, Width, Color.Green),
                new InitialCell(5, 0, 6, Width, Color.Blue),
                new InitialCell(5, 1, 6, Width, Color.Red)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(1, 0, 6, Width, Color.Blue),
                new InitialCell(1, 1, 6, Width, Color.Red),
                new InitialCell(1, 2, 6, Width, Color.Yellow),
                new InitialCell(1, 3, 6, Width, Color.Orange),
                new InitialCell(2, 0, 6, Width, Color.Red),
                new InitialCell(2, 3, 6, Width, Color.Green),
                new InitialCell(3, 0, 6, Width, Color.Green),
                new InitialCell(3, 5, 6, Width, Color.Blue),
                new InitialCell(4, 1, 6, Width, Color.Yellow),
                new InitialCell(4, 4, 6, Width, Color.Orange),
                new InitialCell(4, 5, 6, Width, Color.Cyan),
                new InitialCell(5, 3, 6, Width, Color.Cyan)
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(1, 0, 6, Width, Color.Red),
                new InitialCell(1, 1, 6, Width, Color.Blue),
                new InitialCell(1, 3, 6, Width, Color.Green),
                new InitialCell(2, 1, 6, Width, Color.Yellow),
                new InitialCell(3, 1, 6, Width, Color.Orange),
                new InitialCell(3, 5, 6, Width, Color.Red),
                new InitialCell(4, 1, 6, Width, Color.Yellow),
                new InitialCell(4, 4, 6, Width, Color.Green),
                new InitialCell(4, 5, 6, Width, Color.Blue),
                new InitialCell(5, 0, 6, Width, Color.Orange)
            })
        };

        public static List<Grid> Levels7 = new List<Grid>
        {
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 6, 7, Width, Color.Blue),
                new InitialCell(1, 5, 7, Width, Color.Orange),
                new InitialCell(1, 6, 7, Width, Color.Red),
                new InitialCell(2, 1, 7, Width, Color.Orange),
                new InitialCell(3, 3, 7, Width, Color.Green),
                new InitialCell(3, 4, 7, Width, Color.Cyan),
                new InitialCell(4, 2, 7, Width, Color.Green),
                new InitialCell(4, 4, 7, Width, Color.Yellow),
                new InitialCell(5, 4, 7, Width, Color.Red),
                new InitialCell(5, 5, 7, Width, Color.Yellow),
                new InitialCell(6, 5, 7, Width, Color.Blue),
                new InitialCell(6, 6, 7, Width, Color.Cyan)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 7, Width, Color.Magenta),
                new InitialCell(0, 2, 7, Width, Color.Red),
                new InitialCell(1, 2, 7, Width, Color.Orange),
                new InitialCell(1, 3, 7, Width, Color.Blue),
                new InitialCell(1, 5, 7, Width, Color.Blue),
                new InitialCell(2, 2, 7, Width, Color.Green),
                new InitialCell(3, 2, 7, Width, Color.Cyan),
                new InitialCell(3, 3, 7, Width, Color.Yellow),
                new InitialCell(3, 5, 7, Width, Color.Green),
                new InitialCell(4, 4, 7, Width, Color.Yellow),
                new InitialCell(4, 5, 7, Width, Color.Cyan),
                new InitialCell(5, 2, 7, Width, Color.Orange),
                new InitialCell(6, 2, 7, Width, Color.Magenta),
                new InitialCell(6, 3, 7, Width, Color.Red)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 7, Width, Color.Cyan),
                new InitialCell(1, 0, 7, Width, Color.Yellow),
                new InitialCell(1, 6, 7, Width, Color.Cyan),
                new InitialCell(2, 0, 7, Width, Color.Magenta),
                new InitialCell(2, 2, 7, Width, Color.Magenta),
                new InitialCell(2, 3, 7, Width, Color.Orange),
                new InitialCell(2, 4, 7, Width, Color.Green),
                new InitialCell(2, 6, 7, Width, Color.Yellow),
                new InitialCell(3, 0, 7, Width, Color.Brown),
                new InitialCell(3, 2, 7, Width, Color.Red),
                new InitialCell(3, 6, 7, Width, Color.Green),
                new InitialCell(4, 0, 7, Width, Color.Blue),
                new InitialCell(4, 5, 7, Width, Color.Orange),
                new InitialCell(4, 6, 7, Width, Color.Red),
                new InitialCell(5, 1, 7, Width, Color.Brown),
                new InitialCell(6, 6, 7, Width, Color.Blue)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(1, 0, 7, Width, Color.Green),
                new InitialCell(2, 2, 7, Width, Color.Yellow),
                new InitialCell(3, 4, 7, Width, Color.Yellow),
                new InitialCell(4, 2, 7, Width, Color.Orange),
                new InitialCell(4, 4, 7, Width, Color.Blue),
                new InitialCell(5, 0, 7, Width, Color.Red),
                new InitialCell(5, 1, 7, Width, Color.Blue),
                new InitialCell(5, 4, 7, Width, Color.Orange),
                new InitialCell(5, 5, 7, Width, Color.Red),
                new InitialCell(6, 0, 7, Width, Color.Green)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 7, Width, Color.Cyan),
                new InitialCell(0, 1, 7, Width, Color.Blue),
                new InitialCell(0, 2, 7, Width, Color.Yellow),
                new InitialCell(1, 5, 7, Width, Color.Green),
                new InitialCell(2, 1, 7, Width, Color.Red),
                new InitialCell(2, 3, 7, Width, Color.Yellow),
                new InitialCell(3, 1, 7, Width, Color.Orange),
                new InitialCell(3, 4, 7, Width, Color.Blue),
                new InitialCell(4, 2, 7, Width, Color.Red),
                new InitialCell(4, 4, 7, Width, Color.Green),
                new InitialCell(6, 1, 7, Width, Color.Cyan),
                new InitialCell(6, 6, 7, Width, Color.Orange)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(1, 0, 7, Width, Color.Cyan),
                new InitialCell(1, 1, 7, Width, Color.Red),
                new InitialCell(1, 3, 7, Width, Color.Red),
                new InitialCell(1, 5, 7, Width, Color.Green),
                new InitialCell(2, 2, 7, Width, Color.Magenta),
                new InitialCell(2, 3, 7, Width, Color.Cyan),
                new InitialCell(2, 4, 7, Width, Color.Green),
                new InitialCell(3, 2, 7, Width, Color.Yellow),
                new InitialCell(3, 6, 7, Width, Color.Blue),
                new InitialCell(4, 2, 7, Width, Color.Orange),
                new InitialCell(5, 4, 7, Width, Color.Yellow),
                new InitialCell(5, 6, 7, Width, Color.Blue),
                new InitialCell(6, 4, 7, Width, Color.Magenta),
                new InitialCell(6, 6, 7, Width, Color.Orange)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(1, 0, 7, Width, Color.Green),
                new InitialCell(1, 1, 7, Width, Color.Red),
                new InitialCell(1, 5, 7, Width, Color.Red),
                new InitialCell(2, 0, 7, Width, Color.Orange),
                new InitialCell(2, 1, 7, Width, Color.Green),
                new InitialCell(3, 1, 7, Width, Color.Blue),
                new InitialCell(3, 3, 7, Width, Color.Blue),
                new InitialCell(4, 1, 7, Width, Color.Yellow),
                new InitialCell(4, 2, 7, Width, Color.Orange),
                new InitialCell(4, 5, 7, Width, Color.Yellow)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 4, 7, Width, Color.Green),
                new InitialCell(0, 6, 7, Width, Color.Cyan),
                new InitialCell(1, 1, 7, Width, Color.Cyan),
                new InitialCell(1, 6, 7, Width, Color.Orange),
                new InitialCell(3, 2, 7, Width, Color.Yellow),
                new InitialCell(3, 3, 7, Width, Color.Red),
                new InitialCell(3, 6, 7, Width, Color.Red),
                new InitialCell(4, 3, 7, Width, Color.Blue),
                new InitialCell(4, 6, 7, Width, Color.Blue),
                new InitialCell(5, 1, 7, Width, Color.Orange),
                new InitialCell(5, 2, 7, Width, Color.Yellow),
                new InitialCell(5, 3, 7, Width, Color.Magenta),
                new InitialCell(6, 5, 7, Width, Color.Green),
                new InitialCell(6, 6, 7, Width, Color.Magenta)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 5, 7, Width, Color.Orange),
                new InitialCell(0, 6, 7, Width, Color.Red),
                new InitialCell(1, 0, 7, Width, Color.Orange),
                new InitialCell(1, 1, 7, Width, Color.Cyan),
                new InitialCell(1, 2, 7, Width, Color.Green),
                new InitialCell(2, 4, 7, Width, Color.Blue),
                new InitialCell(2, 6, 7, Width, Color.Blue),
                new InitialCell(3, 1, 7, Width, Color.Yellow),
                new InitialCell(3, 6, 7, Width, Color.Red),
                new InitialCell(4, 5, 7, Width, Color.Green),
                new InitialCell(4, 6, 7, Width, Color.Cyan),
                new InitialCell(5, 5, 7, Width, Color.Yellow)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 7, Width, Color.Cyan),
                new InitialCell(1, 1, 7, Width, Color.Orange),
                new InitialCell(2, 4, 7, Width, Color.Blue),
                new InitialCell(3, 3, 7, Width, Color.Red),
                new InitialCell(4, 3, 7, Width, Color.Yellow),
                new InitialCell(5, 2, 7, Width, Color.Green),
                new InitialCell(5, 5, 7, Width, Color.Red),
                new InitialCell(6, 0, 7, Width, Color.Cyan),
                new InitialCell(6, 2, 7, Width, Color.Orange),
                new InitialCell(6, 3, 7, Width, Color.Yellow),
                new InitialCell(6, 4, 7, Width, Color.Blue),
                new InitialCell(6, 5, 7, Width, Color.Green)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(1, 0, 7, Width, Color.Blue),
                new InitialCell(1, 1, 7, Width, Color.Magenta),
                new InitialCell(1, 2, 7, Width, Color.Cyan),
                new InitialCell(1, 5, 7, Width, Color.Red),
                new InitialCell(2, 3, 7, Width, Color.Blue),
                new InitialCell(3, 1, 7, Width, Color.Orange),
                new InitialCell(3, 3, 7, Width, Color.Cyan),
                new InitialCell(3, 4, 7, Width, Color.Yellow),
                new InitialCell(4, 0, 7, Width, Color.Magenta),
                new InitialCell(5, 0, 7, Width, Color.Yellow),
                new InitialCell(5, 1, 7, Width, Color.Green),
                new InitialCell(5, 3, 7, Width, Color.Green),
                new InitialCell(5, 4, 7, Width, Color.Orange),
                new InitialCell(5, 5, 7, Width, Color.Red)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(1, 5, 7, Width, Color.Red),
                new InitialCell(2, 0, 7, Width, Color.Green),
                new InitialCell(2, 1, 7, Width, Color.Red),
                new InitialCell(2, 2, 7, Width, Color.Orange),
                new InitialCell(2, 3, 7, Width, Color.Green),
                new InitialCell(3, 0, 7, Width, Color.Cyan),
                new InitialCell(3, 1, 7, Width, Color.Magenta),
                new InitialCell(3, 6, 7, Width, Color.Yellow),
                new InitialCell(4, 3, 7, Width, Color.Yellow),
                new InitialCell(5, 5, 7, Width, Color.Blue),
                new InitialCell(6, 0, 7, Width, Color.Cyan),
                new InitialCell(6, 1, 7, Width, Color.Magenta),
                new InitialCell(6, 2, 7, Width, Color.Blue),
                new InitialCell(6, 6, 7, Width, Color.Orange)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 5, 7, Width, Color.Yellow),
                new InitialCell(0, 6, 7, Width, Color.Orange),
                new InitialCell(1, 1, 7, Width, Color.Red),
                new InitialCell(1, 2, 7, Width, Color.Blue),
                new InitialCell(1, 4, 7, Width, Color.Blue),
                new InitialCell(1, 5, 7, Width, Color.Red),
                new InitialCell(2, 4, 7, Width, Color.Cyan),
                new InitialCell(3, 3, 7, Width, Color.Cyan),
                new InitialCell(3, 6, 7, Width, Color.Orange),
                new InitialCell(4, 0, 7, Width, Color.Green),
                new InitialCell(4, 6, 7, Width, Color.Yellow),
                new InitialCell(5, 6, 7, Width, Color.Green)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(1, 1, 7, Width, Color.Orange),
                new InitialCell(1, 2, 7, Width, Color.Brown),
                new InitialCell(1, 3, 7, Width, Color.Red),
                new InitialCell(1, 4, 7, Width, Color.Cyan),
                new InitialCell(1, 5, 7, Width, Color.Magenta),
                new InitialCell(2, 2, 7, Width, Color.Green),
                new InitialCell(2, 6, 7, Width, Color.Red),
                new InitialCell(3, 1, 7, Width, Color.Orange),
                new InitialCell(3, 2, 7, Width, Color.Blue),
                new InitialCell(4, 1, 7, Width, Color.Blue),
                new InitialCell(4, 3, 7, Width, Color.Green),
                new InitialCell(4, 5, 7, Width, Color.Yellow),
                new InitialCell(5, 1, 7, Width, Color.Brown),
                new InitialCell(6, 0, 7, Width, Color.Cyan),
                new InitialCell(6, 3, 7, Width, Color.Yellow),
                new InitialCell(6, 6, 7, Width, Color.Magenta)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 7, Width, Color.Red),
                new InitialCell(0, 5, 7, Width, Color.Yellow),
                new InitialCell(0, 6, 7, Width, Color.Green),
                new InitialCell(1, 0, 7, Width, Color.Yellow),
                new InitialCell(2, 1, 7, Width, Color.Blue),
                new InitialCell(2, 2, 7, Width, Color.Orange),
                new InitialCell(3, 4, 7, Width, Color.Red),
                new InitialCell(4, 0, 7, Width, Color.Green),
                new InitialCell(4, 2, 7, Width, Color.Orange),
                new InitialCell(4, 4, 7, Width, Color.Blue)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(1, 0, 7, Width, Color.Blue),
                new InitialCell(1, 1, 7, Width, Color.Green),
                new InitialCell(2, 0, 7, Width, Color.Yellow),
                new InitialCell(2, 4, 7, Width, Color.Yellow),
                new InitialCell(3, 6, 7, Width, Color.Blue),
                new InitialCell(4, 1, 7, Width, Color.Red),
                new InitialCell(5, 3, 7, Width, Color.Green),
                new InitialCell(5, 5, 7, Width, Color.Orange),
                new InitialCell(6, 0, 7, Width, Color.Orange),
                new InitialCell(6, 5, 7, Width, Color.Red)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 6, 7, Width, Color.Red),
                new InitialCell(1, 1, 7, Width, Color.Magenta),
                new InitialCell(2, 1, 7, Width, Color.Blue),
                new InitialCell(2, 4, 7, Width, Color.Magenta),
                new InitialCell(3, 1, 7, Width, Color.Orange),
                new InitialCell(3, 2, 7, Width, Color.Yellow),
                new InitialCell(3, 4, 7, Width, Color.Blue),
                new InitialCell(3, 5, 7, Width, Color.Orange),
                new InitialCell(4, 1, 7, Width, Color.Cyan),
                new InitialCell(4, 5, 7, Width, Color.Red),
                new InitialCell(5, 1, 7, Width, Color.Green),
                new InitialCell(5, 5, 7, Width, Color.Yellow),
                new InitialCell(5, 6, 7, Width, Color.Green),
                new InitialCell(6, 2, 7, Width, Color.Cyan)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(1, 1, 7, Width, Color.Green),
                new InitialCell(1, 5, 7, Width, Color.Yellow),
                new InitialCell(2, 2, 7, Width, Color.Yellow),
                new InitialCell(2, 5, 7, Width, Color.Blue),
                new InitialCell(2, 6, 7, Width, Color.Red),
                new InitialCell(3, 6, 7, Width, Color.Magenta),
                new InitialCell(4, 5, 7, Width, Color.Orange),
                new InitialCell(4, 6, 7, Width, Color.Cyan),
                new InitialCell(5, 0, 7, Width, Color.Magenta),
                new InitialCell(5, 1, 7, Width, Color.Red),
                new InitialCell(5, 2, 7, Width, Color.Green),
                new InitialCell(5, 3, 7, Width, Color.Blue),
                new InitialCell(6, 5, 7, Width, Color.Orange),
                new InitialCell(6, 6, 7, Width, Color.Cyan)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 3, 7, Width, Color.Yellow),
                new InitialCell(1, 5, 7, Width, Color.Cyan),
                new InitialCell(3, 5, 7, Width, Color.Green),
                new InitialCell(3, 6, 7, Width, Color.Red),
                new InitialCell(4, 3, 7, Width, Color.Green),
                new InitialCell(4, 5, 7, Width, Color.Cyan),
                new InitialCell(4, 6, 7, Width, Color.Blue),
                new InitialCell(5, 5, 7, Width, Color.Orange),
                new InitialCell(6, 0, 7, Width, Color.Yellow),
                new InitialCell(6, 1, 7, Width, Color.Red),
                new InitialCell(6, 2, 7, Width, Color.Orange),
                new InitialCell(6, 6, 7, Width, Color.Blue)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 7, Width, Color.Green),
                new InitialCell(0, 2, 7, Width, Color.Green),
                new InitialCell(0, 3, 7, Width, Color.Red),
                new InitialCell(1, 2, 7, Width, Color.Red),
                new InitialCell(1, 3, 7, Width, Color.Orange),
                new InitialCell(2, 1, 7, Width, Color.Blue),
                new InitialCell(2, 4, 7, Width, Color.Yellow),
                new InitialCell(3, 1, 7, Width, Color.Yellow),
                new InitialCell(3, 3, 7, Width, Color.Blue),
                new InitialCell(4, 1, 7, Width, Color.Orange)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 7, Width, Color.Blue),
                new InitialCell(0, 4, 7, Width, Color.Orange),
                new InitialCell(1, 0, 7, Width, Color.Green),
                new InitialCell(1, 4, 7, Width, Color.Blue),
                new InitialCell(1, 5, 7, Width, Color.Red),
                new InitialCell(2, 0, 7, Width, Color.Yellow),
                new InitialCell(2, 3, 7, Width, Color.Orange),
                new InitialCell(3, 0, 7, Width, Color.Cyan),
                new InitialCell(3, 1, 7, Width, Color.Yellow),
                new InitialCell(3, 3, 7, Width, Color.Green),
                new InitialCell(5, 2, 7, Width, Color.Red),
                new InitialCell(6, 0, 7, Width, Color.Cyan)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 7, Width, Color.Red),
                new InitialCell(1, 2, 7, Width, Color.Green),
                new InitialCell(1, 3, 7, Width, Color.Red),
                new InitialCell(1, 4, 7, Width, Color.Blue),
                new InitialCell(1, 5, 7, Width, Color.Magenta),
                new InitialCell(2, 0, 7, Width, Color.Green),
                new InitialCell(3, 2, 7, Width, Color.Blue),
                new InitialCell(4, 5, 7, Width, Color.Cyan),
                new InitialCell(4, 6, 7, Width, Color.Orange),
                new InitialCell(5, 0, 7, Width, Color.Magenta),
                new InitialCell(5, 1, 7, Width, Color.Cyan),
                new InitialCell(5, 2, 7, Width, Color.Yellow),
                new InitialCell(5, 5, 7, Width, Color.Yellow),
                new InitialCell(6, 0, 7, Width, Color.Orange)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 7, Width, Color.Green),
                new InitialCell(0, 4, 7, Width, Color.Red),
                new InitialCell(0, 6, 7, Width, Color.Cyan),
                new InitialCell(1, 6, 7, Width, Color.Orange),
                new InitialCell(3, 3, 7, Width, Color.Orange),
                new InitialCell(3, 4, 7, Width, Color.Yellow),
                new InitialCell(4, 3, 7, Width, Color.Cyan),
                new InitialCell(4, 4, 7, Width, Color.Green),
                new InitialCell(4, 5, 7, Width, Color.Blue),
                new InitialCell(5, 3, 7, Width, Color.Red),
                new InitialCell(6, 5, 7, Width, Color.Blue),
                new InitialCell(6, 6, 7, Width, Color.Yellow)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 6, 7, Width, Color.Orange),
                new InitialCell(1, 5, 7, Width, Color.Cyan),
                new InitialCell(1, 6, 7, Width, Color.Green),
                new InitialCell(2, 0, 7, Width, Color.Orange),
                new InitialCell(3, 3, 7, Width, Color.Yellow),
                new InitialCell(4, 1, 7, Width, Color.Green),
                new InitialCell(4, 6, 7, Width, Color.Yellow),
                new InitialCell(5, 4, 7, Width, Color.Blue),
                new InitialCell(5, 6, 7, Width, Color.Cyan),
                new InitialCell(6, 0, 7, Width, Color.Red),
                new InitialCell(6, 3, 7, Width, Color.Red),
                new InitialCell(6, 6, 7, Width, Color.Blue)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 7, Width, Color.Green),
                new InitialCell(0, 1, 7, Width, Color.Red),
                new InitialCell(0, 6, 7, Width, Color.Yellow),
                new InitialCell(1, 1, 7, Width, Color.Yellow),
                new InitialCell(1, 5, 7, Width, Color.Red),
                new InitialCell(2, 1, 7, Width, Color.Blue),
                new InitialCell(3, 1, 7, Width, Color.Orange),
                new InitialCell(4, 1, 7, Width, Color.Cyan),
                new InitialCell(5, 5, 7, Width, Color.Orange),
                new InitialCell(6, 3, 7, Width, Color.Green),
                new InitialCell(6, 4, 7, Width, Color.Cyan),
                new InitialCell(6, 5, 7, Width, Color.Blue)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 7, Width, Color.Green),
                new InitialCell(0, 2, 7, Width, Color.Blue),
                new InitialCell(1, 5, 7, Width, Color.Orange),
                new InitialCell(2, 2, 7, Width, Color.Red),
                new InitialCell(4, 1, 7, Width, Color.Green),
                new InitialCell(4, 5, 7, Width, Color.Orange),
                new InitialCell(5, 0, 7, Width, Color.Yellow),
                new InitialCell(5, 3, 7, Width, Color.Red),
                new InitialCell(5, 5, 7, Width, Color.Yellow),
                new InitialCell(6, 0, 7, Width, Color.Blue)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 3, 7, Width, Color.Blue),
                new InitialCell(0, 4, 7, Width, Color.Red),
                new InitialCell(1, 4, 7, Width, Color.Yellow),
                new InitialCell(1, 5, 7, Width, Color.Green),
                new InitialCell(2, 1, 7, Width, Color.Orange),
                new InitialCell(2, 2, 7, Width, Color.Yellow),
                new InitialCell(3, 1, 7, Width, Color.Red),
                new InitialCell(3, 3, 7, Width, Color.Orange),
                new InitialCell(4, 5, 7, Width, Color.Green),
                new InitialCell(6, 6, 7, Width, Color.Blue)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 7, Width, Color.Magenta),
                new InitialCell(0, 2, 7, Width, Color.Green),
                new InitialCell(0, 5, 7, Width, Color.Blue),
                new InitialCell(1, 0, 7, Width, Color.Yellow),
                new InitialCell(1, 3, 7, Width, Color.Magenta),
                new InitialCell(1, 5, 7, Width, Color.Red),
                new InitialCell(2, 3, 7, Width, Color.Yellow),
                new InitialCell(3, 3, 7, Width, Color.Red),
                new InitialCell(3, 4, 7, Width, Color.Green),
                new InitialCell(4, 0, 7, Width, Color.Cyan),
                new InitialCell(4, 1, 7, Width, Color.Orange),
                new InitialCell(5, 5, 7, Width, Color.Cyan),
                new InitialCell(6, 0, 7, Width, Color.Orange),
                new InitialCell(6, 1, 7, Width, Color.Blue)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(2, 1, 7, Width, Color.Red),
                new InitialCell(2, 2, 7, Width, Color.Blue),
                new InitialCell(2, 4, 7, Width, Color.Blue),
                new InitialCell(3, 1, 7, Width, Color.Cyan),
                new InitialCell(4, 3, 7, Width, Color.Green),
                new InitialCell(4, 4, 7, Width, Color.Cyan),
                new InitialCell(4, 5, 7, Width, Color.Red),
                new InitialCell(5, 0, 7, Width, Color.Green),
                new InitialCell(5, 1, 7, Width, Color.Yellow),
                new InitialCell(5, 3, 7, Width, Color.Orange),
                new InitialCell(5, 4, 7, Width, Color.Yellow),
                new InitialCell(6, 6, 7, Width, Color.Orange)
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 7, Width, Color.Orange),
                new InitialCell(0, 2, 7, Width, Color.Green),
                new InitialCell(0, 4, 7, Width, Color.Green),
                new InitialCell(0, 5, 7, Width, Color.Blue),
                new InitialCell(1, 0, 7, Width, Color.Yellow),
                new InitialCell(1, 2, 7, Width, Color.Magenta),
                new InitialCell(1, 5, 7, Width, Color.Cyan),
                new InitialCell(2, 4, 7, Width, Color.Magenta),
                new InitialCell(3, 4, 7, Width, Color.Cyan),
                new InitialCell(3, 6, 7, Width, Color.Blue),
                new InitialCell(4, 0, 7, Width, Color.Orange),
                new InitialCell(4, 1, 7, Width, Color.Red),
                new InitialCell(4, 2, 7, Width, Color.Yellow),
                new InitialCell(5, 5, 7, Width, Color.Red)
            })
        };

        public static List<Grid> Levels8 = new List<Grid>
        {
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 4, 8, Width, Color.Red),
                new InitialCell(1, 4, 8, Width, Color.Cyan),
                new InitialCell(1, 6, 8, Width, Color.Green),
                new InitialCell(1, 7, 8, Width, Color.Yellow),
                new InitialCell(2, 4, 8, Width, Color.Green),
                new InitialCell(2, 5, 8, Width, Color.Yellow),
                new InitialCell(2, 7, 8, Width, Color.Cyan),
                new InitialCell(3, 3, 8, Width, Color.Orange),
                new InitialCell(3, 4, 8, Width, Color.Blue),
                new InitialCell(4, 4, 8, Width, Color.Orange),
                new InitialCell(5, 4, 8, Width, Color.Blue),
                new InitialCell(7, 1, 8, Width, Color.Red)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 8, Width, Color.Red),
                new InitialCell(0, 1, 8, Width, Color.Blue),
                new InitialCell(0, 2, 8, Width, Color.Cyan),
                new InitialCell(1, 6, 8, Width, Color.Orange),
                new InitialCell(3, 0, 8, Width, Color.Yellow),
                new InitialCell(3, 2, 8, Width, Color.Yellow),
                new InitialCell(3, 3, 8, Width, Color.Green),
                new InitialCell(5, 0, 8, Width, Color.Green),
                new InitialCell(5, 5, 8, Width, Color.Blue),
                new InitialCell(7, 0, 8, Width, Color.Red),
                new InitialCell(7, 1, 8, Width, Color.Orange),
                new InitialCell(7, 3, 8, Width, Color.Cyan)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 8, Width, Color.Red),
                new InitialCell(1, 3, 8, Width, Color.Yellow),
                new InitialCell(1, 6, 8, Width, Color.Yellow),
                new InitialCell(2, 2, 8, Width, Color.Blue),
                new InitialCell(4, 3, 8, Width, Color.Red),
                new InitialCell(4, 4, 8, Width, Color.Cyan),
                new InitialCell(4, 7, 8, Width, Color.Green),
                new InitialCell(5, 3, 8, Width, Color.Orange),
                new InitialCell(5, 7, 8, Width, Color.Blue),
                new InitialCell(6, 1, 8, Width, Color.Cyan),
                new InitialCell(7, 6, 8, Width, Color.Orange),
                new InitialCell(7, 7, 8, Width, Color.Green)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 8, Width, Color.Yellow),
                new InitialCell(1, 6, 8, Width, Color.Cyan),
                new InitialCell(1, 7, 8, Width, Color.Green),
                new InitialCell(2, 3, 8, Width, Color.Magenta),
                new InitialCell(3, 1, 8, Width, Color.Green),
                new InitialCell(3, 6, 8, Width, Color.Cyan),
                new InitialCell(3, 7, 8, Width, Color.Magenta),
                new InitialCell(4, 4, 8, Width, Color.Red),
                new InitialCell(4, 7, 8, Width, Color.Orange),
                new InitialCell(5, 2, 8, Width, Color.Orange),
                new InitialCell(5, 7, 8, Width, Color.Blue),
                new InitialCell(6, 2, 8, Width, Color.Red),
                new InitialCell(6, 3, 8, Width, Color.Blue),
                new InitialCell(6, 7, 8, Width, Color.Yellow)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 7, 8, Width, Color.Cyan),
                new InitialCell(1, 1, 8, Width, Color.Blue),
                new InitialCell(1, 2, 8, Width, Color.Orange),
                new InitialCell(2, 7, 8, Width, Color.Orange),
                new InitialCell(3, 3, 8, Width, Color.Cyan),
                new InitialCell(3, 5, 8, Width, Color.Green),
                new InitialCell(4, 5, 8, Width, Color.Yellow),
                new InitialCell(4, 6, 8, Width, Color.Red),
                new InitialCell(4, 7, 8, Width, Color.Blue),
                new InitialCell(5, 7, 8, Width, Color.Yellow),
                new InitialCell(6, 2, 8, Width, Color.Red),
                new InitialCell(7, 0, 8, Width, Color.Green)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 8, Width, Color.Red),
                new InitialCell(0, 7, 8, Width, Color.Blue),
                new InitialCell(1, 0, 8, Width, Color.Magenta),
                new InitialCell(1, 4, 8, Width, Color.Orange),
                new InitialCell(2, 0, 8, Width, Color.Yellow),
                new InitialCell(4, 6, 8, Width, Color.Blue),
                new InitialCell(4, 7, 8, Width, Color.Orange),
                new InitialCell(5, 4, 8, Width, Color.Magenta),
                new InitialCell(5, 7, 8, Width, Color.Red),
                new InitialCell(6, 1, 8, Width, Color.Green),
                new InitialCell(6, 2, 8, Width, Color.Cyan),
                new InitialCell(7, 1, 8, Width, Color.Yellow),
                new InitialCell(7, 6, 8, Width, Color.Cyan),
                new InitialCell(7, 7, 8, Width, Color.Green)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(1, 4, 8, Width, Color.Red),
                new InitialCell(1, 5, 8, Width, Color.Blue),
                new InitialCell(1, 6, 8, Width, Color.Yellow),
                new InitialCell(2, 2, 8, Width, Color.Green),
                new InitialCell(4, 4, 8, Width, Color.Orange),
                new InitialCell(5, 2, 8, Width, Color.Green),
                new InitialCell(5, 4, 8, Width, Color.Blue),
                new InitialCell(5, 5, 8, Width, Color.Red),
                new InitialCell(6, 5, 8, Width, Color.Yellow),
                new InitialCell(7, 7, 8, Width, Color.Orange)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 5, 8, Width, Color.Cyan),
                new InitialCell(0, 6, 8, Width, Color.Orange),
                new InitialCell(0, 7, 8, Width, Color.Green),
                new InitialCell(2, 1, 8, Width, Color.Orange),
                new InitialCell(4, 4, 8, Width, Color.Yellow),
                new InitialCell(5, 1, 8, Width, Color.Green),
                new InitialCell(5, 2, 8, Width, Color.Blue),
                new InitialCell(5, 3, 8, Width, Color.Magenta),
                new InitialCell(5, 4, 8, Width, Color.Red),
                new InitialCell(5, 7, 8, Width, Color.Blue),
                new InitialCell(6, 1, 8, Width, Color.Magenta),
                new InitialCell(6, 4, 8, Width, Color.Cyan),
                new InitialCell(6, 7, 8, Width, Color.Yellow),
                new InitialCell(7, 7, 8, Width, Color.Red)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 8, Width, Color.Blue),
                new InitialCell(0, 7, 8, Width, Color.Cyan),
                new InitialCell(1, 7, 8, Width, Color.Red),
                new InitialCell(2, 7, 8, Width, Color.Green),
                new InitialCell(3, 3, 8, Width, Color.Orange),
                new InitialCell(3, 4, 8, Width, Color.Green),
                new InitialCell(3, 5, 8, Width, Color.Yellow),
                new InitialCell(3, 7, 8, Width, Color.Yellow),
                new InitialCell(4, 6, 8, Width, Color.Cyan),
                new InitialCell(6, 5, 8, Width, Color.Red),
                new InitialCell(6, 6, 8, Width, Color.Orange),
                new InitialCell(7, 2, 8, Width, Color.Blue)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(1, 6, 8, Width, Color.Yellow),
                new InitialCell(2, 2, 8, Width, Color.Blue),
                new InitialCell(3, 4, 8, Width, Color.Green),
                new InitialCell(3, 5, 8, Width, Color.Blue),
                new InitialCell(3, 6, 8, Width, Color.Red),
                new InitialCell(3, 7, 8, Width, Color.Orange),
                new InitialCell(4, 1, 8, Width, Color.Orange),
                new InitialCell(5, 3, 8, Width, Color.Red),
                new InitialCell(6, 2, 8, Width, Color.Yellow),
                new InitialCell(6, 3, 8, Width, Color.Cyan),
                new InitialCell(6, 6, 8, Width, Color.Cyan),
                new InitialCell(7, 0, 8, Width, Color.Green)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 8, Width, Color.Cyan),
                new InitialCell(0, 1, 8, Width, Color.Yellow),
                new InitialCell(0, 2, 8, Width, Color.Magenta),
                new InitialCell(1, 6, 8, Width, Color.Yellow),
                new InitialCell(2, 1, 8, Width, Color.Orange),
                new InitialCell(2, 4, 8, Width, Color.Orange),
                new InitialCell(2, 6, 8, Width, Color.Blue),
                new InitialCell(4, 2, 8, Width, Color.Red),
                new InitialCell(4, 3, 8, Width, Color.Green),
                new InitialCell(4, 7, 8, Width, Color.Blue),
                new InitialCell(5, 6, 8, Width, Color.Magenta),
                new InitialCell(6, 4, 8, Width, Color.Red),
                new InitialCell(6, 6, 8, Width, Color.Green),
                new InitialCell(7, 2, 8, Width, Color.Cyan)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 4, 8, Width, Color.Green),
                new InitialCell(0, 6, 8, Width, Color.Yellow),
                new InitialCell(1, 1, 8, Width, Color.Green),
                new InitialCell(1, 4, 8, Width, Color.Cyan),
                new InitialCell(2, 1, 8, Width, Color.Blue),
                new InitialCell(2, 4, 8, Width, Color.Red),
                new InitialCell(2, 5, 8, Width, Color.Orange),
                new InitialCell(4, 4, 8, Width, Color.Orange),
                new InitialCell(4, 5, 8, Width, Color.Red),
                new InitialCell(5, 0, 8, Width, Color.Cyan),
                new InitialCell(6, 0, 8, Width, Color.Yellow),
                new InitialCell(6, 1, 8, Width, Color.Blue)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 8, Width, Color.Green),
                new InitialCell(0, 1, 8, Width, Color.Red),
                new InitialCell(0, 3, 8, Width, Color.Cyan),
                new InitialCell(0, 6, 8, Width, Color.Red),
                new InitialCell(0, 7, 8, Width, Color.Blue),
                new InitialCell(1, 1, 8, Width, Color.Green),
                new InitialCell(1, 6, 8, Width, Color.Yellow),
                new InitialCell(2, 0, 8, Width, Color.Blue),
                new InitialCell(2, 1, 8, Width, Color.Orange),
                new InitialCell(2, 6, 8, Width, Color.Orange),
                new InitialCell(3, 3, 8, Width, Color.Cyan),
                new InitialCell(5, 2, 8, Width, Color.Yellow)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 7, 8, Width, Color.Yellow),
                new InitialCell(1, 6, 8, Width, Color.Green),
                new InitialCell(1, 7, 8, Width, Color.Cyan),
                new InitialCell(3, 4, 8, Width, Color.Orange),
                new InitialCell(3, 5, 8, Width, Color.Blue),
                new InitialCell(4, 4, 8, Width, Color.Blue),
                new InitialCell(5, 2, 8, Width, Color.Red),
                new InitialCell(5, 5, 8, Width, Color.Orange),
                new InitialCell(6, 6, 8, Width, Color.Red),
                new InitialCell(7, 4, 8, Width, Color.Yellow),
                new InitialCell(7, 6, 8, Width, Color.Green),
                new InitialCell(7, 7, 8, Width, Color.Cyan)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 8, Width, Color.Green),
                new InitialCell(2, 4, 8, Width, Color.Yellow),
                new InitialCell(2, 5, 8, Width, Color.Blue),
                new InitialCell(3, 6, 8, Width, Color.Red),
                new InitialCell(4, 3, 8, Width, Color.Yellow),
                new InitialCell(4, 4, 8, Width, Color.Orange),
                new InitialCell(5, 7, 8, Width, Color.Orange),
                new InitialCell(6, 2, 8, Width, Color.Blue),
                new InitialCell(6, 5, 8, Width, Color.Cyan),
                new InitialCell(6, 7, 8, Width, Color.Cyan),
                new InitialCell(7, 3, 8, Width, Color.Green),
                new InitialCell(7, 7, 8, Width, Color.Red)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 8, Width, Color.Green),
                new InitialCell(0, 6, 8, Width, Color.Magenta),
                new InitialCell(0, 7, 8, Width, Color.Green),
                new InitialCell(1, 4, 8, Width, Color.Orange),
                new InitialCell(2, 4, 8, Width, Color.Cyan),
                new InitialCell(3, 2, 8, Width, Color.Red),
                new InitialCell(3, 4, 8, Width, Color.Blue),
                new InitialCell(4, 0, 8, Width, Color.Orange),
                new InitialCell(4, 4, 8, Width, Color.Yellow),
                new InitialCell(5, 0, 8, Width, Color.Yellow),
                new InitialCell(5, 2, 8, Width, Color.Red),
                new InitialCell(6, 2, 8, Width, Color.Cyan),
                new InitialCell(6, 3, 8, Width, Color.Blue),
                new InitialCell(6, 6, 8, Width, Color.Magenta)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 8, Width, Color.Blue),
                new InitialCell(2, 1, 8, Width, Color.Magenta),
                new InitialCell(3, 0, 8, Width, Color.Orange),
                new InitialCell(3, 1, 8, Width, Color.Brown),
                new InitialCell(3, 4, 8, Width, Color.Brown),
                new InitialCell(4, 0, 8, Width, Color.Cyan),
                new InitialCell(4, 4, 8, Width, Color.Red),
                new InitialCell(4, 6, 8, Width, Color.Orange),
                new InitialCell(5, 3, 8, Width, Color.Yellow),
                new InitialCell(5, 4, 8, Width, Color.Cyan),
                new InitialCell(5, 5, 8, Width, Color.Magenta),
                new InitialCell(5, 6, 8, Width, Color.Green),
                new InitialCell(6, 1, 8, Width, Color.Red),
                new InitialCell(6, 2, 8, Width, Color.Yellow),
                new InitialCell(7, 4, 8, Width, Color.Green),
                new InitialCell(7, 6, 8, Width, Color.Blue)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 8, Width, Color.Cyan),
                new InitialCell(0, 4, 8, Width, Color.Orange),
                new InitialCell(1, 0, 8, Width, Color.Blue),
                new InitialCell(1, 5, 8, Width, Color.Red),
                new InitialCell(1, 6, 8, Width, Color.Yellow),
                new InitialCell(1, 7, 8, Width, Color.Red),
                new InitialCell(2, 0, 8, Width, Color.Cyan),
                new InitialCell(2, 2, 8, Width, Color.Blue),
                new InitialCell(2, 5, 8, Width, Color.Yellow),
                new InitialCell(2, 7, 8, Width, Color.Green),
                new InitialCell(3, 0, 8, Width, Color.Purple),
                new InitialCell(3, 5, 8, Width, Color.Brown),
                new InitialCell(3, 6, 8, Width, Color.Purple),
                new InitialCell(4, 2, 8, Width, Color.Brown),
                new InitialCell(4, 3, 8, Width, Color.Magenta),
                new InitialCell(5, 2, 8, Width, Color.Magenta),
                new InitialCell(5, 4, 8, Width, Color.Orange),
                new InitialCell(7, 7, 8, Width, Color.Green)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 8, Width, Color.Cyan),
                new InitialCell(0, 6, 8, Width, Color.Orange),
                new InitialCell(1, 1, 8, Width, Color.Brown),
                new InitialCell(1, 4, 8, Width, Color.Red),
                new InitialCell(2, 1, 8, Width, Color.Red),
                new InitialCell(2, 4, 8, Width, Color.Orange),
                new InitialCell(2, 6, 8, Width, Color.Brown),
                new InitialCell(3, 2, 8, Width, Color.Cyan),
                new InitialCell(3, 3, 8, Width, Color.Magenta),
                new InitialCell(3, 4, 8, Width, Color.Blue),
                new InitialCell(4, 0, 8, Width, Color.Magenta),
                new InitialCell(4, 5, 8, Width, Color.Yellow),
                new InitialCell(4, 6, 8, Width, Color.Blue),
                new InitialCell(5, 6, 8, Width, Color.Yellow),
                new InitialCell(6, 1, 8, Width, Color.Green),
                new InitialCell(6, 6, 8, Width, Color.Green)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 2, 8, Width, Color.Orange),
                new InitialCell(0, 4, 8, Width, Color.Red),
                new InitialCell(0, 5, 8, Width, Color.Purple),
                new InitialCell(1, 1, 8, Width, Color.Yellow),
                new InitialCell(1, 4, 8, Width, Color.Magenta),
                new InitialCell(1, 6, 8, Width, Color.Magenta),
                new InitialCell(2, 7, 8, Width, Color.Purple),
                new InitialCell(3, 0, 8, Width, Color.Green),
                new InitialCell(3, 5, 8, Width, Color.Yellow),
                new InitialCell(3, 7, 8, Width, Color.Red),
                new InitialCell(4, 7, 8, Width, Color.Cyan),
                new InitialCell(5, 5, 8, Width, Color.Blue),
                new InitialCell(6, 1, 8, Width, Color.Orange),
                new InitialCell(6, 2, 8, Width, Color.Brown),
                new InitialCell(6, 3, 8, Width, Color.Blue),
                new InitialCell(7, 3, 8, Width, Color.Green),
                new InitialCell(7, 4, 8, Width, Color.Brown),
                new InitialCell(7, 5, 8, Width, Color.Cyan)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 5, 8, Width, Color.Brown),
                new InitialCell(0, 6, 8, Width, Color.Orange),
                new InitialCell(0, 7, 8, Width, Color.Blue),
                new InitialCell(2, 1, 8, Width, Color.Green),
                new InitialCell(2, 6, 8, Width, Color.Orange),
                new InitialCell(3, 3, 8, Width, Color.Red),
                new InitialCell(4, 1, 8, Width, Color.Yellow),
                new InitialCell(4, 5, 8, Width, Color.Cyan),
                new InitialCell(4, 7, 8, Width, Color.Blue),
                new InitialCell(5, 3, 8, Width, Color.Magenta),
                new InitialCell(6, 1, 8, Width, Color.Red),
                new InitialCell(6, 6, 8, Width, Color.Cyan),
                new InitialCell(7, 1, 8, Width, Color.Brown),
                new InitialCell(7, 2, 8, Width, Color.Magenta),
                new InitialCell(7, 3, 8, Width, Color.Yellow),
                new InitialCell(7, 5, 8, Width, Color.Green)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 4, 8, Width, Color.Orange),
                new InitialCell(0, 6, 8, Width, Color.Blue),
                new InitialCell(1, 2, 8, Width, Color.Cyan),
                new InitialCell(1, 5, 8, Width, Color.Orange),
                new InitialCell(1, 6, 8, Width, Color.Red),
                new InitialCell(2, 2, 8, Width, Color.Blue),
                new InitialCell(2, 3, 8, Width, Color.Green),
                new InitialCell(3, 4, 8, Width, Color.Red),
                new InitialCell(4, 5, 8, Width, Color.Yellow),
                new InitialCell(6, 1, 8, Width, Color.Cyan),
                new InitialCell(6, 6, 8, Width, Color.Green),
                new InitialCell(7, 1, 8, Width, Color.Yellow)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 8, Width, Color.Green),
                new InitialCell(0, 7, 8, Width, Color.Cyan),
                new InitialCell(1, 2, 8, Width, Color.Blue),
                new InitialCell(1, 3, 8, Width, Color.Orange),
                new InitialCell(1, 4, 8, Width, Color.Cyan),
                new InitialCell(1, 5, 8, Width, Color.Magenta),
                new InitialCell(2, 6, 8, Width, Color.Blue),
                new InitialCell(4, 1, 8, Width, Color.Yellow),
                new InitialCell(5, 4, 8, Width, Color.Red),
                new InitialCell(6, 1, 8, Width, Color.Red),
                new InitialCell(6, 4, 8, Width, Color.Green),
                new InitialCell(6, 5, 8, Width, Color.Yellow),
                new InitialCell(6, 6, 8, Width, Color.Orange),
                new InitialCell(7, 3, 8, Width, Color.Magenta)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 8, Width, Color.Green),
                new InitialCell(0, 2, 8, Width, Color.Orange),
                new InitialCell(1, 1, 8, Width, Color.Orange),
                new InitialCell(1, 2, 8, Width, Color.Cyan),
                new InitialCell(2, 3, 8, Width, Color.Cyan),
                new InitialCell(2, 5, 8, Width, Color.Red),
                new InitialCell(3, 1, 8, Width, Color.Yellow),
                new InitialCell(3, 3, 8, Width, Color.Magenta),
                new InitialCell(4, 5, 8, Width, Color.Red),
                new InitialCell(4, 6, 8, Width, Color.Blue),
                new InitialCell(5, 5, 8, Width, Color.Blue),
                new InitialCell(5, 6, 8, Width, Color.Magenta),
                new InitialCell(7, 0, 8, Width, Color.Green),
                new InitialCell(7, 1, 8, Width, Color.Yellow)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 8, Width, Color.Magenta),
                new InitialCell(0, 3, 8, Width, Color.Cyan),
                new InitialCell(1, 1, 8, Width, Color.Yellow),
                new InitialCell(1, 3, 8, Width, Color.Red),
                new InitialCell(1, 4, 8, Width, Color.Blue),
                new InitialCell(2, 1, 8, Width, Color.Magenta),
                new InitialCell(3, 1, 8, Width, Color.Orange),
                new InitialCell(4, 3, 8, Width, Color.Yellow),
                new InitialCell(5, 3, 8, Width, Color.Green),
                new InitialCell(6, 0, 8, Width, Color.Green),
                new InitialCell(6, 6, 8, Width, Color.Blue),
                new InitialCell(7, 0, 8, Width, Color.Orange),
                new InitialCell(7, 2, 8, Width, Color.Red),
                new InitialCell(7, 6, 8, Width, Color.Cyan)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 8, Width, Color.Blue),
                new InitialCell(1, 0, 8, Width, Color.Yellow),
                new InitialCell(1, 1, 8, Width, Color.Cyan),
                new InitialCell(1, 3, 8, Width, Color.Orange),
                new InitialCell(2, 2, 8, Width, Color.Blue),
                new InitialCell(2, 5, 8, Width, Color.Brown),
                new InitialCell(3, 1, 8, Width, Color.Cyan),
                new InitialCell(3, 2, 8, Width, Color.Green),
                new InitialCell(4, 2, 8, Width, Color.Magenta),
                new InitialCell(4, 4, 8, Width, Color.Brown),
                new InitialCell(5, 0, 8, Width, Color.Red),
                new InitialCell(5, 2, 8, Width, Color.Yellow),
                new InitialCell(5, 4, 8, Width, Color.Magenta),
                new InitialCell(5, 5, 8, Width, Color.Green),
                new InitialCell(5, 6, 8, Width, Color.Red),
                new InitialCell(7, 0, 8, Width, Color.Orange)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(1, 1, 8, Width, Color.Magenta),
                new InitialCell(1, 7, 8, Width, Color.Orange),
                new InitialCell(2, 7, 8, Width, Color.Cyan),
                new InitialCell(3, 4, 8, Width, Color.Green),
                new InitialCell(3, 5, 8, Width, Color.Blue),
                new InitialCell(5, 2, 8, Width, Color.Green),
                new InitialCell(5, 5, 8, Width, Color.Yellow),
                new InitialCell(6, 2, 8, Width, Color.Blue),
                new InitialCell(6, 3, 8, Width, Color.Magenta),
                new InitialCell(6, 4, 8, Width, Color.Yellow),
                new InitialCell(6, 5, 8, Width, Color.Cyan),
                new InitialCell(6, 7, 8, Width, Color.Red),
                new InitialCell(7, 3, 8, Width, Color.Orange),
                new InitialCell(7, 4, 8, Width, Color.Red)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(1, 2, 8, Width, Color.Magenta),
                new InitialCell(1, 3, 8, Width, Color.Orange),
                new InitialCell(1, 7, 8, Width, Color.Blue),
                new InitialCell(2, 5, 8, Width, Color.Yellow),
                new InitialCell(3, 1, 8, Width, Color.Magenta),
                new InitialCell(3, 3, 8, Width, Color.Green),
                new InitialCell(3, 6, 8, Width, Color.Cyan),
                new InitialCell(4, 1, 8, Width, Color.Red),
                new InitialCell(5, 1, 8, Width, Color.Green),
                new InitialCell(5, 4, 8, Width, Color.Red),
                new InitialCell(6, 1, 8, Width, Color.Yellow),
                new InitialCell(7, 3, 8, Width, Color.Blue),
                new InitialCell(7, 4, 8, Width, Color.Cyan),
                new InitialCell(7, 7, 8, Width, Color.Orange)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 8, Width, Color.Cyan),
                new InitialCell(0, 7, 8, Width, Color.Red),
                new InitialCell(1, 6, 8, Width, Color.Yellow),
                new InitialCell(2, 3, 8, Width, Color.Green),
                new InitialCell(2, 6, 8, Width, Color.Orange),
                new InitialCell(3, 7, 8, Width, Color.Yellow),
                new InitialCell(4, 2, 8, Width, Color.Red),
                new InitialCell(4, 5, 8, Width, Color.Orange),
                new InitialCell(5, 5, 8, Width, Color.Blue),
                new InitialCell(5, 6, 8, Width, Color.Cyan),
                new InitialCell(6, 1, 8, Width, Color.Blue),
                new InitialCell(7, 3, 8, Width, Color.Green)
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 4, 8, Width, Color.Orange),
                new InitialCell(0, 5, 8, Width, Color.Magenta),
                new InitialCell(0, 6, 8, Width, Color.Orange),
                new InitialCell(1, 4, 8, Width, Color.Red),
                new InitialCell(1, 6, 8, Width, Color.Cyan),
                new InitialCell(2, 2, 8, Width, Color.Green),
                new InitialCell(3, 5, 8, Width, Color.Magenta),
                new InitialCell(3, 6, 8, Width, Color.Cyan),
                new InitialCell(4, 2, 8, Width, Color.Green),
                new InitialCell(4, 3, 8, Width, Color.Blue),
                new InitialCell(5, 5, 8, Width, Color.Yellow),
                new InitialCell(6, 1, 8, Width, Color.Blue),
                new InitialCell(6, 2, 8, Width, Color.Yellow),
                new InitialCell(6, 3, 8, Width, Color.Red)
            })
        };

        public static List<Grid> Levels9 = new List<Grid>
        {
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(1, 1, 9, Width, Color.Red),
                new InitialCell(1, 2, 9, Width, Color.Cyan),
                new InitialCell(1, 3, 9, Width, Color.Blue),
                new InitialCell(2, 3, 9, Width, Color.Cyan),
                new InitialCell(2, 4, 9, Width, Color.Orange),
                new InitialCell(2, 6, 9, Width, Color.Orange),
                new InitialCell(2, 7, 9, Width, Color.Blue),
                new InitialCell(3, 7, 9, Width, Color.Magenta),
                new InitialCell(4, 1, 9, Width, Color.Green),
                new InitialCell(4, 3, 9, Width, Color.Green),
                new InitialCell(4, 4, 9, Width, Color.Red),
                new InitialCell(5, 0, 9, Width, Color.Yellow),
                new InitialCell(5, 1, 9, Width, Color.Magenta),
                new InitialCell(5, 7, 9, Width, Color.Brown),
                new InitialCell(5, 8, 9, Width, Color.Purple),
                new InitialCell(6, 1, 9, Width, Color.Purple),
                new InitialCell(6, 2, 9, Width, Color.Yellow),
                new InitialCell(7, 1, 9, Width, Color.Brown)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 9, Width, Color.Blue),
                new InitialCell(0, 7, 9, Width, Color.Brown),
                new InitialCell(3, 0, 9, Width, Color.Brown),
                new InitialCell(3, 3, 9, Width, Color.Red),
                new InitialCell(3, 5, 9, Width, Color.Magenta),
                new InitialCell(3, 7, 9, Width, Color.Blue),
                new InitialCell(4, 3, 9, Width, Color.Green),
                new InitialCell(4, 7, 9, Width, Color.Cyan),
                new InitialCell(5, 1, 9, Width, Color.Orange),
                new InitialCell(5, 4, 9, Width, Color.Yellow),
                new InitialCell(5, 5, 9, Width, Color.Magenta),
                new InitialCell(7, 1, 9, Width, Color.Orange),
                new InitialCell(7, 2, 9, Width, Color.Red),
                new InitialCell(7, 5, 9, Width, Color.Cyan),
                new InitialCell(8, 2, 9, Width, Color.Yellow),
                new InitialCell(8, 3, 9, Width, Color.Green)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 7, 9, Width, Color.Green),
                new InitialCell(1, 1, 9, Width, Color.Blue),
                new InitialCell(1, 2, 9, Width, Color.Yellow),
                new InitialCell(2, 0, 9, Width, Color.Orange),
                new InitialCell(3, 0, 9, Width, Color.Magenta),
                new InitialCell(3, 5, 9, Width, Color.Red),
                new InitialCell(3, 6, 9, Width, Color.Yellow),
                new InitialCell(4, 2, 9, Width, Color.Orange),
                new InitialCell(4, 4, 9, Width, Color.Blue),
                new InitialCell(4, 8, 9, Width, Color.Green),
                new InitialCell(5, 4, 9, Width, Color.Cyan),
                new InitialCell(5, 5, 9, Width, Color.Red),
                new InitialCell(5, 8, 9, Width, Color.Cyan),
                new InitialCell(6, 8, 9, Width, Color.Magenta)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 9, Width, Color.Yellow),
                new InitialCell(0, 1, 9, Width, Color.Orange),
                new InitialCell(0, 8, 9, Width, Color.Cyan),
                new InitialCell(1, 3, 9, Width, Color.Orange),
                new InitialCell(1, 8, 9, Width, Color.Green),
                new InitialCell(3, 4, 9, Width, Color.Green),
                new InitialCell(3, 7, 9, Width, Color.Yellow),
                new InitialCell(3, 8, 9, Width, Color.Red),
                new InitialCell(4, 4, 9, Width, Color.Red),
                new InitialCell(4, 8, 9, Width, Color.Blue),
                new InitialCell(5, 8, 9, Width, Color.Magenta),
                new InitialCell(6, 4, 9, Width, Color.Cyan),
                new InitialCell(7, 8, 9, Width, Color.Magenta),
                new InitialCell(8, 8, 9, Width, Color.Blue)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 9, Width, Color.Green),
                new InitialCell(1, 0, 9, Width, Color.Orange),
                new InitialCell(1, 4, 9, Width, Color.Yellow),
                new InitialCell(1, 7, 9, Width, Color.Blue),
                new InitialCell(2, 0, 9, Width, Color.Magenta),
                new InitialCell(2, 5, 9, Width, Color.Brown),
                new InitialCell(3, 3, 9, Width, Color.Green),
                new InitialCell(3, 6, 9, Width, Color.Yellow),
                new InitialCell(5, 3, 9, Width, Color.Red),
                new InitialCell(6, 4, 9, Width, Color.Brown),
                new InitialCell(6, 5, 9, Width, Color.Blue),
                new InitialCell(6, 7, 9, Width, Color.Cyan),
                new InitialCell(6, 8, 9, Width, Color.Magenta),
                new InitialCell(7, 1, 9, Width, Color.Orange),
                new InitialCell(7, 2, 9, Width, Color.Cyan),
                new InitialCell(7, 7, 9, Width, Color.Red)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(1, 1, 9, Width, Color.Yellow),
                new InitialCell(1, 4, 9, Width, Color.Yellow),
                new InitialCell(1, 5, 9, Width, Color.Purple),
                new InitialCell(3, 4, 9, Width, Color.Orange),
                new InitialCell(3, 5, 9, Width, Color.Blue),
                new InitialCell(3, 6, 9, Width, Color.Magenta),
                new InitialCell(4, 4, 9, Width, Color.Cyan),
                new InitialCell(4, 6, 9, Width, Color.Red),
                new InitialCell(5, 0, 9, Width, Color.Orange),
                new InitialCell(6, 0, 9, Width, Color.Magenta),
                new InitialCell(6, 4, 9, Width, Color.Blue),
                new InitialCell(6, 5, 9, Width, Color.Brown),
                new InitialCell(6, 7, 9, Width, Color.Purple),
                new InitialCell(7, 0, 9, Width, Color.Orange),
                new InitialCell(7, 4, 9, Width, Color.Cyan),
                new InitialCell(7, 7, 9, Width, Color.Red),
                new InitialCell(8, 0, 9, Width, Color.Green),
                new InitialCell(8, 4, 9, Width, Color.Green),
                new InitialCell(8, 6, 9, Width, Color.Brown),
                new InitialCell(8, 7, 9, Width, Color.Orange)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 9, Width, Color.Yellow),
                new InitialCell(0, 4, 9, Width, Color.Orange),
                new InitialCell(0, 6, 9, Width, Color.Magenta),
                new InitialCell(1, 2, 9, Width, Color.Red),
                new InitialCell(1, 7, 9, Width, Color.Purple),
                new InitialCell(2, 1, 9, Width, Color.Green),
                new InitialCell(2, 3, 9, Width, Color.Cyan),
                new InitialCell(2, 7, 9, Width, Color.Blue),
                new InitialCell(3, 1, 9, Width, Color.Red),
                new InitialCell(4, 2, 9, Width, Color.Orange),
                new InitialCell(5, 2, 9, Width, Color.Orange),
                new InitialCell(5, 6, 9, Width, Color.Purple),
                new InitialCell(5, 7, 9, Width, Color.Blue),
                new InitialCell(6, 3, 9, Width, Color.Cyan),
                new InitialCell(6, 4, 9, Width, Color.Green),
                new InitialCell(6, 6, 9, Width, Color.Orange),
                new InitialCell(6, 7, 9, Width, Color.Brown),
                new InitialCell(7, 8, 9, Width, Color.Magenta),
                new InitialCell(8, 0, 9, Width, Color.Yellow),
                new InitialCell(8, 8, 9, Width, Color.Brown)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 9, Width, Color.Blue),
                new InitialCell(1, 0, 9, Width, Color.Green),
                new InitialCell(1, 5, 9, Width, Color.Magenta),
                new InitialCell(1, 7, 9, Width, Color.Magenta),
                new InitialCell(1, 8, 9, Width, Color.Blue),
                new InitialCell(2, 3, 9, Width, Color.Cyan),
                new InitialCell(2, 8, 9, Width, Color.Orange),
                new InitialCell(3, 5, 9, Width, Color.Orange),
                new InitialCell(4, 7, 9, Width, Color.Red),
                new InitialCell(5, 2, 9, Width, Color.Brown),
                new InitialCell(6, 2, 9, Width, Color.Yellow),
                new InitialCell(6, 4, 9, Width, Color.Brown),
                new InitialCell(6, 6, 9, Width, Color.Yellow),
                new InitialCell(6, 7, 9, Width, Color.Red),
                new InitialCell(7, 4, 9, Width, Color.Green),
                new InitialCell(8, 8, 9, Width, Color.Cyan)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 9, Width, Color.Blue),
                new InitialCell(0, 1, 9, Width, Color.Brown),
                new InitialCell(0, 3, 9, Width, Color.Orange),
                new InitialCell(1, 1, 9, Width, Color.Yellow),
                new InitialCell(1, 7, 9, Width, Color.Green),
                new InitialCell(2, 6, 9, Width, Color.Magenta),
                new InitialCell(2, 7, 9, Width, Color.Cyan),
                new InitialCell(2, 8, 9, Width, Color.Brown),
                new InitialCell(3, 3, 9, Width, Color.Orange),
                new InitialCell(3, 8, 9, Width, Color.Blue),
                new InitialCell(4, 5, 9, Width, Color.Green),
                new InitialCell(4, 6, 9, Width, Color.Magenta),
                new InitialCell(6, 2, 9, Width, Color.Cyan),
                new InitialCell(6, 6, 9, Width, Color.Yellow),
                new InitialCell(6, 7, 9, Width, Color.Red),
                new InitialCell(7, 4, 9, Width, Color.Red)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(2, 2, 9, Width, Color.Red),
                new InitialCell(2, 6, 9, Width, Color.Magenta),
                new InitialCell(4, 3, 9, Width, Color.Yellow),
                new InitialCell(5, 1, 9, Width, Color.Cyan),
                new InitialCell(5, 6, 9, Width, Color.Magenta),
                new InitialCell(6, 1, 9, Width, Color.Green),
                new InitialCell(6, 6, 9, Width, Color.Red),
                new InitialCell(6, 8, 9, Width, Color.Green),
                new InitialCell(7, 1, 9, Width, Color.Yellow),
                new InitialCell(7, 5, 9, Width, Color.Orange),
                new InitialCell(7, 6, 9, Width, Color.Blue),
                new InitialCell(7, 8, 9, Width, Color.Orange),
                new InitialCell(8, 5, 9, Width, Color.Cyan),
                new InitialCell(8, 8, 9, Width, Color.Blue)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 9, Width, Color.Yellow),
                new InitialCell(1, 1, 9, Width, Color.Cyan),
                new InitialCell(1, 2, 9, Width, Color.Red),
                new InitialCell(1, 4, 9, Width, Color.Orange),
                new InitialCell(2, 5, 9, Width, Color.Cyan),
                new InitialCell(3, 0, 9, Width, Color.Purple),
                new InitialCell(4, 0, 9, Width, Color.Brown),
                new InitialCell(4, 2, 9, Width, Color.Blue),
                new InitialCell(4, 3, 9, Width, Color.Yellow),
                new InitialCell(4, 4, 9, Width, Color.Magenta),
                new InitialCell(5, 1, 9, Width, Color.Purple),
                new InitialCell(5, 3, 9, Width, Color.Blue),
                new InitialCell(6, 5, 9, Width, Color.Red),
                new InitialCell(7, 2, 9, Width, Color.Green),
                new InitialCell(7, 7, 9, Width, Color.Orange),
                new InitialCell(8, 0, 9, Width, Color.Brown),
                new InitialCell(8, 4, 9, Width, Color.Magenta),
                new InitialCell(8, 5, 9, Width, Color.Green)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 9, Width, Color.Red),
                new InitialCell(0, 2, 9, Width, Color.Green),
                new InitialCell(0, 3, 9, Width, Color.Yellow),
                new InitialCell(1, 1, 9, Width, Color.Orange),
                new InitialCell(1, 6, 9, Width, Color.Brown),
                new InitialCell(2, 3, 9, Width, Color.Green),
                new InitialCell(2, 4, 9, Width, Color.Yellow),
                new InitialCell(3, 1, 9, Width, Color.Blue),
                new InitialCell(4, 4, 9, Width, Color.Cyan),
                new InitialCell(4, 5, 9, Width, Color.Orange),
                new InitialCell(6, 2, 9, Width, Color.Cyan),
                new InitialCell(6, 3, 9, Width, Color.Red),
                new InitialCell(6, 4, 9, Width, Color.Blue),
                new InitialCell(6, 5, 9, Width, Color.Brown),
                new InitialCell(7, 5, 9, Width, Color.Magenta),
                new InitialCell(7, 7, 9, Width, Color.Magenta)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(1, 7, 9, Width, Color.Green),
                new InitialCell(2, 2, 9, Width, Color.Yellow),
                new InitialCell(2, 7, 9, Width, Color.Yellow),
                new InitialCell(3, 2, 9, Width, Color.Brown),
                new InitialCell(3, 4, 9, Width, Color.Blue),
                new InitialCell(4, 2, 9, Width, Color.Magenta),
                new InitialCell(4, 4, 9, Width, Color.Brown),
                new InitialCell(4, 5, 9, Width, Color.Orange),
                new InitialCell(5, 4, 9, Width, Color.Red),
                new InitialCell(5, 5, 9, Width, Color.Cyan),
                new InitialCell(5, 7, 9, Width, Color.Blue),
                new InitialCell(6, 4, 9, Width, Color.Magenta),
                new InitialCell(7, 1, 9, Width, Color.Green),
                new InitialCell(7, 6, 9, Width, Color.Cyan),
                new InitialCell(7, 7, 9, Width, Color.Orange),
                new InitialCell(8, 3, 9, Width, Color.Red)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(1, 1, 9, Width, Color.Brown),
                new InitialCell(1, 3, 9, Width, Color.Red),
                new InitialCell(1, 4, 9, Width, Color.Orange),
                new InitialCell(2, 1, 9, Width, Color.Purple),
                new InitialCell(2, 6, 9, Width, Color.Magenta),
                new InitialCell(2, 7, 9, Width, Color.Brown),
                new InitialCell(3, 3, 9, Width, Color.Purple),
                new InitialCell(3, 4, 9, Width, Color.Magenta),
                new InitialCell(4, 5, 9, Width, Color.Red),
                new InitialCell(4, 8, 9, Width, Color.Yellow),
                new InitialCell(5, 7, 9, Width, Color.Green),
                new InitialCell(6, 1, 9, Width, Color.Cyan),
                new InitialCell(6, 2, 9, Width, Color.Yellow),
                new InitialCell(6, 3, 9, Width, Color.Green),
                new InitialCell(6, 4, 9, Width, Color.Blue),
                new InitialCell(6, 6, 9, Width, Color.Blue),
                new InitialCell(7, 0, 9, Width, Color.Orange),
                new InitialCell(8, 0, 9, Width, Color.Cyan)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 3, 9, Width, Color.Yellow),
                new InitialCell(1, 1, 9, Width, Color.Magenta),
                new InitialCell(2, 0, 9, Width, Color.Orange),
                new InitialCell(2, 5, 9, Width, Color.Green),
                new InitialCell(2, 6, 9, Width, Color.Blue),
                new InitialCell(3, 0, 9, Width, Color.Blue),
                new InitialCell(3, 1, 9, Width, Color.Magenta),
                new InitialCell(3, 3, 9, Width, Color.Yellow),
                new InitialCell(5, 0, 9, Width, Color.Orange),
                new InitialCell(5, 7, 9, Width, Color.Red),
                new InitialCell(6, 2, 9, Width, Color.Red),
                new InitialCell(6, 6, 9, Width, Color.Green),
                new InitialCell(7, 0, 9, Width, Color.Cyan),
                new InitialCell(8, 3, 9, Width, Color.Cyan)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 3, 9, Width, Color.Red),
                new InitialCell(1, 0, 9, Width, Color.Yellow),
                new InitialCell(1, 1, 9, Width, Color.Magenta),
                new InitialCell(1, 5, 9, Width, Color.Cyan),
                new InitialCell(2, 0, 9, Width, Color.Green),
                new InitialCell(2, 6, 9, Width, Color.Yellow),
                new InitialCell(3, 2, 9, Width, Color.Green),
                new InitialCell(3, 6, 9, Width, Color.Orange),
                new InitialCell(3, 7, 9, Width, Color.Cyan),
                new InitialCell(5, 5, 9, Width, Color.Purple),
                new InitialCell(5, 6, 9, Width, Color.Blue),
                new InitialCell(5, 7, 9, Width, Color.Purple),
                new InitialCell(6, 2, 9, Width, Color.Blue),
                new InitialCell(6, 7, 9, Width, Color.Red),
                new InitialCell(7, 4, 9, Width, Color.Orange),
                new InitialCell(7, 7, 9, Width, Color.Magenta),
                new InitialCell(7, 8, 9, Width, Color.Brown),
                new InitialCell(8, 6, 9, Width, Color.Brown)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 6, 9, Width, Color.Yellow),
                new InitialCell(1, 0, 9, Width, Color.Green),
                new InitialCell(1, 4, 9, Width, Color.Cyan),
                new InitialCell(1, 7, 9, Width, Color.Red),
                new InitialCell(2, 5, 9, Width, Color.Yellow),
                new InitialCell(3, 4, 9, Width, Color.Blue),
                new InitialCell(3, 5, 9, Width, Color.Green),
                new InitialCell(6, 2, 9, Width, Color.Blue),
                new InitialCell(6, 3, 9, Width, Color.Red),
                new InitialCell(7, 7, 9, Width, Color.Orange),
                new InitialCell(8, 6, 9, Width, Color.Orange),
                new InitialCell(8, 8, 9, Width, Color.Cyan)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 8, 9, Width, Color.Cyan),
                new InitialCell(1, 4, 9, Width, Color.Blue),
                new InitialCell(1, 6, 9, Width, Color.Red),
                new InitialCell(2, 6, 9, Width, Color.Purple),
                new InitialCell(3, 3, 9, Width, Color.Purple),
                new InitialCell(4, 3, 9, Width, Color.Brown),
                new InitialCell(4, 4, 9, Width, Color.Green),
                new InitialCell(4, 5, 9, Width, Color.Yellow),
                new InitialCell(5, 5, 9, Width, Color.Magenta),
                new InitialCell(5, 7, 9, Width, Color.Magenta),
                new InitialCell(6, 5, 9, Width, Color.Orange),
                new InitialCell(7, 1, 9, Width, Color.Blue),
                new InitialCell(7, 2, 9, Width, Color.Red),
                new InitialCell(7, 3, 9, Width, Color.Brown),
                new InitialCell(7, 6, 9, Width, Color.Green),
                new InitialCell(8, 6, 9, Width, Color.Yellow),
                new InitialCell(8, 7, 9, Width, Color.Orange),
                new InitialCell(8, 8, 9, Width, Color.Cyan)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 7, 9, Width, Color.Green),
                new InitialCell(1, 3, 9, Width, Color.Magenta),
                new InitialCell(1, 4, 9, Width, Color.Brown),
                new InitialCell(1, 6, 9, Width, Color.Blue),
                new InitialCell(1, 7, 9, Width, Color.Brown),
                new InitialCell(2, 4, 9, Width, Color.Purple),
                new InitialCell(3, 3, 9, Width, Color.Red),
                new InitialCell(3, 4, 9, Width, Color.Yellow),
                new InitialCell(4, 1, 9, Width, Color.Magenta),
                new InitialCell(4, 5, 9, Width, Color.Green),
                new InitialCell(4, 6, 9, Width, Color.Yellow),
                new InitialCell(4, 7, 9, Width, Color.Cyan),
                new InitialCell(5, 1, 9, Width, Color.Orange),
                new InitialCell(5, 7, 9, Width, Color.Blue),
                new InitialCell(6, 2, 9, Width, Color.Purple),
                new InitialCell(7, 5, 9, Width, Color.Orange),
                new InitialCell(7, 6, 9, Width, Color.Red),
                new InitialCell(8, 8, 9, Width, Color.Cyan)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 4, 9, Width, Color.Yellow),
                new InitialCell(0, 5, 9, Width, Color.Red),
                new InitialCell(1, 1, 9, Width, Color.Blue),
                new InitialCell(1, 7, 9, Width, Color.Cyan),
                new InitialCell(2, 4, 9, Width, Color.Red),
                new InitialCell(3, 0, 9, Width, Color.Orange),
                new InitialCell(3, 1, 9, Width, Color.Green),
                new InitialCell(3, 6, 9, Width, Color.Green),
                new InitialCell(3, 8, 9, Width, Color.Brown),
                new InitialCell(4, 4, 9, Width, Color.Brown),
                new InitialCell(5, 6, 9, Width, Color.Magenta),
                new InitialCell(5, 7, 9, Width, Color.Purple),
                new InitialCell(6, 2, 9, Width, Color.Yellow),
                new InitialCell(6, 3, 9, Width, Color.Blue),
                new InitialCell(6, 5, 9, Width, Color.Orange),
                new InitialCell(6, 8, 9, Width, Color.Cyan),
                new InitialCell(7, 8, 9, Width, Color.Purple),
                new InitialCell(8, 8, 9, Width, Color.Magenta)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 6, 9, Width, Color.Blue),
                new InitialCell(0, 7, 9, Width, Color.Magenta),
                new InitialCell(1, 6, 9, Width, Color.Cyan),
                new InitialCell(1, 7, 9, Width, Color.Blue),
                new InitialCell(4, 4, 9, Width, Color.Yellow),
                new InitialCell(4, 5, 9, Width, Color.Red),
                new InitialCell(4, 8, 9, Width, Color.Green),
                new InitialCell(5, 3, 9, Width, Color.Magenta),
                new InitialCell(5, 6, 9, Width, Color.Green),
                new InitialCell(6, 4, 9, Width, Color.Orange),
                new InitialCell(6, 7, 9, Width, Color.Red),
                new InitialCell(7, 2, 9, Width, Color.Cyan),
                new InitialCell(8, 4, 9, Width, Color.Orange),
                new InitialCell(8, 8, 9, Width, Color.Yellow)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 4, 9, Width, Color.Orange),
                new InitialCell(0, 5, 9, Width, Color.Brown),
                new InitialCell(0, 8, 9, Width, Color.Brown),
                new InitialCell(1, 4, 9, Width, Color.Magenta),
                new InitialCell(2, 1, 9, Width, Color.Magenta),
                new InitialCell(2, 2, 9, Width, Color.Purple),
                new InitialCell(2, 6, 9, Width, Color.Red),
                new InitialCell(2, 8, 9, Width, Color.Yellow),
                new InitialCell(3, 6, 9, Width, Color.Cyan),
                new InitialCell(4, 4, 9, Width, Color.Purple),
                new InitialCell(4, 7, 9, Width, Color.Green),
                new InitialCell(5, 1, 9, Width, Color.Blue),
                new InitialCell(5, 2, 9, Width, Color.Green),
                new InitialCell(5, 8, 9, Width, Color.Red),
                new InitialCell(6, 2, 9, Width, Color.Yellow),
                new InitialCell(6, 4, 9, Width, Color.Orange),
                new InitialCell(7, 2, 9, Width, Color.Blue),
                new InitialCell(7, 7, 9, Width, Color.Cyan)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(1, 4, 9, Width, Color.Orange),
                new InitialCell(1, 5, 9, Width, Color.Brown),
                new InitialCell(1, 6, 9, Width, Color.Magenta),
                new InitialCell(1, 8, 9, Width, Color.Cyan),
                new InitialCell(2, 1, 9, Width, Color.Orange),
                new InitialCell(2, 4, 9, Width, Color.Yellow),
                new InitialCell(2, 6, 9, Width, Color.Green),
                new InitialCell(3, 3, 9, Width, Color.Red),
                new InitialCell(3, 8, 9, Width, Color.Magenta),
                new InitialCell(4, 0, 9, Width, Color.Blue),
                new InitialCell(4, 6, 9, Width, Color.Brown),
                new InitialCell(5, 2, 9, Width, Color.Purple),
                new InitialCell(6, 4, 9, Width, Color.Yellow),
                new InitialCell(6, 6, 9, Width, Color.Purple),
                new InitialCell(6, 7, 9, Width, Color.Red),
                new InitialCell(7, 7, 9, Width, Color.Cyan),
                new InitialCell(8, 0, 9, Width, Color.Blue),
                new InitialCell(8, 7, 9, Width, Color.Green)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 2, 9, Width, Color.Orange),
                new InitialCell(1, 1, 9, Width, Color.Blue),
                new InitialCell(1, 2, 9, Width, Color.Magenta),
                new InitialCell(1, 3, 9, Width, Color.Green),
                new InitialCell(1, 4, 9, Width, Color.Brown),
                new InitialCell(2, 3, 9, Width, Color.Red),
                new InitialCell(2, 4, 9, Width, Color.Yellow),
                new InitialCell(4, 3, 9, Width, Color.Blue),
                new InitialCell(4, 4, 9, Width, Color.Cyan),
                new InitialCell(4, 7, 9, Width, Color.Brown),
                new InitialCell(5, 7, 9, Width, Color.Yellow),
                new InitialCell(5, 8, 9, Width, Color.Green),
                new InitialCell(6, 2, 9, Width, Color.Magenta),
                new InitialCell(6, 8, 9, Width, Color.Orange),
                new InitialCell(7, 6, 9, Width, Color.Cyan),
                new InitialCell(7, 7, 9, Width, Color.Red)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 9, Width, Color.Cyan),
                new InitialCell(0, 1, 9, Width, Color.Green),
                new InitialCell(0, 2, 9, Width, Color.Yellow),
                new InitialCell(0, 8, 9, Width, Color.Magenta),
                new InitialCell(1, 4, 9, Width, Color.Brown),
                new InitialCell(1, 5, 9, Width, Color.Red),
                new InitialCell(2, 6, 9, Width, Color.Brown),
                new InitialCell(2, 7, 9, Width, Color.Blue),
                new InitialCell(4, 3, 9, Width, Color.Magenta),
                new InitialCell(4, 7, 9, Width, Color.Orange),
                new InitialCell(6, 3, 9, Width, Color.Blue),
                new InitialCell(6, 4, 9, Width, Color.Orange),
                new InitialCell(6, 6, 9, Width, Color.Red),
                new InitialCell(6, 7, 9, Width, Color.Yellow),
                new InitialCell(6, 8, 9, Width, Color.Green),
                new InitialCell(8, 0, 9, Width, Color.Cyan)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 4, 9, Width, Color.Green),
                new InitialCell(1, 4, 9, Width, Color.Red),
                new InitialCell(1, 7, 9, Width, Color.Brown),
                new InitialCell(2, 1, 9, Width, Color.Red),
                new InitialCell(2, 2, 9, Width, Color.Yellow),
                new InitialCell(2, 7, 9, Width, Color.Cyan),
                new InitialCell(3, 5, 9, Width, Color.Green),
                new InitialCell(4, 0, 9, Width, Color.Magenta),
                new InitialCell(4, 4, 9, Width, Color.Purple),
                new InitialCell(5, 2, 9, Width, Color.Brown),
                new InitialCell(5, 6, 9, Width, Color.Cyan),
                new InitialCell(6, 6, 9, Width, Color.Yellow),
                new InitialCell(7, 3, 9, Width, Color.Magenta),
                new InitialCell(7, 4, 9, Width, Color.Blue),
                new InitialCell(7, 6, 9, Width, Color.Orange),
                new InitialCell(7, 8, 9, Width, Color.Orange),
                new InitialCell(8, 0, 9, Width, Color.Blue),
                new InitialCell(8, 8, 9, Width, Color.Purple)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 9, Width, Color.Orange),
                new InitialCell(1, 7, 9, Width, Color.Blue),
                new InitialCell(3, 1, 9, Width, Color.Magenta),
                new InitialCell(3, 8, 9, Width, Color.Yellow),
                new InitialCell(4, 3, 9, Width, Color.Orange),
                new InitialCell(4, 6, 9, Width, Color.Magenta),
                new InitialCell(5, 1, 9, Width, Color.Cyan),
                new InitialCell(5, 3, 9, Width, Color.Red),
                new InitialCell(6, 3, 9, Width, Color.Brown),
                new InitialCell(6, 6, 9, Width, Color.Cyan),
                new InitialCell(7, 0, 9, Width, Color.Blue),
                new InitialCell(7, 2, 9, Width, Color.Brown),
                new InitialCell(7, 4, 9, Width, Color.Green),
                new InitialCell(8, 0, 9, Width, Color.Red),
                new InitialCell(8, 2, 9, Width, Color.Green),
                new InitialCell(8, 5, 9, Width, Color.Yellow)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 9, Width, Color.Yellow),
                new InitialCell(3, 1, 9, Width, Color.Yellow),
                new InitialCell(4, 1, 9, Width, Color.Orange),
                new InitialCell(4, 4, 9, Width, Color.Cyan),
                new InitialCell(5, 2, 9, Width, Color.Red),
                new InitialCell(5, 4, 9, Width, Color.Orange),
                new InitialCell(6, 2, 9, Width, Color.Blue),
                new InitialCell(6, 5, 9, Width, Color.Magenta),
                new InitialCell(7, 1, 9, Width, Color.Red),
                new InitialCell(7, 7, 9, Width, Color.Green),
                new InitialCell(8, 2, 9, Width, Color.Green),
                new InitialCell(8, 3, 9, Width, Color.Blue),
                new InitialCell(8, 4, 9, Width, Color.Cyan),
                new InitialCell(8, 5, 9, Width, Color.Magenta)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 9, Width, Color.Cyan),
                new InitialCell(1, 0, 9, Width, Color.Orange),
                new InitialCell(1, 4, 9, Width, Color.Orange),
                new InitialCell(1, 7, 9, Width, Color.Magenta),
                new InitialCell(2, 7, 9, Width, Color.Yellow),
                new InitialCell(3, 7, 9, Width, Color.Cyan),
                new InitialCell(4, 1, 9, Width, Color.Blue),
                new InitialCell(4, 2, 9, Width, Color.Brown),
                new InitialCell(4, 4, 9, Width, Color.Brown),
                new InitialCell(4, 5, 9, Width, Color.Blue),
                new InitialCell(4, 7, 9, Width, Color.Red),
                new InitialCell(5, 5, 9, Width, Color.Red),
                new InitialCell(5, 7, 9, Width, Color.Green),
                new InitialCell(6, 2, 9, Width, Color.Yellow),
                new InitialCell(7, 3, 9, Width, Color.Green),
                new InitialCell(8, 1, 9, Width, Color.Magenta)
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 6, 9, Width, Color.Red),
                new InitialCell(0, 7, 9, Width, Color.Cyan),
                new InitialCell(0, 8, 9, Width, Color.Green),
                new InitialCell(1, 1, 9, Width, Color.Blue),
                new InitialCell(2, 0, 9, Width, Color.Brown),
                new InitialCell(2, 3, 9, Width, Color.Red),
                new InitialCell(3, 3, 9, Width, Color.Cyan),
                new InitialCell(4, 1, 9, Width, Color.Green),
                new InitialCell(4, 7, 9, Width, Color.Orange),
                new InitialCell(5, 4, 9, Width, Color.Magenta),
                new InitialCell(6, 6, 9, Width, Color.Yellow),
                new InitialCell(6, 8, 9, Width, Color.Yellow),
                new InitialCell(7, 3, 9, Width, Color.Brown),
                new InitialCell(7, 6, 9, Width, Color.Magenta),
                new InitialCell(7, 7, 9, Width, Color.Orange),
                new InitialCell(7, 8, 9, Width, Color.Purple),
                new InitialCell(8, 0, 9, Width, Color.Blue),
                new InitialCell(8, 5, 9, Width, Color.Purple)
            })
        };
    }
}
