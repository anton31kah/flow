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

		public override string ToString()
		{
			return String.Join(" -> \n", PathList);
		}

		public LinkedListNode<Cell> AddAfter(LinkedListNode<Cell> toAddAfter, Cell cell)
		{
			var prevCell = toAddAfter.Value;
			if (prevCell.Row == cell.Row)
			{
				if (prevCell is NormalCell cell1 && cell is NormalCell cell2)
				{
					if (cell1.Col < cell2.Col)
					{
						cell1.AddPipe(PipeDirection.Right);
						cell2.AddPipe(PipeDirection.Left);
					}
					else
					{
						cell1.AddPipe(PipeDirection.Left);
						cell2.AddPipe(PipeDirection.Right);
					}
				}
				else if (prevCell is InitialCell cell3 && cell is NormalCell cell4)
				{
					if (cell3.Col < cell4.Col)
					{
						cell3.PipeDirection = PipeDirection.Right;
						cell4.AddPipe(PipeDirection.Left);
					}
					else
					{
						cell3.PipeDirection = PipeDirection.Left;
						cell4.AddPipe(PipeDirection.Right);
					}
				}
				else if (prevCell is NormalCell cell5 && cell is InitialCell cell6)
				{
					if (cell5.Col < cell6.Col)
					{
						cell5.AddPipe(PipeDirection.Right);
						cell6.PipeDirection = PipeDirection.Left;
					}
					else
					{
						cell5.AddPipe(PipeDirection.Left);
						cell6.PipeDirection = PipeDirection.Right;
					}
				}
			}
			if (prevCell.Col == cell.Col)
			{
				if (prevCell is NormalCell cell1 && cell is NormalCell cell2)
				{
					if (cell1.Row < cell2.Row)
					{
						cell1.AddPipe(PipeDirection.Down);
						cell2.AddPipe(PipeDirection.Up);
					}
					else
					{
						cell1.AddPipe(PipeDirection.Up);
						cell2.AddPipe(PipeDirection.Down);
					}
				}
				else if (prevCell is InitialCell cell3 && cell is NormalCell cell4)
				{
					if (cell3.Row < cell4.Row)
					{
						cell3.PipeDirection = PipeDirection.Down;
						cell4.AddPipe(PipeDirection.Up);
					}
					else
					{
						cell3.PipeDirection = PipeDirection.Up;
						cell4.AddPipe(PipeDirection.Down);
					}
				}
				else if (prevCell is NormalCell cell5 && cell is InitialCell cell6)
				{
					if (cell5.Row < cell6.Row)
					{
						cell5.AddPipe(PipeDirection.Down);
						cell6.PipeDirection = PipeDirection.Up;
					}
					else
					{
						cell5.AddPipe(PipeDirection.Up);
						cell6.PipeDirection = PipeDirection.Down;
					}
				}
			}
			return PathList.AddAfter(toAddAfter, cell);
		}
	}
}
