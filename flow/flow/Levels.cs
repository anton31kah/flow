using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flow
{
	class Levels
	{
		public static int Width = 500;

		/*public static List<Grid> levels5 = new List<Grid>
		{
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(0 * Width / 5, 0 * Width / 5, Width / 5, Width / 5, "1", true),
				new Cell(2 * Width / 5, 0 * Width / 5, Width / 5, Width / 5, "2", true),
				new Cell(4 * Width / 5, 0 * Width / 5, Width / 5, Width / 5, "4", true),
				new Cell(2 * Width / 5, 1 * Width / 5, Width / 5, Width / 5, "3", true),
				new Cell(4 * Width / 5, 1 * Width / 5, Width / 5, Width / 5, "5", true),
				new Cell(1 * Width / 5, 3 * Width / 5, Width / 5, Width / 5, "2", true),
				new Cell(1 * Width / 5, 4 * Width / 5, Width / 5, Width / 5, "1", true),
				new Cell(2 * Width / 5, 4 * Width / 5, Width / 5, Width / 5, "3", true),
				new Cell(3 * Width / 5, 4 * Width / 5, Width / 5, Width / 5, "5", true),
				new Cell(3 * Width / 5, 3 * Width / 5, Width / 5, Width / 5, "4", true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(0 * Width / 5, 0 * Width / 5, Width / 5, Width / 5, "4", true),
				new Cell(2 * Width / 5, 2 * Width / 5, Width / 5, Width / 5, "2", true),
				new Cell(0 * Width / 5, 3 * Width / 5, Width / 5, Width / 5, "3", true),
				new Cell(1 * Width / 5, 3 * Width / 5, Width / 5, Width / 5, "2", true),
				new Cell(2 * Width / 5, 3 * Width / 5, Width / 5, Width / 5, "1", true),
				new Cell(4 * Width / 5, 3 * Width / 5, Width / 5, Width / 5, "4", true),
				new Cell(0 * Width / 5, 4 * Width / 5, Width / 5, Width / 5, "1", true),
				new Cell(4 * Width / 5, 4 * Width / 5, Width / 5, Width / 5, "3", true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(1 * Width / 5, 0 * Width / 5, Width / 5, Width / 5, "4", true),
				new Cell(2 * Width / 5, 0 * Width / 5, Width / 5, Width / 5, "3", true),
				new Cell(3 * Width / 5, 0 * Width / 5, Width / 5, Width / 5, "2", true),
				new Cell(3 * Width / 5, 1 * Width / 5, Width / 5, Width / 5, "1", true),
				new Cell(2 * Width / 5, 2 * Width / 5, Width / 5, Width / 5, "1", true),
				new Cell(0 * Width / 5, 3 * Width / 5, Width / 5, Width / 5, "4", true),
				new Cell(3 * Width / 5, 3 * Width / 5, Width / 5, Width / 5, "5", true),
				new Cell(0 * Width / 5, 4 * Width / 5, Width / 5, Width / 5, "3", true),
				new Cell(2 * Width / 5, 4 * Width / 5, Width / 5, Width / 5, "5", true),
				new Cell(3 * Width / 5, 4 * Width / 5, Width / 5, Width / 5, "2", true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(3 * Width / 5, 0 * Width / 5, Width / 5, Width / 5, "1", true),
				new Cell(4 * Width / 5, 0 * Width / 5, Width / 5, Width / 5, "2", true),
				new Cell(0 * Width / 5, 1 * Width / 5, Width / 5, Width / 5, "1", true),
				new Cell(2 * Width / 5, 2 * Width / 5, Width / 5, Width / 5, "4", true),
				new Cell(3 * Width / 5, 3 * Width / 5, Width / 5, Width / 5, "3", true),
				new Cell(0 * Width / 5, 4 * Width / 5, Width / 5, Width / 5, "2", true),
				new Cell(1 * Width / 5, 4 * Width / 5, Width / 5, Width / 5, "3", true),
				new Cell(2 * Width / 5, 4 * Width / 5, Width / 5, Width / 5, "4", true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(3 * Width / 5, 0 * Width / 5, Width / 5, Width / 5, "1", true),
				new Cell(4 * Width / 5, 0 * Width / 5, Width / 5, Width / 5, "2", true),
				new Cell(1 * Width / 5, 1 * Width / 5, Width / 5, Width / 5, "4", true),
				new Cell(2 * Width / 5, 1 * Width / 5, Width / 5, Width / 5, "3", true),
				new Cell(3 * Width / 5, 1 * Width / 5, Width / 5, Width / 5, "2", true),
				new Cell(4 * Width / 5, 3 * Width / 5, Width / 5, Width / 5, "3", true),
				new Cell(2 * Width / 5, 4 * Width / 5, Width / 5, Width / 5, "1", true),
				new Cell(4 * Width / 5, 4 * Width / 5, Width / 5, Width / 5, "4", true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(0 * Width / 5, 0 * Width / 5, Width / 5, Width / 5, "4", true),
				new Cell(2 * Width / 5, 0 * Width / 5, Width / 5, Width / 5, "3", true),
				new Cell(3 * Width / 5, 0 * Width / 5, Width / 5, Width / 5, "1", true),
				new Cell(4 * Width / 5, 0 * Width / 5, Width / 5, Width / 5, "2", true),
				new Cell(3 * Width / 5, 2 * Width / 5, Width / 5, Width / 5, "2", true),
				new Cell(1 * Width / 5, 3 * Width / 5, Width / 5, Width / 5, "3", true),
				new Cell(4 * Width / 5, 3 * Width / 5, Width / 5, Width / 5, "1", true),
				new Cell(4 * Width / 5, 4 * Width / 5, Width / 5, Width / 5, "4", true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(0 * Width / 5, 0 * Width / 5, Width / 5, Width / 5, "3", true),
				new Cell(3 * Width / 5, 0 * Width / 5, Width / 5, Width / 5, "4", true),
				new Cell(0 * Width / 5, 1 * Width / 5, Width / 5, Width / 5, "2", true),
				new Cell(0 * Width / 5, 2 * Width / 5, Width / 5, Width / 5, "4", true),
				new Cell(2 * Width / 5, 2 * Width / 5, Width / 5, Width / 5, "2", true),
				new Cell(3 * Width / 5, 2 * Width / 5, Width / 5, Width / 5, "3", true),
				new Cell(1 * Width / 5, 3 * Width / 5, Width / 5, Width / 5, "1", true),
				new Cell(3 * Width / 5, 3 * Width / 5, Width / 5, Width / 5, "1", true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(0 * Width / 5, 0 * Width / 5, Width / 5, Width / 5, "3", true),
				new Cell(3 * Width / 5, 0 * Width / 5, Width / 5, Width / 5, "1", true),
				new Cell(4 * Width / 5, 0 * Width / 5, Width / 5, Width / 5, "5", true),
				new Cell(3 * Width / 5, 1 * Width / 5, Width / 5, Width / 5, "4", true),
				new Cell(2 * Width / 5, 2 * Width / 5, Width / 5, Width / 5, "4", true),
				new Cell(1 * Width / 5, 3 * Width / 5, Width / 5, Width / 5, "1", true),
				new Cell(2 * Width / 5, 3 * Width / 5, Width / 5, Width / 5, "5", true),
				new Cell(4 * Width / 5, 3 * Width / 5, Width / 5, Width / 5, "2", true),
				new Cell(1 * Width / 5, 4 * Width / 5, Width / 5, Width / 5, "3", true),
				new Cell(2 * Width / 5, 4 * Width / 5, Width / 5, Width / 5, "2", true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(3 * Width / 5, 0 * Width / 5, Width / 5, Width / 5, "1", true),
				new Cell(1 * Width / 5, 1 * Width / 5, Width / 5, Width / 5, "4", true),
				new Cell(2 * Width / 5, 1 * Width / 5, Width / 5, Width / 5, "3", true),
				new Cell(3 * Width / 5, 1 * Width / 5, Width / 5, Width / 5, "2", true),
				new Cell(2 * Width / 5, 2 * Width / 5, Width / 5, Width / 5, "4", true),
				new Cell(0 * Width / 5, 4 * Width / 5, Width / 5, Width / 5, "3", true),
				new Cell(1 * Width / 5, 4 * Width / 5, Width / 5, Width / 5, "2", true),
				new Cell(2 * Width / 5, 4 * Width / 5, Width / 5, Width / 5, "1", true)
			}),
			new Grid(5, Width, Width, new List<Cell>
			{
				new Cell(0 * Width / 5, 1 * Width / 5, Width / 5, Width / 5, "2", true),
				new Cell(3 * Width / 5, 1 * Width / 5, Width / 5, Width / 5, "1", true),
				new Cell(0 * Width / 5, 2 * Width / 5, Width / 5, Width / 5, "3", true),
				new Cell(1 * Width / 5, 2 * Width / 5, Width / 5, Width / 5, "1", true),
				new Cell(2 * Width / 5, 2 * Width / 5, Width / 5, Width / 5, "3", true),
				new Cell(3 * Width / 5, 2 * Width / 5, Width / 5, Width / 5, "4", true),
				new Cell(0 * Width / 5, 4 * Width / 5, Width / 5, Width / 5, "4", true),
				new Cell(4 * Width / 5, 4 * Width / 5, Width / 5, Width / 5, "2", true)
			})
		};*/

		public static List<Grid> Levels6 = new List<Grid>
		{
			new Grid(6, Width, Width, new List<Cell>
			{
				new Cell(0 * Width / 6, 0 * Width / 6, 0, 0, Width / 6, Width / 6, "2", true),
				new Cell(0 * Width / 6, 1 * Width / 6, 1, 0, Width / 6, Width / 6, "4", true),
				new Cell(0 * Width / 6, 2 * Width / 6, 2, 0, Width / 6, Width / 6, "6", true),
				new Cell(0 * Width / 6, 4 * Width / 6, 4, 0, Width / 6, Width / 6, "1", true),
				new Cell(0 * Width / 6, 5 * Width / 6, 5, 0, Width / 6, Width / 6, "3", true),
				new Cell(1 * Width / 6, 4 * Width / 6, 4, 1, Width / 6, Width / 6, "5", true),
				new Cell(2 * Width / 6, 2 * Width / 6, 2, 2, Width / 6, Width / 6, "6", true),
				new Cell(3 * Width / 6, 2 * Width / 6, 2, 3, Width / 6, Width / 6, "1", true),
				new Cell(4 * Width / 6, 0 * Width / 6, 0, 4, Width / 6, Width / 6, "2", true),
				new Cell(4 * Width / 6, 2 * Width / 6, 2, 4, Width / 6, Width / 6, "5", true),
				new Cell(5 * Width / 6, 0 * Width / 6, 0, 5, Width / 6, Width / 6, "4", true),
				new Cell(5 * Width / 6, 2 * Width / 6, 2, 5, Width / 6, Width / 6, "3", true),
				new Cell(3 * Width / 6, 4 * Width / 6, 4, 3, Width / 6, Width / 6, "7", true)
			})
		};
	}
}
