using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flow
{
	class Levels
	{
		public static List<Grid> levels5 = new List<Grid>
		{
			new Grid(5, 500, 500, new List<Cell>
			{
				new Cell(0 * 100, 0 * 100, 100, 100, "1", true),
				new Cell(2 * 100, 0 * 100, 100, 100, "2", true),
				new Cell(4 * 100, 0 * 100, 100, 100, "4", true),
				new Cell(2 * 100, 1 * 100, 100, 100, "3", true),
				new Cell(4 * 100, 1 * 100, 100, 100, "5", true),
				new Cell(1 * 100, 3 * 100, 100, 100, "2", true),
				new Cell(1 * 100, 4 * 100, 100, 100, "1", true),
				new Cell(2 * 100, 4 * 100, 100, 100, "3", true),
				new Cell(3 * 100, 4 * 100, 100, 100, "5", true),
				new Cell(3 * 100, 3 * 100, 100, 100, "4", true)
			}),
			new Grid(5, 500, 500, new List<Cell>
			{
				new Cell(0 * 100, 0 * 100, 100, 100, "4", true),
				new Cell(2 * 100, 2 * 100, 100, 100, "2", true),
				new Cell(0 * 100, 3 * 100, 100, 100, "3", true),
				new Cell(1 * 100, 3 * 100, 100, 100, "2", true),
				new Cell(2 * 100, 3 * 100, 100, 100, "1", true),
				new Cell(4 * 100, 3 * 100, 100, 100, "4", true),
				new Cell(0 * 100, 4 * 100, 100, 100, "1", true),
				new Cell(4 * 100, 4 * 100, 100, 100, "3", true)
			}),
			new Grid(5, 500, 500, new List<Cell>
			{
				new Cell(1 * 100, 0 * 100, 100, 100, "4", true),
				new Cell(2 * 100, 0 * 100, 100, 100, "3", true),
				new Cell(3 * 100, 0 * 100, 100, 100, "2", true),
				new Cell(3 * 100, 1 * 100, 100, 100, "1", true),
				new Cell(2 * 100, 2 * 100, 100, 100, "1", true),
				new Cell(0 * 100, 3 * 100, 100, 100, "4", true),
				new Cell(3 * 100, 3 * 100, 100, 100, "5", true),
				new Cell(0 * 100, 4 * 100, 100, 100, "3", true),
				new Cell(2 * 100, 4 * 100, 100, 100, "5", true),
				new Cell(3 * 100, 4 * 100, 100, 100, "2", true)
			}),
			new Grid(5, 500, 500, new List<Cell>
			{
				new Cell(3 * 100, 0 * 100, 100, 100, "1", true),
				new Cell(4 * 100, 0 * 100, 100, 100, "2", true),
				new Cell(0 * 100, 1 * 100, 100, 100, "1", true),
				new Cell(2 * 100, 2 * 100, 100, 100, "4", true),
				new Cell(3 * 100, 3 * 100, 100, 100, "3", true),
				new Cell(0 * 100, 4 * 100, 100, 100, "2", true),
				new Cell(1 * 100, 4 * 100, 100, 100, "3", true),
				new Cell(2 * 100, 4 * 100, 100, 100, "4", true)
			}),
			new Grid(5, 500, 500, new List<Cell>
			{
				new Cell(3 * 100, 0 * 100, 100, 100, "1", true),
				new Cell(4 * 100, 0 * 100, 100, 100, "2", true),
				new Cell(1 * 100, 1 * 100, 100, 100, "4", true),
				new Cell(2 * 100, 1 * 100, 100, 100, "3", true),
				new Cell(3 * 100, 1 * 100, 100, 100, "2", true),
				new Cell(4 * 100, 3 * 100, 100, 100, "3", true),
				new Cell(2 * 100, 4 * 100, 100, 100, "1", true),
				new Cell(4 * 100, 4 * 100, 100, 100, "4", true)
			}),
			new Grid(5, 500, 500, new List<Cell>
			{
				new Cell(0 * 100, 0 * 100, 100, 100, "4", true),
				new Cell(2 * 100, 0 * 100, 100, 100, "3", true),
				new Cell(3 * 100, 0 * 100, 100, 100, "1", true),
				new Cell(4 * 100, 0 * 100, 100, 100, "2", true),
				new Cell(3 * 100, 2 * 100, 100, 100, "2", true),
				new Cell(1 * 100, 3 * 100, 100, 100, "3", true),
				new Cell(4 * 100, 3 * 100, 100, 100, "1", true),
				new Cell(4 * 100, 4 * 100, 100, 100, "4", true)
			}),
			new Grid(5, 500, 500, new List<Cell>
			{
				new Cell(0 * 100, 0 * 100, 100, 100, "3", true),
				new Cell(3 * 100, 0 * 100, 100, 100, "4", true),
				new Cell(0 * 100, 1 * 100, 100, 100, "2", true),
				new Cell(0 * 100, 2 * 100, 100, 100, "4", true),
				new Cell(2 * 100, 2 * 100, 100, 100, "2", true),
				new Cell(3 * 100, 2 * 100, 100, 100, "3", true),
				new Cell(1 * 100, 3 * 100, 100, 100, "1", true),
				new Cell(3 * 100, 3 * 100, 100, 100, "1", true)
			}),
			new Grid(5, 500, 500, new List<Cell>
			{
				new Cell(0 * 100, 0 * 100, 100, 100, "3", true),
				new Cell(3 * 100, 0 * 100, 100, 100, "1", true),
				new Cell(4 * 100, 0 * 100, 100, 100, "5", true),
				new Cell(3 * 100, 1 * 100, 100, 100, "4", true),
				new Cell(2 * 100, 2 * 100, 100, 100, "4", true),
				new Cell(1 * 100, 3 * 100, 100, 100, "1", true),
				new Cell(2 * 100, 3 * 100, 100, 100, "5", true),
				new Cell(4 * 100, 3 * 100, 100, 100, "2", true),
				new Cell(1 * 100, 4 * 100, 100, 100, "3", true),
				new Cell(2 * 100, 4 * 100, 100, 100, "2", true)
			}),
			new Grid(5, 500, 500, new List<Cell>
			{
				new Cell(3 * 100, 0 * 100, 100, 100, "1", true),
				new Cell(1 * 100, 1 * 100, 100, 100, "4", true),
				new Cell(2 * 100, 1 * 100, 100, 100, "3", true),
				new Cell(3 * 100, 1 * 100, 100, 100, "2", true),
				new Cell(2 * 100, 2 * 100, 100, 100, "4", true),
				new Cell(0 * 100, 4 * 100, 100, 100, "3", true),
				new Cell(1 * 100, 4 * 100, 100, 100, "2", true),
				new Cell(2 * 100, 4 * 100, 100, 100, "1", true)
			}),
			new Grid(5, 500, 500, new List<Cell>
			{
				new Cell(0 * 100, 1 * 100, 100, 100, "2", true),
				new Cell(3 * 100, 1 * 100, 100, 100, "1", true),
				new Cell(0 * 100, 2 * 100, 100, 100, "3", true),
				new Cell(1 * 100, 2 * 100, 100, 100, "1", true),
				new Cell(2 * 100, 2 * 100, 100, 100, "3", true),
				new Cell(3 * 100, 2 * 100, 100, 100, "4", true),
				new Cell(0 * 100, 4 * 100, 100, 100, "4", true),
				new Cell(4 * 100, 4 * 100, 100, 100, "2", true)
			})
		};
	}
}
