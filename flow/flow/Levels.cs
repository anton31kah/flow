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
                new Cell(0,0, 100, 100, "1", true),
                new Cell(200, 0, 100, 100, "2", true),
                new Cell(400, 0, 100, 100, "4", true),
                new Cell(200, 100, 100, 100, "3", true),
                new Cell(400, 100, 100, 100, "5", true),
                new Cell(100, 300, 100, 100, "2", true),
                new Cell(100, 400, 100, 100, "1", true),
                new Cell(200, 400, 100, 100, "3", true),
                new Cell(300, 400, 100, 100, "5", true),
                new Cell(300, 300, 100, 100, "4", true)
            }
                )
        };

    }
}
