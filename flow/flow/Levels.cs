﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace flow
{
    [Serializable]
    public class Levels
    {
        public static int Width = 500;

        public Dictionary<int, Dictionary<int, Grid>> RegularLevels = new Dictionary<int, Dictionary<int, Grid>>
        {
            {
                5, new Dictionary<int, Grid>
                {
                    {
                        1, new Grid(5, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        2, new Grid(5, Width, Width, new List<Cell>
                        {
                            new InitialCell(0, 0, 5, Width, Color.Yellow),
                            new InitialCell(2, 2, 5, Width, Color.Green),
                            new InitialCell(3, 0, 5, Width, Color.Blue),
                            new InitialCell(3, 1, 5, Width, Color.Green),
                            new InitialCell(3, 2, 5, Width, Color.Red),
                            new InitialCell(3, 4, 5, Width, Color.Yellow),
                            new InitialCell(4, 0, 5, Width, Color.Red),
                            new InitialCell(4, 4, 5, Width, Color.Blue)
                        })
                    },
                    {
                        3, new Grid(5, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        4, new Grid(5, Width, Width, new List<Cell>
                        {
                            new InitialCell(0, 3, 5, Width, Color.Red),
                            new InitialCell(0, 4, 5, Width, Color.Green),
                            new InitialCell(1, 0, 5, Width, Color.Red),
                            new InitialCell(2, 2, 5, Width, Color.Yellow),
                            new InitialCell(3, 3, 5, Width, Color.Blue),
                            new InitialCell(4, 0, 5, Width, Color.Green),
                            new InitialCell(4, 1, 5, Width, Color.Blue),
                            new InitialCell(4, 2, 5, Width, Color.Yellow)
                        })
                    },
                    {
                        5, new Grid(5, Width, Width, new List<Cell>
                        {
                            new InitialCell(0, 3, 5, Width, Color.Red),
                            new InitialCell(0, 4, 5, Width, Color.Green),
                            new InitialCell(1, 1, 5, Width, Color.Yellow),
                            new InitialCell(1, 2, 5, Width, Color.Blue),
                            new InitialCell(1, 3, 5, Width, Color.Green),
                            new InitialCell(3, 4, 5, Width, Color.Blue),
                            new InitialCell(4, 2, 5, Width, Color.Red),
                            new InitialCell(4, 4, 5, Width, Color.Yellow)
                        })
                    },
                    {
                        6, new Grid(5, Width, Width, new List<Cell>
                        {
                            new InitialCell(0, 0, 5, Width, Color.Yellow),
                            new InitialCell(0, 2, 5, Width, Color.Blue),
                            new InitialCell(0, 3, 5, Width, Color.Red),
                            new InitialCell(0, 4, 5, Width, Color.Green),
                            new InitialCell(2, 3, 5, Width, Color.Green),
                            new InitialCell(3, 1, 5, Width, Color.Blue),
                            new InitialCell(3, 4, 5, Width, Color.Red),
                            new InitialCell(4, 4, 5, Width, Color.Yellow)
                        })
                    },
                    {
                        7, new Grid(5, Width, Width, new List<Cell>
                        {
                            new InitialCell(0, 0, 5, Width, Color.Blue),
                            new InitialCell(0, 3, 5, Width, Color.Yellow),
                            new InitialCell(1, 0, 5, Width, Color.Green),
                            new InitialCell(2, 0, 5, Width, Color.Yellow),
                            new InitialCell(2, 2, 5, Width, Color.Green),
                            new InitialCell(2, 3, 5, Width, Color.Blue),
                            new InitialCell(3, 1, 5, Width, Color.Red),
                            new InitialCell(3, 3, 5, Width, Color.Red)
                        })
                    },
                    {
                        8, new Grid(5, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        9, new Grid(5, Width, Width, new List<Cell>
                        {
                            new InitialCell(0, 3, 5, Width, Color.Red),
                            new InitialCell(1, 1, 5, Width, Color.Yellow),
                            new InitialCell(1, 2, 5, Width, Color.Blue),
                            new InitialCell(1, 3, 5, Width, Color.Green),
                            new InitialCell(2, 2, 5, Width, Color.Yellow),
                            new InitialCell(4, 0, 5, Width, Color.Blue),
                            new InitialCell(4, 1, 5, Width, Color.Green),
                            new InitialCell(4, 2, 5, Width, Color.Red)
                        })
                    },
                    {
                        10, new Grid(5, Width, Width, new List<Cell>
                        {
                            new InitialCell(1, 0, 5, Width, Color.Green),
                            new InitialCell(1, 3, 5, Width, Color.Red),
                            new InitialCell(2, 0, 5, Width, Color.Blue),
                            new InitialCell(2, 1, 5, Width, Color.Red),
                            new InitialCell(2, 2, 5, Width, Color.Blue),
                            new InitialCell(2, 3, 5, Width, Color.Yellow),
                            new InitialCell(4, 0, 5, Width, Color.Yellow),
                            new InitialCell(4, 4, 5, Width, Color.Green)
                        })
                    },
                    {
                        11, new Grid(5, Width, Width, new List<Cell>
                        {
                            new InitialCell(0, 0, 5, Width, Color.Blue),
                            new InitialCell(0, 1, 5, Width, Color.Yellow),
                            new InitialCell(0, 2, 5, Width, Color.Red),
                            new InitialCell(2, 1, 5, Width, Color.Blue),
                            new InitialCell(2, 2, 5, Width, Color.Green),
                            new InitialCell(4, 0, 5, Width, Color.Green),
                            new InitialCell(4, 1, 5, Width, Color.Yellow),
                            new InitialCell(4, 4, 5, Width, Color.Red)
                        })
                    },
                    {
                        12, new Grid(5, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        13, new Grid(5, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        14, new Grid(5, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        15, new Grid(5, Width, Width, new List<Cell>
                        {
                            new InitialCell(0, 0, 5, Width, Color.Blue),
                            new InitialCell(0, 1, 5, Width, Color.Yellow),
                            new InitialCell(1, 2, 5, Width, Color.Green),
                            new InitialCell(2, 0, 5, Width, Color.Red),
                            new InitialCell(2, 2, 5, Width, Color.Blue),
                            new InitialCell(4, 0, 5, Width, Color.Red),
                            new InitialCell(4, 1, 5, Width, Color.Green),
                            new InitialCell(4, 2, 5, Width, Color.Yellow)
                        })
                    },
                    {
                        16, new Grid(5, Width, Width, new List<Cell>
                        {
                            new InitialCell(1, 0, 5, Width, Color.Yellow),
                            new InitialCell(1, 1, 5, Width, Color.Green),
                            new InitialCell(1, 3, 5, Width, Color.Green),
                            new InitialCell(2, 0, 5, Width, Color.Blue),
                            new InitialCell(3, 1, 5, Width, Color.Yellow),
                            new InitialCell(3, 2, 5, Width, Color.Red),
                            new InitialCell(3, 4, 5, Width, Color.Red),
                            new InitialCell(4, 4, 5, Width, Color.Blue)
                        })
                    },
                    {
                        17, new Grid(5, Width, Width, new List<Cell>
                        {
                            new InitialCell(0, 0, 5, Width, Color.Red),
                            new InitialCell(0, 4, 5, Width, Color.Red),
                            new InitialCell(1, 1, 5, Width, Color.Blue),
                            new InitialCell(1, 2, 5, Width, Color.Green),
                            new InitialCell(1, 3, 5, Width, Color.Blue),
                            new InitialCell(1, 4, 5, Width, Color.Yellow),
                            new InitialCell(3, 1, 5, Width, Color.Green),
                            new InitialCell(4, 3, 5, Width, Color.Yellow)
                        })
                    },
                    {
                        18, new Grid(5, Width, Width, new List<Cell>
                        {
                            new InitialCell(1, 1, 5, Width, Color.Yellow),
                            new InitialCell(1, 3, 5, Width, Color.Blue),
                            new InitialCell(2, 2, 5, Width, Color.Blue),
                            new InitialCell(3, 2, 5, Width, Color.Red),
                            new InitialCell(3, 4, 5, Width, Color.Green),
                            new InitialCell(4, 0, 5, Width, Color.Red),
                            new InitialCell(4, 1, 5, Width, Color.Yellow),
                            new InitialCell(4, 2, 5, Width, Color.Green)
                        })
                    },
                    {
                        19, new Grid(5, Width, Width, new List<Cell>
                        {
                            new InitialCell(1, 0, 5, Width, Color.Red),
                            new InitialCell(1, 1, 5, Width, Color.Blue),
                            new InitialCell(1, 3, 5, Width, Color.Blue),
                            new InitialCell(2, 3, 5, Width, Color.Green),
                            new InitialCell(3, 0, 5, Width, Color.Green),
                            new InitialCell(3, 3, 5, Width, Color.Yellow),
                            new InitialCell(4, 0, 5, Width, Color.Yellow),
                            new InitialCell(4, 2, 5, Width, Color.Red)
                        })
                    },
                    {
                        20, new Grid(5, Width, Width, new List<Cell>
                        {
                            new InitialCell(0, 0, 5, Width, Color.Red),
                            new InitialCell(0, 2, 5, Width, Color.Green),
                            new InitialCell(0, 3, 5, Width, Color.Yellow),
                            new InitialCell(0, 4, 5, Width, Color.Blue),
                            new InitialCell(1, 0, 5, Width, Color.Blue),
                            new InitialCell(2, 2, 5, Width, Color.Green),
                            new InitialCell(3, 2, 5, Width, Color.Red),
                            new InitialCell(3, 3, 5, Width, Color.Yellow)
                        })
                    },
                    {
                        21, new Grid(5, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        22, new Grid(5, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        23, new Grid(5, Width, Width, new List<Cell>
                        {
                            new InitialCell(1, 0, 5, Width, Color.Blue),
                            new InitialCell(1, 1, 5, Width, Color.Green),
                            new InitialCell(1, 3, 5, Width, Color.Green),
                            new InitialCell(2, 0, 5, Width, Color.Red),
                            new InitialCell(3, 1, 5, Width, Color.Blue),
                            new InitialCell(3, 3, 5, Width, Color.Red),
                            new InitialCell(3, 4, 5, Width, Color.Yellow),
                            new InitialCell(4, 3, 5, Width, Color.Yellow)
                        })
                    },
                    {
                        24, new Grid(5, Width, Width, new List<Cell>
                        {
                            new InitialCell(0, 0, 5, Width, Color.Red),
                            new InitialCell(0, 4, 5, Width, Color.Red),
                            new InitialCell(2, 1, 5, Width, Color.Blue),
                            new InitialCell(2, 2, 5, Width, Color.Yellow),
                            new InitialCell(2, 4, 5, Width, Color.Green),
                            new InitialCell(3, 4, 5, Width, Color.Yellow),
                            new InitialCell(4, 1, 5, Width, Color.Green),
                            new InitialCell(4, 4, 5, Width, Color.Blue)
                        })
                    },
                    {
                        25, new Grid(5, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        26, new Grid(5, Width, Width, new List<Cell>
                        {
                            new InitialCell(1, 1, 5, Width, Color.Red),
                            new InitialCell(1, 3, 5, Width, Color.Red),
                            new InitialCell(2, 4, 5, Width, Color.Blue),
                            new InitialCell(3, 0, 5, Width, Color.Blue),
                            new InitialCell(3, 2, 5, Width, Color.Green),
                            new InitialCell(3, 4, 5, Width, Color.Yellow),
                            new InitialCell(4, 0, 5, Width, Color.Yellow),
                            new InitialCell(4, 4, 5, Width, Color.Green)
                        })
                    },
                    {
                        27, new Grid(5, Width, Width, new List<Cell>
                        {
                            new InitialCell(0, 2, 5, Width, Color.Green),
                            new InitialCell(0, 4, 5, Width, Color.Red),
                            new InitialCell(1, 1, 5, Width, Color.Red),
                            new InitialCell(1, 4, 5, Width, Color.Yellow),
                            new InitialCell(2, 1, 5, Width, Color.Blue),
                            new InitialCell(2, 3, 5, Width, Color.Blue),
                            new InitialCell(3, 1, 5, Width, Color.Yellow),
                            new InitialCell(4, 4, 5, Width, Color.Green)
                        })
                    },
                    {
                        28, new Grid(5, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        29, new Grid(5, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        30, new Grid(5, Width, Width, new List<Cell>
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
                    }

                }
            },
            {
                6, new Dictionary<int, Grid>
                {
                    {
                        1, new Grid(6, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        2, new Grid(6, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        3, new Grid(6, Width, Width, new List<Cell>
                        {
                            new InitialCell(1, 1, 6, Width, Color.Yellow),
                            new InitialCell(1, 4, 6, Width, Color.Green),
                            new InitialCell(2, 3, 6, Width, Color.Red),
                            new InitialCell(4, 2, 6, Width, Color.Yellow),
                            new InitialCell(4, 3, 6, Width, Color.Blue),
                            new InitialCell(4, 4, 6, Width, Color.Green),
                            new InitialCell(5, 2, 6, Width, Color.Blue),
                            new InitialCell(5, 3, 6, Width, Color.Red)
                        })
                    },
                    {
                        4, new Grid(6, Width, Width, new List<Cell>
                        {
                            new InitialCell(0, 0, 6, Width, Color.Yellow),
                            new InitialCell(3, 0, 6, Width, Color.Red),
                            new InitialCell(3, 1, 6, Width, Color.Green),
                            new InitialCell(3, 2, 6, Width, Color.Blue),
                            new InitialCell(3, 3, 6, Width, Color.Green),
                            new InitialCell(4, 0, 6, Width, Color.Yellow),
                            new InitialCell(4, 1, 6, Width, Color.Blue),
                            new InitialCell(4, 3, 6, Width, Color.Red)
                        })
                    },
                    {
                        5, new Grid(6, Width, Width, new List<Cell>
                        {
                            new InitialCell(0, 0, 6, Width, Color.Green),
                            new InitialCell(2, 0, 6, Width, Color.Yellow),
                            new InitialCell(2, 3, 6, Width, Color.Red),
                            new InitialCell(2, 4, 6, Width, Color.Yellow),
                            new InitialCell(3, 4, 6, Width, Color.Blue),
                            new InitialCell(4, 1, 6, Width, Color.Blue),
                            new InitialCell(4, 4, 6, Width, Color.Red),
                            new InitialCell(5, 4, 6, Width, Color.Green)
                        })
                    },
                    {
                        6, new Grid(6, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        7, new Grid(6, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        8, new Grid(6, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        9, new Grid(6, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        10, new Grid(6, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        11, new Grid(6, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        12, new Grid(6, Width, Width, new List<Cell>
                        {
                            new InitialCell(0, 1, 6, Width, Color.Green),
                            new InitialCell(0, 2, 6, Width, Color.Yellow),
                            new InitialCell(1, 1, 6, Width, Color.Blue),
                            new InitialCell(1, 2, 6, Width, Color.Red),
                            new InitialCell(2, 3, 6, Width, Color.Blue),
                            new InitialCell(3, 3, 6, Width, Color.Green),
                            new InitialCell(5, 0, 6, Width, Color.Red),
                            new InitialCell(5, 1, 6, Width, Color.Yellow)
                        })
                    },
                    {
                        13, new Grid(6, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        14, new Grid(6, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        15, new Grid(6, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        16, new Grid(6, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        17, new Grid(6, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        18, new Grid(6, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        19, new Grid(6, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        20, new Grid(6, Width, Width, new List<Cell>
                        {
                            new InitialCell(0, 0, 6, Width, Color.Blue),
                            new InitialCell(2, 4, 6, Width, Color.Yellow),
                            new InitialCell(3, 2, 6, Width, Color.Yellow),
                            new InitialCell(3, 3, 6, Width, Color.Green),
                            new InitialCell(3, 4, 6, Width, Color.Red),
                            new InitialCell(4, 1, 6, Width, Color.Green),
                            new InitialCell(4, 3, 6, Width, Color.Red),
                            new InitialCell(5, 3, 6, Width, Color.Blue)
                        })
                    },
                    {
                        21, new Grid(6, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        22, new Grid(6, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        23, new Grid(6, Width, Width, new List<Cell>
                        {
                            new InitialCell(0, 5, 6, Width, Color.Green),
                            new InitialCell(1, 5, 6, Width, Color.Blue),
                            new InitialCell(2, 2, 6, Width, Color.Yellow),
                            new InitialCell(2, 4, 6, Width, Color.Yellow),
                            new InitialCell(2, 5, 6, Width, Color.Red),
                            new InitialCell(3, 2, 6, Width, Color.Red),
                            new InitialCell(4, 5, 6, Width, Color.Blue),
                            new InitialCell(5, 5, 6, Width, Color.Green)
                        })
                    },
                    {
                        24, new Grid(6, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        25, new Grid(6, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        26, new Grid(6, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        27, new Grid(6, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        28, new Grid(6, Width, Width, new List<Cell>
                        {
                            new InitialCell(0, 0, 6, Width, Color.Yellow),
                            new InitialCell(0, 1, 6, Width, Color.Red),
                            new InitialCell(1, 1, 6, Width, Color.Blue),
                            new InitialCell(2, 3, 6, Width, Color.Yellow),
                            new InitialCell(4, 1, 6, Width, Color.Green),
                            new InitialCell(4, 4, 6, Width, Color.Green),
                            new InitialCell(5, 0, 6, Width, Color.Blue),
                            new InitialCell(5, 1, 6, Width, Color.Red)
                        })
                    },
                    {
                        29, new Grid(6, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        30, new Grid(6, Width, Width, new List<Cell>
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
                    }
                }
            },
            {
                7, new Dictionary<int, Grid>
                {
                    {
                        1, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        2, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        3, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        4, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        5, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        6, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        7, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        8, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        9, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        10, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        11, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        12, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        13, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        14, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        15, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        16, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        17, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        18, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        19, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        20, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        21, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        22, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        23, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        24, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        25, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        26, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        27, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        28, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        29, new Grid(7, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        30, new Grid(7, Width, Width, new List<Cell>
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
                    }
                }
            },
            {
                8, new Dictionary<int, Grid>
                {
                    {
                        1, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        2, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        3, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        4, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        5, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        6, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        7, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        8, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        9, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        10, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        11, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        12, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        13, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        14, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        15, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        16, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        17, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        18, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        19, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        20, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        21, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        22, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        23, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        24, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        25, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        26, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        27, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        28, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        29, new Grid(8, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        30, new Grid(8, Width, Width, new List<Cell>
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
                    }
                }
            },
            {
                9, new Dictionary<int, Grid>
                {
                    {
                        1, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        2, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        3, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        4, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        5, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        6, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        7, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        8, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        9, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        10, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        11, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        12, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        13, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        14, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        15, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        16, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        17, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        18, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        19, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        20, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        21, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        22, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        23, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        24, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        25, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        26, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        27, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        28, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        29, new Grid(9, Width, Width, new List<Cell>
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
                        })
                    },
                    {
                        30, new Grid(9, Width, Width, new List<Cell>
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
                    }
                }
            }
        };

        public int IsGroupOrLevelUnderMouse(int x, int y, out int groupLevel)
        {
            if (y >= 60 && y <= 110)
            {
                int width = 750;
                int height = 60;
                for (int i = 5; i <= 9; i++, width += 55)
                {
                    if (x >= width && x <= width + 50 && y >= height && y <= height + 50)
                    {
                        groupLevel = i;
                        return 1;
                    }
                }
            }
            else if (y >= 160 && y <= 490)
            {
                int height = 160;
                int width = 750;
                for (int i = 1; i <= 30; i++, width += 55)
                {
                    if (x >= width && x <= width + 50 && y >= height && y <= height + 50)
                    {
                        groupLevel = i;
                        return -1;
                    }

                    if (i % 5 == 0)
                    {
                        width = 695;
                        height += 55;
                    }
                }
            }

            groupLevel = 0;
            return 0;
        }

        public void Draw(Graphics graphics, int selectedGroup, int selectedLevel, Dictionary<int, HashSet<int>> solvedLevels)
        {
            // draw upper row (groups)
            int width = 750;
            int height = 60;
            Color[] colors = { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Orange };
            Color[] colorsFaded = { Color.LightCoral, Color.LightGreen, Color.LightBlue, Color.LightYellow, Color.LightSalmon };
            for (int i = 5; i <= 9; i++, width += 55)
            {
                if (i == selectedGroup)
                    graphics.FillRectangle(new SolidBrush(colorsFaded[i - 5]), width, height, 50, 50);

                graphics.DrawRectangle(new Pen(colors[i - 5], 1), width, height, 50, 50);
                var stringSize = graphics.MeasureString($"{i}", new Font("Arial", 15));
                graphics.DrawString($"{i}", new Font("Arial", 15), new SolidBrush(colors[i - 5]), (float)(width + (25 - stringSize.Width / 2.0)), (float)(height + (25 - stringSize.Height / 2.0)));
            }

			width = 750;
			for (int i = 5; i <= 9; i++, width += 55)
			{
				if (solvedLevels.ContainsKey(i) && solvedLevels[i].Count == 30)
					graphics.FillRectangle(new SolidBrush(colorsFaded[i - 5]), width, height, 50, 50);
				graphics.DrawRectangle(new Pen(colors[i - 5], 1), width, height, 50, 50);
				var stringSize = graphics.MeasureString($"{i}", new Font("Arial", 15));
				graphics.DrawString($"{i}", new Font("Arial", 15), new SolidBrush(colors[i - 5]), (float)(width + (25 - stringSize.Width / 2.0)), (float)(height + (25 - stringSize.Height / 2.0)));
			}

			// draw levels
			height = 160;
            width = 750;
            for (int i = 1; i <= 30; i++, width += 55)
            {
                var c = Color.Black;
                if (i == selectedLevel || solvedLevels.ContainsKey(selectedGroup) && solvedLevels[selectedGroup].Contains(i))
                {
                    c = colorsFaded[selectedGroup - 5];
                    graphics.FillRectangle(new SolidBrush(colorsFaded[selectedGroup - 5]), width, height, 50, 50);
				}
                graphics.DrawRectangle(Pens.White, width, height, 50, 50);
				if (i == selectedLevel)
					graphics.DrawRectangle(new Pen(colors[selectedGroup - 5], 2), width, height, 50, 50);
				var stringSize = graphics.MeasureString($"{i}", new Font("Arial", 15));
                var textColorBrush = c.R / 255.0 + c.G / 255.0 + c.B / 255.0 < 1.5 ? Brushes.White : Brushes.Black;
                graphics.DrawString($"{i}", new Font("Arial", 15), textColorBrush, (float)(width + (25 - stringSize.Width / 2.0)), (float)(height + (25 - stringSize.Height / 2.0)));

                if (i % 5 == 0)
                {
                    width = 695;
                    height += 55;
                }
            }
        }
    }
}
