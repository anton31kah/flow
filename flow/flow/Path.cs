using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flow
{
    public class Path
    {
        public LinkedList<Cell> PathList { get; set; }
        public LinkedListNode<Cell> LastAddedCell { get; set; }


        public Path(Cell initialCell, Cell lastCell)
        {
            PathList = new LinkedList<Cell>();
            LastAddedCell = PathList.AddFirst(initialCell);
            PathList.AddLast(lastCell);
        }
    }
}
