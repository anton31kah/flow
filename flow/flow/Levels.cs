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
				new Cell(0, 0, 5, Width, 'r', true),
				new Cell(0, 2, 5, Width, 'g', true),
				new Cell(0, 4, 5, Width, 'y', true),
				new Cell(1, 2, 5, Width, 'b', true),
				new Cell(1, 4, 5, Width, 'o', true),
				new Cell(3, 1, 5, Width, 'g', true),
				new Cell(3, 3, 5, Width, 'y', true),
				new Cell(4, 1, 5, Width, 'r', true),
				new Cell(4, 2, 5, Width, 'b', true),
				new Cell(4, 3, 5, Width, 'o', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 5, Width, 'y', true),
				new Cell(2, 2, 5, Width, 'g', true),
				new Cell(3, 0, 5, Width, 'b', true),
				new Cell(3, 1, 5, Width, 'g', true),
				new Cell(3, 2, 5, Width, 'r', true),
				new Cell(3, 4, 5, Width, 'y', true),
				new Cell(4, 0, 5, Width, 'r', true),
				new Cell(4, 4, 5, Width, 'b', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(0, 1, 5, Width, 'y', true),
				new Cell(0, 2, 5, Width, 'b', true),
				new Cell(0, 3, 5, Width, 'g', true),
				new Cell(1, 3, 5, Width, 'r', true),
				new Cell(2, 2, 5, Width, 'r', true),
				new Cell(3, 0, 5, Width, 'y', true),
				new Cell(3, 3, 5, Width, 'o', true),
				new Cell(4, 0, 5, Width, 'b', true),
				new Cell(4, 2, 5, Width, 'o', true),
				new Cell(4, 3, 5, Width, 'g', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(0, 3, 5, Width, 'r', true),
				new Cell(0, 4, 5, Width, 'g', true),
				new Cell(1, 0, 5, Width, 'r', true),
				new Cell(2, 2, 5, Width, 'y', true),
				new Cell(3, 3, 5, Width, 'b', true),
				new Cell(4, 0, 5, Width, 'g', true),
				new Cell(4, 1, 5, Width, 'b', true),
				new Cell(4, 2, 5, Width, 'y', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(0, 3, 5, Width, 'r', true),
				new Cell(0, 4, 5, Width, 'g', true),
				new Cell(1, 1, 5, Width, 'y', true),
				new Cell(1, 2, 5, Width, 'b', true),
				new Cell(1, 3, 5, Width, 'g', true),
				new Cell(3, 4, 5, Width, 'b', true),
				new Cell(4, 2, 5, Width, 'r', true),
				new Cell(4, 4, 5, Width, 'y', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 5, Width, 'y', true),
				new Cell(0, 2, 5, Width, 'b', true),
				new Cell(0, 3, 5, Width, 'r', true),
				new Cell(0, 4, 5, Width, 'g', true),
				new Cell(2, 3, 5, Width, 'g', true),
				new Cell(3, 1, 5, Width, 'b', true),
				new Cell(3, 4, 5, Width, 'r', true),
				new Cell(4, 4, 5, Width, 'y', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 5, Width, 'b', true),
				new Cell(0, 3, 5, Width, 'y', true),
				new Cell(1, 0, 5, Width, 'g', true),
				new Cell(2, 0, 5, Width, 'y', true),
				new Cell(2, 2, 5, Width, 'g', true),
				new Cell(2, 3, 5, Width, 'b', true),
				new Cell(3, 1, 5, Width, 'r', true),
				new Cell(3, 3, 5, Width, 'r', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 5, Width, 'b', true),
				new Cell(0, 3, 5, Width, 'r', true),
				new Cell(0, 4, 5, Width, 'o', true),
				new Cell(1, 3, 5, Width, 'y', true),
				new Cell(2, 2, 5, Width, 'y', true),
				new Cell(3, 1, 5, Width, 'r', true),
				new Cell(3, 2, 5, Width, 'o', true),
				new Cell(3, 4, 5, Width, 'g', true),
				new Cell(4, 1, 5, Width, 'b', true),
				new Cell(4, 2, 5, Width, 'g', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(0, 3, 5, Width, 'r', true),
				new Cell(1, 1, 5, Width, 'y', true),
				new Cell(1, 2, 5, Width, 'b', true),
				new Cell(1, 3, 5, Width, 'g', true),
				new Cell(2, 2, 5, Width, 'y', true),
				new Cell(4, 0, 5, Width, 'b', true),
				new Cell(4, 1, 5, Width, 'g', true),
				new Cell(4, 2, 5, Width, 'r', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(1, 0, 5, Width, 'g', true),
				new Cell(1, 3, 5, Width, 'r', true),
				new Cell(2, 0, 5, Width, 'b', true),
				new Cell(2, 1, 5, Width, 'r', true),
				new Cell(2, 2, 5, Width, 'b', true),
				new Cell(2, 3, 5, Width, 'y', true),
				new Cell(4, 0, 5, Width, 'y', true),
				new Cell(4, 4, 5, Width, 'g', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 5, Width, 'b', true),
				new Cell(0, 1, 5, Width, 'y', true),
				new Cell(0, 2, 5, Width, 'r', true),
				new Cell(2, 1, 5, Width, 'b', true),
				new Cell(2, 2, 5, Width, 'g', true),
				new Cell(4, 0, 5, Width, 'g', true),
				new Cell(4, 1, 5, Width, 'y', true),
				new Cell(4, 4, 5, Width, 'r', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(0, 3, 5, Width, 'r', true),
				new Cell(0, 4, 5, Width, 'g', true),
				new Cell(1, 2, 5, Width, 'b', true),
				new Cell(1, 3, 5, Width, 'g', true),
				new Cell(2, 0, 5, Width, 'r', true),
				new Cell(3, 0, 5, Width, 'o', true),
				new Cell(3, 1, 5, Width, 'b', true),
				new Cell(3, 3, 5, Width, 'y', true),
				new Cell(3, 4, 5, Width, 'o', true),
				new Cell(4, 4, 5, Width, 'y', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 5, Width, 'g', true),
				new Cell(0, 1, 5, Width, 'y', true),
				new Cell(0, 3, 5, Width, 'y', true),
				new Cell(0, 4, 5, Width, 'o', true),
				new Cell(2, 0, 5, Width, 'r', true),
				new Cell(2, 2, 5, Width, 'o', true),
				new Cell(2, 3, 5, Width, 'b', true),
				new Cell(3, 3, 5, Width, 'g', true),
				new Cell(4, 3, 5, Width, 'r', true),
				new Cell(4, 4, 5, Width, 'b', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(0, 2, 5, Width, 'g', true),
				new Cell(0, 3, 5, Width, 'y', true),
				new Cell(0, 4, 5, Width, 'b', true),
				new Cell(2, 0, 5, Width, 'g', true),
				new Cell(2, 3, 5, Width, 'o', true),
				new Cell(3, 3, 5, Width, 'r', true),
				new Cell(3, 4, 5, Width, 'b', true),
				new Cell(4, 0, 5, Width, 'y', true),
				new Cell(4, 1, 5, Width, 'o', true),
				new Cell(4, 4, 5, Width, 'r', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 5, Width, 'b', true),
				new Cell(0, 1, 5, Width, 'y', true),
				new Cell(1, 2, 5, Width, 'g', true),
				new Cell(2, 0, 5, Width, 'r', true),
				new Cell(2, 2, 5, Width, 'b', true),
				new Cell(4, 0, 5, Width, 'r', true),
				new Cell(4, 1, 5, Width, 'g', true),
				new Cell(4, 2, 5, Width, 'y', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(1, 0, 5, Width, 'y', true),
				new Cell(1, 1, 5, Width, 'g', true),
				new Cell(1, 3, 5, Width, 'g', true),
				new Cell(2, 0, 5, Width, 'b', true),
				new Cell(3, 1, 5, Width, 'y', true),
				new Cell(3, 2, 5, Width, 'r', true),
				new Cell(3, 4, 5, Width, 'r', true),
				new Cell(4, 4, 5, Width, 'b', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 5, Width, 'r', true),
				new Cell(0, 4, 5, Width, 'r', true),
				new Cell(1, 1, 5, Width, 'b', true),
				new Cell(1, 2, 5, Width, 'g', true),
				new Cell(1, 3, 5, Width, 'b', true),
				new Cell(1, 4, 5, Width, 'y', true),
				new Cell(3, 1, 5, Width, 'g', true),
				new Cell(4, 3, 5, Width, 'y', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(1, 1, 5, Width, 'y', true),
				new Cell(1, 3, 5, Width, 'b', true),
				new Cell(2, 2, 5, Width, 'b', true),
				new Cell(3, 2, 5, Width, 'r', true),
				new Cell(3, 4, 5, Width, 'g', true),
				new Cell(4, 0, 5, Width, 'r', true),
				new Cell(4, 1, 5, Width, 'y', true),
				new Cell(4, 2, 5, Width, 'g', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(1, 0, 5, Width, 'r', true),
				new Cell(1, 1, 5, Width, 'b', true),
				new Cell(1, 3, 5, Width, 'b', true),
				new Cell(2, 3, 5, Width, 'g', true),
				new Cell(3, 0, 5, Width, 'g', true),
				new Cell(3, 3, 5, Width, 'y', true),
				new Cell(4, 0, 5, Width, 'y', true),
				new Cell(4, 2, 5, Width, 'r', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 5, Width, 'r', true),
				new Cell(0, 2, 5, Width, 'g', true),
				new Cell(0, 3, 5, Width, 'y', true),
				new Cell(0, 4, 5, Width, 'b', true),
				new Cell(1, 0, 5, Width, 'b', true),
				new Cell(2, 2, 5, Width, 'g', true),
				new Cell(3, 2, 5, Width, 'r', true),
				new Cell(3, 3, 5, Width, 'y', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(1, 1, 5, Width, 'g', true),
				new Cell(1, 2, 5, Width, 'r', true),
				new Cell(1, 4, 5, Width, 'y', true),
				new Cell(2, 4, 5, Width, 'o', true),
				new Cell(3, 0, 5, Width, 'y', true),
				new Cell(3, 1, 5, Width, 'b', true),
				new Cell(3, 3, 5, Width, 'r', true),
				new Cell(4, 0, 5, Width, 'b', true),
				new Cell(4, 2, 5, Width, 'g', true),
				new Cell(4, 3, 5, Width, 'o', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(0, 1, 5, Width, 'r', true),
				new Cell(1, 1, 5, Width, 'o', true),
				new Cell(1, 3, 5, Width, 'b', true),
				new Cell(2, 0, 5, Width, 'r', true),
				new Cell(2, 1, 5, Width, 'y', true),
				new Cell(2, 2, 5, Width, 'b', true),
				new Cell(3, 2, 5, Width, 'o', true),
				new Cell(4, 0, 5, Width, 'y', true),
				new Cell(4, 1, 5, Width, 'g', true),
				new Cell(4, 4, 5, Width, 'g', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(1, 0, 5, Width, 'b', true),
				new Cell(1, 1, 5, Width, 'g', true),
				new Cell(1, 3, 5, Width, 'g', true),
				new Cell(2, 0, 5, Width, 'r', true),
				new Cell(3, 1, 5, Width, 'b', true),
				new Cell(3, 3, 5, Width, 'r', true),
				new Cell(3, 4, 5, Width, 'y', true),
				new Cell(4, 3, 5, Width, 'y', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 5, Width, 'r', true),
				new Cell(0, 4, 5, Width, 'r', true),
				new Cell(2, 1, 5, Width, 'b', true),
				new Cell(2, 2, 5, Width, 'y', true),
				new Cell(2, 4, 5, Width, 'g', true),
				new Cell(3, 4, 5, Width, 'y', true),
				new Cell(4, 1, 5, Width, 'g', true),
				new Cell(4, 4, 5, Width, 'b', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 5, Width, 'g', true),
				new Cell(0, 1, 5, Width, 'r', true),
				new Cell(0, 4, 5, Width, 'r', true),
				new Cell(2, 3, 5, Width, 'o', true),
				new Cell(2, 4, 5, Width, 'g', true),
				new Cell(3, 0, 5, Width, 'o', true),
				new Cell(3, 3, 5, Width, 'b', true),
				new Cell(3, 4, 5, Width, 'y', true),
				new Cell(4, 0, 5, Width, 'b', true),
				new Cell(4, 2, 5, Width, 'y', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(1, 1, 5, Width, 'r', true),
				new Cell(1, 3, 5, Width, 'r', true),
				new Cell(2, 4, 5, Width, 'b', true),
				new Cell(3, 0, 5, Width, 'b', true),
				new Cell(3, 2, 5, Width, 'g', true),
				new Cell(3, 4, 5, Width, 'y', true),
				new Cell(4, 0, 5, Width, 'y', true),
				new Cell(4, 4, 5, Width, 'g', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(0, 2, 5, Width, 'g', true),
				new Cell(0, 4, 5, Width, 'r', true),
				new Cell(1, 1, 5, Width, 'r', true),
				new Cell(1, 4, 5, Width, 'y', true),
				new Cell(2, 1, 5, Width, 'b', true),
				new Cell(2, 3, 5, Width, 'b', true),
				new Cell(3, 1, 5, Width, 'y', true),
				new Cell(4, 4, 5, Width, 'g', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(1, 0, 5, Width, 'o', true),
				new Cell(1, 1, 5, Width, 'r', true),
				new Cell(1, 3, 5, Width, 'r', true),
				new Cell(1, 4, 5, Width, 'o', true),
				new Cell(2, 0, 5, Width, 'y', true),
				new Cell(3, 1, 5, Width, 'b', true),
				new Cell(3, 3, 5, Width, 'g', true),
				new Cell(4, 0, 5, Width, 'y', true),
				new Cell(4, 1, 5, Width, 'g', true),
				new Cell(4, 3, 5, Width, 'b', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 5, Width, 'g', true),
				new Cell(1, 0, 5, Width, 'o', true),
				new Cell(1, 1, 5, Width, 'r', true),
				new Cell(1, 3, 5, Width, 'r', true),
				new Cell(2, 3, 5, Width, 'o', true),
				new Cell(2, 4, 5, Width, 'g', true),
				new Cell(3, 0, 5, Width, 'b', true),
				new Cell(3, 3, 5, Width, 'b', true),
				new Cell(3, 4, 5, Width, 'y', true),
				new Cell(4, 0, 5, Width, 'y', true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 5, Width, 'b', true),
				new Cell(0, 4, 5, Width, 'y', true),
				new Cell(2, 1, 5, Width, 'r', true),
				new Cell(2, 2, 5, Width, 'g', true),
				new Cell(3, 2, 5, Width, 'b', true),
				new Cell(4, 0, 5, Width, 'g', true),
				new Cell(4, 1, 5, Width, 'r', true),
				new Cell(4, 2, 5, Width, 'y', true),
			})
		};

		public static List<Grid> Levels6 = new List<Grid>
		{
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 6, Width, 'g', true),
				new Cell(0, 1, 6, Width, 'y', true),
				new Cell(0, 2, 6, Width, 'c', true),
				new Cell(0, 4, 6, Width, 'r', true),
				new Cell(0, 5, 6, Width, 'b', true),
				new Cell(1, 4, 6, Width, 'o', true),
				new Cell(2, 2, 6, Width, 'c', true),
				new Cell(3, 2, 6, Width, 'r', true),
				new Cell(4, 0, 6, Width, 'g', true),
				new Cell(4, 2, 6, Width, 'o', true),
				new Cell(5, 0, 6, Width, 'y', true),
				new Cell(5, 2, 6, Width, 'b', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(0, 1, 6, Width, 'o', true),
				new Cell(0, 2, 6, Width, 'b', true),
				new Cell(0, 5, 6, Width, 'g', true),
				new Cell(2, 2, 6, Width, 'y', true),
				new Cell(2, 3, 6, Width, 'r', true),
				new Cell(2, 5, 6, Width, 'g', true),
				new Cell(3, 3, 6, Width, 'c', true),
				new Cell(3, 5, 6, Width, 'b', true),
				new Cell(4, 1, 6, Width, 'r', true),
				new Cell(4, 2, 6, Width, 'y', true),
				new Cell(4, 4, 6, Width, 'c', true),
				new Cell(4, 5, 6, Width, 'o', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(1, 1, 6, Width, 'y', true),
				new Cell(1, 4, 6, Width, 'g', true),
				new Cell(2, 3, 6, Width, 'r', true),
				new Cell(4, 2, 6, Width, 'y', true),
				new Cell(4, 3, 6, Width, 'b', true),
				new Cell(4, 4, 6, Width, 'g', true),
				new Cell(5, 2, 6, Width, 'b', true),
				new Cell(5, 3, 6, Width, 'r', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 6, Width, 'y', true),
				new Cell(3, 0, 6, Width, 'r', true),
				new Cell(3, 1, 6, Width, 'g', true),
				new Cell(3, 2, 6, Width, 'b', true),
				new Cell(3, 3, 6, Width, 'g', true),
				new Cell(4, 0, 6, Width, 'y', true),
				new Cell(4, 1, 6, Width, 'b', true),
				new Cell(4, 3, 6, Width, 'r', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 6, Width, 'g', true),
				new Cell(2, 0, 6, Width, 'y', true),
				new Cell(2, 3, 6, Width, 'r', true),
				new Cell(2, 4, 6, Width, 'y', true),
				new Cell(3, 4, 6, Width, 'b', true),
				new Cell(4, 1, 6, Width, 'b', true),
				new Cell(4, 4, 6, Width, 'r', true),
				new Cell(5, 4, 6, Width, 'g', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(0, 3, 6, Width, 'r', true),
				new Cell(0, 5, 6, Width, 'g', true),
				new Cell(1, 1, 6, Width, 'o', true),
				new Cell(1, 3, 6, Width, 'y', true),
				new Cell(2, 4, 6, Width, 'r', true),
				new Cell(2, 5, 6, Width, 'g', true),
				new Cell(3, 2, 6, Width, 'b', true),
				new Cell(3, 3, 6, Width, 'y', true),
				new Cell(3, 4, 6, Width, 'c', true),
				new Cell(3, 5, 6, Width, 'o', true),
				new Cell(4, 2, 6, Width, 'c', true),
				new Cell(5, 0, 6, Width, 'b', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(0, 2, 6, Width, 'b', true),
				new Cell(0, 3, 6, Width, 'y', true),
				new Cell(1, 1, 6, Width, 'o', true),
				new Cell(1, 2, 6, Width, 'g', true),
				new Cell(1, 5, 6, Width, 'y', true),
				new Cell(2, 3, 6, Width, 'b', true),
				new Cell(2, 5, 6, Width, 'r', true),
				new Cell(3, 2, 6, Width, 'o', true),
				new Cell(4, 0, 6, Width, 'r', true),
				new Cell(4, 4, 6, Width, 'g', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(0, 4, 6, Width, 'b', true),
				new Cell(0, 5, 6, Width, 'g', true),
				new Cell(1, 2, 6, Width, 'r', true),
				new Cell(2, 2, 6, Width, 'o', true),
				new Cell(3, 2, 6, Width, 'y', true),
				new Cell(3, 3, 6, Width, 'g', true),
				new Cell(4, 1, 6, Width, 'r', true),
				new Cell(4, 4, 6, Width, 'b', true),
				new Cell(5, 1, 6, Width, 'o', true),
				new Cell(5, 2, 6, Width, 'y', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 6, Width, 'r', true),
				new Cell(0, 1, 6, Width, 'g', true),
				new Cell(0, 5, 6, Width, 'g', true),
				new Cell(1, 2, 6, Width, 'c', true),
				new Cell(1, 5, 6, Width, 'c', true),
				new Cell(2, 0, 6, Width, 'o', true),
				new Cell(2, 5, 6, Width, 'r', true),
				new Cell(3, 1, 6, Width, 'y', true),
				new Cell(3, 5, 6, Width, 'y', true),
				new Cell(4, 1, 6, Width, 'b', true),
				new Cell(4, 5, 6, Width, 'b', true),
				new Cell(5, 5, 6, Width, 'o', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 6, Width, 'r', true),
				new Cell(1, 3, 6, Width, 'o', true),
				new Cell(1, 4, 6, Width, 'b', true),
				new Cell(1, 5, 6, Width, 'r', true),
				new Cell(2, 3, 6, Width, 'y', true),
				new Cell(2, 5, 6, Width, 'g', true),
				new Cell(3, 2, 6, Width, 'g', true),
				new Cell(4, 1, 6, Width, 'y', true),
				new Cell(4, 2, 6, Width, 'o', true),
				new Cell(4, 4, 6, Width, 'b', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(1, 1, 6, Width, 'b', true),
				new Cell(1, 2, 6, Width, 'o', true),
				new Cell(1, 4, 6, Width, 'o', true),
				new Cell(1, 5, 6, Width, 'r', true),
				new Cell(2, 5, 6, Width, 'b', true),
				new Cell(3, 4, 6, Width, 'r', true),
				new Cell(3, 5, 6, Width, 'g', true),
				new Cell(4, 0, 6, Width, 'g', true),
				new Cell(4, 1, 6, Width, 'y', true),
				new Cell(4, 4, 6, Width, 'y', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(0, 1, 6, Width, 'g', true),
				new Cell(0, 2, 6, Width, 'y', true),
				new Cell(1, 1, 6, Width, 'b', true),
				new Cell(1, 2, 6, Width, 'r', true),
				new Cell(2, 3, 6, Width, 'b', true),
				new Cell(3, 3, 6, Width, 'g', true),
				new Cell(5, 0, 6, Width, 'r', true),
				new Cell(5, 1, 6, Width, 'y', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(0, 2, 6, Width, 'b', true),
				new Cell(1, 1, 6, Width, 'g', true),
				new Cell(1, 2, 6, Width, 'r', true),
				new Cell(1, 4, 6, Width, 'y', true),
				new Cell(2, 0, 6, Width, 'b', true),
				new Cell(2, 5, 6, Width, 'r', true),
				new Cell(4, 0, 6, Width, 'y', true),
				new Cell(4, 1, 6, Width, 'o', true),
				new Cell(4, 4, 6, Width, 'g', true),
				new Cell(5, 0, 6, Width, 'o', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(0, 4, 6, Width, 'o', true),
				new Cell(1, 2, 6, Width, 'g', true),
				new Cell(1, 4, 6, Width, 'b', true),
				new Cell(3, 3, 6, Width, 'r', true),
				new Cell(4, 5, 6, Width, 'o', true),
				new Cell(5, 0, 6, Width, 'y', true),
				new Cell(5, 1, 6, Width, 'g', true),
				new Cell(5, 2, 6, Width, 'y', true),
				new Cell(5, 3, 6, Width, 'r', true),
				new Cell(5, 5, 6, Width, 'b', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 6, Width, 'y', true),
				new Cell(1, 0, 6, Width, 'b', true),
				new Cell(2, 0, 6, Width, 'r', true),
				new Cell(2, 1, 6, Width, 'b', true),
				new Cell(2, 3, 6, Width, 'g', true),
				new Cell(2, 4, 6, Width, 'c', true),
				new Cell(4, 3, 6, Width, 'o', true),
				new Cell(4, 4, 6, Width, 'g', true),
				new Cell(5, 0, 6, Width, 'r', true),
				new Cell(5, 1, 6, Width, 'c', true),
				new Cell(5, 2, 6, Width, 'o', true),
				new Cell(5, 3, 6, Width, 'y', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(0, 2, 6, Width, 'c', true),
				new Cell(0, 3, 6, Width, 'b', true),
				new Cell(1, 0, 6, Width, 'c', true),
				new Cell(1, 4, 6, Width, 'y', true),
				new Cell(2, 3, 6, Width, 'g', true),
				new Cell(2, 4, 6, Width, 'o', true),
				new Cell(3, 1, 6, Width, 'g', true),
				new Cell(3, 3, 6, Width, 'r', true),
				new Cell(4, 0, 6, Width, 'y', true),
				new Cell(4, 1, 6, Width, 'r', true),
				new Cell(4, 4, 6, Width, 'o', true),
				new Cell(5, 0, 6, Width, 'b', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(0, 1, 6, Width, 'y', true),
				new Cell(0, 5, 6, Width, 'r', true),
				new Cell(1, 1, 6, Width, 'r', true),
				new Cell(1, 3, 6, Width, 'b', true),
				new Cell(2, 1, 6, Width, 'c', true),
				new Cell(2, 3, 6, Width, 'g', true),
				new Cell(2, 4, 6, Width, 'o', true),
				new Cell(3, 2, 6, Width, 'c', true),
				new Cell(4, 0, 6, Width, 'g', true),
				new Cell(4, 2, 6, Width, 'y', true),
				new Cell(4, 4, 6, Width, 'o', true),
				new Cell(5, 4, 6, Width, 'b', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(0, 5, 6, Width, 'o', true),
				new Cell(1, 1, 6, Width, 'g', true),
				new Cell(1, 5, 6, Width, 'y', true),
				new Cell(2, 1, 6, Width, 'r', true),
				new Cell(2, 3, 6, Width, 'r', true),
				new Cell(4, 2, 6, Width, 'b', true),
				new Cell(4, 4, 6, Width, 'b', true),
				new Cell(5, 0, 6, Width, 'o', true),
				new Cell(5, 2, 6, Width, 'g', true),
				new Cell(5, 3, 6, Width, 'y', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 6, Width, 'g', true),
				new Cell(0, 1, 6, Width, 'o', true),
				new Cell(0, 5, 6, Width, 'b', true),
				new Cell(1, 5, 6, Width, 'r', true),
				new Cell(2, 2, 6, Width, 'b', true),
				new Cell(2, 3, 6, Width, 'r', true),
				new Cell(2, 4, 6, Width, 'g', true),
				new Cell(3, 4, 6, Width, 'o', true),
				new Cell(4, 1, 6, Width, 'y', true),
				new Cell(4, 4, 6, Width, 'y', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 6, Width, 'b', true),
				new Cell(2, 4, 6, Width, 'y', true),
				new Cell(3, 2, 6, Width, 'y', true),
				new Cell(3, 3, 6, Width, 'g', true),
				new Cell(3, 4, 6, Width, 'r', true),
				new Cell(4, 1, 6, Width, 'g', true),
				new Cell(4, 3, 6, Width, 'r', true),
				new Cell(5, 3, 6, Width, 'b', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 6, Width, 'b', true),
				new Cell(0, 1, 6, Width, 'r', true),
				new Cell(0, 3, 6, Width, 'o', true),
				new Cell(0, 4, 6, Width, 'c', true),
				new Cell(0, 5, 6, Width, 'g', true),
				new Cell(1, 1, 6, Width, 'b', true),
				new Cell(2, 0, 6, Width, 'y', true),
				new Cell(2, 1, 6, Width, 'r', true),
				new Cell(2, 3, 6, Width, 'o', true),
				new Cell(3, 3, 6, Width, 'y', true),
				new Cell(5, 0, 6, Width, 'c', true),
				new Cell(5, 1, 6, Width, 'g', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 6, Width, 'b', true),
				new Cell(0, 5, 6, Width, 'r', true),
				new Cell(1, 0, 6, Width, 'y', true),
				new Cell(2, 0, 6, Width, 'o', true),
				new Cell(2, 1, 6, Width, 'g', true),
				new Cell(3, 2, 6, Width, 'g', true),
				new Cell(3, 3, 6, Width, 'y', true),
				new Cell(4, 0, 6, Width, 'r', true),
				new Cell(4, 2, 6, Width, 'o', true),
				new Cell(4, 3, 6, Width, 'b', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(0, 5, 6, Width, 'g', true),
				new Cell(1, 5, 6, Width, 'b', true),
				new Cell(2, 2, 6, Width, 'y', true),
				new Cell(2, 4, 6, Width, 'y', true),
				new Cell(2, 5, 6, Width, 'r', true),
				new Cell(3, 2, 6, Width, 'r', true),
				new Cell(4, 5, 6, Width, 'b', true),
				new Cell(5, 5, 6, Width, 'g', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 6, Width, 'g', true),
				new Cell(0, 2, 6, Width, 'r', true),
				new Cell(0, 5, 6, Width, 'c', true),
				new Cell(1, 0, 6, Width, 'o', true),
				new Cell(1, 2, 6, Width, 'g', true),
				new Cell(1, 3, 6, Width, 'o', true),
				new Cell(3, 1, 6, Width, 'y', true),
				new Cell(3, 2, 6, Width, 'b', true),
				new Cell(4, 1, 6, Width, 'b', true),
				new Cell(4, 3, 6, Width, 'r', true),
				new Cell(4, 4, 6, Width, 'y', true),
				new Cell(5, 5, 6, Width, 'c', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(0, 1, 6, Width, 'g', true),
				new Cell(0, 2, 6, Width, 'o', true),
				new Cell(0, 5, 6, Width, 'o', true),
				new Cell(1, 5, 6, Width, 'r', true),
				new Cell(2, 2, 6, Width, 'c', true),
				new Cell(2, 3, 6, Width, 'b', true),
				new Cell(2, 5, 6, Width, 'b', true),
				new Cell(3, 3, 6, Width, 'y', true),
				new Cell(3, 4, 6, Width, 'c', true),
				new Cell(4, 4, 6, Width, 'y', true),
				new Cell(5, 0, 6, Width, 'g', true),
				new Cell(5, 1, 6, Width, 'r', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 6, Width, 'r', true),
				new Cell(1, 0, 6, Width, 'g', true),
				new Cell(2, 3, 6, Width, 'o', true),
				new Cell(3, 0, 6, Width, 'o', true),
				new Cell(3, 3, 6, Width, 'b', true),
				new Cell(4, 2, 6, Width, 'y', true),
				new Cell(4, 3, 6, Width, 'g', true),
				new Cell(5, 0, 6, Width, 'b', true),
				new Cell(5, 1, 6, Width, 'y', true),
				new Cell(5, 3, 6, Width, 'r', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 6, Width, 'o', true),
				new Cell(1, 0, 6, Width, 'y', true),
				new Cell(1, 4, 6, Width, 'r', true),
				new Cell(1, 5, 6, Width, 'g', true),
				new Cell(2, 4, 6, Width, 'b', true),
				new Cell(4, 1, 6, Width, 'o', true),
				new Cell(4, 4, 6, Width, 'r', true),
				new Cell(5, 2, 6, Width, 'y', true),
				new Cell(5, 3, 6, Width, 'g', true),
				new Cell(5, 4, 6, Width, 'b', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 6, Width, 'y', true),
				new Cell(0, 1, 6, Width, 'r', true),
				new Cell(1, 1, 6, Width, 'b', true),
				new Cell(2, 3, 6, Width, 'y', true),
				new Cell(4, 1, 6, Width, 'g', true),
				new Cell(4, 4, 6, Width, 'g', true),
				new Cell(5, 0, 6, Width, 'b', true),
				new Cell(5, 1, 6, Width, 'r', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(1, 0, 6, Width, 'b', true),
				new Cell(1, 1, 6, Width, 'r', true),
				new Cell(1, 2, 6, Width, 'y', true),
				new Cell(1, 3, 6, Width, 'o', true),
				new Cell(2, 0, 6, Width, 'r', true),
				new Cell(2, 3, 6, Width, 'g', true),
				new Cell(3, 0, 6, Width, 'g', true),
				new Cell(3, 5, 6, Width, 'b', true),
				new Cell(4, 1, 6, Width, 'y', true),
				new Cell(4, 4, 6, Width, 'o', true),
				new Cell(4, 5, 6, Width, 'c', true),
				new Cell(5, 3, 6, Width, 'c', true)
			}),
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(1, 0, 6, Width, 'r', true),
				new Cell(1, 1, 6, Width, 'b', true),
				new Cell(1, 3, 6, Width, 'g', true),
				new Cell(2, 1, 6, Width, 'y', true),
				new Cell(3, 1, 6, Width, 'o', true),
				new Cell(3, 5, 6, Width, 'r', true),
				new Cell(4, 1, 6, Width, 'y', true),
				new Cell(4, 4, 6, Width, 'g', true),
				new Cell(4, 5, 6, Width, 'b', true),
				new Cell(5, 0, 6, Width, 'o', true)
			})
		};

		public static List<Grid> Levels7 = new List<Grid>
		{
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(0, 6, 7, Width, 'b', true),
				new Cell(1, 5, 7, Width, 'o', true),
				new Cell(1, 6, 7, Width, 'r', true),
				new Cell(2, 1, 7, Width, 'o', true),
				new Cell(3, 3, 7, Width, 'g', true),
				new Cell(3, 4, 7, Width, 'c', true),
				new Cell(4, 2, 7, Width, 'g', true),
				new Cell(4, 4, 7, Width, 'y', true),
				new Cell(5, 4, 7, Width, 'r', true),
				new Cell(5, 5, 7, Width, 'y', true),
				new Cell(6, 5, 7, Width, 'b', true),
				new Cell(6, 6, 7, Width, 'c', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(0, 1, 7, Width, 'm', true),
				new Cell(0, 2, 7, Width, 'r', true),
				new Cell(1, 2, 7, Width, 'o', true),
				new Cell(1, 3, 7, Width, 'b', true),
				new Cell(1, 5, 7, Width, 'b', true),
				new Cell(2, 2, 7, Width, 'g', true),
				new Cell(3, 2, 7, Width, 'c', true),
				new Cell(3, 3, 7, Width, 'y', true),
				new Cell(3, 5, 7, Width, 'g', true),
				new Cell(4, 4, 7, Width, 'y', true),
				new Cell(4, 5, 7, Width, 'c', true),
				new Cell(5, 2, 7, Width, 'o', true),
				new Cell(6, 2, 7, Width, 'm', true),
				new Cell(6, 3, 7, Width, 'r', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 7, Width, 'c', true),
				new Cell(1, 0, 7, Width, 'y', true),
				new Cell(1, 6, 7, Width, 'c', true),
				new Cell(2, 0, 7, Width, 'm', true),
				new Cell(2, 2, 7, Width, 'm', true),
				new Cell(2, 3, 7, Width, 'o', true),
				new Cell(2, 4, 7, Width, 'g', true),
				new Cell(2, 6, 7, Width, 'y', true),
				new Cell(3, 0, 7, Width, 'n', true),
				new Cell(3, 2, 7, Width, 'r', true),
				new Cell(3, 6, 7, Width, 'g', true),
				new Cell(4, 0, 7, Width, 'b', true),
				new Cell(4, 5, 7, Width, 'o', true),
				new Cell(4, 6, 7, Width, 'r', true),
				new Cell(5, 1, 7, Width, 'n', true),
				new Cell(6, 6, 7, Width, 'b', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(1, 0, 7, Width, 'g', true),
				new Cell(2, 2, 7, Width, 'y', true),
				new Cell(3, 4, 7, Width, 'y', true),
				new Cell(4, 2, 7, Width, 'o', true),
				new Cell(4, 4, 7, Width, 'b', true),
				new Cell(5, 0, 7, Width, 'r', true),
				new Cell(5, 1, 7, Width, 'b', true),
				new Cell(5, 4, 7, Width, 'o', true),
				new Cell(5, 5, 7, Width, 'r', true),
				new Cell(6, 0, 7, Width, 'g', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 7, Width, 'c', true),
				new Cell(0, 1, 7, Width, 'b', true),
				new Cell(0, 2, 7, Width, 'y', true),
				new Cell(1, 5, 7, Width, 'g', true),
				new Cell(2, 1, 7, Width, 'r', true),
				new Cell(2, 3, 7, Width, 'y', true),
				new Cell(3, 1, 7, Width, 'o', true),
				new Cell(3, 4, 7, Width, 'b', true),
				new Cell(4, 2, 7, Width, 'r', true),
				new Cell(4, 4, 7, Width, 'g', true),
				new Cell(6, 1, 7, Width, 'c', true),
				new Cell(6, 6, 7, Width, 'o', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(1, 0, 7, Width, 'c', true),
				new Cell(1, 1, 7, Width, 'r', true),
				new Cell(1, 3, 7, Width, 'r', true),
				new Cell(1, 5, 7, Width, 'g', true),
				new Cell(2, 2, 7, Width, 'm', true),
				new Cell(2, 3, 7, Width, 'c', true),
				new Cell(2, 4, 7, Width, 'g', true),
				new Cell(3, 2, 7, Width, 'y', true),
				new Cell(3, 6, 7, Width, 'b', true),
				new Cell(4, 2, 7, Width, 'o', true),
				new Cell(5, 4, 7, Width, 'y', true),
				new Cell(5, 6, 7, Width, 'b', true),
				new Cell(6, 4, 7, Width, 'm', true),
				new Cell(6, 6, 7, Width, 'o', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(1, 0, 7, Width, 'g', true),
				new Cell(1, 1, 7, Width, 'r', true),
				new Cell(1, 5, 7, Width, 'r', true),
				new Cell(2, 0, 7, Width, 'o', true),
				new Cell(2, 1, 7, Width, 'g', true),
				new Cell(3, 1, 7, Width, 'b', true),
				new Cell(3, 3, 7, Width, 'b', true),
				new Cell(4, 1, 7, Width, 'y', true),
				new Cell(4, 2, 7, Width, 'o', true),
				new Cell(4, 5, 7, Width, 'y', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(0, 4, 7, Width, 'g', true),
				new Cell(0, 6, 7, Width, 'c', true),
				new Cell(1, 1, 7, Width, 'c', true),
				new Cell(1, 6, 7, Width, 'o', true),
				new Cell(3, 2, 7, Width, 'y', true),
				new Cell(3, 3, 7, Width, 'r', true),
				new Cell(3, 6, 7, Width, 'r', true),
				new Cell(4, 3, 7, Width, 'b', true),
				new Cell(4, 6, 7, Width, 'b', true),
				new Cell(5, 1, 7, Width, 'o', true),
				new Cell(5, 2, 7, Width, 'y', true),
				new Cell(5, 3, 7, Width, 'm', true),
				new Cell(6, 5, 7, Width, 'g', true),
				new Cell(6, 6, 7, Width, 'm', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(0, 5, 7, Width, 'o', true),
				new Cell(0, 6, 7, Width, 'r', true),
				new Cell(1, 0, 7, Width, 'o', true),
				new Cell(1, 1, 7, Width, 'c', true),
				new Cell(1, 2, 7, Width, 'g', true),
				new Cell(2, 4, 7, Width, 'b', true),
				new Cell(2, 6, 7, Width, 'b', true),
				new Cell(3, 1, 7, Width, 'y', true),
				new Cell(3, 6, 7, Width, 'r', true),
				new Cell(4, 5, 7, Width, 'g', true),
				new Cell(4, 6, 7, Width, 'c', true),
				new Cell(5, 5, 7, Width, 'y', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(0, 1, 7, Width, 'c', true),
				new Cell(1, 1, 7, Width, 'o', true),
				new Cell(2, 4, 7, Width, 'b', true),
				new Cell(3, 3, 7, Width, 'r', true),
				new Cell(4, 3, 7, Width, 'y', true),
				new Cell(5, 2, 7, Width, 'g', true),
				new Cell(5, 5, 7, Width, 'r', true),
				new Cell(6, 0, 7, Width, 'c', true),
				new Cell(6, 2, 7, Width, 'o', true),
				new Cell(6, 3, 7, Width, 'y', true),
				new Cell(6, 4, 7, Width, 'b', true),
				new Cell(6, 5, 7, Width, 'g', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(1, 0, 7, Width, 'b', true),
				new Cell(1, 1, 7, Width, 'm', true),
				new Cell(1, 2, 7, Width, 'c', true),
				new Cell(1, 5, 7, Width, 'r', true),
				new Cell(2, 3, 7, Width, 'b', true),
				new Cell(3, 1, 7, Width, 'o', true),
				new Cell(3, 3, 7, Width, 'c', true),
				new Cell(3, 4, 7, Width, 'y', true),
				new Cell(4, 0, 7, Width, 'm', true),
				new Cell(5, 0, 7, Width, 'y', true),
				new Cell(5, 1, 7, Width, 'g', true),
				new Cell(5, 3, 7, Width, 'g', true),
				new Cell(5, 4, 7, Width, 'o', true),
				new Cell(5, 5, 7, Width, 'r', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(1, 5, 7, Width, 'r', true),
				new Cell(2, 0, 7, Width, 'g', true),
				new Cell(2, 1, 7, Width, 'r', true),
				new Cell(2, 2, 7, Width, 'o', true),
				new Cell(2, 3, 7, Width, 'g', true),
				new Cell(3, 0, 7, Width, 'c', true),
				new Cell(3, 1, 7, Width, 'm', true),
				new Cell(3, 6, 7, Width, 'y', true),
				new Cell(4, 3, 7, Width, 'y', true),
				new Cell(5, 5, 7, Width, 'b', true),
				new Cell(6, 0, 7, Width, 'c', true),
				new Cell(6, 1, 7, Width, 'm', true),
				new Cell(6, 2, 7, Width, 'b', true),
				new Cell(6, 6, 7, Width, 'o', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(0, 5, 7, Width, 'y', true),
				new Cell(0, 6, 7, Width, 'o', true),
				new Cell(1, 1, 7, Width, 'r', true),
				new Cell(1, 2, 7, Width, 'b', true),
				new Cell(1, 4, 7, Width, 'b', true),
				new Cell(1, 5, 7, Width, 'r', true),
				new Cell(2, 4, 7, Width, 'c', true),
				new Cell(3, 3, 7, Width, 'c', true),
				new Cell(3, 6, 7, Width, 'o', true),
				new Cell(4, 0, 7, Width, 'g', true),
				new Cell(4, 6, 7, Width, 'y', true),
				new Cell(5, 6, 7, Width, 'g', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(1, 1, 7, Width, 'o', true),
				new Cell(1, 2, 7, Width, 'n', true),
				new Cell(1, 3, 7, Width, 'r', true),
				new Cell(1, 4, 7, Width, 'c', true),
				new Cell(1, 5, 7, Width, 'm', true),
				new Cell(2, 2, 7, Width, 'g', true),
				new Cell(2, 6, 7, Width, 'r', true),
				new Cell(3, 1, 7, Width, 'o', true),
				new Cell(3, 2, 7, Width, 'b', true),
				new Cell(4, 1, 7, Width, 'b', true),
				new Cell(4, 3, 7, Width, 'g', true),
				new Cell(4, 5, 7, Width, 'y', true),
				new Cell(5, 1, 7, Width, 'n', true),
				new Cell(6, 0, 7, Width, 'c', true),
				new Cell(6, 3, 7, Width, 'y', true),
				new Cell(6, 6, 7, Width, 'm', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 7, Width, 'r', true),
				new Cell(0, 5, 7, Width, 'y', true),
				new Cell(0, 6, 7, Width, 'g', true),
				new Cell(1, 0, 7, Width, 'y', true),
				new Cell(2, 1, 7, Width, 'b', true),
				new Cell(2, 2, 7, Width, 'o', true),
				new Cell(3, 4, 7, Width, 'r', true),
				new Cell(4, 0, 7, Width, 'g', true),
				new Cell(4, 2, 7, Width, 'o', true),
				new Cell(4, 4, 7, Width, 'b', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(1, 0, 7, Width, 'b', true),
				new Cell(1, 1, 7, Width, 'g', true),
				new Cell(2, 0, 7, Width, 'y', true),
				new Cell(2, 4, 7, Width, 'y', true),
				new Cell(3, 6, 7, Width, 'b', true),
				new Cell(4, 1, 7, Width, 'r', true),
				new Cell(5, 3, 7, Width, 'g', true),
				new Cell(5, 5, 7, Width, 'o', true),
				new Cell(6, 0, 7, Width, 'o', true),
				new Cell(6, 5, 7, Width, 'r', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(0, 6, 7, Width, 'r', true),
				new Cell(1, 1, 7, Width, 'm', true),
				new Cell(2, 1, 7, Width, 'b', true),
				new Cell(2, 4, 7, Width, 'm', true),
				new Cell(3, 1, 7, Width, 'o', true),
				new Cell(3, 2, 7, Width, 'y', true),
				new Cell(3, 4, 7, Width, 'b', true),
				new Cell(3, 5, 7, Width, 'o', true),
				new Cell(4, 1, 7, Width, 'c', true),
				new Cell(4, 5, 7, Width, 'r', true),
				new Cell(5, 1, 7, Width, 'g', true),
				new Cell(5, 5, 7, Width, 'y', true),
				new Cell(5, 6, 7, Width, 'g', true),
				new Cell(6, 2, 7, Width, 'c', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(1, 1, 7, Width, 'g', true),
				new Cell(1, 5, 7, Width, 'y', true),
				new Cell(2, 2, 7, Width, 'y', true),
				new Cell(2, 5, 7, Width, 'b', true),
				new Cell(2, 6, 7, Width, 'r', true),
				new Cell(3, 6, 7, Width, 'm', true),
				new Cell(4, 5, 7, Width, 'o', true),
				new Cell(4, 6, 7, Width, 'c', true),
				new Cell(5, 0, 7, Width, 'm', true),
				new Cell(5, 1, 7, Width, 'r', true),
				new Cell(5, 2, 7, Width, 'g', true),
				new Cell(5, 3, 7, Width, 'b', true),
				new Cell(6, 5, 7, Width, 'o', true),
				new Cell(6, 6, 7, Width, 'c', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(0, 3, 7, Width, 'y', true),
				new Cell(1, 5, 7, Width, 'c', true),
				new Cell(3, 5, 7, Width, 'g', true),
				new Cell(3, 6, 7, Width, 'r', true),
				new Cell(4, 3, 7, Width, 'g', true),
				new Cell(4, 5, 7, Width, 'c', true),
				new Cell(4, 6, 7, Width, 'b', true),
				new Cell(5, 5, 7, Width, 'o', true),
				new Cell(6, 0, 7, Width, 'y', true),
				new Cell(6, 1, 7, Width, 'r', true),
				new Cell(6, 2, 7, Width, 'o', true),
				new Cell(6, 6, 7, Width, 'b', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 7, Width, 'g', true),
				new Cell(0, 2, 7, Width, 'g', true),
				new Cell(0, 3, 7, Width, 'r', true),
				new Cell(1, 2, 7, Width, 'r', true),
				new Cell(1, 3, 7, Width, 'o', true),
				new Cell(2, 1, 7, Width, 'b', true),
				new Cell(2, 4, 7, Width, 'y', true),
				new Cell(3, 1, 7, Width, 'y', true),
				new Cell(3, 3, 7, Width, 'b', true),
				new Cell(4, 1, 7, Width, 'o', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 7, Width, 'b', true),
				new Cell(0, 4, 7, Width, 'o', true),
				new Cell(1, 0, 7, Width, 'g', true),
				new Cell(1, 4, 7, Width, 'b', true),
				new Cell(1, 5, 7, Width, 'r', true),
				new Cell(2, 0, 7, Width, 'y', true),
				new Cell(2, 3, 7, Width, 'o', true),
				new Cell(3, 0, 7, Width, 'c', true),
				new Cell(3, 1, 7, Width, 'y', true),
				new Cell(3, 3, 7, Width, 'g', true),
				new Cell(5, 2, 7, Width, 'r', true),
				new Cell(6, 0, 7, Width, 'c', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 7, Width, 'r', true),
				new Cell(1, 2, 7, Width, 'g', true),
				new Cell(1, 3, 7, Width, 'r', true),
				new Cell(1, 4, 7, Width, 'b', true),
				new Cell(1, 5, 7, Width, 'm', true),
				new Cell(2, 0, 7, Width, 'g', true),
				new Cell(3, 2, 7, Width, 'b', true),
				new Cell(4, 5, 7, Width, 'c', true),
				new Cell(4, 6, 7, Width, 'o', true),
				new Cell(5, 0, 7, Width, 'm', true),
				new Cell(5, 1, 7, Width, 'c', true),
				new Cell(5, 2, 7, Width, 'y', true),
				new Cell(5, 5, 7, Width, 'y', true),
				new Cell(6, 0, 7, Width, 'o', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 7, Width, 'g', true),
				new Cell(0, 4, 7, Width, 'r', true),
				new Cell(0, 6, 7, Width, 'c', true),
				new Cell(1, 6, 7, Width, 'o', true),
				new Cell(3, 3, 7, Width, 'o', true),
				new Cell(3, 4, 7, Width, 'y', true),
				new Cell(4, 3, 7, Width, 'c', true),
				new Cell(4, 4, 7, Width, 'g', true),
				new Cell(4, 5, 7, Width, 'b', true),
				new Cell(5, 3, 7, Width, 'r', true),
				new Cell(6, 5, 7, Width, 'b', true),
				new Cell(6, 6, 7, Width, 'y', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(0, 6, 7, Width, 'o', true),
				new Cell(1, 5, 7, Width, 'c', true),
				new Cell(1, 6, 7, Width, 'g', true),
				new Cell(2, 0, 7, Width, 'o', true),
				new Cell(3, 3, 7, Width, 'y', true),
				new Cell(4, 1, 7, Width, 'g', true),
				new Cell(4, 6, 7, Width, 'y', true),
				new Cell(5, 4, 7, Width, 'b', true),
				new Cell(5, 6, 7, Width, 'c', true),
				new Cell(6, 0, 7, Width, 'r', true),
				new Cell(6, 3, 7, Width, 'r', true),
				new Cell(6, 6, 7, Width, 'b', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 7, Width, 'g', true),
				new Cell(0, 1, 7, Width, 'r', true),
				new Cell(0, 6, 7, Width, 'y', true),
				new Cell(1, 1, 7, Width, 'y', true),
				new Cell(1, 5, 7, Width, 'r', true),
				new Cell(2, 1, 7, Width, 'b', true),
				new Cell(3, 1, 7, Width, 'o', true),
				new Cell(4, 1, 7, Width, 'c', true),
				new Cell(5, 5, 7, Width, 'o', true),
				new Cell(6, 3, 7, Width, 'g', true),
				new Cell(6, 4, 7, Width, 'c', true),
				new Cell(6, 5, 7, Width, 'b', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(0, 1, 7, Width, 'g', true),
				new Cell(0, 2, 7, Width, 'b', true),
				new Cell(1, 5, 7, Width, 'o', true),
				new Cell(2, 2, 7, Width, 'r', true),
				new Cell(4, 1, 7, Width, 'g', true),
				new Cell(4, 5, 7, Width, 'o', true),
				new Cell(5, 0, 7, Width, 'y', true),
				new Cell(5, 3, 7, Width, 'r', true),
				new Cell(5, 5, 7, Width, 'y', true),
				new Cell(6, 0, 7, Width, 'b', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(0, 3, 7, Width, 'b', true),
				new Cell(0, 4, 7, Width, 'r', true),
				new Cell(1, 4, 7, Width, 'y', true),
				new Cell(1, 5, 7, Width, 'g', true),
				new Cell(2, 1, 7, Width, 'o', true),
				new Cell(2, 2, 7, Width, 'y', true),
				new Cell(3, 1, 7, Width, 'r', true),
				new Cell(3, 3, 7, Width, 'o', true),
				new Cell(4, 5, 7, Width, 'g', true),
				new Cell(6, 6, 7, Width, 'b', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 7, Width, 'm', true),
				new Cell(0, 2, 7, Width, 'g', true),
				new Cell(0, 5, 7, Width, 'b', true),
				new Cell(1, 0, 7, Width, 'y', true),
				new Cell(1, 3, 7, Width, 'm', true),
				new Cell(1, 5, 7, Width, 'r', true),
				new Cell(2, 3, 7, Width, 'y', true),
				new Cell(3, 3, 7, Width, 'r', true),
				new Cell(3, 4, 7, Width, 'g', true),
				new Cell(4, 0, 7, Width, 'c', true),
				new Cell(4, 1, 7, Width, 'o', true),
				new Cell(5, 5, 7, Width, 'c', true),
				new Cell(6, 0, 7, Width, 'o', true),
				new Cell(6, 1, 7, Width, 'b', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(2, 1, 7, Width, 'r', true),
				new Cell(2, 2, 7, Width, 'b', true),
				new Cell(2, 4, 7, Width, 'b', true),
				new Cell(3, 1, 7, Width, 'c', true),
				new Cell(4, 3, 7, Width, 'g', true),
				new Cell(4, 4, 7, Width, 'c', true),
				new Cell(4, 5, 7, Width, 'r', true),
				new Cell(5, 0, 7, Width, 'g', true),
				new Cell(5, 1, 7, Width, 'y', true),
				new Cell(5, 3, 7, Width, 'o', true),
				new Cell(5, 4, 7, Width, 'y', true),
				new Cell(6, 6, 7, Width, 'o', true)
			}),
			new Grid(7, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 7, Width, 'o', true),
				new Cell(0, 2, 7, Width, 'g', true),
				new Cell(0, 4, 7, Width, 'g', true),
				new Cell(0, 5, 7, Width, 'b', true),
				new Cell(1, 0, 7, Width, 'y', true),
				new Cell(1, 2, 7, Width, 'm', true),
				new Cell(1, 5, 7, Width, 'c', true),
				new Cell(2, 4, 7, Width, 'm', true),
				new Cell(3, 4, 7, Width, 'c', true),
				new Cell(3, 6, 7, Width, 'b', true),
				new Cell(4, 0, 7, Width, 'o', true),
				new Cell(4, 1, 7, Width, 'r', true),
				new Cell(4, 2, 7, Width, 'y', true),
				new Cell(5, 5, 7, Width, 'r', true)
			})
		};

		public static List<Grid> Levels8 = new List<Grid>
		{
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(0, 4, 8, Width, 'r', true),
				new Cell(1, 4, 8, Width, 'c', true),
				new Cell(1, 6, 8, Width, 'g', true),
				new Cell(1, 7, 8, Width, 'y', true),
				new Cell(2, 4, 8, Width, 'g', true),
				new Cell(2, 5, 8, Width, 'y', true),
				new Cell(2, 7, 8, Width, 'c', true),
				new Cell(3, 3, 8, Width, 'o', true),
				new Cell(3, 4, 8, Width, 'b', true),
				new Cell(4, 4, 8, Width, 'o', true),
				new Cell(5, 4, 8, Width, 'b', true),
				new Cell(7, 1, 8, Width, 'r', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 8, Width, 'r', true),
				new Cell(0, 1, 8, Width, 'b', true),
				new Cell(0, 2, 8, Width, 'c', true),
				new Cell(1, 6, 8, Width, 'o', true),
				new Cell(3, 0, 8, Width, 'y', true),
				new Cell(3, 2, 8, Width, 'y', true),
				new Cell(3, 3, 8, Width, 'g', true),
				new Cell(5, 0, 8, Width, 'g', true),
				new Cell(5, 5, 8, Width, 'b', true),
				new Cell(7, 0, 8, Width, 'r', true),
				new Cell(7, 1, 8, Width, 'o', true),
				new Cell(7, 3, 8, Width, 'c', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(0, 1, 8, Width, 'r', true),
				new Cell(1, 3, 8, Width, 'y', true),
				new Cell(1, 6, 8, Width, 'y', true),
				new Cell(2, 2, 8, Width, 'b', true),
				new Cell(4, 3, 8, Width, 'r', true),
				new Cell(4, 4, 8, Width, 'c', true),
				new Cell(4, 7, 8, Width, 'g', true),
				new Cell(5, 3, 8, Width, 'o', true),
				new Cell(5, 7, 8, Width, 'b', true),
				new Cell(6, 1, 8, Width, 'c', true),
				new Cell(7, 6, 8, Width, 'o', true),
				new Cell(7, 7, 8, Width, 'g', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 8, Width, 'y', true),
				new Cell(1, 6, 8, Width, 'c', true),
				new Cell(1, 7, 8, Width, 'g', true),
				new Cell(2, 3, 8, Width, 'm', true),
				new Cell(3, 1, 8, Width, 'g', true),
				new Cell(3, 6, 8, Width, 'c', true),
				new Cell(3, 7, 8, Width, 'm', true),
				new Cell(4, 4, 8, Width, 'r', true),
				new Cell(4, 7, 8, Width, 'o', true),
				new Cell(5, 2, 8, Width, 'o', true),
				new Cell(5, 7, 8, Width, 'b', true),
				new Cell(6, 2, 8, Width, 'r', true),
				new Cell(6, 3, 8, Width, 'b', true),
				new Cell(6, 7, 8, Width, 'y', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(0, 7, 8, Width, 'c', true),
				new Cell(1, 1, 8, Width, 'b', true),
				new Cell(1, 2, 8, Width, 'o', true),
				new Cell(2, 7, 8, Width, 'o', true),
				new Cell(3, 3, 8, Width, 'c', true),
				new Cell(3, 5, 8, Width, 'g', true),
				new Cell(4, 5, 8, Width, 'y', true),
				new Cell(4, 6, 8, Width, 'r', true),
				new Cell(4, 7, 8, Width, 'b', true),
				new Cell(5, 7, 8, Width, 'y', true),
				new Cell(6, 2, 8, Width, 'r', true),
				new Cell(7, 0, 8, Width, 'g', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 8, Width, 'r', true),
				new Cell(0, 7, 8, Width, 'b', true),
				new Cell(1, 0, 8, Width, 'm', true),
				new Cell(1, 4, 8, Width, 'o', true),
				new Cell(2, 0, 8, Width, 'y', true),
				new Cell(4, 6, 8, Width, 'b', true),
				new Cell(4, 7, 8, Width, 'o', true),
				new Cell(5, 4, 8, Width, 'm', true),
				new Cell(5, 7, 8, Width, 'r', true),
				new Cell(6, 1, 8, Width, 'g', true),
				new Cell(6, 2, 8, Width, 'c', true),
				new Cell(7, 1, 8, Width, 'y', true),
				new Cell(7, 6, 8, Width, 'c', true),
				new Cell(7, 7, 8, Width, 'g', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(1, 4, 8, Width, 'r', true),
				new Cell(1, 5, 8, Width, 'b', true),
				new Cell(1, 6, 8, Width, 'y', true),
				new Cell(2, 2, 8, Width, 'g', true),
				new Cell(4, 4, 8, Width, 'o', true),
				new Cell(5, 2, 8, Width, 'g', true),
				new Cell(5, 4, 8, Width, 'b', true),
				new Cell(5, 5, 8, Width, 'r', true),
				new Cell(6, 5, 8, Width, 'y', true),
				new Cell(7, 7, 8, Width, 'o', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(0, 5, 8, Width, 'c', true),
				new Cell(0, 6, 8, Width, 'o', true),
				new Cell(0, 7, 8, Width, 'g', true),
				new Cell(2, 1, 8, Width, 'o', true),
				new Cell(4, 4, 8, Width, 'y', true),
				new Cell(5, 1, 8, Width, 'g', true),
				new Cell(5, 2, 8, Width, 'b', true),
				new Cell(5, 3, 8, Width, 'm', true),
				new Cell(5, 4, 8, Width, 'r', true),
				new Cell(5, 7, 8, Width, 'b', true),
				new Cell(6, 1, 8, Width, 'm', true),
				new Cell(6, 4, 8, Width, 'c', true),
				new Cell(6, 7, 8, Width, 'y', true),
				new Cell(7, 7, 8, Width, 'r', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(0, 1, 8, Width, 'b', true),
				new Cell(0, 7, 8, Width, 'c', true),
				new Cell(1, 7, 8, Width, 'r', true),
				new Cell(2, 7, 8, Width, 'g', true),
				new Cell(3, 3, 8, Width, 'o', true),
				new Cell(3, 4, 8, Width, 'g', true),
				new Cell(3, 5, 8, Width, 'y', true),
				new Cell(3, 7, 8, Width, 'y', true),
				new Cell(4, 6, 8, Width, 'c', true),
				new Cell(6, 5, 8, Width, 'r', true),
				new Cell(6, 6, 8, Width, 'o', true),
				new Cell(7, 2, 8, Width, 'b', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(1, 6, 8, Width, 'y', true),
				new Cell(2, 2, 8, Width, 'b', true),
				new Cell(3, 4, 8, Width, 'g', true),
				new Cell(3, 5, 8, Width, 'b', true),
				new Cell(3, 6, 8, Width, 'r', true),
				new Cell(3, 7, 8, Width, 'o', true),
				new Cell(4, 1, 8, Width, 'o', true),
				new Cell(5, 3, 8, Width, 'r', true),
				new Cell(6, 2, 8, Width, 'y', true),
				new Cell(6, 3, 8, Width, 'c', true),
				new Cell(6, 6, 8, Width, 'c', true),
				new Cell(7, 0, 8, Width, 'g', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 8, Width, 'c', true),
				new Cell(0, 1, 8, Width, 'y', true),
				new Cell(0, 2, 8, Width, 'm', true),
				new Cell(1, 6, 8, Width, 'y', true),
				new Cell(2, 1, 8, Width, 'o', true),
				new Cell(2, 4, 8, Width, 'o', true),
				new Cell(2, 6, 8, Width, 'b', true),
				new Cell(4, 2, 8, Width, 'r', true),
				new Cell(4, 3, 8, Width, 'g', true),
				new Cell(4, 7, 8, Width, 'b', true),
				new Cell(5, 6, 8, Width, 'm', true),
				new Cell(6, 4, 8, Width, 'r', true),
				new Cell(6, 6, 8, Width, 'g', true),
				new Cell(7, 2, 8, Width, 'c', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(0, 4, 8, Width, 'g', true),
				new Cell(0, 6, 8, Width, 'y', true),
				new Cell(1, 1, 8, Width, 'g', true),
				new Cell(1, 4, 8, Width, 'c', true),
				new Cell(2, 1, 8, Width, 'b', true),
				new Cell(2, 4, 8, Width, 'r', true),
				new Cell(2, 5, 8, Width, 'o', true),
				new Cell(4, 4, 8, Width, 'o', true),
				new Cell(4, 5, 8, Width, 'r', true),
				new Cell(5, 0, 8, Width, 'c', true),
				new Cell(6, 0, 8, Width, 'y', true),
				new Cell(6, 1, 8, Width, 'b', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 8, Width, 'g', true),
				new Cell(0, 1, 8, Width, 'r', true),
				new Cell(0, 3, 8, Width, 'c', true),
				new Cell(0, 6, 8, Width, 'r', true),
				new Cell(0, 7, 8, Width, 'b', true),
				new Cell(1, 1, 8, Width, 'g', true),
				new Cell(1, 6, 8, Width, 'y', true),
				new Cell(2, 0, 8, Width, 'b', true),
				new Cell(2, 1, 8, Width, 'o', true),
				new Cell(2, 6, 8, Width, 'o', true),
				new Cell(3, 3, 8, Width, 'c', true),
				new Cell(5, 2, 8, Width, 'y', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(0, 7, 8, Width, 'y', true),
				new Cell(1, 6, 8, Width, 'g', true),
				new Cell(1, 7, 8, Width, 'c', true),
				new Cell(3, 4, 8, Width, 'o', true),
				new Cell(3, 5, 8, Width, 'b', true),
				new Cell(4, 4, 8, Width, 'b', true),
				new Cell(5, 2, 8, Width, 'r', true),
				new Cell(5, 5, 8, Width, 'o', true),
				new Cell(6, 6, 8, Width, 'r', true),
				new Cell(7, 4, 8, Width, 'y', true),
				new Cell(7, 6, 8, Width, 'g', true),
				new Cell(7, 7, 8, Width, 'c', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(0, 1, 8, Width, 'g', true),
				new Cell(2, 4, 8, Width, 'y', true),
				new Cell(2, 5, 8, Width, 'b', true),
				new Cell(3, 6, 8, Width, 'r', true),
				new Cell(4, 3, 8, Width, 'y', true),
				new Cell(4, 4, 8, Width, 'o', true),
				new Cell(5, 7, 8, Width, 'o', true),
				new Cell(6, 2, 8, Width, 'b', true),
				new Cell(6, 5, 8, Width, 'c', true),
				new Cell(6, 7, 8, Width, 'c', true),
				new Cell(7, 3, 8, Width, 'g', true),
				new Cell(7, 7, 8, Width, 'r', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 8, Width, 'g', true),
				new Cell(0, 6, 8, Width, 'm', true),
				new Cell(0, 7, 8, Width, 'g', true),
				new Cell(1, 4, 8, Width, 'o', true),
				new Cell(2, 4, 8, Width, 'c', true),
				new Cell(3, 2, 8, Width, 'r', true),
				new Cell(3, 4, 8, Width, 'b', true),
				new Cell(4, 0, 8, Width, 'o', true),
				new Cell(4, 4, 8, Width, 'y', true),
				new Cell(5, 0, 8, Width, 'y', true),
				new Cell(5, 2, 8, Width, 'r', true),
				new Cell(6, 2, 8, Width, 'c', true),
				new Cell(6, 3, 8, Width, 'b', true),
				new Cell(6, 6, 8, Width, 'm', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 8, Width, 'b', true),
				new Cell(2, 1, 8, Width, 'm', true),
				new Cell(3, 0, 8, Width, 'o', true),
				new Cell(3, 1, 8, Width, 'n', true),
				new Cell(3, 4, 8, Width, 'n', true),
				new Cell(4, 0, 8, Width, 'c', true),
				new Cell(4, 4, 8, Width, 'r', true),
				new Cell(4, 6, 8, Width, 'o', true),
				new Cell(5, 3, 8, Width, 'y', true),
				new Cell(5, 4, 8, Width, 'c', true),
				new Cell(5, 5, 8, Width, 'm', true),
				new Cell(5, 6, 8, Width, 'g', true),
				new Cell(6, 1, 8, Width, 'r', true),
				new Cell(6, 2, 8, Width, 'y', true),
				new Cell(7, 4, 8, Width, 'g', true),
				new Cell(7, 6, 8, Width, 'b', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 8, Width, 'c', true),
				new Cell(0, 4, 8, Width, 'o', true),
				new Cell(1, 0, 8, Width, 'b', true),
				new Cell(1, 5, 8, Width, 'r', true),
				new Cell(1, 6, 8, Width, 'y', true),
				new Cell(1, 7, 8, Width, 'r', true),
				new Cell(2, 0, 8, Width, 'c', true),
				new Cell(2, 2, 8, Width, 'b', true),
				new Cell(2, 5, 8, Width, 'y', true),
				new Cell(2, 7, 8, Width, 'g', true),
				new Cell(3, 0, 8, Width, 'p', true),
				new Cell(3, 5, 8, Width, 'n', true),
				new Cell(3, 6, 8, Width, 'p', true),
				new Cell(4, 2, 8, Width, 'n', true),
				new Cell(4, 3, 8, Width, 'm', true),
				new Cell(5, 2, 8, Width, 'm', true),
				new Cell(5, 4, 8, Width, 'o', true),
				new Cell(7, 7, 8, Width, 'g', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(0, 1, 8, Width, 'c', true),
				new Cell(0, 6, 8, Width, 'o', true),
				new Cell(1, 1, 8, Width, 'n', true),
				new Cell(1, 4, 8, Width, 'r', true),
				new Cell(2, 1, 8, Width, 'r', true),
				new Cell(2, 4, 8, Width, 'o', true),
				new Cell(2, 6, 8, Width, 'n', true),
				new Cell(3, 2, 8, Width, 'c', true),
				new Cell(3, 3, 8, Width, 'm', true),
				new Cell(3, 4, 8, Width, 'b', true),
				new Cell(4, 0, 8, Width, 'm', true),
				new Cell(4, 5, 8, Width, 'y', true),
				new Cell(4, 6, 8, Width, 'b', true),
				new Cell(5, 6, 8, Width, 'y', true),
				new Cell(6, 1, 8, Width, 'g', true),
				new Cell(6, 6, 8, Width, 'g', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(0, 2, 8, Width, 'o', true),
				new Cell(0, 4, 8, Width, 'r', true),
				new Cell(0, 5, 8, Width, 'p', true),
				new Cell(1, 1, 8, Width, 'y', true),
				new Cell(1, 4, 8, Width, 'm', true),
				new Cell(1, 6, 8, Width, 'm', true),
				new Cell(2, 7, 8, Width, 'p', true),
				new Cell(3, 0, 8, Width, 'g', true),
				new Cell(3, 5, 8, Width, 'y', true),
				new Cell(3, 7, 8, Width, 'r', true),
				new Cell(4, 7, 8, Width, 'c', true),
				new Cell(5, 5, 8, Width, 'b', true),
				new Cell(6, 1, 8, Width, 'o', true),
				new Cell(6, 2, 8, Width, 'n', true),
				new Cell(6, 3, 8, Width, 'b', true),
				new Cell(7, 3, 8, Width, 'g', true),
				new Cell(7, 4, 8, Width, 'n', true),
				new Cell(7, 5, 8, Width, 'c', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(0, 5, 8, Width, 'n', true),
				new Cell(0, 6, 8, Width, 'o', true),
				new Cell(0, 7, 8, Width, 'b', true),
				new Cell(2, 1, 8, Width, 'g', true),
				new Cell(2, 6, 8, Width, 'o', true),
				new Cell(3, 3, 8, Width, 'r', true),
				new Cell(4, 1, 8, Width, 'y', true),
				new Cell(4, 5, 8, Width, 'c', true),
				new Cell(4, 7, 8, Width, 'b', true),
				new Cell(5, 3, 8, Width, 'm', true),
				new Cell(6, 1, 8, Width, 'r', true),
				new Cell(6, 6, 8, Width, 'c', true),
				new Cell(7, 1, 8, Width, 'n', true),
				new Cell(7, 2, 8, Width, 'm', true),
				new Cell(7, 3, 8, Width, 'y', true),
				new Cell(7, 5, 8, Width, 'g', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(0, 4, 8, Width, 'o', true),
				new Cell(0, 6, 8, Width, 'b', true),
				new Cell(1, 2, 8, Width, 'c', true),
				new Cell(1, 5, 8, Width, 'o', true),
				new Cell(1, 6, 8, Width, 'r', true),
				new Cell(2, 2, 8, Width, 'b', true),
				new Cell(2, 3, 8, Width, 'g', true),
				new Cell(3, 4, 8, Width, 'r', true),
				new Cell(4, 5, 8, Width, 'y', true),
				new Cell(6, 1, 8, Width, 'c', true),
				new Cell(6, 6, 8, Width, 'g', true),
				new Cell(7, 1, 8, Width, 'y', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 8, Width, 'g', true),
				new Cell(0, 7, 8, Width, 'c', true),
				new Cell(1, 2, 8, Width, 'b', true),
				new Cell(1, 3, 8, Width, 'o', true),
				new Cell(1, 4, 8, Width, 'c', true),
				new Cell(1, 5, 8, Width, 'm', true),
				new Cell(2, 6, 8, Width, 'b', true),
				new Cell(4, 1, 8, Width, 'y', true),
				new Cell(5, 4, 8, Width, 'r', true),
				new Cell(6, 1, 8, Width, 'r', true),
				new Cell(6, 4, 8, Width, 'g', true),
				new Cell(6, 5, 8, Width, 'y', true),
				new Cell(6, 6, 8, Width, 'o', true),
				new Cell(7, 3, 8, Width, 'm', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(0, 1, 8, Width, 'g', true),
				new Cell(0, 2, 8, Width, 'o', true),
				new Cell(1, 1, 8, Width, 'o', true),
				new Cell(1, 2, 8, Width, 'c', true),
				new Cell(2, 3, 8, Width, 'c', true),
				new Cell(2, 5, 8, Width, 'r', true),
				new Cell(3, 1, 8, Width, 'y', true),
				new Cell(3, 3, 8, Width, 'm', true),
				new Cell(4, 5, 8, Width, 'r', true),
				new Cell(4, 6, 8, Width, 'b', true),
				new Cell(5, 5, 8, Width, 'b', true),
				new Cell(5, 6, 8, Width, 'm', true),
				new Cell(7, 0, 8, Width, 'g', true),
				new Cell(7, 1, 8, Width, 'y', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 8, Width, 'm', true),
				new Cell(0, 3, 8, Width, 'c', true),
				new Cell(1, 1, 8, Width, 'y', true),
				new Cell(1, 3, 8, Width, 'r', true),
				new Cell(1, 4, 8, Width, 'b', true),
				new Cell(2, 1, 8, Width, 'm', true),
				new Cell(3, 1, 8, Width, 'o', true),
				new Cell(4, 3, 8, Width, 'y', true),
				new Cell(5, 3, 8, Width, 'g', true),
				new Cell(6, 0, 8, Width, 'g', true),
				new Cell(6, 6, 8, Width, 'b', true),
				new Cell(7, 0, 8, Width, 'o', true),
				new Cell(7, 2, 8, Width, 'r', true),
				new Cell(7, 6, 8, Width, 'c', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 8, Width, 'b', true),
				new Cell(1, 0, 8, Width, 'y', true),
				new Cell(1, 1, 8, Width, 'c', true),
				new Cell(1, 3, 8, Width, 'o', true),
				new Cell(2, 2, 8, Width, 'b', true),
				new Cell(2, 5, 8, Width, 'n', true),
				new Cell(3, 1, 8, Width, 'c', true),
				new Cell(3, 2, 8, Width, 'g', true),
				new Cell(4, 2, 8, Width, 'm', true),
				new Cell(4, 4, 8, Width, 'n', true),
				new Cell(5, 0, 8, Width, 'r', true),
				new Cell(5, 2, 8, Width, 'y', true),
				new Cell(5, 4, 8, Width, 'm', true),
				new Cell(5, 5, 8, Width, 'g', true),
				new Cell(5, 6, 8, Width, 'r', true),
				new Cell(7, 0, 8, Width, 'o', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(1, 1, 8, Width, 'm', true),
				new Cell(1, 7, 8, Width, 'o', true),
				new Cell(2, 7, 8, Width, 'c', true),
				new Cell(3, 4, 8, Width, 'g', true),
				new Cell(3, 5, 8, Width, 'b', true),
				new Cell(5, 2, 8, Width, 'g', true),
				new Cell(5, 5, 8, Width, 'y', true),
				new Cell(6, 2, 8, Width, 'b', true),
				new Cell(6, 3, 8, Width, 'm', true),
				new Cell(6, 4, 8, Width, 'y', true),
				new Cell(6, 5, 8, Width, 'c', true),
				new Cell(6, 7, 8, Width, 'r', true),
				new Cell(7, 3, 8, Width, 'o', true),
				new Cell(7, 4, 8, Width, 'r', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(1, 2, 8, Width, 'm', true),
				new Cell(1, 3, 8, Width, 'o', true),
				new Cell(1, 7, 8, Width, 'b', true),
				new Cell(2, 5, 8, Width, 'y', true),
				new Cell(3, 1, 8, Width, 'm', true),
				new Cell(3, 3, 8, Width, 'g', true),
				new Cell(3, 6, 8, Width, 'c', true),
				new Cell(4, 1, 8, Width, 'r', true),
				new Cell(5, 1, 8, Width, 'g', true),
				new Cell(5, 4, 8, Width, 'r', true),
				new Cell(6, 1, 8, Width, 'y', true),
				new Cell(7, 3, 8, Width, 'b', true),
				new Cell(7, 4, 8, Width, 'c', true),
				new Cell(7, 7, 8, Width, 'o', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 8, Width, 'c', true),
				new Cell(0, 7, 8, Width, 'r', true),
				new Cell(1, 6, 8, Width, 'y', true),
				new Cell(2, 3, 8, Width, 'g', true),
				new Cell(2, 6, 8, Width, 'o', true),
				new Cell(3, 7, 8, Width, 'y', true),
				new Cell(4, 2, 8, Width, 'r', true),
				new Cell(4, 5, 8, Width, 'o', true),
				new Cell(5, 5, 8, Width, 'b', true),
				new Cell(5, 6, 8, Width, 'c', true),
				new Cell(6, 1, 8, Width, 'b', true),
				new Cell(7, 3, 8, Width, 'g', true)
			}),
			new Grid(8, Width, Width, new List<Cell>
			{
				new Cell(0, 4, 8, Width, 'o', true),
				new Cell(0, 5, 8, Width, 'm', true),
				new Cell(0, 6, 8, Width, 'o', true),
				new Cell(1, 4, 8, Width, 'r', true),
				new Cell(1, 6, 8, Width, 'c', true),
				new Cell(2, 2, 8, Width, 'g', true),
				new Cell(3, 5, 8, Width, 'm', true),
				new Cell(3, 6, 8, Width, 'c', true),
				new Cell(4, 2, 8, Width, 'g', true),
				new Cell(4, 3, 8, Width, 'b', true),
				new Cell(5, 5, 8, Width, 'y', true),
				new Cell(6, 1, 8, Width, 'b', true),
				new Cell(6, 2, 8, Width, 'y', true),
				new Cell(6, 3, 8, Width, 'r', true)
			})
		};

		public static List<Grid> Levels9 = new List<Grid>
		{
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(1, 1, 9, Width, 'r', true),
				new Cell(1, 2, 9, Width, 'c', true),
				new Cell(1, 3, 9, Width, 'b', true),
				new Cell(2, 3, 9, Width, 'c', true),
				new Cell(2, 4, 9, Width, 'o', true),
				new Cell(2, 6, 9, Width, 'o', true),
				new Cell(2, 7, 9, Width, 'b', true),
				new Cell(3, 7, 9, Width, 'm', true),
				new Cell(4, 1, 9, Width, 'g', true),
				new Cell(4, 3, 9, Width, 'g', true),
				new Cell(4, 4, 9, Width, 'r', true),
				new Cell(5, 0, 9, Width, 'y', true),
				new Cell(5, 1, 9, Width, 'm', true),
				new Cell(5, 7, 9, Width, 'n', true),
				new Cell(5, 8, 9, Width, 'p', true),
				new Cell(6, 1, 9, Width, 'p', true),
				new Cell(6, 2, 9, Width, 'y', true),
				new Cell(7, 1, 9, Width, 'n', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 9, Width, 'b', true),
				new Cell(0, 7, 9, Width, 'n', true),
				new Cell(3, 0, 9, Width, 'n', true),
				new Cell(3, 3, 9, Width, 'r', true),
				new Cell(3, 5, 9, Width, 'm', true),
				new Cell(3, 7, 9, Width, 'b', true),
				new Cell(4, 3, 9, Width, 'g', true),
				new Cell(4, 7, 9, Width, 'c', true),
				new Cell(5, 1, 9, Width, 'o', true),
				new Cell(5, 4, 9, Width, 'y', true),
				new Cell(5, 5, 9, Width, 'm', true),
				new Cell(7, 1, 9, Width, 'o', true),
				new Cell(7, 2, 9, Width, 'r', true),
				new Cell(7, 5, 9, Width, 'c', true),
				new Cell(8, 2, 9, Width, 'y', true),
				new Cell(8, 3, 9, Width, 'g', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(0, 7, 9, Width, 'g', true),
				new Cell(1, 1, 9, Width, 'b', true),
				new Cell(1, 2, 9, Width, 'y', true),
				new Cell(2, 0, 9, Width, 'o', true),
				new Cell(3, 0, 9, Width, 'm', true),
				new Cell(3, 5, 9, Width, 'r', true),
				new Cell(3, 6, 9, Width, 'y', true),
				new Cell(4, 2, 9, Width, 'o', true),
				new Cell(4, 4, 9, Width, 'b', true),
				new Cell(4, 8, 9, Width, 'g', true),
				new Cell(5, 4, 9, Width, 'c', true),
				new Cell(5, 5, 9, Width, 'r', true),
				new Cell(5, 8, 9, Width, 'c', true),
				new Cell(6, 8, 9, Width, 'm', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 9, Width, 'y', true),
				new Cell(0, 1, 9, Width, 'o', true),
				new Cell(0, 8, 9, Width, 'c', true),
				new Cell(1, 3, 9, Width, 'o', true),
				new Cell(1, 8, 9, Width, 'g', true),
				new Cell(3, 4, 9, Width, 'g', true),
				new Cell(3, 7, 9, Width, 'y', true),
				new Cell(3, 8, 9, Width, 'r', true),
				new Cell(4, 4, 9, Width, 'r', true),
				new Cell(4, 8, 9, Width, 'b', true),
				new Cell(5, 8, 9, Width, 'm', true),
				new Cell(6, 4, 9, Width, 'c', true),
				new Cell(7, 8, 9, Width, 'm', true),
				new Cell(8, 8, 9, Width, 'b', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 9, Width, 'g', true),
				new Cell(1, 0, 9, Width, 'o', true),
				new Cell(1, 4, 9, Width, 'y', true),
				new Cell(1, 7, 9, Width, 'b', true),
				new Cell(2, 0, 9, Width, 'm', true),
				new Cell(2, 5, 9, Width, 'n', true),
				new Cell(3, 3, 9, Width, 'g', true),
				new Cell(3, 6, 9, Width, 'y', true),
				new Cell(5, 3, 9, Width, 'r', true),
				new Cell(6, 4, 9, Width, 'n', true),
				new Cell(6, 5, 9, Width, 'b', true),
				new Cell(6, 7, 9, Width, 'c', true),
				new Cell(6, 8, 9, Width, 'm', true),
				new Cell(7, 1, 9, Width, 'o', true),
				new Cell(7, 2, 9, Width, 'c', true),
				new Cell(7, 7, 9, Width, 'r', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(1, 1, 9, Width, 'y', true),
				new Cell(1, 4, 9, Width, 'y', true),
				new Cell(1, 5, 9, Width, 'p', true),
				new Cell(3, 4, 9, Width, 'o', true),
				new Cell(3, 5, 9, Width, 'b', true),
				new Cell(3, 6, 9, Width, 'm', true),
				new Cell(4, 4, 9, Width, 'c', true),
				new Cell(4, 6, 9, Width, 'r', true),
				new Cell(5, 0, 9, Width, 'o', true),
				new Cell(6, 0, 9, Width, 'm', true),
				new Cell(6, 4, 9, Width, 'b', true),
				new Cell(6, 5, 9, Width, 'n', true),
				new Cell(6, 7, 9, Width, 'p', true),
				new Cell(7, 0, 9, Width, 'o', true),
				new Cell(7, 4, 9, Width, 'c', true),
				new Cell(7, 7, 9, Width, 'r', true),
				new Cell(8, 0, 9, Width, 'g', true),
				new Cell(8, 4, 9, Width, 'g', true),
				new Cell(8, 6, 9, Width, 'n', true),
				new Cell(8, 7, 9, Width, 'o', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 9, Width, 'y', true),
				new Cell(0, 4, 9, Width, 'o', true),
				new Cell(0, 6, 9, Width, 'm', true),
				new Cell(1, 2, 9, Width, 'r', true),
				new Cell(1, 7, 9, Width, 'p', true),
				new Cell(2, 1, 9, Width, 'g', true),
				new Cell(2, 3, 9, Width, 'c', true),
				new Cell(2, 7, 9, Width, 'b', true),
				new Cell(3, 1, 9, Width, 'r', true),
				new Cell(4, 2, 9, Width, 'o', true),
				new Cell(5, 2, 9, Width, 'o', true),
				new Cell(5, 6, 9, Width, 'p', true),
				new Cell(5, 7, 9, Width, 'b', true),
				new Cell(6, 3, 9, Width, 'c', true),
				new Cell(6, 4, 9, Width, 'g', true),
				new Cell(6, 6, 9, Width, 'o', true),
				new Cell(6, 7, 9, Width, 'n', true),
				new Cell(7, 8, 9, Width, 'm', true),
				new Cell(8, 0, 9, Width, 'y', true),
				new Cell(8, 8, 9, Width, 'n', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 9, Width, 'b', true),
				new Cell(1, 0, 9, Width, 'g', true),
				new Cell(1, 5, 9, Width, 'm', true),
				new Cell(1, 7, 9, Width, 'm', true),
				new Cell(1, 8, 9, Width, 'b', true),
				new Cell(2, 3, 9, Width, 'c', true),
				new Cell(2, 8, 9, Width, 'o', true),
				new Cell(3, 5, 9, Width, 'o', true),
				new Cell(4, 7, 9, Width, 'r', true),
				new Cell(5, 2, 9, Width, 'n', true),
				new Cell(6, 2, 9, Width, 'y', true),
				new Cell(6, 4, 9, Width, 'n', true),
				new Cell(6, 6, 9, Width, 'y', true),
				new Cell(6, 7, 9, Width, 'r', true),
				new Cell(7, 4, 9, Width, 'g', true),
				new Cell(8, 8, 9, Width, 'c', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 9, Width, 'b', true),
				new Cell(0, 1, 9, Width, 'n', true),
				new Cell(0, 3, 9, Width, 'o', true),
				new Cell(1, 1, 9, Width, 'y', true),
				new Cell(1, 7, 9, Width, 'g', true),
				new Cell(2, 6, 9, Width, 'm', true),
				new Cell(2, 7, 9, Width, 'c', true),
				new Cell(2, 8, 9, Width, 'n', true),
				new Cell(3, 3, 9, Width, 'o', true),
				new Cell(3, 8, 9, Width, 'b', true),
				new Cell(4, 5, 9, Width, 'g', true),
				new Cell(4, 6, 9, Width, 'm', true),
				new Cell(6, 2, 9, Width, 'c', true),
				new Cell(6, 6, 9, Width, 'y', true),
				new Cell(6, 7, 9, Width, 'r', true),
				new Cell(7, 4, 9, Width, 'r', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(2, 2, 9, Width, 'r', true),
				new Cell(2, 6, 9, Width, 'm', true),
				new Cell(4, 3, 9, Width, 'y', true),
				new Cell(5, 1, 9, Width, 'c', true),
				new Cell(5, 6, 9, Width, 'm', true),
				new Cell(6, 1, 9, Width, 'g', true),
				new Cell(6, 6, 9, Width, 'r', true),
				new Cell(6, 8, 9, Width, 'g', true),
				new Cell(7, 1, 9, Width, 'y', true),
				new Cell(7, 5, 9, Width, 'o', true),
				new Cell(7, 6, 9, Width, 'b', true),
				new Cell(7, 8, 9, Width, 'o', true),
				new Cell(8, 5, 9, Width, 'c', true),
				new Cell(8, 8, 9, Width, 'b', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 9, Width, 'y', true),
				new Cell(1, 1, 9, Width, 'c', true),
				new Cell(1, 2, 9, Width, 'r', true),
				new Cell(1, 4, 9, Width, 'o', true),
				new Cell(2, 5, 9, Width, 'c', true),
				new Cell(3, 0, 9, Width, 'p', true),
				new Cell(4, 0, 9, Width, 'n', true),
				new Cell(4, 2, 9, Width, 'b', true),
				new Cell(4, 3, 9, Width, 'y', true),
				new Cell(4, 4, 9, Width, 'm', true),
				new Cell(5, 1, 9, Width, 'p', true),
				new Cell(5, 3, 9, Width, 'b', true),
				new Cell(6, 5, 9, Width, 'r', true),
				new Cell(7, 2, 9, Width, 'g', true),
				new Cell(7, 7, 9, Width, 'o', true),
				new Cell(8, 0, 9, Width, 'n', true),
				new Cell(8, 4, 9, Width, 'm', true),
				new Cell(8, 5, 9, Width, 'g', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(0, 1, 9, Width, 'r', true),
				new Cell(0, 2, 9, Width, 'g', true),
				new Cell(0, 3, 9, Width, 'y', true),
				new Cell(1, 1, 9, Width, 'o', true),
				new Cell(1, 6, 9, Width, 'n', true),
				new Cell(2, 3, 9, Width, 'g', true),
				new Cell(2, 4, 9, Width, 'y', true),
				new Cell(3, 1, 9, Width, 'b', true),
				new Cell(4, 4, 9, Width, 'c', true),
				new Cell(4, 5, 9, Width, 'o', true),
				new Cell(6, 2, 9, Width, 'c', true),
				new Cell(6, 3, 9, Width, 'r', true),
				new Cell(6, 4, 9, Width, 'b', true),
				new Cell(6, 5, 9, Width, 'n', true),
				new Cell(7, 5, 9, Width, 'm', true),
				new Cell(7, 7, 9, Width, 'm', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(1, 7, 9, Width, 'g', true),
				new Cell(2, 2, 9, Width, 'y', true),
				new Cell(2, 7, 9, Width, 'y', true),
				new Cell(3, 2, 9, Width, 'n', true),
				new Cell(3, 4, 9, Width, 'b', true),
				new Cell(4, 2, 9, Width, 'm', true),
				new Cell(4, 4, 9, Width, 'n', true),
				new Cell(4, 5, 9, Width, 'o', true),
				new Cell(5, 4, 9, Width, 'r', true),
				new Cell(5, 5, 9, Width, 'c', true),
				new Cell(5, 7, 9, Width, 'b', true),
				new Cell(6, 4, 9, Width, 'm', true),
				new Cell(7, 1, 9, Width, 'g', true),
				new Cell(7, 6, 9, Width, 'c', true),
				new Cell(7, 7, 9, Width, 'o', true),
				new Cell(8, 3, 9, Width, 'r', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(1, 1, 9, Width, 'n', true),
				new Cell(1, 3, 9, Width, 'r', true),
				new Cell(1, 4, 9, Width, 'o', true),
				new Cell(2, 1, 9, Width, 'p', true),
				new Cell(2, 6, 9, Width, 'm', true),
				new Cell(2, 7, 9, Width, 'n', true),
				new Cell(3, 3, 9, Width, 'p', true),
				new Cell(3, 4, 9, Width, 'm', true),
				new Cell(4, 5, 9, Width, 'r', true),
				new Cell(4, 8, 9, Width, 'y', true),
				new Cell(5, 7, 9, Width, 'g', true),
				new Cell(6, 1, 9, Width, 'c', true),
				new Cell(6, 2, 9, Width, 'y', true),
				new Cell(6, 3, 9, Width, 'g', true),
				new Cell(6, 4, 9, Width, 'b', true),
				new Cell(6, 6, 9, Width, 'b', true),
				new Cell(7, 0, 9, Width, 'o', true),
				new Cell(8, 0, 9, Width, 'c', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(0, 3, 9, Width, 'y', true),
				new Cell(1, 1, 9, Width, 'm', true),
				new Cell(2, 0, 9, Width, 'o', true),
				new Cell(2, 5, 9, Width, 'g', true),
				new Cell(2, 6, 9, Width, 'b', true),
				new Cell(3, 0, 9, Width, 'b', true),
				new Cell(3, 1, 9, Width, 'm', true),
				new Cell(3, 3, 9, Width, 'y', true),
				new Cell(5, 0, 9, Width, 'o', true),
				new Cell(5, 7, 9, Width, 'r', true),
				new Cell(6, 2, 9, Width, 'r', true),
				new Cell(6, 6, 9, Width, 'g', true),
				new Cell(7, 0, 9, Width, 'c', true),
				new Cell(8, 3, 9, Width, 'c', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(0, 3, 9, Width, 'r', true),
				new Cell(1, 0, 9, Width, 'y', true),
				new Cell(1, 1, 9, Width, 'm', true),
				new Cell(1, 5, 9, Width, 'c', true),
				new Cell(2, 0, 9, Width, 'g', true),
				new Cell(2, 6, 9, Width, 'y', true),
				new Cell(3, 2, 9, Width, 'g', true),
				new Cell(3, 6, 9, Width, 'o', true),
				new Cell(3, 7, 9, Width, 'c', true),
				new Cell(5, 5, 9, Width, 'p', true),
				new Cell(5, 6, 9, Width, 'b', true),
				new Cell(5, 7, 9, Width, 'p', true),
				new Cell(6, 2, 9, Width, 'b', true),
				new Cell(6, 7, 9, Width, 'r', true),
				new Cell(7, 4, 9, Width, 'o', true),
				new Cell(7, 7, 9, Width, 'm', true),
				new Cell(7, 8, 9, Width, 'n', true),
				new Cell(8, 6, 9, Width, 'n', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(0, 6, 9, Width, 'y', true),
				new Cell(1, 0, 9, Width, 'g', true),
				new Cell(1, 4, 9, Width, 'c', true),
				new Cell(1, 7, 9, Width, 'r', true),
				new Cell(2, 5, 9, Width, 'y', true),
				new Cell(3, 4, 9, Width, 'b', true),
				new Cell(3, 5, 9, Width, 'g', true),
				new Cell(6, 2, 9, Width, 'b', true),
				new Cell(6, 3, 9, Width, 'r', true),
				new Cell(7, 7, 9, Width, 'o', true),
				new Cell(8, 6, 9, Width, 'o', true),
				new Cell(8, 8, 9, Width, 'c', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(0, 8, 9, Width, 'c', true),
				new Cell(1, 4, 9, Width, 'b', true),
				new Cell(1, 6, 9, Width, 'r', true),
				new Cell(2, 6, 9, Width, 'p', true),
				new Cell(3, 3, 9, Width, 'p', true),
				new Cell(4, 3, 9, Width, 'n', true),
				new Cell(4, 4, 9, Width, 'g', true),
				new Cell(4, 5, 9, Width, 'y', true),
				new Cell(5, 5, 9, Width, 'm', true),
				new Cell(5, 7, 9, Width, 'm', true),
				new Cell(6, 5, 9, Width, 'o', true),
				new Cell(7, 1, 9, Width, 'b', true),
				new Cell(7, 2, 9, Width, 'r', true),
				new Cell(7, 3, 9, Width, 'n', true),
				new Cell(7, 6, 9, Width, 'g', true),
				new Cell(8, 6, 9, Width, 'y', true),
				new Cell(8, 7, 9, Width, 'o', true),
				new Cell(8, 8, 9, Width, 'c', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(0, 7, 9, Width, 'g', true),
				new Cell(1, 3, 9, Width, 'm', true),
				new Cell(1, 4, 9, Width, 'n', true),
				new Cell(1, 6, 9, Width, 'b', true),
				new Cell(1, 7, 9, Width, 'n', true),
				new Cell(2, 4, 9, Width, 'p', true),
				new Cell(3, 3, 9, Width, 'r', true),
				new Cell(3, 4, 9, Width, 'y', true),
				new Cell(4, 1, 9, Width, 'm', true),
				new Cell(4, 5, 9, Width, 'g', true),
				new Cell(4, 6, 9, Width, 'y', true),
				new Cell(4, 7, 9, Width, 'c', true),
				new Cell(5, 1, 9, Width, 'o', true),
				new Cell(5, 7, 9, Width, 'b', true),
				new Cell(6, 2, 9, Width, 'p', true),
				new Cell(7, 5, 9, Width, 'o', true),
				new Cell(7, 6, 9, Width, 'r', true),
				new Cell(8, 8, 9, Width, 'c', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(0, 4, 9, Width, 'y', true),
				new Cell(0, 5, 9, Width, 'r', true),
				new Cell(1, 1, 9, Width, 'b', true),
				new Cell(1, 7, 9, Width, 'c', true),
				new Cell(2, 4, 9, Width, 'r', true),
				new Cell(3, 0, 9, Width, 'o', true),
				new Cell(3, 1, 9, Width, 'g', true),
				new Cell(3, 6, 9, Width, 'g', true),
				new Cell(3, 8, 9, Width, 'n', true),
				new Cell(4, 4, 9, Width, 'n', true),
				new Cell(5, 6, 9, Width, 'm', true),
				new Cell(5, 7, 9, Width, 'p', true),
				new Cell(6, 2, 9, Width, 'y', true),
				new Cell(6, 3, 9, Width, 'b', true),
				new Cell(6, 5, 9, Width, 'o', true),
				new Cell(6, 8, 9, Width, 'c', true),
				new Cell(7, 8, 9, Width, 'p', true),
				new Cell(8, 8, 9, Width, 'm', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(0, 6, 9, Width, 'b', true),
				new Cell(0, 7, 9, Width, 'm', true),
				new Cell(1, 6, 9, Width, 'c', true),
				new Cell(1, 7, 9, Width, 'b', true),
				new Cell(4, 4, 9, Width, 'y', true),
				new Cell(4, 5, 9, Width, 'r', true),
				new Cell(4, 8, 9, Width, 'g', true),
				new Cell(5, 3, 9, Width, 'm', true),
				new Cell(5, 6, 9, Width, 'g', true),
				new Cell(6, 4, 9, Width, 'o', true),
				new Cell(6, 7, 9, Width, 'r', true),
				new Cell(7, 2, 9, Width, 'c', true),
				new Cell(8, 4, 9, Width, 'o', true),
				new Cell(8, 8, 9, Width, 'y', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(0, 4, 9, Width, 'o', true),
				new Cell(0, 5, 9, Width, 'n', true),
				new Cell(0, 8, 9, Width, 'n', true),
				new Cell(1, 4, 9, Width, 'm', true),
				new Cell(2, 1, 9, Width, 'm', true),
				new Cell(2, 2, 9, Width, 'p', true),
				new Cell(2, 6, 9, Width, 'r', true),
				new Cell(2, 8, 9, Width, 'y', true),
				new Cell(3, 6, 9, Width, 'c', true),
				new Cell(4, 4, 9, Width, 'p', true),
				new Cell(4, 7, 9, Width, 'g', true),
				new Cell(5, 1, 9, Width, 'b', true),
				new Cell(5, 2, 9, Width, 'g', true),
				new Cell(5, 8, 9, Width, 'r', true),
				new Cell(6, 2, 9, Width, 'y', true),
				new Cell(6, 4, 9, Width, 'o', true),
				new Cell(7, 2, 9, Width, 'b', true),
				new Cell(7, 7, 9, Width, 'c', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(1, 4, 9, Width, 'o', true),
				new Cell(1, 5, 9, Width, 'n', true),
				new Cell(1, 6, 9, Width, 'm', true),
				new Cell(1, 8, 9, Width, 'c', true),
				new Cell(2, 1, 9, Width, 'o', true),
				new Cell(2, 4, 9, Width, 'y', true),
				new Cell(2, 6, 9, Width, 'g', true),
				new Cell(3, 3, 9, Width, 'r', true),
				new Cell(3, 8, 9, Width, 'm', true),
				new Cell(4, 0, 9, Width, 'b', true),
				new Cell(4, 6, 9, Width, 'n', true),
				new Cell(5, 2, 9, Width, 'p', true),
				new Cell(6, 4, 9, Width, 'y', true),
				new Cell(6, 6, 9, Width, 'p', true),
				new Cell(6, 7, 9, Width, 'r', true),
				new Cell(7, 7, 9, Width, 'c', true),
				new Cell(8, 0, 9, Width, 'b', true),
				new Cell(8, 7, 9, Width, 'g', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(0, 2, 9, Width, 'o', true),
				new Cell(1, 1, 9, Width, 'b', true),
				new Cell(1, 2, 9, Width, 'm', true),
				new Cell(1, 3, 9, Width, 'g', true),
				new Cell(1, 4, 9, Width, 'n', true),
				new Cell(2, 3, 9, Width, 'r', true),
				new Cell(2, 4, 9, Width, 'y', true),
				new Cell(4, 3, 9, Width, 'b', true),
				new Cell(4, 4, 9, Width, 'c', true),
				new Cell(4, 7, 9, Width, 'n', true),
				new Cell(5, 7, 9, Width, 'y', true),
				new Cell(5, 8, 9, Width, 'g', true),
				new Cell(6, 2, 9, Width, 'm', true),
				new Cell(6, 8, 9, Width, 'o', true),
				new Cell(7, 6, 9, Width, 'c', true),
				new Cell(7, 7, 9, Width, 'r', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 9, Width, 'c', true),
				new Cell(0, 1, 9, Width, 'g', true),
				new Cell(0, 2, 9, Width, 'y', true),
				new Cell(0, 8, 9, Width, 'm', true),
				new Cell(1, 4, 9, Width, 'n', true),
				new Cell(1, 5, 9, Width, 'r', true),
				new Cell(2, 6, 9, Width, 'n', true),
				new Cell(2, 7, 9, Width, 'b', true),
				new Cell(4, 3, 9, Width, 'm', true),
				new Cell(4, 7, 9, Width, 'o', true),
				new Cell(6, 3, 9, Width, 'b', true),
				new Cell(6, 4, 9, Width, 'o', true),
				new Cell(6, 6, 9, Width, 'r', true),
				new Cell(6, 7, 9, Width, 'y', true),
				new Cell(6, 8, 9, Width, 'g', true),
				new Cell(8, 0, 9, Width, 'c', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(0, 4, 9, Width, 'g', true),
				new Cell(1, 4, 9, Width, 'r', true),
				new Cell(1, 7, 9, Width, 'n', true),
				new Cell(2, 1, 9, Width, 'r', true),
				new Cell(2, 2, 9, Width, 'y', true),
				new Cell(2, 7, 9, Width, 'c', true),
				new Cell(3, 5, 9, Width, 'g', true),
				new Cell(4, 0, 9, Width, 'm', true),
				new Cell(4, 4, 9, Width, 'p', true),
				new Cell(5, 2, 9, Width, 'n', true),
				new Cell(5, 6, 9, Width, 'c', true),
				new Cell(6, 6, 9, Width, 'y', true),
				new Cell(7, 3, 9, Width, 'm', true),
				new Cell(7, 4, 9, Width, 'b', true),
				new Cell(7, 6, 9, Width, 'o', true),
				new Cell(7, 8, 9, Width, 'o', true),
				new Cell(8, 0, 9, Width, 'b', true),
				new Cell(8, 8, 9, Width, 'p', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 9, Width, 'o', true),
				new Cell(1, 7, 9, Width, 'b', true),
				new Cell(3, 1, 9, Width, 'm', true),
				new Cell(3, 8, 9, Width, 'y', true),
				new Cell(4, 3, 9, Width, 'o', true),
				new Cell(4, 6, 9, Width, 'm', true),
				new Cell(5, 1, 9, Width, 'c', true),
				new Cell(5, 3, 9, Width, 'r', true),
				new Cell(6, 3, 9, Width, 'n', true),
				new Cell(6, 6, 9, Width, 'c', true),
				new Cell(7, 0, 9, Width, 'b', true),
				new Cell(7, 2, 9, Width, 'n', true),
				new Cell(7, 4, 9, Width, 'g', true),
				new Cell(8, 0, 9, Width, 'r', true),
				new Cell(8, 2, 9, Width, 'g', true),
				new Cell(8, 5, 9, Width, 'y', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 9, Width, 'y', true),
				new Cell(3, 1, 9, Width, 'y', true),
				new Cell(4, 1, 9, Width, 'o', true),
				new Cell(4, 4, 9, Width, 'c', true),
				new Cell(5, 2, 9, Width, 'r', true),
				new Cell(5, 4, 9, Width, 'o', true),
				new Cell(6, 2, 9, Width, 'b', true),
				new Cell(6, 5, 9, Width, 'm', true),
				new Cell(7, 1, 9, Width, 'r', true),
				new Cell(7, 7, 9, Width, 'g', true),
				new Cell(8, 2, 9, Width, 'g', true),
				new Cell(8, 3, 9, Width, 'b', true),
				new Cell(8, 4, 9, Width, 'c', true),
				new Cell(8, 5, 9, Width, 'm', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(0, 0, 9, Width, 'c', true),
				new Cell(1, 0, 9, Width, 'o', true),
				new Cell(1, 4, 9, Width, 'o', true),
				new Cell(1, 7, 9, Width, 'm', true),
				new Cell(2, 7, 9, Width, 'y', true),
				new Cell(3, 7, 9, Width, 'c', true),
				new Cell(4, 1, 9, Width, 'b', true),
				new Cell(4, 2, 9, Width, 'n', true),
				new Cell(4, 4, 9, Width, 'n', true),
				new Cell(4, 5, 9, Width, 'b', true),
				new Cell(4, 7, 9, Width, 'r', true),
				new Cell(5, 5, 9, Width, 'r', true),
				new Cell(5, 7, 9, Width, 'g', true),
				new Cell(6, 2, 9, Width, 'y', true),
				new Cell(7, 3, 9, Width, 'g', true),
				new Cell(8, 1, 9, Width, 'm', true)
			}),
			new Grid(9, Width, Width, new List<Cell>
			{
				new Cell(0, 6, 9, Width, 'r', true),
				new Cell(0, 7, 9, Width, 'c', true),
				new Cell(0, 8, 9, Width, 'g', true),
				new Cell(1, 1, 9, Width, 'b', true),
				new Cell(2, 0, 9, Width, 'n', true),
				new Cell(2, 3, 9, Width, 'r', true),
				new Cell(3, 3, 9, Width, 'c', true),
				new Cell(4, 1, 9, Width, 'g', true),
				new Cell(4, 7, 9, Width, 'o', true),
				new Cell(5, 4, 9, Width, 'm', true),
				new Cell(6, 6, 9, Width, 'y', true),
				new Cell(6, 8, 9, Width, 'y', true),
				new Cell(7, 3, 9, Width, 'n', true),
				new Cell(7, 6, 9, Width, 'm', true),
				new Cell(7, 7, 9, Width, 'o', true),
				new Cell(7, 8, 9, Width, 'p', true),
				new Cell(8, 0, 9, Width, 'b', true),
				new Cell(8, 5, 9, Width, 'p', true)
			})
		};
	}
}
