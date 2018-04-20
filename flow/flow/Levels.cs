using System.Collections.Generic;

namespace flow
{
    class Levels
    {
        public static int Width = 500;

        public static List<Grid> Levels5 = new List<Grid>
        {
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 5, Width, 'r'),
                new InitialCell(0, 2, 5, Width, 'g'),
                new InitialCell(0, 4, 5, Width, 'y'),
                new InitialCell(1, 2, 5, Width, 'b'),
                new InitialCell(1, 4, 5, Width, 'o'),
                new InitialCell(3, 1, 5, Width, 'g'),
                new InitialCell(3, 3, 5, Width, 'y'),
                new InitialCell(4, 1, 5, Width, 'r'),
                new InitialCell(4, 2, 5, Width, 'b'),
                new InitialCell(4, 3, 5, Width, 'o')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 5, Width, 'y'),
                new InitialCell(2, 2, 5, Width, 'g'),
                new InitialCell(3, 0, 5, Width, 'b'),
                new InitialCell(3, 1, 5, Width, 'g'),
                new InitialCell(3, 2, 5, Width, 'r'),
                new InitialCell(3, 4, 5, Width, 'y'),
                new InitialCell(4, 0, 5, Width, 'r'),
                new InitialCell(4, 4, 5, Width, 'b')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 5, Width, 'y'),
                new InitialCell(0, 2, 5, Width, 'b'),
                new InitialCell(0, 3, 5, Width, 'g'),
                new InitialCell(1, 3, 5, Width, 'r'),
                new InitialCell(2, 2, 5, Width, 'r'),
                new InitialCell(3, 0, 5, Width, 'y'),
                new InitialCell(3, 3, 5, Width, 'o'),
                new InitialCell(4, 0, 5, Width, 'b'),
                new InitialCell(4, 2, 5, Width, 'o'),
                new InitialCell(4, 3, 5, Width, 'g')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 3, 5, Width, 'r'),
                new InitialCell(0, 4, 5, Width, 'g'),
                new InitialCell(1, 0, 5, Width, 'r'),
                new InitialCell(2, 2, 5, Width, 'y'),
                new InitialCell(3, 3, 5, Width, 'b'),
                new InitialCell(4, 0, 5, Width, 'g'),
                new InitialCell(4, 1, 5, Width, 'b'),
                new InitialCell(4, 2, 5, Width, 'y')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 3, 5, Width, 'r'),
                new InitialCell(0, 4, 5, Width, 'g'),
                new InitialCell(1, 1, 5, Width, 'y'),
                new InitialCell(1, 2, 5, Width, 'b'),
                new InitialCell(1, 3, 5, Width, 'g'),
                new InitialCell(3, 4, 5, Width, 'b'),
                new InitialCell(4, 2, 5, Width, 'r'),
                new InitialCell(4, 4, 5, Width, 'y')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 5, Width, 'y'),
                new InitialCell(0, 2, 5, Width, 'b'),
                new InitialCell(0, 3, 5, Width, 'r'),
                new InitialCell(0, 4, 5, Width, 'g'),
                new InitialCell(2, 3, 5, Width, 'g'),
                new InitialCell(3, 1, 5, Width, 'b'),
                new InitialCell(3, 4, 5, Width, 'r'),
                new InitialCell(4, 4, 5, Width, 'y')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 5, Width, 'b'),
                new InitialCell(0, 3, 5, Width, 'y'),
                new InitialCell(1, 0, 5, Width, 'g'),
                new InitialCell(2, 0, 5, Width, 'y'),
                new InitialCell(2, 2, 5, Width, 'g'),
                new InitialCell(2, 3, 5, Width, 'b'),
                new InitialCell(3, 1, 5, Width, 'r'),
                new InitialCell(3, 3, 5, Width, 'r')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 5, Width, 'b'),
                new InitialCell(0, 3, 5, Width, 'r'),
                new InitialCell(0, 4, 5, Width, 'o'),
                new InitialCell(1, 3, 5, Width, 'y'),
                new InitialCell(2, 2, 5, Width, 'y'),
                new InitialCell(3, 1, 5, Width, 'r'),
                new InitialCell(3, 2, 5, Width, 'o'),
                new InitialCell(3, 4, 5, Width, 'g'),
                new InitialCell(4, 1, 5, Width, 'b'),
                new InitialCell(4, 2, 5, Width, 'g')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 3, 5, Width, 'r'),
                new InitialCell(1, 1, 5, Width, 'y'),
                new InitialCell(1, 2, 5, Width, 'b'),
                new InitialCell(1, 3, 5, Width, 'g'),
                new InitialCell(2, 2, 5, Width, 'y'),
                new InitialCell(4, 0, 5, Width, 'b'),
                new InitialCell(4, 1, 5, Width, 'g'),
                new InitialCell(4, 2, 5, Width, 'r')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(1, 0, 5, Width, 'g'),
                new InitialCell(1, 3, 5, Width, 'r'),
                new InitialCell(2, 0, 5, Width, 'b'),
                new InitialCell(2, 1, 5, Width, 'r'),
                new InitialCell(2, 2, 5, Width, 'b'),
                new InitialCell(2, 3, 5, Width, 'y'),
                new InitialCell(4, 0, 5, Width, 'y'),
                new InitialCell(4, 4, 5, Width, 'g')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 5, Width, 'b'),
                new InitialCell(0, 1, 5, Width, 'y'),
                new InitialCell(0, 2, 5, Width, 'r'),
                new InitialCell(2, 1, 5, Width, 'b'),
                new InitialCell(2, 2, 5, Width, 'g'),
                new InitialCell(4, 0, 5, Width, 'g'),
                new InitialCell(4, 1, 5, Width, 'y'),
                new InitialCell(4, 4, 5, Width, 'r')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 3, 5, Width, 'r'),
                new InitialCell(0, 4, 5, Width, 'g'),
                new InitialCell(1, 2, 5, Width, 'b'),
                new InitialCell(1, 3, 5, Width, 'g'),
                new InitialCell(2, 0, 5, Width, 'r'),
                new InitialCell(3, 0, 5, Width, 'o'),
                new InitialCell(3, 1, 5, Width, 'b'),
                new InitialCell(3, 3, 5, Width, 'y'),
                new InitialCell(3, 4, 5, Width, 'o'),
                new InitialCell(4, 4, 5, Width, 'y')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 5, Width, 'g'),
                new InitialCell(0, 1, 5, Width, 'y'),
                new InitialCell(0, 3, 5, Width, 'y'),
                new InitialCell(0, 4, 5, Width, 'o'),
                new InitialCell(2, 0, 5, Width, 'r'),
                new InitialCell(2, 2, 5, Width, 'o'),
                new InitialCell(2, 3, 5, Width, 'b'),
                new InitialCell(3, 3, 5, Width, 'g'),
                new InitialCell(4, 3, 5, Width, 'r'),
                new InitialCell(4, 4, 5, Width, 'b')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 2, 5, Width, 'g'),
                new InitialCell(0, 3, 5, Width, 'y'),
                new InitialCell(0, 4, 5, Width, 'b'),
                new InitialCell(2, 0, 5, Width, 'g'),
                new InitialCell(2, 3, 5, Width, 'o'),
                new InitialCell(3, 3, 5, Width, 'r'),
                new InitialCell(3, 4, 5, Width, 'b'),
                new InitialCell(4, 0, 5, Width, 'y'),
                new InitialCell(4, 1, 5, Width, 'o'),
                new InitialCell(4, 4, 5, Width, 'r')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 5, Width, 'b'),
                new InitialCell(0, 1, 5, Width, 'y'),
                new InitialCell(1, 2, 5, Width, 'g'),
                new InitialCell(2, 0, 5, Width, 'r'),
                new InitialCell(2, 2, 5, Width, 'b'),
                new InitialCell(4, 0, 5, Width, 'r'),
                new InitialCell(4, 1, 5, Width, 'g'),
                new InitialCell(4, 2, 5, Width, 'y')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(1, 0, 5, Width, 'y'),
                new InitialCell(1, 1, 5, Width, 'g'),
                new InitialCell(1, 3, 5, Width, 'g'),
                new InitialCell(2, 0, 5, Width, 'b'),
                new InitialCell(3, 1, 5, Width, 'y'),
                new InitialCell(3, 2, 5, Width, 'r'),
                new InitialCell(3, 4, 5, Width, 'r'),
                new InitialCell(4, 4, 5, Width, 'b')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 5, Width, 'r'),
                new InitialCell(0, 4, 5, Width, 'r'),
                new InitialCell(1, 1, 5, Width, 'b'),
                new InitialCell(1, 2, 5, Width, 'g'),
                new InitialCell(1, 3, 5, Width, 'b'),
                new InitialCell(1, 4, 5, Width, 'y'),
                new InitialCell(3, 1, 5, Width, 'g'),
                new InitialCell(4, 3, 5, Width, 'y')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(1, 1, 5, Width, 'y'),
                new InitialCell(1, 3, 5, Width, 'b'),
                new InitialCell(2, 2, 5, Width, 'b'),
                new InitialCell(3, 2, 5, Width, 'r'),
                new InitialCell(3, 4, 5, Width, 'g'),
                new InitialCell(4, 0, 5, Width, 'r'),
                new InitialCell(4, 1, 5, Width, 'y'),
                new InitialCell(4, 2, 5, Width, 'g')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(1, 0, 5, Width, 'r'),
                new InitialCell(1, 1, 5, Width, 'b'),
                new InitialCell(1, 3, 5, Width, 'b'),
                new InitialCell(2, 3, 5, Width, 'g'),
                new InitialCell(3, 0, 5, Width, 'g'),
                new InitialCell(3, 3, 5, Width, 'y'),
                new InitialCell(4, 0, 5, Width, 'y'),
                new InitialCell(4, 2, 5, Width, 'r')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 5, Width, 'r'),
                new InitialCell(0, 2, 5, Width, 'g'),
                new InitialCell(0, 3, 5, Width, 'y'),
                new InitialCell(0, 4, 5, Width, 'b'),
                new InitialCell(1, 0, 5, Width, 'b'),
                new InitialCell(2, 2, 5, Width, 'g'),
                new InitialCell(3, 2, 5, Width, 'r'),
                new InitialCell(3, 3, 5, Width, 'y')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(1, 1, 5, Width, 'g'),
                new InitialCell(1, 2, 5, Width, 'r'),
                new InitialCell(1, 4, 5, Width, 'y'),
                new InitialCell(2, 4, 5, Width, 'o'),
                new InitialCell(3, 0, 5, Width, 'y'),
                new InitialCell(3, 1, 5, Width, 'b'),
                new InitialCell(3, 3, 5, Width, 'r'),
                new InitialCell(4, 0, 5, Width, 'b'),
                new InitialCell(4, 2, 5, Width, 'g'),
                new InitialCell(4, 3, 5, Width, 'o')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 5, Width, 'r'),
                new InitialCell(1, 1, 5, Width, 'o'),
                new InitialCell(1, 3, 5, Width, 'b'),
                new InitialCell(2, 0, 5, Width, 'r'),
                new InitialCell(2, 1, 5, Width, 'y'),
                new InitialCell(2, 2, 5, Width, 'b'),
                new InitialCell(3, 2, 5, Width, 'o'),
                new InitialCell(4, 0, 5, Width, 'y'),
                new InitialCell(4, 1, 5, Width, 'g'),
                new InitialCell(4, 4, 5, Width, 'g')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(1, 0, 5, Width, 'b'),
                new InitialCell(1, 1, 5, Width, 'g'),
                new InitialCell(1, 3, 5, Width, 'g'),
                new InitialCell(2, 0, 5, Width, 'r'),
                new InitialCell(3, 1, 5, Width, 'b'),
                new InitialCell(3, 3, 5, Width, 'r'),
                new InitialCell(3, 4, 5, Width, 'y'),
                new InitialCell(4, 3, 5, Width, 'y')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 5, Width, 'r'),
                new InitialCell(0, 4, 5, Width, 'r'),
                new InitialCell(2, 1, 5, Width, 'b'),
                new InitialCell(2, 2, 5, Width, 'y'),
                new InitialCell(2, 4, 5, Width, 'g'),
                new InitialCell(3, 4, 5, Width, 'y'),
                new InitialCell(4, 1, 5, Width, 'g'),
                new InitialCell(4, 4, 5, Width, 'b')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 5, Width, 'g'),
                new InitialCell(0, 1, 5, Width, 'r'),
                new InitialCell(0, 4, 5, Width, 'r'),
                new InitialCell(2, 3, 5, Width, 'o'),
                new InitialCell(2, 4, 5, Width, 'g'),
                new InitialCell(3, 0, 5, Width, 'o'),
                new InitialCell(3, 3, 5, Width, 'b'),
                new InitialCell(3, 4, 5, Width, 'y'),
                new InitialCell(4, 0, 5, Width, 'b'),
                new InitialCell(4, 2, 5, Width, 'y')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(1, 1, 5, Width, 'r'),
                new InitialCell(1, 3, 5, Width, 'r'),
                new InitialCell(2, 4, 5, Width, 'b'),
                new InitialCell(3, 0, 5, Width, 'b'),
                new InitialCell(3, 2, 5, Width, 'g'),
                new InitialCell(3, 4, 5, Width, 'y'),
                new InitialCell(4, 0, 5, Width, 'y'),
                new InitialCell(4, 4, 5, Width, 'g')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 2, 5, Width, 'g'),
                new InitialCell(0, 4, 5, Width, 'r'),
                new InitialCell(1, 1, 5, Width, 'r'),
                new InitialCell(1, 4, 5, Width, 'y'),
                new InitialCell(2, 1, 5, Width, 'b'),
                new InitialCell(2, 3, 5, Width, 'b'),
                new InitialCell(3, 1, 5, Width, 'y'),
                new InitialCell(4, 4, 5, Width, 'g')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(1, 0, 5, Width, 'o'),
                new InitialCell(1, 1, 5, Width, 'r'),
                new InitialCell(1, 3, 5, Width, 'r'),
                new InitialCell(1, 4, 5, Width, 'o'),
                new InitialCell(2, 0, 5, Width, 'y'),
                new InitialCell(3, 1, 5, Width, 'b'),
                new InitialCell(3, 3, 5, Width, 'g'),
                new InitialCell(4, 0, 5, Width, 'y'),
                new InitialCell(4, 1, 5, Width, 'g'),
                new InitialCell(4, 3, 5, Width, 'b')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 5, Width, 'g'),
                new InitialCell(1, 0, 5, Width, 'o'),
                new InitialCell(1, 1, 5, Width, 'r'),
                new InitialCell(1, 3, 5, Width, 'r'),
                new InitialCell(2, 3, 5, Width, 'o'),
                new InitialCell(2, 4, 5, Width, 'g'),
                new InitialCell(3, 0, 5, Width, 'b'),
                new InitialCell(3, 3, 5, Width, 'b'),
                new InitialCell(3, 4, 5, Width, 'y'),
                new InitialCell(4, 0, 5, Width, 'y')
            }),
            new Grid(5, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 5, Width, 'b'),
                new InitialCell(0, 4, 5, Width, 'y'),
                new InitialCell(2, 1, 5, Width, 'r'),
                new InitialCell(2, 2, 5, Width, 'g'),
                new InitialCell(3, 2, 5, Width, 'b'),
                new InitialCell(4, 0, 5, Width, 'g'),
                new InitialCell(4, 1, 5, Width, 'r'),
                new InitialCell(4, 2, 5, Width, 'y'),
            })
        };

        public static List<Grid> Levels6 = new List<Grid>
        {
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 6, Width, 'g'),
                new InitialCell(0, 1, 6, Width, 'y'),
                new InitialCell(0, 2, 6, Width, 'c'),
                new InitialCell(0, 4, 6, Width, 'r'),
                new InitialCell(0, 5, 6, Width, 'b'),
                new InitialCell(1, 4, 6, Width, 'o'),
                new InitialCell(2, 2, 6, Width, 'c'),
                new InitialCell(3, 2, 6, Width, 'r'),
                new InitialCell(4, 0, 6, Width, 'g'),
                new InitialCell(4, 2, 6, Width, 'o'),
                new InitialCell(5, 0, 6, Width, 'y'),
                new InitialCell(5, 2, 6, Width, 'b')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 6, Width, 'o'),
                new InitialCell(0, 2, 6, Width, 'b'),
                new InitialCell(0, 5, 6, Width, 'g'),
                new InitialCell(2, 2, 6, Width, 'y'),
                new InitialCell(2, 3, 6, Width, 'r'),
                new InitialCell(2, 5, 6, Width, 'g'),
                new InitialCell(3, 3, 6, Width, 'c'),
                new InitialCell(3, 5, 6, Width, 'b'),
                new InitialCell(4, 1, 6, Width, 'r'),
                new InitialCell(4, 2, 6, Width, 'y'),
                new InitialCell(4, 4, 6, Width, 'c'),
                new InitialCell(4, 5, 6, Width, 'o')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(1, 1, 6, Width, 'y'),
                new InitialCell(1, 4, 6, Width, 'g'),
                new InitialCell(2, 3, 6, Width, 'r'),
                new InitialCell(4, 2, 6, Width, 'y'),
                new InitialCell(4, 3, 6, Width, 'b'),
                new InitialCell(4, 4, 6, Width, 'g'),
                new InitialCell(5, 2, 6, Width, 'b'),
                new InitialCell(5, 3, 6, Width, 'r')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 6, Width, 'y'),
                new InitialCell(3, 0, 6, Width, 'r'),
                new InitialCell(3, 1, 6, Width, 'g'),
                new InitialCell(3, 2, 6, Width, 'b'),
                new InitialCell(3, 3, 6, Width, 'g'),
                new InitialCell(4, 0, 6, Width, 'y'),
                new InitialCell(4, 1, 6, Width, 'b'),
                new InitialCell(4, 3, 6, Width, 'r')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 6, Width, 'g'),
                new InitialCell(2, 0, 6, Width, 'y'),
                new InitialCell(2, 3, 6, Width, 'r'),
                new InitialCell(2, 4, 6, Width, 'y'),
                new InitialCell(3, 4, 6, Width, 'b'),
                new InitialCell(4, 1, 6, Width, 'b'),
                new InitialCell(4, 4, 6, Width, 'r'),
                new InitialCell(5, 4, 6, Width, 'g')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 3, 6, Width, 'r'),
                new InitialCell(0, 5, 6, Width, 'g'),
                new InitialCell(1, 1, 6, Width, 'o'),
                new InitialCell(1, 3, 6, Width, 'y'),
                new InitialCell(2, 4, 6, Width, 'r'),
                new InitialCell(2, 5, 6, Width, 'g'),
                new InitialCell(3, 2, 6, Width, 'b'),
                new InitialCell(3, 3, 6, Width, 'y'),
                new InitialCell(3, 4, 6, Width, 'c'),
                new InitialCell(3, 5, 6, Width, 'o'),
                new InitialCell(4, 2, 6, Width, 'c'),
                new InitialCell(5, 0, 6, Width, 'b')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 2, 6, Width, 'b'),
                new InitialCell(0, 3, 6, Width, 'y'),
                new InitialCell(1, 1, 6, Width, 'o'),
                new InitialCell(1, 2, 6, Width, 'g'),
                new InitialCell(1, 5, 6, Width, 'y'),
                new InitialCell(2, 3, 6, Width, 'b'),
                new InitialCell(2, 5, 6, Width, 'r'),
                new InitialCell(3, 2, 6, Width, 'o'),
                new InitialCell(4, 0, 6, Width, 'r'),
                new InitialCell(4, 4, 6, Width, 'g')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 4, 6, Width, 'b'),
                new InitialCell(0, 5, 6, Width, 'g'),
                new InitialCell(1, 2, 6, Width, 'r'),
                new InitialCell(2, 2, 6, Width, 'o'),
                new InitialCell(3, 2, 6, Width, 'y'),
                new InitialCell(3, 3, 6, Width, 'g'),
                new InitialCell(4, 1, 6, Width, 'r'),
                new InitialCell(4, 4, 6, Width, 'b'),
                new InitialCell(5, 1, 6, Width, 'o'),
                new InitialCell(5, 2, 6, Width, 'y')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 6, Width, 'r'),
                new InitialCell(0, 1, 6, Width, 'g'),
                new InitialCell(0, 5, 6, Width, 'g'),
                new InitialCell(1, 2, 6, Width, 'c'),
                new InitialCell(1, 5, 6, Width, 'c'),
                new InitialCell(2, 0, 6, Width, 'o'),
                new InitialCell(2, 5, 6, Width, 'r'),
                new InitialCell(3, 1, 6, Width, 'y'),
                new InitialCell(3, 5, 6, Width, 'y'),
                new InitialCell(4, 1, 6, Width, 'b'),
                new InitialCell(4, 5, 6, Width, 'b'),
                new InitialCell(5, 5, 6, Width, 'o')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 6, Width, 'r'),
                new InitialCell(1, 3, 6, Width, 'o'),
                new InitialCell(1, 4, 6, Width, 'b'),
                new InitialCell(1, 5, 6, Width, 'r'),
                new InitialCell(2, 3, 6, Width, 'y'),
                new InitialCell(2, 5, 6, Width, 'g'),
                new InitialCell(3, 2, 6, Width, 'g'),
                new InitialCell(4, 1, 6, Width, 'y'),
                new InitialCell(4, 2, 6, Width, 'o'),
                new InitialCell(4, 4, 6, Width, 'b')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(1, 1, 6, Width, 'b'),
                new InitialCell(1, 2, 6, Width, 'o'),
                new InitialCell(1, 4, 6, Width, 'o'),
                new InitialCell(1, 5, 6, Width, 'r'),
                new InitialCell(2, 5, 6, Width, 'b'),
                new InitialCell(3, 4, 6, Width, 'r'),
                new InitialCell(3, 5, 6, Width, 'g'),
                new InitialCell(4, 0, 6, Width, 'g'),
                new InitialCell(4, 1, 6, Width, 'y'),
                new InitialCell(4, 4, 6, Width, 'y')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 6, Width, 'g'),
                new InitialCell(0, 2, 6, Width, 'y'),
                new InitialCell(1, 1, 6, Width, 'b'),
                new InitialCell(1, 2, 6, Width, 'r'),
                new InitialCell(2, 3, 6, Width, 'b'),
                new InitialCell(3, 3, 6, Width, 'g'),
                new InitialCell(5, 0, 6, Width, 'r'),
                new InitialCell(5, 1, 6, Width, 'y')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 2, 6, Width, 'b'),
                new InitialCell(1, 1, 6, Width, 'g'),
                new InitialCell(1, 2, 6, Width, 'r'),
                new InitialCell(1, 4, 6, Width, 'y'),
                new InitialCell(2, 0, 6, Width, 'b'),
                new InitialCell(2, 5, 6, Width, 'r'),
                new InitialCell(4, 0, 6, Width, 'y'),
                new InitialCell(4, 1, 6, Width, 'o'),
                new InitialCell(4, 4, 6, Width, 'g'),
                new InitialCell(5, 0, 6, Width, 'o')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 4, 6, Width, 'o'),
                new InitialCell(1, 2, 6, Width, 'g'),
                new InitialCell(1, 4, 6, Width, 'b'),
                new InitialCell(3, 3, 6, Width, 'r'),
                new InitialCell(4, 5, 6, Width, 'o'),
                new InitialCell(5, 0, 6, Width, 'y'),
                new InitialCell(5, 1, 6, Width, 'g'),
                new InitialCell(5, 2, 6, Width, 'y'),
                new InitialCell(5, 3, 6, Width, 'r'),
                new InitialCell(5, 5, 6, Width, 'b')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 6, Width, 'y'),
                new InitialCell(1, 0, 6, Width, 'b'),
                new InitialCell(2, 0, 6, Width, 'r'),
                new InitialCell(2, 1, 6, Width, 'b'),
                new InitialCell(2, 3, 6, Width, 'g'),
                new InitialCell(2, 4, 6, Width, 'c'),
                new InitialCell(4, 3, 6, Width, 'o'),
                new InitialCell(4, 4, 6, Width, 'g'),
                new InitialCell(5, 0, 6, Width, 'r'),
                new InitialCell(5, 1, 6, Width, 'c'),
                new InitialCell(5, 2, 6, Width, 'o'),
                new InitialCell(5, 3, 6, Width, 'y')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 2, 6, Width, 'c'),
                new InitialCell(0, 3, 6, Width, 'b'),
                new InitialCell(1, 0, 6, Width, 'c'),
                new InitialCell(1, 4, 6, Width, 'y'),
                new InitialCell(2, 3, 6, Width, 'g'),
                new InitialCell(2, 4, 6, Width, 'o'),
                new InitialCell(3, 1, 6, Width, 'g'),
                new InitialCell(3, 3, 6, Width, 'r'),
                new InitialCell(4, 0, 6, Width, 'y'),
                new InitialCell(4, 1, 6, Width, 'r'),
                new InitialCell(4, 4, 6, Width, 'o'),
                new InitialCell(5, 0, 6, Width, 'b')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 6, Width, 'y'),
                new InitialCell(0, 5, 6, Width, 'r'),
                new InitialCell(1, 1, 6, Width, 'r'),
                new InitialCell(1, 3, 6, Width, 'b'),
                new InitialCell(2, 1, 6, Width, 'c'),
                new InitialCell(2, 3, 6, Width, 'g'),
                new InitialCell(2, 4, 6, Width, 'o'),
                new InitialCell(3, 2, 6, Width, 'c'),
                new InitialCell(4, 0, 6, Width, 'g'),
                new InitialCell(4, 2, 6, Width, 'y'),
                new InitialCell(4, 4, 6, Width, 'o'),
                new InitialCell(5, 4, 6, Width, 'b')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 5, 6, Width, 'o'),
                new InitialCell(1, 1, 6, Width, 'g'),
                new InitialCell(1, 5, 6, Width, 'y'),
                new InitialCell(2, 1, 6, Width, 'r'),
                new InitialCell(2, 3, 6, Width, 'r'),
                new InitialCell(4, 2, 6, Width, 'b'),
                new InitialCell(4, 4, 6, Width, 'b'),
                new InitialCell(5, 0, 6, Width, 'o'),
                new InitialCell(5, 2, 6, Width, 'g'),
                new InitialCell(5, 3, 6, Width, 'y')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 6, Width, 'g'),
                new InitialCell(0, 1, 6, Width, 'o'),
                new InitialCell(0, 5, 6, Width, 'b'),
                new InitialCell(1, 5, 6, Width, 'r'),
                new InitialCell(2, 2, 6, Width, 'b'),
                new InitialCell(2, 3, 6, Width, 'r'),
                new InitialCell(2, 4, 6, Width, 'g'),
                new InitialCell(3, 4, 6, Width, 'o'),
                new InitialCell(4, 1, 6, Width, 'y'),
                new InitialCell(4, 4, 6, Width, 'y')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 6, Width, 'b'),
                new InitialCell(2, 4, 6, Width, 'y'),
                new InitialCell(3, 2, 6, Width, 'y'),
                new InitialCell(3, 3, 6, Width, 'g'),
                new InitialCell(3, 4, 6, Width, 'r'),
                new InitialCell(4, 1, 6, Width, 'g'),
                new InitialCell(4, 3, 6, Width, 'r'),
                new InitialCell(5, 3, 6, Width, 'b')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 6, Width, 'b'),
                new InitialCell(0, 1, 6, Width, 'r'),
                new InitialCell(0, 3, 6, Width, 'o'),
                new InitialCell(0, 4, 6, Width, 'c'),
                new InitialCell(0, 5, 6, Width, 'g'),
                new InitialCell(1, 1, 6, Width, 'b'),
                new InitialCell(2, 0, 6, Width, 'y'),
                new InitialCell(2, 1, 6, Width, 'r'),
                new InitialCell(2, 3, 6, Width, 'o'),
                new InitialCell(3, 3, 6, Width, 'y'),
                new InitialCell(5, 0, 6, Width, 'c'),
                new InitialCell(5, 1, 6, Width, 'g')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 6, Width, 'b'),
                new InitialCell(0, 5, 6, Width, 'r'),
                new InitialCell(1, 0, 6, Width, 'y'),
                new InitialCell(2, 0, 6, Width, 'o'),
                new InitialCell(2, 1, 6, Width, 'g'),
                new InitialCell(3, 2, 6, Width, 'g'),
                new InitialCell(3, 3, 6, Width, 'y'),
                new InitialCell(4, 0, 6, Width, 'r'),
                new InitialCell(4, 2, 6, Width, 'o'),
                new InitialCell(4, 3, 6, Width, 'b')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 5, 6, Width, 'g'),
                new InitialCell(1, 5, 6, Width, 'b'),
                new InitialCell(2, 2, 6, Width, 'y'),
                new InitialCell(2, 4, 6, Width, 'y'),
                new InitialCell(2, 5, 6, Width, 'r'),
                new InitialCell(3, 2, 6, Width, 'r'),
                new InitialCell(4, 5, 6, Width, 'b'),
                new InitialCell(5, 5, 6, Width, 'g')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 6, Width, 'g'),
                new InitialCell(0, 2, 6, Width, 'r'),
                new InitialCell(0, 5, 6, Width, 'c'),
                new InitialCell(1, 0, 6, Width, 'o'),
                new InitialCell(1, 2, 6, Width, 'g'),
                new InitialCell(1, 3, 6, Width, 'o'),
                new InitialCell(3, 1, 6, Width, 'y'),
                new InitialCell(3, 2, 6, Width, 'b'),
                new InitialCell(4, 1, 6, Width, 'b'),
                new InitialCell(4, 3, 6, Width, 'r'),
                new InitialCell(4, 4, 6, Width, 'y'),
                new InitialCell(5, 5, 6, Width, 'c')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 6, Width, 'g'),
                new InitialCell(0, 2, 6, Width, 'o'),
                new InitialCell(0, 5, 6, Width, 'o'),
                new InitialCell(1, 5, 6, Width, 'r'),
                new InitialCell(2, 2, 6, Width, 'c'),
                new InitialCell(2, 3, 6, Width, 'b'),
                new InitialCell(2, 5, 6, Width, 'b'),
                new InitialCell(3, 3, 6, Width, 'y'),
                new InitialCell(3, 4, 6, Width, 'c'),
                new InitialCell(4, 4, 6, Width, 'y'),
                new InitialCell(5, 0, 6, Width, 'g'),
                new InitialCell(5, 1, 6, Width, 'r')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 6, Width, 'r'),
                new InitialCell(1, 0, 6, Width, 'g'),
                new InitialCell(2, 3, 6, Width, 'o'),
                new InitialCell(3, 0, 6, Width, 'o'),
                new InitialCell(3, 3, 6, Width, 'b'),
                new InitialCell(4, 2, 6, Width, 'y'),
                new InitialCell(4, 3, 6, Width, 'g'),
                new InitialCell(5, 0, 6, Width, 'b'),
                new InitialCell(5, 1, 6, Width, 'y'),
                new InitialCell(5, 3, 6, Width, 'r')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 6, Width, 'o'),
                new InitialCell(1, 0, 6, Width, 'y'),
                new InitialCell(1, 4, 6, Width, 'r'),
                new InitialCell(1, 5, 6, Width, 'g'),
                new InitialCell(2, 4, 6, Width, 'b'),
                new InitialCell(4, 1, 6, Width, 'o'),
                new InitialCell(4, 4, 6, Width, 'r'),
                new InitialCell(5, 2, 6, Width, 'y'),
                new InitialCell(5, 3, 6, Width, 'g'),
                new InitialCell(5, 4, 6, Width, 'b')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 6, Width, 'y'),
                new InitialCell(0, 1, 6, Width, 'r'),
                new InitialCell(1, 1, 6, Width, 'b'),
                new InitialCell(2, 3, 6, Width, 'y'),
                new InitialCell(4, 1, 6, Width, 'g'),
                new InitialCell(4, 4, 6, Width, 'g'),
                new InitialCell(5, 0, 6, Width, 'b'),
                new InitialCell(5, 1, 6, Width, 'r')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(1, 0, 6, Width, 'b'),
                new InitialCell(1, 1, 6, Width, 'r'),
                new InitialCell(1, 2, 6, Width, 'y'),
                new InitialCell(1, 3, 6, Width, 'o'),
                new InitialCell(2, 0, 6, Width, 'r'),
                new InitialCell(2, 3, 6, Width, 'g'),
                new InitialCell(3, 0, 6, Width, 'g'),
                new InitialCell(3, 5, 6, Width, 'b'),
                new InitialCell(4, 1, 6, Width, 'y'),
                new InitialCell(4, 4, 6, Width, 'o'),
                new InitialCell(4, 5, 6, Width, 'c'),
                new InitialCell(5, 3, 6, Width, 'c')
            }),
            new Grid(6, Width, Width, new List<Cell>
            {
                new InitialCell(1, 0, 6, Width, 'r'),
                new InitialCell(1, 1, 6, Width, 'b'),
                new InitialCell(1, 3, 6, Width, 'g'),
                new InitialCell(2, 1, 6, Width, 'y'),
                new InitialCell(3, 1, 6, Width, 'o'),
                new InitialCell(3, 5, 6, Width, 'r'),
                new InitialCell(4, 1, 6, Width, 'y'),
                new InitialCell(4, 4, 6, Width, 'g'),
                new InitialCell(4, 5, 6, Width, 'b'),
                new InitialCell(5, 0, 6, Width, 'o')
            })
        };

        public static List<Grid> Levels7 = new List<Grid>
        {
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 6, 7, Width, 'b'),
                new InitialCell(1, 5, 7, Width, 'o'),
                new InitialCell(1, 6, 7, Width, 'r'),
                new InitialCell(2, 1, 7, Width, 'o'),
                new InitialCell(3, 3, 7, Width, 'g'),
                new InitialCell(3, 4, 7, Width, 'c'),
                new InitialCell(4, 2, 7, Width, 'g'),
                new InitialCell(4, 4, 7, Width, 'y'),
                new InitialCell(5, 4, 7, Width, 'r'),
                new InitialCell(5, 5, 7, Width, 'y'),
                new InitialCell(6, 5, 7, Width, 'b'),
                new InitialCell(6, 6, 7, Width, 'c')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 7, Width, 'm'),
                new InitialCell(0, 2, 7, Width, 'r'),
                new InitialCell(1, 2, 7, Width, 'o'),
                new InitialCell(1, 3, 7, Width, 'b'),
                new InitialCell(1, 5, 7, Width, 'b'),
                new InitialCell(2, 2, 7, Width, 'g'),
                new InitialCell(3, 2, 7, Width, 'c'),
                new InitialCell(3, 3, 7, Width, 'y'),
                new InitialCell(3, 5, 7, Width, 'g'),
                new InitialCell(4, 4, 7, Width, 'y'),
                new InitialCell(4, 5, 7, Width, 'c'),
                new InitialCell(5, 2, 7, Width, 'o'),
                new InitialCell(6, 2, 7, Width, 'm'),
                new InitialCell(6, 3, 7, Width, 'r')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 7, Width, 'c'),
                new InitialCell(1, 0, 7, Width, 'y'),
                new InitialCell(1, 6, 7, Width, 'c'),
                new InitialCell(2, 0, 7, Width, 'm'),
                new InitialCell(2, 2, 7, Width, 'm'),
                new InitialCell(2, 3, 7, Width, 'o'),
                new InitialCell(2, 4, 7, Width, 'g'),
                new InitialCell(2, 6, 7, Width, 'y'),
                new InitialCell(3, 0, 7, Width, 'n'),
                new InitialCell(3, 2, 7, Width, 'r'),
                new InitialCell(3, 6, 7, Width, 'g'),
                new InitialCell(4, 0, 7, Width, 'b'),
                new InitialCell(4, 5, 7, Width, 'o'),
                new InitialCell(4, 6, 7, Width, 'r'),
                new InitialCell(5, 1, 7, Width, 'n'),
                new InitialCell(6, 6, 7, Width, 'b')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(1, 0, 7, Width, 'g'),
                new InitialCell(2, 2, 7, Width, 'y'),
                new InitialCell(3, 4, 7, Width, 'y'),
                new InitialCell(4, 2, 7, Width, 'o'),
                new InitialCell(4, 4, 7, Width, 'b'),
                new InitialCell(5, 0, 7, Width, 'r'),
                new InitialCell(5, 1, 7, Width, 'b'),
                new InitialCell(5, 4, 7, Width, 'o'),
                new InitialCell(5, 5, 7, Width, 'r'),
                new InitialCell(6, 0, 7, Width, 'g')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 7, Width, 'c'),
                new InitialCell(0, 1, 7, Width, 'b'),
                new InitialCell(0, 2, 7, Width, 'y'),
                new InitialCell(1, 5, 7, Width, 'g'),
                new InitialCell(2, 1, 7, Width, 'r'),
                new InitialCell(2, 3, 7, Width, 'y'),
                new InitialCell(3, 1, 7, Width, 'o'),
                new InitialCell(3, 4, 7, Width, 'b'),
                new InitialCell(4, 2, 7, Width, 'r'),
                new InitialCell(4, 4, 7, Width, 'g'),
                new InitialCell(6, 1, 7, Width, 'c'),
                new InitialCell(6, 6, 7, Width, 'o')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(1, 0, 7, Width, 'c'),
                new InitialCell(1, 1, 7, Width, 'r'),
                new InitialCell(1, 3, 7, Width, 'r'),
                new InitialCell(1, 5, 7, Width, 'g'),
                new InitialCell(2, 2, 7, Width, 'm'),
                new InitialCell(2, 3, 7, Width, 'c'),
                new InitialCell(2, 4, 7, Width, 'g'),
                new InitialCell(3, 2, 7, Width, 'y'),
                new InitialCell(3, 6, 7, Width, 'b'),
                new InitialCell(4, 2, 7, Width, 'o'),
                new InitialCell(5, 4, 7, Width, 'y'),
                new InitialCell(5, 6, 7, Width, 'b'),
                new InitialCell(6, 4, 7, Width, 'm'),
                new InitialCell(6, 6, 7, Width, 'o')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(1, 0, 7, Width, 'g'),
                new InitialCell(1, 1, 7, Width, 'r'),
                new InitialCell(1, 5, 7, Width, 'r'),
                new InitialCell(2, 0, 7, Width, 'o'),
                new InitialCell(2, 1, 7, Width, 'g'),
                new InitialCell(3, 1, 7, Width, 'b'),
                new InitialCell(3, 3, 7, Width, 'b'),
                new InitialCell(4, 1, 7, Width, 'y'),
                new InitialCell(4, 2, 7, Width, 'o'),
                new InitialCell(4, 5, 7, Width, 'y')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 4, 7, Width, 'g'),
                new InitialCell(0, 6, 7, Width, 'c'),
                new InitialCell(1, 1, 7, Width, 'c'),
                new InitialCell(1, 6, 7, Width, 'o'),
                new InitialCell(3, 2, 7, Width, 'y'),
                new InitialCell(3, 3, 7, Width, 'r'),
                new InitialCell(3, 6, 7, Width, 'r'),
                new InitialCell(4, 3, 7, Width, 'b'),
                new InitialCell(4, 6, 7, Width, 'b'),
                new InitialCell(5, 1, 7, Width, 'o'),
                new InitialCell(5, 2, 7, Width, 'y'),
                new InitialCell(5, 3, 7, Width, 'm'),
                new InitialCell(6, 5, 7, Width, 'g'),
                new InitialCell(6, 6, 7, Width, 'm')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 5, 7, Width, 'o'),
                new InitialCell(0, 6, 7, Width, 'r'),
                new InitialCell(1, 0, 7, Width, 'o'),
                new InitialCell(1, 1, 7, Width, 'c'),
                new InitialCell(1, 2, 7, Width, 'g'),
                new InitialCell(2, 4, 7, Width, 'b'),
                new InitialCell(2, 6, 7, Width, 'b'),
                new InitialCell(3, 1, 7, Width, 'y'),
                new InitialCell(3, 6, 7, Width, 'r'),
                new InitialCell(4, 5, 7, Width, 'g'),
                new InitialCell(4, 6, 7, Width, 'c'),
                new InitialCell(5, 5, 7, Width, 'y')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 7, Width, 'c'),
                new InitialCell(1, 1, 7, Width, 'o'),
                new InitialCell(2, 4, 7, Width, 'b'),
                new InitialCell(3, 3, 7, Width, 'r'),
                new InitialCell(4, 3, 7, Width, 'y'),
                new InitialCell(5, 2, 7, Width, 'g'),
                new InitialCell(5, 5, 7, Width, 'r'),
                new InitialCell(6, 0, 7, Width, 'c'),
                new InitialCell(6, 2, 7, Width, 'o'),
                new InitialCell(6, 3, 7, Width, 'y'),
                new InitialCell(6, 4, 7, Width, 'b'),
                new InitialCell(6, 5, 7, Width, 'g')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(1, 0, 7, Width, 'b'),
                new InitialCell(1, 1, 7, Width, 'm'),
                new InitialCell(1, 2, 7, Width, 'c'),
                new InitialCell(1, 5, 7, Width, 'r'),
                new InitialCell(2, 3, 7, Width, 'b'),
                new InitialCell(3, 1, 7, Width, 'o'),
                new InitialCell(3, 3, 7, Width, 'c'),
                new InitialCell(3, 4, 7, Width, 'y'),
                new InitialCell(4, 0, 7, Width, 'm'),
                new InitialCell(5, 0, 7, Width, 'y'),
                new InitialCell(5, 1, 7, Width, 'g'),
                new InitialCell(5, 3, 7, Width, 'g'),
                new InitialCell(5, 4, 7, Width, 'o'),
                new InitialCell(5, 5, 7, Width, 'r')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(1, 5, 7, Width, 'r'),
                new InitialCell(2, 0, 7, Width, 'g'),
                new InitialCell(2, 1, 7, Width, 'r'),
                new InitialCell(2, 2, 7, Width, 'o'),
                new InitialCell(2, 3, 7, Width, 'g'),
                new InitialCell(3, 0, 7, Width, 'c'),
                new InitialCell(3, 1, 7, Width, 'm'),
                new InitialCell(3, 6, 7, Width, 'y'),
                new InitialCell(4, 3, 7, Width, 'y'),
                new InitialCell(5, 5, 7, Width, 'b'),
                new InitialCell(6, 0, 7, Width, 'c'),
                new InitialCell(6, 1, 7, Width, 'm'),
                new InitialCell(6, 2, 7, Width, 'b'),
                new InitialCell(6, 6, 7, Width, 'o')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 5, 7, Width, 'y'),
                new InitialCell(0, 6, 7, Width, 'o'),
                new InitialCell(1, 1, 7, Width, 'r'),
                new InitialCell(1, 2, 7, Width, 'b'),
                new InitialCell(1, 4, 7, Width, 'b'),
                new InitialCell(1, 5, 7, Width, 'r'),
                new InitialCell(2, 4, 7, Width, 'c'),
                new InitialCell(3, 3, 7, Width, 'c'),
                new InitialCell(3, 6, 7, Width, 'o'),
                new InitialCell(4, 0, 7, Width, 'g'),
                new InitialCell(4, 6, 7, Width, 'y'),
                new InitialCell(5, 6, 7, Width, 'g')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(1, 1, 7, Width, 'o'),
                new InitialCell(1, 2, 7, Width, 'n'),
                new InitialCell(1, 3, 7, Width, 'r'),
                new InitialCell(1, 4, 7, Width, 'c'),
                new InitialCell(1, 5, 7, Width, 'm'),
                new InitialCell(2, 2, 7, Width, 'g'),
                new InitialCell(2, 6, 7, Width, 'r'),
                new InitialCell(3, 1, 7, Width, 'o'),
                new InitialCell(3, 2, 7, Width, 'b'),
                new InitialCell(4, 1, 7, Width, 'b'),
                new InitialCell(4, 3, 7, Width, 'g'),
                new InitialCell(4, 5, 7, Width, 'y'),
                new InitialCell(5, 1, 7, Width, 'n'),
                new InitialCell(6, 0, 7, Width, 'c'),
                new InitialCell(6, 3, 7, Width, 'y'),
                new InitialCell(6, 6, 7, Width, 'm')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 7, Width, 'r'),
                new InitialCell(0, 5, 7, Width, 'y'),
                new InitialCell(0, 6, 7, Width, 'g'),
                new InitialCell(1, 0, 7, Width, 'y'),
                new InitialCell(2, 1, 7, Width, 'b'),
                new InitialCell(2, 2, 7, Width, 'o'),
                new InitialCell(3, 4, 7, Width, 'r'),
                new InitialCell(4, 0, 7, Width, 'g'),
                new InitialCell(4, 2, 7, Width, 'o'),
                new InitialCell(4, 4, 7, Width, 'b')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(1, 0, 7, Width, 'b'),
                new InitialCell(1, 1, 7, Width, 'g'),
                new InitialCell(2, 0, 7, Width, 'y'),
                new InitialCell(2, 4, 7, Width, 'y'),
                new InitialCell(3, 6, 7, Width, 'b'),
                new InitialCell(4, 1, 7, Width, 'r'),
                new InitialCell(5, 3, 7, Width, 'g'),
                new InitialCell(5, 5, 7, Width, 'o'),
                new InitialCell(6, 0, 7, Width, 'o'),
                new InitialCell(6, 5, 7, Width, 'r')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 6, 7, Width, 'r'),
                new InitialCell(1, 1, 7, Width, 'm'),
                new InitialCell(2, 1, 7, Width, 'b'),
                new InitialCell(2, 4, 7, Width, 'm'),
                new InitialCell(3, 1, 7, Width, 'o'),
                new InitialCell(3, 2, 7, Width, 'y'),
                new InitialCell(3, 4, 7, Width, 'b'),
                new InitialCell(3, 5, 7, Width, 'o'),
                new InitialCell(4, 1, 7, Width, 'c'),
                new InitialCell(4, 5, 7, Width, 'r'),
                new InitialCell(5, 1, 7, Width, 'g'),
                new InitialCell(5, 5, 7, Width, 'y'),
                new InitialCell(5, 6, 7, Width, 'g'),
                new InitialCell(6, 2, 7, Width, 'c')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(1, 1, 7, Width, 'g'),
                new InitialCell(1, 5, 7, Width, 'y'),
                new InitialCell(2, 2, 7, Width, 'y'),
                new InitialCell(2, 5, 7, Width, 'b'),
                new InitialCell(2, 6, 7, Width, 'r'),
                new InitialCell(3, 6, 7, Width, 'm'),
                new InitialCell(4, 5, 7, Width, 'o'),
                new InitialCell(4, 6, 7, Width, 'c'),
                new InitialCell(5, 0, 7, Width, 'm'),
                new InitialCell(5, 1, 7, Width, 'r'),
                new InitialCell(5, 2, 7, Width, 'g'),
                new InitialCell(5, 3, 7, Width, 'b'),
                new InitialCell(6, 5, 7, Width, 'o'),
                new InitialCell(6, 6, 7, Width, 'c')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 3, 7, Width, 'y'),
                new InitialCell(1, 5, 7, Width, 'c'),
                new InitialCell(3, 5, 7, Width, 'g'),
                new InitialCell(3, 6, 7, Width, 'r'),
                new InitialCell(4, 3, 7, Width, 'g'),
                new InitialCell(4, 5, 7, Width, 'c'),
                new InitialCell(4, 6, 7, Width, 'b'),
                new InitialCell(5, 5, 7, Width, 'o'),
                new InitialCell(6, 0, 7, Width, 'y'),
                new InitialCell(6, 1, 7, Width, 'r'),
                new InitialCell(6, 2, 7, Width, 'o'),
                new InitialCell(6, 6, 7, Width, 'b')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 7, Width, 'g'),
                new InitialCell(0, 2, 7, Width, 'g'),
                new InitialCell(0, 3, 7, Width, 'r'),
                new InitialCell(1, 2, 7, Width, 'r'),
                new InitialCell(1, 3, 7, Width, 'o'),
                new InitialCell(2, 1, 7, Width, 'b'),
                new InitialCell(2, 4, 7, Width, 'y'),
                new InitialCell(3, 1, 7, Width, 'y'),
                new InitialCell(3, 3, 7, Width, 'b'),
                new InitialCell(4, 1, 7, Width, 'o')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 7, Width, 'b'),
                new InitialCell(0, 4, 7, Width, 'o'),
                new InitialCell(1, 0, 7, Width, 'g'),
                new InitialCell(1, 4, 7, Width, 'b'),
                new InitialCell(1, 5, 7, Width, 'r'),
                new InitialCell(2, 0, 7, Width, 'y'),
                new InitialCell(2, 3, 7, Width, 'o'),
                new InitialCell(3, 0, 7, Width, 'c'),
                new InitialCell(3, 1, 7, Width, 'y'),
                new InitialCell(3, 3, 7, Width, 'g'),
                new InitialCell(5, 2, 7, Width, 'r'),
                new InitialCell(6, 0, 7, Width, 'c')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 7, Width, 'r'),
                new InitialCell(1, 2, 7, Width, 'g'),
                new InitialCell(1, 3, 7, Width, 'r'),
                new InitialCell(1, 4, 7, Width, 'b'),
                new InitialCell(1, 5, 7, Width, 'm'),
                new InitialCell(2, 0, 7, Width, 'g'),
                new InitialCell(3, 2, 7, Width, 'b'),
                new InitialCell(4, 5, 7, Width, 'c'),
                new InitialCell(4, 6, 7, Width, 'o'),
                new InitialCell(5, 0, 7, Width, 'm'),
                new InitialCell(5, 1, 7, Width, 'c'),
                new InitialCell(5, 2, 7, Width, 'y'),
                new InitialCell(5, 5, 7, Width, 'y'),
                new InitialCell(6, 0, 7, Width, 'o')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 7, Width, 'g'),
                new InitialCell(0, 4, 7, Width, 'r'),
                new InitialCell(0, 6, 7, Width, 'c'),
                new InitialCell(1, 6, 7, Width, 'o'),
                new InitialCell(3, 3, 7, Width, 'o'),
                new InitialCell(3, 4, 7, Width, 'y'),
                new InitialCell(4, 3, 7, Width, 'c'),
                new InitialCell(4, 4, 7, Width, 'g'),
                new InitialCell(4, 5, 7, Width, 'b'),
                new InitialCell(5, 3, 7, Width, 'r'),
                new InitialCell(6, 5, 7, Width, 'b'),
                new InitialCell(6, 6, 7, Width, 'y')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 6, 7, Width, 'o'),
                new InitialCell(1, 5, 7, Width, 'c'),
                new InitialCell(1, 6, 7, Width, 'g'),
                new InitialCell(2, 0, 7, Width, 'o'),
                new InitialCell(3, 3, 7, Width, 'y'),
                new InitialCell(4, 1, 7, Width, 'g'),
                new InitialCell(4, 6, 7, Width, 'y'),
                new InitialCell(5, 4, 7, Width, 'b'),
                new InitialCell(5, 6, 7, Width, 'c'),
                new InitialCell(6, 0, 7, Width, 'r'),
                new InitialCell(6, 3, 7, Width, 'r'),
                new InitialCell(6, 6, 7, Width, 'b')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 7, Width, 'g'),
                new InitialCell(0, 1, 7, Width, 'r'),
                new InitialCell(0, 6, 7, Width, 'y'),
                new InitialCell(1, 1, 7, Width, 'y'),
                new InitialCell(1, 5, 7, Width, 'r'),
                new InitialCell(2, 1, 7, Width, 'b'),
                new InitialCell(3, 1, 7, Width, 'o'),
                new InitialCell(4, 1, 7, Width, 'c'),
                new InitialCell(5, 5, 7, Width, 'o'),
                new InitialCell(6, 3, 7, Width, 'g'),
                new InitialCell(6, 4, 7, Width, 'c'),
                new InitialCell(6, 5, 7, Width, 'b')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 7, Width, 'g'),
                new InitialCell(0, 2, 7, Width, 'b'),
                new InitialCell(1, 5, 7, Width, 'o'),
                new InitialCell(2, 2, 7, Width, 'r'),
                new InitialCell(4, 1, 7, Width, 'g'),
                new InitialCell(4, 5, 7, Width, 'o'),
                new InitialCell(5, 0, 7, Width, 'y'),
                new InitialCell(5, 3, 7, Width, 'r'),
                new InitialCell(5, 5, 7, Width, 'y'),
                new InitialCell(6, 0, 7, Width, 'b')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 3, 7, Width, 'b'),
                new InitialCell(0, 4, 7, Width, 'r'),
                new InitialCell(1, 4, 7, Width, 'y'),
                new InitialCell(1, 5, 7, Width, 'g'),
                new InitialCell(2, 1, 7, Width, 'o'),
                new InitialCell(2, 2, 7, Width, 'y'),
                new InitialCell(3, 1, 7, Width, 'r'),
                new InitialCell(3, 3, 7, Width, 'o'),
                new InitialCell(4, 5, 7, Width, 'g'),
                new InitialCell(6, 6, 7, Width, 'b')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 7, Width, 'm'),
                new InitialCell(0, 2, 7, Width, 'g'),
                new InitialCell(0, 5, 7, Width, 'b'),
                new InitialCell(1, 0, 7, Width, 'y'),
                new InitialCell(1, 3, 7, Width, 'm'),
                new InitialCell(1, 5, 7, Width, 'r'),
                new InitialCell(2, 3, 7, Width, 'y'),
                new InitialCell(3, 3, 7, Width, 'r'),
                new InitialCell(3, 4, 7, Width, 'g'),
                new InitialCell(4, 0, 7, Width, 'c'),
                new InitialCell(4, 1, 7, Width, 'o'),
                new InitialCell(5, 5, 7, Width, 'c'),
                new InitialCell(6, 0, 7, Width, 'o'),
                new InitialCell(6, 1, 7, Width, 'b')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(2, 1, 7, Width, 'r'),
                new InitialCell(2, 2, 7, Width, 'b'),
                new InitialCell(2, 4, 7, Width, 'b'),
                new InitialCell(3, 1, 7, Width, 'c'),
                new InitialCell(4, 3, 7, Width, 'g'),
                new InitialCell(4, 4, 7, Width, 'c'),
                new InitialCell(4, 5, 7, Width, 'r'),
                new InitialCell(5, 0, 7, Width, 'g'),
                new InitialCell(5, 1, 7, Width, 'y'),
                new InitialCell(5, 3, 7, Width, 'o'),
                new InitialCell(5, 4, 7, Width, 'y'),
                new InitialCell(6, 6, 7, Width, 'o')
            }),
            new Grid(7, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 7, Width, 'o'),
                new InitialCell(0, 2, 7, Width, 'g'),
                new InitialCell(0, 4, 7, Width, 'g'),
                new InitialCell(0, 5, 7, Width, 'b'),
                new InitialCell(1, 0, 7, Width, 'y'),
                new InitialCell(1, 2, 7, Width, 'm'),
                new InitialCell(1, 5, 7, Width, 'c'),
                new InitialCell(2, 4, 7, Width, 'm'),
                new InitialCell(3, 4, 7, Width, 'c'),
                new InitialCell(3, 6, 7, Width, 'b'),
                new InitialCell(4, 0, 7, Width, 'o'),
                new InitialCell(4, 1, 7, Width, 'r'),
                new InitialCell(4, 2, 7, Width, 'y'),
                new InitialCell(5, 5, 7, Width, 'r')
            })
        };

        public static List<Grid> Levels8 = new List<Grid>
        {
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 4, 8, Width, 'r'),
                new InitialCell(1, 4, 8, Width, 'c'),
                new InitialCell(1, 6, 8, Width, 'g'),
                new InitialCell(1, 7, 8, Width, 'y'),
                new InitialCell(2, 4, 8, Width, 'g'),
                new InitialCell(2, 5, 8, Width, 'y'),
                new InitialCell(2, 7, 8, Width, 'c'),
                new InitialCell(3, 3, 8, Width, 'o'),
                new InitialCell(3, 4, 8, Width, 'b'),
                new InitialCell(4, 4, 8, Width, 'o'),
                new InitialCell(5, 4, 8, Width, 'b'),
                new InitialCell(7, 1, 8, Width, 'r')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 8, Width, 'r'),
                new InitialCell(0, 1, 8, Width, 'b'),
                new InitialCell(0, 2, 8, Width, 'c'),
                new InitialCell(1, 6, 8, Width, 'o'),
                new InitialCell(3, 0, 8, Width, 'y'),
                new InitialCell(3, 2, 8, Width, 'y'),
                new InitialCell(3, 3, 8, Width, 'g'),
                new InitialCell(5, 0, 8, Width, 'g'),
                new InitialCell(5, 5, 8, Width, 'b'),
                new InitialCell(7, 0, 8, Width, 'r'),
                new InitialCell(7, 1, 8, Width, 'o'),
                new InitialCell(7, 3, 8, Width, 'c')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 8, Width, 'r'),
                new InitialCell(1, 3, 8, Width, 'y'),
                new InitialCell(1, 6, 8, Width, 'y'),
                new InitialCell(2, 2, 8, Width, 'b'),
                new InitialCell(4, 3, 8, Width, 'r'),
                new InitialCell(4, 4, 8, Width, 'c'),
                new InitialCell(4, 7, 8, Width, 'g'),
                new InitialCell(5, 3, 8, Width, 'o'),
                new InitialCell(5, 7, 8, Width, 'b'),
                new InitialCell(6, 1, 8, Width, 'c'),
                new InitialCell(7, 6, 8, Width, 'o'),
                new InitialCell(7, 7, 8, Width, 'g')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 8, Width, 'y'),
                new InitialCell(1, 6, 8, Width, 'c'),
                new InitialCell(1, 7, 8, Width, 'g'),
                new InitialCell(2, 3, 8, Width, 'm'),
                new InitialCell(3, 1, 8, Width, 'g'),
                new InitialCell(3, 6, 8, Width, 'c'),
                new InitialCell(3, 7, 8, Width, 'm'),
                new InitialCell(4, 4, 8, Width, 'r'),
                new InitialCell(4, 7, 8, Width, 'o'),
                new InitialCell(5, 2, 8, Width, 'o'),
                new InitialCell(5, 7, 8, Width, 'b'),
                new InitialCell(6, 2, 8, Width, 'r'),
                new InitialCell(6, 3, 8, Width, 'b'),
                new InitialCell(6, 7, 8, Width, 'y')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 7, 8, Width, 'c'),
                new InitialCell(1, 1, 8, Width, 'b'),
                new InitialCell(1, 2, 8, Width, 'o'),
                new InitialCell(2, 7, 8, Width, 'o'),
                new InitialCell(3, 3, 8, Width, 'c'),
                new InitialCell(3, 5, 8, Width, 'g'),
                new InitialCell(4, 5, 8, Width, 'y'),
                new InitialCell(4, 6, 8, Width, 'r'),
                new InitialCell(4, 7, 8, Width, 'b'),
                new InitialCell(5, 7, 8, Width, 'y'),
                new InitialCell(6, 2, 8, Width, 'r'),
                new InitialCell(7, 0, 8, Width, 'g')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 8, Width, 'r'),
                new InitialCell(0, 7, 8, Width, 'b'),
                new InitialCell(1, 0, 8, Width, 'm'),
                new InitialCell(1, 4, 8, Width, 'o'),
                new InitialCell(2, 0, 8, Width, 'y'),
                new InitialCell(4, 6, 8, Width, 'b'),
                new InitialCell(4, 7, 8, Width, 'o'),
                new InitialCell(5, 4, 8, Width, 'm'),
                new InitialCell(5, 7, 8, Width, 'r'),
                new InitialCell(6, 1, 8, Width, 'g'),
                new InitialCell(6, 2, 8, Width, 'c'),
                new InitialCell(7, 1, 8, Width, 'y'),
                new InitialCell(7, 6, 8, Width, 'c'),
                new InitialCell(7, 7, 8, Width, 'g')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(1, 4, 8, Width, 'r'),
                new InitialCell(1, 5, 8, Width, 'b'),
                new InitialCell(1, 6, 8, Width, 'y'),
                new InitialCell(2, 2, 8, Width, 'g'),
                new InitialCell(4, 4, 8, Width, 'o'),
                new InitialCell(5, 2, 8, Width, 'g'),
                new InitialCell(5, 4, 8, Width, 'b'),
                new InitialCell(5, 5, 8, Width, 'r'),
                new InitialCell(6, 5, 8, Width, 'y'),
                new InitialCell(7, 7, 8, Width, 'o')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 5, 8, Width, 'c'),
                new InitialCell(0, 6, 8, Width, 'o'),
                new InitialCell(0, 7, 8, Width, 'g'),
                new InitialCell(2, 1, 8, Width, 'o'),
                new InitialCell(4, 4, 8, Width, 'y'),
                new InitialCell(5, 1, 8, Width, 'g'),
                new InitialCell(5, 2, 8, Width, 'b'),
                new InitialCell(5, 3, 8, Width, 'm'),
                new InitialCell(5, 4, 8, Width, 'r'),
                new InitialCell(5, 7, 8, Width, 'b'),
                new InitialCell(6, 1, 8, Width, 'm'),
                new InitialCell(6, 4, 8, Width, 'c'),
                new InitialCell(6, 7, 8, Width, 'y'),
                new InitialCell(7, 7, 8, Width, 'r')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 8, Width, 'b'),
                new InitialCell(0, 7, 8, Width, 'c'),
                new InitialCell(1, 7, 8, Width, 'r'),
                new InitialCell(2, 7, 8, Width, 'g'),
                new InitialCell(3, 3, 8, Width, 'o'),
                new InitialCell(3, 4, 8, Width, 'g'),
                new InitialCell(3, 5, 8, Width, 'y'),
                new InitialCell(3, 7, 8, Width, 'y'),
                new InitialCell(4, 6, 8, Width, 'c'),
                new InitialCell(6, 5, 8, Width, 'r'),
                new InitialCell(6, 6, 8, Width, 'o'),
                new InitialCell(7, 2, 8, Width, 'b')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(1, 6, 8, Width, 'y'),
                new InitialCell(2, 2, 8, Width, 'b'),
                new InitialCell(3, 4, 8, Width, 'g'),
                new InitialCell(3, 5, 8, Width, 'b'),
                new InitialCell(3, 6, 8, Width, 'r'),
                new InitialCell(3, 7, 8, Width, 'o'),
                new InitialCell(4, 1, 8, Width, 'o'),
                new InitialCell(5, 3, 8, Width, 'r'),
                new InitialCell(6, 2, 8, Width, 'y'),
                new InitialCell(6, 3, 8, Width, 'c'),
                new InitialCell(6, 6, 8, Width, 'c'),
                new InitialCell(7, 0, 8, Width, 'g')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 8, Width, 'c'),
                new InitialCell(0, 1, 8, Width, 'y'),
                new InitialCell(0, 2, 8, Width, 'm'),
                new InitialCell(1, 6, 8, Width, 'y'),
                new InitialCell(2, 1, 8, Width, 'o'),
                new InitialCell(2, 4, 8, Width, 'o'),
                new InitialCell(2, 6, 8, Width, 'b'),
                new InitialCell(4, 2, 8, Width, 'r'),
                new InitialCell(4, 3, 8, Width, 'g'),
                new InitialCell(4, 7, 8, Width, 'b'),
                new InitialCell(5, 6, 8, Width, 'm'),
                new InitialCell(6, 4, 8, Width, 'r'),
                new InitialCell(6, 6, 8, Width, 'g'),
                new InitialCell(7, 2, 8, Width, 'c')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 4, 8, Width, 'g'),
                new InitialCell(0, 6, 8, Width, 'y'),
                new InitialCell(1, 1, 8, Width, 'g'),
                new InitialCell(1, 4, 8, Width, 'c'),
                new InitialCell(2, 1, 8, Width, 'b'),
                new InitialCell(2, 4, 8, Width, 'r'),
                new InitialCell(2, 5, 8, Width, 'o'),
                new InitialCell(4, 4, 8, Width, 'o'),
                new InitialCell(4, 5, 8, Width, 'r'),
                new InitialCell(5, 0, 8, Width, 'c'),
                new InitialCell(6, 0, 8, Width, 'y'),
                new InitialCell(6, 1, 8, Width, 'b')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 8, Width, 'g'),
                new InitialCell(0, 1, 8, Width, 'r'),
                new InitialCell(0, 3, 8, Width, 'c'),
                new InitialCell(0, 6, 8, Width, 'r'),
                new InitialCell(0, 7, 8, Width, 'b'),
                new InitialCell(1, 1, 8, Width, 'g'),
                new InitialCell(1, 6, 8, Width, 'y'),
                new InitialCell(2, 0, 8, Width, 'b'),
                new InitialCell(2, 1, 8, Width, 'o'),
                new InitialCell(2, 6, 8, Width, 'o'),
                new InitialCell(3, 3, 8, Width, 'c'),
                new InitialCell(5, 2, 8, Width, 'y')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 7, 8, Width, 'y'),
                new InitialCell(1, 6, 8, Width, 'g'),
                new InitialCell(1, 7, 8, Width, 'c'),
                new InitialCell(3, 4, 8, Width, 'o'),
                new InitialCell(3, 5, 8, Width, 'b'),
                new InitialCell(4, 4, 8, Width, 'b'),
                new InitialCell(5, 2, 8, Width, 'r'),
                new InitialCell(5, 5, 8, Width, 'o'),
                new InitialCell(6, 6, 8, Width, 'r'),
                new InitialCell(7, 4, 8, Width, 'y'),
                new InitialCell(7, 6, 8, Width, 'g'),
                new InitialCell(7, 7, 8, Width, 'c')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 8, Width, 'g'),
                new InitialCell(2, 4, 8, Width, 'y'),
                new InitialCell(2, 5, 8, Width, 'b'),
                new InitialCell(3, 6, 8, Width, 'r'),
                new InitialCell(4, 3, 8, Width, 'y'),
                new InitialCell(4, 4, 8, Width, 'o'),
                new InitialCell(5, 7, 8, Width, 'o'),
                new InitialCell(6, 2, 8, Width, 'b'),
                new InitialCell(6, 5, 8, Width, 'c'),
                new InitialCell(6, 7, 8, Width, 'c'),
                new InitialCell(7, 3, 8, Width, 'g'),
                new InitialCell(7, 7, 8, Width, 'r')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 8, Width, 'g'),
                new InitialCell(0, 6, 8, Width, 'm'),
                new InitialCell(0, 7, 8, Width, 'g'),
                new InitialCell(1, 4, 8, Width, 'o'),
                new InitialCell(2, 4, 8, Width, 'c'),
                new InitialCell(3, 2, 8, Width, 'r'),
                new InitialCell(3, 4, 8, Width, 'b'),
                new InitialCell(4, 0, 8, Width, 'o'),
                new InitialCell(4, 4, 8, Width, 'y'),
                new InitialCell(5, 0, 8, Width, 'y'),
                new InitialCell(5, 2, 8, Width, 'r'),
                new InitialCell(6, 2, 8, Width, 'c'),
                new InitialCell(6, 3, 8, Width, 'b'),
                new InitialCell(6, 6, 8, Width, 'm')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 8, Width, 'b'),
                new InitialCell(2, 1, 8, Width, 'm'),
                new InitialCell(3, 0, 8, Width, 'o'),
                new InitialCell(3, 1, 8, Width, 'n'),
                new InitialCell(3, 4, 8, Width, 'n'),
                new InitialCell(4, 0, 8, Width, 'c'),
                new InitialCell(4, 4, 8, Width, 'r'),
                new InitialCell(4, 6, 8, Width, 'o'),
                new InitialCell(5, 3, 8, Width, 'y'),
                new InitialCell(5, 4, 8, Width, 'c'),
                new InitialCell(5, 5, 8, Width, 'm'),
                new InitialCell(5, 6, 8, Width, 'g'),
                new InitialCell(6, 1, 8, Width, 'r'),
                new InitialCell(6, 2, 8, Width, 'y'),
                new InitialCell(7, 4, 8, Width, 'g'),
                new InitialCell(7, 6, 8, Width, 'b')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 8, Width, 'c'),
                new InitialCell(0, 4, 8, Width, 'o'),
                new InitialCell(1, 0, 8, Width, 'b'),
                new InitialCell(1, 5, 8, Width, 'r'),
                new InitialCell(1, 6, 8, Width, 'y'),
                new InitialCell(1, 7, 8, Width, 'r'),
                new InitialCell(2, 0, 8, Width, 'c'),
                new InitialCell(2, 2, 8, Width, 'b'),
                new InitialCell(2, 5, 8, Width, 'y'),
                new InitialCell(2, 7, 8, Width, 'g'),
                new InitialCell(3, 0, 8, Width, 'p'),
                new InitialCell(3, 5, 8, Width, 'n'),
                new InitialCell(3, 6, 8, Width, 'p'),
                new InitialCell(4, 2, 8, Width, 'n'),
                new InitialCell(4, 3, 8, Width, 'm'),
                new InitialCell(5, 2, 8, Width, 'm'),
                new InitialCell(5, 4, 8, Width, 'o'),
                new InitialCell(7, 7, 8, Width, 'g')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 8, Width, 'c'),
                new InitialCell(0, 6, 8, Width, 'o'),
                new InitialCell(1, 1, 8, Width, 'n'),
                new InitialCell(1, 4, 8, Width, 'r'),
                new InitialCell(2, 1, 8, Width, 'r'),
                new InitialCell(2, 4, 8, Width, 'o'),
                new InitialCell(2, 6, 8, Width, 'n'),
                new InitialCell(3, 2, 8, Width, 'c'),
                new InitialCell(3, 3, 8, Width, 'm'),
                new InitialCell(3, 4, 8, Width, 'b'),
                new InitialCell(4, 0, 8, Width, 'm'),
                new InitialCell(4, 5, 8, Width, 'y'),
                new InitialCell(4, 6, 8, Width, 'b'),
                new InitialCell(5, 6, 8, Width, 'y'),
                new InitialCell(6, 1, 8, Width, 'g'),
                new InitialCell(6, 6, 8, Width, 'g')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 2, 8, Width, 'o'),
                new InitialCell(0, 4, 8, Width, 'r'),
                new InitialCell(0, 5, 8, Width, 'p'),
                new InitialCell(1, 1, 8, Width, 'y'),
                new InitialCell(1, 4, 8, Width, 'm'),
                new InitialCell(1, 6, 8, Width, 'm'),
                new InitialCell(2, 7, 8, Width, 'p'),
                new InitialCell(3, 0, 8, Width, 'g'),
                new InitialCell(3, 5, 8, Width, 'y'),
                new InitialCell(3, 7, 8, Width, 'r'),
                new InitialCell(4, 7, 8, Width, 'c'),
                new InitialCell(5, 5, 8, Width, 'b'),
                new InitialCell(6, 1, 8, Width, 'o'),
                new InitialCell(6, 2, 8, Width, 'n'),
                new InitialCell(6, 3, 8, Width, 'b'),
                new InitialCell(7, 3, 8, Width, 'g'),
                new InitialCell(7, 4, 8, Width, 'n'),
                new InitialCell(7, 5, 8, Width, 'c')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 5, 8, Width, 'n'),
                new InitialCell(0, 6, 8, Width, 'o'),
                new InitialCell(0, 7, 8, Width, 'b'),
                new InitialCell(2, 1, 8, Width, 'g'),
                new InitialCell(2, 6, 8, Width, 'o'),
                new InitialCell(3, 3, 8, Width, 'r'),
                new InitialCell(4, 1, 8, Width, 'y'),
                new InitialCell(4, 5, 8, Width, 'c'),
                new InitialCell(4, 7, 8, Width, 'b'),
                new InitialCell(5, 3, 8, Width, 'm'),
                new InitialCell(6, 1, 8, Width, 'r'),
                new InitialCell(6, 6, 8, Width, 'c'),
                new InitialCell(7, 1, 8, Width, 'n'),
                new InitialCell(7, 2, 8, Width, 'm'),
                new InitialCell(7, 3, 8, Width, 'y'),
                new InitialCell(7, 5, 8, Width, 'g')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 4, 8, Width, 'o'),
                new InitialCell(0, 6, 8, Width, 'b'),
                new InitialCell(1, 2, 8, Width, 'c'),
                new InitialCell(1, 5, 8, Width, 'o'),
                new InitialCell(1, 6, 8, Width, 'r'),
                new InitialCell(2, 2, 8, Width, 'b'),
                new InitialCell(2, 3, 8, Width, 'g'),
                new InitialCell(3, 4, 8, Width, 'r'),
                new InitialCell(4, 5, 8, Width, 'y'),
                new InitialCell(6, 1, 8, Width, 'c'),
                new InitialCell(6, 6, 8, Width, 'g'),
                new InitialCell(7, 1, 8, Width, 'y')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 8, Width, 'g'),
                new InitialCell(0, 7, 8, Width, 'c'),
                new InitialCell(1, 2, 8, Width, 'b'),
                new InitialCell(1, 3, 8, Width, 'o'),
                new InitialCell(1, 4, 8, Width, 'c'),
                new InitialCell(1, 5, 8, Width, 'm'),
                new InitialCell(2, 6, 8, Width, 'b'),
                new InitialCell(4, 1, 8, Width, 'y'),
                new InitialCell(5, 4, 8, Width, 'r'),
                new InitialCell(6, 1, 8, Width, 'r'),
                new InitialCell(6, 4, 8, Width, 'g'),
                new InitialCell(6, 5, 8, Width, 'y'),
                new InitialCell(6, 6, 8, Width, 'o'),
                new InitialCell(7, 3, 8, Width, 'm')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 8, Width, 'g'),
                new InitialCell(0, 2, 8, Width, 'o'),
                new InitialCell(1, 1, 8, Width, 'o'),
                new InitialCell(1, 2, 8, Width, 'c'),
                new InitialCell(2, 3, 8, Width, 'c'),
                new InitialCell(2, 5, 8, Width, 'r'),
                new InitialCell(3, 1, 8, Width, 'y'),
                new InitialCell(3, 3, 8, Width, 'm'),
                new InitialCell(4, 5, 8, Width, 'r'),
                new InitialCell(4, 6, 8, Width, 'b'),
                new InitialCell(5, 5, 8, Width, 'b'),
                new InitialCell(5, 6, 8, Width, 'm'),
                new InitialCell(7, 0, 8, Width, 'g'),
                new InitialCell(7, 1, 8, Width, 'y')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 8, Width, 'm'),
                new InitialCell(0, 3, 8, Width, 'c'),
                new InitialCell(1, 1, 8, Width, 'y'),
                new InitialCell(1, 3, 8, Width, 'r'),
                new InitialCell(1, 4, 8, Width, 'b'),
                new InitialCell(2, 1, 8, Width, 'm'),
                new InitialCell(3, 1, 8, Width, 'o'),
                new InitialCell(4, 3, 8, Width, 'y'),
                new InitialCell(5, 3, 8, Width, 'g'),
                new InitialCell(6, 0, 8, Width, 'g'),
                new InitialCell(6, 6, 8, Width, 'b'),
                new InitialCell(7, 0, 8, Width, 'o'),
                new InitialCell(7, 2, 8, Width, 'r'),
                new InitialCell(7, 6, 8, Width, 'c')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 8, Width, 'b'),
                new InitialCell(1, 0, 8, Width, 'y'),
                new InitialCell(1, 1, 8, Width, 'c'),
                new InitialCell(1, 3, 8, Width, 'o'),
                new InitialCell(2, 2, 8, Width, 'b'),
                new InitialCell(2, 5, 8, Width, 'n'),
                new InitialCell(3, 1, 8, Width, 'c'),
                new InitialCell(3, 2, 8, Width, 'g'),
                new InitialCell(4, 2, 8, Width, 'm'),
                new InitialCell(4, 4, 8, Width, 'n'),
                new InitialCell(5, 0, 8, Width, 'r'),
                new InitialCell(5, 2, 8, Width, 'y'),
                new InitialCell(5, 4, 8, Width, 'm'),
                new InitialCell(5, 5, 8, Width, 'g'),
                new InitialCell(5, 6, 8, Width, 'r'),
                new InitialCell(7, 0, 8, Width, 'o')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(1, 1, 8, Width, 'm'),
                new InitialCell(1, 7, 8, Width, 'o'),
                new InitialCell(2, 7, 8, Width, 'c'),
                new InitialCell(3, 4, 8, Width, 'g'),
                new InitialCell(3, 5, 8, Width, 'b'),
                new InitialCell(5, 2, 8, Width, 'g'),
                new InitialCell(5, 5, 8, Width, 'y'),
                new InitialCell(6, 2, 8, Width, 'b'),
                new InitialCell(6, 3, 8, Width, 'm'),
                new InitialCell(6, 4, 8, Width, 'y'),
                new InitialCell(6, 5, 8, Width, 'c'),
                new InitialCell(6, 7, 8, Width, 'r'),
                new InitialCell(7, 3, 8, Width, 'o'),
                new InitialCell(7, 4, 8, Width, 'r')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(1, 2, 8, Width, 'm'),
                new InitialCell(1, 3, 8, Width, 'o'),
                new InitialCell(1, 7, 8, Width, 'b'),
                new InitialCell(2, 5, 8, Width, 'y'),
                new InitialCell(3, 1, 8, Width, 'm'),
                new InitialCell(3, 3, 8, Width, 'g'),
                new InitialCell(3, 6, 8, Width, 'c'),
                new InitialCell(4, 1, 8, Width, 'r'),
                new InitialCell(5, 1, 8, Width, 'g'),
                new InitialCell(5, 4, 8, Width, 'r'),
                new InitialCell(6, 1, 8, Width, 'y'),
                new InitialCell(7, 3, 8, Width, 'b'),
                new InitialCell(7, 4, 8, Width, 'c'),
                new InitialCell(7, 7, 8, Width, 'o')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 8, Width, 'c'),
                new InitialCell(0, 7, 8, Width, 'r'),
                new InitialCell(1, 6, 8, Width, 'y'),
                new InitialCell(2, 3, 8, Width, 'g'),
                new InitialCell(2, 6, 8, Width, 'o'),
                new InitialCell(3, 7, 8, Width, 'y'),
                new InitialCell(4, 2, 8, Width, 'r'),
                new InitialCell(4, 5, 8, Width, 'o'),
                new InitialCell(5, 5, 8, Width, 'b'),
                new InitialCell(5, 6, 8, Width, 'c'),
                new InitialCell(6, 1, 8, Width, 'b'),
                new InitialCell(7, 3, 8, Width, 'g')
            }),
            new Grid(8, Width, Width, new List<Cell>
            {
                new InitialCell(0, 4, 8, Width, 'o'),
                new InitialCell(0, 5, 8, Width, 'm'),
                new InitialCell(0, 6, 8, Width, 'o'),
                new InitialCell(1, 4, 8, Width, 'r'),
                new InitialCell(1, 6, 8, Width, 'c'),
                new InitialCell(2, 2, 8, Width, 'g'),
                new InitialCell(3, 5, 8, Width, 'm'),
                new InitialCell(3, 6, 8, Width, 'c'),
                new InitialCell(4, 2, 8, Width, 'g'),
                new InitialCell(4, 3, 8, Width, 'b'),
                new InitialCell(5, 5, 8, Width, 'y'),
                new InitialCell(6, 1, 8, Width, 'b'),
                new InitialCell(6, 2, 8, Width, 'y'),
                new InitialCell(6, 3, 8, Width, 'r')
            })
        };

        public static List<Grid> Levels9 = new List<Grid>
        {
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(1, 1, 9, Width, 'r'),
                new InitialCell(1, 2, 9, Width, 'c'),
                new InitialCell(1, 3, 9, Width, 'b'),
                new InitialCell(2, 3, 9, Width, 'c'),
                new InitialCell(2, 4, 9, Width, 'o'),
                new InitialCell(2, 6, 9, Width, 'o'),
                new InitialCell(2, 7, 9, Width, 'b'),
                new InitialCell(3, 7, 9, Width, 'm'),
                new InitialCell(4, 1, 9, Width, 'g'),
                new InitialCell(4, 3, 9, Width, 'g'),
                new InitialCell(4, 4, 9, Width, 'r'),
                new InitialCell(5, 0, 9, Width, 'y'),
                new InitialCell(5, 1, 9, Width, 'm'),
                new InitialCell(5, 7, 9, Width, 'n'),
                new InitialCell(5, 8, 9, Width, 'p'),
                new InitialCell(6, 1, 9, Width, 'p'),
                new InitialCell(6, 2, 9, Width, 'y'),
                new InitialCell(7, 1, 9, Width, 'n')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 9, Width, 'b'),
                new InitialCell(0, 7, 9, Width, 'n'),
                new InitialCell(3, 0, 9, Width, 'n'),
                new InitialCell(3, 3, 9, Width, 'r'),
                new InitialCell(3, 5, 9, Width, 'm'),
                new InitialCell(3, 7, 9, Width, 'b'),
                new InitialCell(4, 3, 9, Width, 'g'),
                new InitialCell(4, 7, 9, Width, 'c'),
                new InitialCell(5, 1, 9, Width, 'o'),
                new InitialCell(5, 4, 9, Width, 'y'),
                new InitialCell(5, 5, 9, Width, 'm'),
                new InitialCell(7, 1, 9, Width, 'o'),
                new InitialCell(7, 2, 9, Width, 'r'),
                new InitialCell(7, 5, 9, Width, 'c'),
                new InitialCell(8, 2, 9, Width, 'y'),
                new InitialCell(8, 3, 9, Width, 'g')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 7, 9, Width, 'g'),
                new InitialCell(1, 1, 9, Width, 'b'),
                new InitialCell(1, 2, 9, Width, 'y'),
                new InitialCell(2, 0, 9, Width, 'o'),
                new InitialCell(3, 0, 9, Width, 'm'),
                new InitialCell(3, 5, 9, Width, 'r'),
                new InitialCell(3, 6, 9, Width, 'y'),
                new InitialCell(4, 2, 9, Width, 'o'),
                new InitialCell(4, 4, 9, Width, 'b'),
                new InitialCell(4, 8, 9, Width, 'g'),
                new InitialCell(5, 4, 9, Width, 'c'),
                new InitialCell(5, 5, 9, Width, 'r'),
                new InitialCell(5, 8, 9, Width, 'c'),
                new InitialCell(6, 8, 9, Width, 'm')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 9, Width, 'y'),
                new InitialCell(0, 1, 9, Width, 'o'),
                new InitialCell(0, 8, 9, Width, 'c'),
                new InitialCell(1, 3, 9, Width, 'o'),
                new InitialCell(1, 8, 9, Width, 'g'),
                new InitialCell(3, 4, 9, Width, 'g'),
                new InitialCell(3, 7, 9, Width, 'y'),
                new InitialCell(3, 8, 9, Width, 'r'),
                new InitialCell(4, 4, 9, Width, 'r'),
                new InitialCell(4, 8, 9, Width, 'b'),
                new InitialCell(5, 8, 9, Width, 'm'),
                new InitialCell(6, 4, 9, Width, 'c'),
                new InitialCell(7, 8, 9, Width, 'm'),
                new InitialCell(8, 8, 9, Width, 'b')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 9, Width, 'g'),
                new InitialCell(1, 0, 9, Width, 'o'),
                new InitialCell(1, 4, 9, Width, 'y'),
                new InitialCell(1, 7, 9, Width, 'b'),
                new InitialCell(2, 0, 9, Width, 'm'),
                new InitialCell(2, 5, 9, Width, 'n'),
                new InitialCell(3, 3, 9, Width, 'g'),
                new InitialCell(3, 6, 9, Width, 'y'),
                new InitialCell(5, 3, 9, Width, 'r'),
                new InitialCell(6, 4, 9, Width, 'n'),
                new InitialCell(6, 5, 9, Width, 'b'),
                new InitialCell(6, 7, 9, Width, 'c'),
                new InitialCell(6, 8, 9, Width, 'm'),
                new InitialCell(7, 1, 9, Width, 'o'),
                new InitialCell(7, 2, 9, Width, 'c'),
                new InitialCell(7, 7, 9, Width, 'r')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(1, 1, 9, Width, 'y'),
                new InitialCell(1, 4, 9, Width, 'y'),
                new InitialCell(1, 5, 9, Width, 'p'),
                new InitialCell(3, 4, 9, Width, 'o'),
                new InitialCell(3, 5, 9, Width, 'b'),
                new InitialCell(3, 6, 9, Width, 'm'),
                new InitialCell(4, 4, 9, Width, 'c'),
                new InitialCell(4, 6, 9, Width, 'r'),
                new InitialCell(5, 0, 9, Width, 'o'),
                new InitialCell(6, 0, 9, Width, 'm'),
                new InitialCell(6, 4, 9, Width, 'b'),
                new InitialCell(6, 5, 9, Width, 'n'),
                new InitialCell(6, 7, 9, Width, 'p'),
                new InitialCell(7, 0, 9, Width, 'o'),
                new InitialCell(7, 4, 9, Width, 'c'),
                new InitialCell(7, 7, 9, Width, 'r'),
                new InitialCell(8, 0, 9, Width, 'g'),
                new InitialCell(8, 4, 9, Width, 'g'),
                new InitialCell(8, 6, 9, Width, 'n'),
                new InitialCell(8, 7, 9, Width, 'o')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 9, Width, 'y'),
                new InitialCell(0, 4, 9, Width, 'o'),
                new InitialCell(0, 6, 9, Width, 'm'),
                new InitialCell(1, 2, 9, Width, 'r'),
                new InitialCell(1, 7, 9, Width, 'p'),
                new InitialCell(2, 1, 9, Width, 'g'),
                new InitialCell(2, 3, 9, Width, 'c'),
                new InitialCell(2, 7, 9, Width, 'b'),
                new InitialCell(3, 1, 9, Width, 'r'),
                new InitialCell(4, 2, 9, Width, 'o'),
                new InitialCell(5, 2, 9, Width, 'o'),
                new InitialCell(5, 6, 9, Width, 'p'),
                new InitialCell(5, 7, 9, Width, 'b'),
                new InitialCell(6, 3, 9, Width, 'c'),
                new InitialCell(6, 4, 9, Width, 'g'),
                new InitialCell(6, 6, 9, Width, 'o'),
                new InitialCell(6, 7, 9, Width, 'n'),
                new InitialCell(7, 8, 9, Width, 'm'),
                new InitialCell(8, 0, 9, Width, 'y'),
                new InitialCell(8, 8, 9, Width, 'n')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 9, Width, 'b'),
                new InitialCell(1, 0, 9, Width, 'g'),
                new InitialCell(1, 5, 9, Width, 'm'),
                new InitialCell(1, 7, 9, Width, 'm'),
                new InitialCell(1, 8, 9, Width, 'b'),
                new InitialCell(2, 3, 9, Width, 'c'),
                new InitialCell(2, 8, 9, Width, 'o'),
                new InitialCell(3, 5, 9, Width, 'o'),
                new InitialCell(4, 7, 9, Width, 'r'),
                new InitialCell(5, 2, 9, Width, 'n'),
                new InitialCell(6, 2, 9, Width, 'y'),
                new InitialCell(6, 4, 9, Width, 'n'),
                new InitialCell(6, 6, 9, Width, 'y'),
                new InitialCell(6, 7, 9, Width, 'r'),
                new InitialCell(7, 4, 9, Width, 'g'),
                new InitialCell(8, 8, 9, Width, 'c')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 9, Width, 'b'),
                new InitialCell(0, 1, 9, Width, 'n'),
                new InitialCell(0, 3, 9, Width, 'o'),
                new InitialCell(1, 1, 9, Width, 'y'),
                new InitialCell(1, 7, 9, Width, 'g'),
                new InitialCell(2, 6, 9, Width, 'm'),
                new InitialCell(2, 7, 9, Width, 'c'),
                new InitialCell(2, 8, 9, Width, 'n'),
                new InitialCell(3, 3, 9, Width, 'o'),
                new InitialCell(3, 8, 9, Width, 'b'),
                new InitialCell(4, 5, 9, Width, 'g'),
                new InitialCell(4, 6, 9, Width, 'm'),
                new InitialCell(6, 2, 9, Width, 'c'),
                new InitialCell(6, 6, 9, Width, 'y'),
                new InitialCell(6, 7, 9, Width, 'r'),
                new InitialCell(7, 4, 9, Width, 'r')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(2, 2, 9, Width, 'r'),
                new InitialCell(2, 6, 9, Width, 'm'),
                new InitialCell(4, 3, 9, Width, 'y'),
                new InitialCell(5, 1, 9, Width, 'c'),
                new InitialCell(5, 6, 9, Width, 'm'),
                new InitialCell(6, 1, 9, Width, 'g'),
                new InitialCell(6, 6, 9, Width, 'r'),
                new InitialCell(6, 8, 9, Width, 'g'),
                new InitialCell(7, 1, 9, Width, 'y'),
                new InitialCell(7, 5, 9, Width, 'o'),
                new InitialCell(7, 6, 9, Width, 'b'),
                new InitialCell(7, 8, 9, Width, 'o'),
                new InitialCell(8, 5, 9, Width, 'c'),
                new InitialCell(8, 8, 9, Width, 'b')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 9, Width, 'y'),
                new InitialCell(1, 1, 9, Width, 'c'),
                new InitialCell(1, 2, 9, Width, 'r'),
                new InitialCell(1, 4, 9, Width, 'o'),
                new InitialCell(2, 5, 9, Width, 'c'),
                new InitialCell(3, 0, 9, Width, 'p'),
                new InitialCell(4, 0, 9, Width, 'n'),
                new InitialCell(4, 2, 9, Width, 'b'),
                new InitialCell(4, 3, 9, Width, 'y'),
                new InitialCell(4, 4, 9, Width, 'm'),
                new InitialCell(5, 1, 9, Width, 'p'),
                new InitialCell(5, 3, 9, Width, 'b'),
                new InitialCell(6, 5, 9, Width, 'r'),
                new InitialCell(7, 2, 9, Width, 'g'),
                new InitialCell(7, 7, 9, Width, 'o'),
                new InitialCell(8, 0, 9, Width, 'n'),
                new InitialCell(8, 4, 9, Width, 'm'),
                new InitialCell(8, 5, 9, Width, 'g')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 1, 9, Width, 'r'),
                new InitialCell(0, 2, 9, Width, 'g'),
                new InitialCell(0, 3, 9, Width, 'y'),
                new InitialCell(1, 1, 9, Width, 'o'),
                new InitialCell(1, 6, 9, Width, 'n'),
                new InitialCell(2, 3, 9, Width, 'g'),
                new InitialCell(2, 4, 9, Width, 'y'),
                new InitialCell(3, 1, 9, Width, 'b'),
                new InitialCell(4, 4, 9, Width, 'c'),
                new InitialCell(4, 5, 9, Width, 'o'),
                new InitialCell(6, 2, 9, Width, 'c'),
                new InitialCell(6, 3, 9, Width, 'r'),
                new InitialCell(6, 4, 9, Width, 'b'),
                new InitialCell(6, 5, 9, Width, 'n'),
                new InitialCell(7, 5, 9, Width, 'm'),
                new InitialCell(7, 7, 9, Width, 'm')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(1, 7, 9, Width, 'g'),
                new InitialCell(2, 2, 9, Width, 'y'),
                new InitialCell(2, 7, 9, Width, 'y'),
                new InitialCell(3, 2, 9, Width, 'n'),
                new InitialCell(3, 4, 9, Width, 'b'),
                new InitialCell(4, 2, 9, Width, 'm'),
                new InitialCell(4, 4, 9, Width, 'n'),
                new InitialCell(4, 5, 9, Width, 'o'),
                new InitialCell(5, 4, 9, Width, 'r'),
                new InitialCell(5, 5, 9, Width, 'c'),
                new InitialCell(5, 7, 9, Width, 'b'),
                new InitialCell(6, 4, 9, Width, 'm'),
                new InitialCell(7, 1, 9, Width, 'g'),
                new InitialCell(7, 6, 9, Width, 'c'),
                new InitialCell(7, 7, 9, Width, 'o'),
                new InitialCell(8, 3, 9, Width, 'r')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(1, 1, 9, Width, 'n'),
                new InitialCell(1, 3, 9, Width, 'r'),
                new InitialCell(1, 4, 9, Width, 'o'),
                new InitialCell(2, 1, 9, Width, 'p'),
                new InitialCell(2, 6, 9, Width, 'm'),
                new InitialCell(2, 7, 9, Width, 'n'),
                new InitialCell(3, 3, 9, Width, 'p'),
                new InitialCell(3, 4, 9, Width, 'm'),
                new InitialCell(4, 5, 9, Width, 'r'),
                new InitialCell(4, 8, 9, Width, 'y'),
                new InitialCell(5, 7, 9, Width, 'g'),
                new InitialCell(6, 1, 9, Width, 'c'),
                new InitialCell(6, 2, 9, Width, 'y'),
                new InitialCell(6, 3, 9, Width, 'g'),
                new InitialCell(6, 4, 9, Width, 'b'),
                new InitialCell(6, 6, 9, Width, 'b'),
                new InitialCell(7, 0, 9, Width, 'o'),
                new InitialCell(8, 0, 9, Width, 'c')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 3, 9, Width, 'y'),
                new InitialCell(1, 1, 9, Width, 'm'),
                new InitialCell(2, 0, 9, Width, 'o'),
                new InitialCell(2, 5, 9, Width, 'g'),
                new InitialCell(2, 6, 9, Width, 'b'),
                new InitialCell(3, 0, 9, Width, 'b'),
                new InitialCell(3, 1, 9, Width, 'm'),
                new InitialCell(3, 3, 9, Width, 'y'),
                new InitialCell(5, 0, 9, Width, 'o'),
                new InitialCell(5, 7, 9, Width, 'r'),
                new InitialCell(6, 2, 9, Width, 'r'),
                new InitialCell(6, 6, 9, Width, 'g'),
                new InitialCell(7, 0, 9, Width, 'c'),
                new InitialCell(8, 3, 9, Width, 'c')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 3, 9, Width, 'r'),
                new InitialCell(1, 0, 9, Width, 'y'),
                new InitialCell(1, 1, 9, Width, 'm'),
                new InitialCell(1, 5, 9, Width, 'c'),
                new InitialCell(2, 0, 9, Width, 'g'),
                new InitialCell(2, 6, 9, Width, 'y'),
                new InitialCell(3, 2, 9, Width, 'g'),
                new InitialCell(3, 6, 9, Width, 'o'),
                new InitialCell(3, 7, 9, Width, 'c'),
                new InitialCell(5, 5, 9, Width, 'p'),
                new InitialCell(5, 6, 9, Width, 'b'),
                new InitialCell(5, 7, 9, Width, 'p'),
                new InitialCell(6, 2, 9, Width, 'b'),
                new InitialCell(6, 7, 9, Width, 'r'),
                new InitialCell(7, 4, 9, Width, 'o'),
                new InitialCell(7, 7, 9, Width, 'm'),
                new InitialCell(7, 8, 9, Width, 'n'),
                new InitialCell(8, 6, 9, Width, 'n')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 6, 9, Width, 'y'),
                new InitialCell(1, 0, 9, Width, 'g'),
                new InitialCell(1, 4, 9, Width, 'c'),
                new InitialCell(1, 7, 9, Width, 'r'),
                new InitialCell(2, 5, 9, Width, 'y'),
                new InitialCell(3, 4, 9, Width, 'b'),
                new InitialCell(3, 5, 9, Width, 'g'),
                new InitialCell(6, 2, 9, Width, 'b'),
                new InitialCell(6, 3, 9, Width, 'r'),
                new InitialCell(7, 7, 9, Width, 'o'),
                new InitialCell(8, 6, 9, Width, 'o'),
                new InitialCell(8, 8, 9, Width, 'c')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 8, 9, Width, 'c'),
                new InitialCell(1, 4, 9, Width, 'b'),
                new InitialCell(1, 6, 9, Width, 'r'),
                new InitialCell(2, 6, 9, Width, 'p'),
                new InitialCell(3, 3, 9, Width, 'p'),
                new InitialCell(4, 3, 9, Width, 'n'),
                new InitialCell(4, 4, 9, Width, 'g'),
                new InitialCell(4, 5, 9, Width, 'y'),
                new InitialCell(5, 5, 9, Width, 'm'),
                new InitialCell(5, 7, 9, Width, 'm'),
                new InitialCell(6, 5, 9, Width, 'o'),
                new InitialCell(7, 1, 9, Width, 'b'),
                new InitialCell(7, 2, 9, Width, 'r'),
                new InitialCell(7, 3, 9, Width, 'n'),
                new InitialCell(7, 6, 9, Width, 'g'),
                new InitialCell(8, 6, 9, Width, 'y'),
                new InitialCell(8, 7, 9, Width, 'o'),
                new InitialCell(8, 8, 9, Width, 'c')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 7, 9, Width, 'g'),
                new InitialCell(1, 3, 9, Width, 'm'),
                new InitialCell(1, 4, 9, Width, 'n'),
                new InitialCell(1, 6, 9, Width, 'b'),
                new InitialCell(1, 7, 9, Width, 'n'),
                new InitialCell(2, 4, 9, Width, 'p'),
                new InitialCell(3, 3, 9, Width, 'r'),
                new InitialCell(3, 4, 9, Width, 'y'),
                new InitialCell(4, 1, 9, Width, 'm'),
                new InitialCell(4, 5, 9, Width, 'g'),
                new InitialCell(4, 6, 9, Width, 'y'),
                new InitialCell(4, 7, 9, Width, 'c'),
                new InitialCell(5, 1, 9, Width, 'o'),
                new InitialCell(5, 7, 9, Width, 'b'),
                new InitialCell(6, 2, 9, Width, 'p'),
                new InitialCell(7, 5, 9, Width, 'o'),
                new InitialCell(7, 6, 9, Width, 'r'),
                new InitialCell(8, 8, 9, Width, 'c')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 4, 9, Width, 'y'),
                new InitialCell(0, 5, 9, Width, 'r'),
                new InitialCell(1, 1, 9, Width, 'b'),
                new InitialCell(1, 7, 9, Width, 'c'),
                new InitialCell(2, 4, 9, Width, 'r'),
                new InitialCell(3, 0, 9, Width, 'o'),
                new InitialCell(3, 1, 9, Width, 'g'),
                new InitialCell(3, 6, 9, Width, 'g'),
                new InitialCell(3, 8, 9, Width, 'n'),
                new InitialCell(4, 4, 9, Width, 'n'),
                new InitialCell(5, 6, 9, Width, 'm'),
                new InitialCell(5, 7, 9, Width, 'p'),
                new InitialCell(6, 2, 9, Width, 'y'),
                new InitialCell(6, 3, 9, Width, 'b'),
                new InitialCell(6, 5, 9, Width, 'o'),
                new InitialCell(6, 8, 9, Width, 'c'),
                new InitialCell(7, 8, 9, Width, 'p'),
                new InitialCell(8, 8, 9, Width, 'm')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 6, 9, Width, 'b'),
                new InitialCell(0, 7, 9, Width, 'm'),
                new InitialCell(1, 6, 9, Width, 'c'),
                new InitialCell(1, 7, 9, Width, 'b'),
                new InitialCell(4, 4, 9, Width, 'y'),
                new InitialCell(4, 5, 9, Width, 'r'),
                new InitialCell(4, 8, 9, Width, 'g'),
                new InitialCell(5, 3, 9, Width, 'm'),
                new InitialCell(5, 6, 9, Width, 'g'),
                new InitialCell(6, 4, 9, Width, 'o'),
                new InitialCell(6, 7, 9, Width, 'r'),
                new InitialCell(7, 2, 9, Width, 'c'),
                new InitialCell(8, 4, 9, Width, 'o'),
                new InitialCell(8, 8, 9, Width, 'y')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 4, 9, Width, 'o'),
                new InitialCell(0, 5, 9, Width, 'n'),
                new InitialCell(0, 8, 9, Width, 'n'),
                new InitialCell(1, 4, 9, Width, 'm'),
                new InitialCell(2, 1, 9, Width, 'm'),
                new InitialCell(2, 2, 9, Width, 'p'),
                new InitialCell(2, 6, 9, Width, 'r'),
                new InitialCell(2, 8, 9, Width, 'y'),
                new InitialCell(3, 6, 9, Width, 'c'),
                new InitialCell(4, 4, 9, Width, 'p'),
                new InitialCell(4, 7, 9, Width, 'g'),
                new InitialCell(5, 1, 9, Width, 'b'),
                new InitialCell(5, 2, 9, Width, 'g'),
                new InitialCell(5, 8, 9, Width, 'r'),
                new InitialCell(6, 2, 9, Width, 'y'),
                new InitialCell(6, 4, 9, Width, 'o'),
                new InitialCell(7, 2, 9, Width, 'b'),
                new InitialCell(7, 7, 9, Width, 'c')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(1, 4, 9, Width, 'o'),
                new InitialCell(1, 5, 9, Width, 'n'),
                new InitialCell(1, 6, 9, Width, 'm'),
                new InitialCell(1, 8, 9, Width, 'c'),
                new InitialCell(2, 1, 9, Width, 'o'),
                new InitialCell(2, 4, 9, Width, 'y'),
                new InitialCell(2, 6, 9, Width, 'g'),
                new InitialCell(3, 3, 9, Width, 'r'),
                new InitialCell(3, 8, 9, Width, 'm'),
                new InitialCell(4, 0, 9, Width, 'b'),
                new InitialCell(4, 6, 9, Width, 'n'),
                new InitialCell(5, 2, 9, Width, 'p'),
                new InitialCell(6, 4, 9, Width, 'y'),
                new InitialCell(6, 6, 9, Width, 'p'),
                new InitialCell(6, 7, 9, Width, 'r'),
                new InitialCell(7, 7, 9, Width, 'c'),
                new InitialCell(8, 0, 9, Width, 'b'),
                new InitialCell(8, 7, 9, Width, 'g')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 2, 9, Width, 'o'),
                new InitialCell(1, 1, 9, Width, 'b'),
                new InitialCell(1, 2, 9, Width, 'm'),
                new InitialCell(1, 3, 9, Width, 'g'),
                new InitialCell(1, 4, 9, Width, 'n'),
                new InitialCell(2, 3, 9, Width, 'r'),
                new InitialCell(2, 4, 9, Width, 'y'),
                new InitialCell(4, 3, 9, Width, 'b'),
                new InitialCell(4, 4, 9, Width, 'c'),
                new InitialCell(4, 7, 9, Width, 'n'),
                new InitialCell(5, 7, 9, Width, 'y'),
                new InitialCell(5, 8, 9, Width, 'g'),
                new InitialCell(6, 2, 9, Width, 'm'),
                new InitialCell(6, 8, 9, Width, 'o'),
                new InitialCell(7, 6, 9, Width, 'c'),
                new InitialCell(7, 7, 9, Width, 'r')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 9, Width, 'c'),
                new InitialCell(0, 1, 9, Width, 'g'),
                new InitialCell(0, 2, 9, Width, 'y'),
                new InitialCell(0, 8, 9, Width, 'm'),
                new InitialCell(1, 4, 9, Width, 'n'),
                new InitialCell(1, 5, 9, Width, 'r'),
                new InitialCell(2, 6, 9, Width, 'n'),
                new InitialCell(2, 7, 9, Width, 'b'),
                new InitialCell(4, 3, 9, Width, 'm'),
                new InitialCell(4, 7, 9, Width, 'o'),
                new InitialCell(6, 3, 9, Width, 'b'),
                new InitialCell(6, 4, 9, Width, 'o'),
                new InitialCell(6, 6, 9, Width, 'r'),
                new InitialCell(6, 7, 9, Width, 'y'),
                new InitialCell(6, 8, 9, Width, 'g'),
                new InitialCell(8, 0, 9, Width, 'c')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 4, 9, Width, 'g'),
                new InitialCell(1, 4, 9, Width, 'r'),
                new InitialCell(1, 7, 9, Width, 'n'),
                new InitialCell(2, 1, 9, Width, 'r'),
                new InitialCell(2, 2, 9, Width, 'y'),
                new InitialCell(2, 7, 9, Width, 'c'),
                new InitialCell(3, 5, 9, Width, 'g'),
                new InitialCell(4, 0, 9, Width, 'm'),
                new InitialCell(4, 4, 9, Width, 'p'),
                new InitialCell(5, 2, 9, Width, 'n'),
                new InitialCell(5, 6, 9, Width, 'c'),
                new InitialCell(6, 6, 9, Width, 'y'),
                new InitialCell(7, 3, 9, Width, 'm'),
                new InitialCell(7, 4, 9, Width, 'b'),
                new InitialCell(7, 6, 9, Width, 'o'),
                new InitialCell(7, 8, 9, Width, 'o'),
                new InitialCell(8, 0, 9, Width, 'b'),
                new InitialCell(8, 8, 9, Width, 'p')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 9, Width, 'o'),
                new InitialCell(1, 7, 9, Width, 'b'),
                new InitialCell(3, 1, 9, Width, 'm'),
                new InitialCell(3, 8, 9, Width, 'y'),
                new InitialCell(4, 3, 9, Width, 'o'),
                new InitialCell(4, 6, 9, Width, 'm'),
                new InitialCell(5, 1, 9, Width, 'c'),
                new InitialCell(5, 3, 9, Width, 'r'),
                new InitialCell(6, 3, 9, Width, 'n'),
                new InitialCell(6, 6, 9, Width, 'c'),
                new InitialCell(7, 0, 9, Width, 'b'),
                new InitialCell(7, 2, 9, Width, 'n'),
                new InitialCell(7, 4, 9, Width, 'g'),
                new InitialCell(8, 0, 9, Width, 'r'),
                new InitialCell(8, 2, 9, Width, 'g'),
                new InitialCell(8, 5, 9, Width, 'y')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 9, Width, 'y'),
                new InitialCell(3, 1, 9, Width, 'y'),
                new InitialCell(4, 1, 9, Width, 'o'),
                new InitialCell(4, 4, 9, Width, 'c'),
                new InitialCell(5, 2, 9, Width, 'r'),
                new InitialCell(5, 4, 9, Width, 'o'),
                new InitialCell(6, 2, 9, Width, 'b'),
                new InitialCell(6, 5, 9, Width, 'm'),
                new InitialCell(7, 1, 9, Width, 'r'),
                new InitialCell(7, 7, 9, Width, 'g'),
                new InitialCell(8, 2, 9, Width, 'g'),
                new InitialCell(8, 3, 9, Width, 'b'),
                new InitialCell(8, 4, 9, Width, 'c'),
                new InitialCell(8, 5, 9, Width, 'm')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 0, 9, Width, 'c'),
                new InitialCell(1, 0, 9, Width, 'o'),
                new InitialCell(1, 4, 9, Width, 'o'),
                new InitialCell(1, 7, 9, Width, 'm'),
                new InitialCell(2, 7, 9, Width, 'y'),
                new InitialCell(3, 7, 9, Width, 'c'),
                new InitialCell(4, 1, 9, Width, 'b'),
                new InitialCell(4, 2, 9, Width, 'n'),
                new InitialCell(4, 4, 9, Width, 'n'),
                new InitialCell(4, 5, 9, Width, 'b'),
                new InitialCell(4, 7, 9, Width, 'r'),
                new InitialCell(5, 5, 9, Width, 'r'),
                new InitialCell(5, 7, 9, Width, 'g'),
                new InitialCell(6, 2, 9, Width, 'y'),
                new InitialCell(7, 3, 9, Width, 'g'),
                new InitialCell(8, 1, 9, Width, 'm')
            }),
            new Grid(9, Width, Width, new List<Cell>
            {
                new InitialCell(0, 6, 9, Width, 'r'),
                new InitialCell(0, 7, 9, Width, 'c'),
                new InitialCell(0, 8, 9, Width, 'g'),
                new InitialCell(1, 1, 9, Width, 'b'),
                new InitialCell(2, 0, 9, Width, 'n'),
                new InitialCell(2, 3, 9, Width, 'r'),
                new InitialCell(3, 3, 9, Width, 'c'),
                new InitialCell(4, 1, 9, Width, 'g'),
                new InitialCell(4, 7, 9, Width, 'o'),
                new InitialCell(5, 4, 9, Width, 'm'),
                new InitialCell(6, 6, 9, Width, 'y'),
                new InitialCell(6, 8, 9, Width, 'y'),
                new InitialCell(7, 3, 9, Width, 'n'),
                new InitialCell(7, 6, 9, Width, 'm'),
                new InitialCell(7, 7, 9, Width, 'o'),
                new InitialCell(7, 8, 9, Width, 'p'),
                new InitialCell(8, 0, 9, Width, 'b'),
                new InitialCell(8, 5, 9, Width, 'p')
            })
        };
    }
}
