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
            PathList.AddFirst(initialCell);
            LastAddedCell = PathList.AddLast(lastCell);
        }

		public override string ToString()
		{
			return String.Join(" -> \n", PathList);
		}

        //ERROR ============================================================================
        public void Update()
        {
            foreach (var prev in PathList)
            {
                foreach (var curr in PathList)
                {
                    if (!AreAdjacent(curr, prev))
                        continue;
                    if (prev.Row == curr.Row)
                    {
                        if (curr.Col < prev.Col)
                        {
                            curr.AddPipe(PipeDirection.Right);
                            prev.AddPipe(PipeDirection.Left);
                        }
                        else if (curr.Col > prev.Col)
                        {
                            curr.AddPipe(PipeDirection.Left);
                            prev.AddPipe(PipeDirection.Right);
                        }
                    }
                    if (prev.Col == curr.Col)
                    {
                        if (prev.Row < curr.Row)
                        {
                            prev.AddPipe(PipeDirection.Down);
                            curr.AddPipe(PipeDirection.Up);
                        }
                        else if (prev.Row > curr.Row)
                        {
                            prev.AddPipe(PipeDirection.Up);
                            curr.AddPipe(PipeDirection.Down);
                        }
                    }
                }
            }
        }

		public LinkedListNode<Cell> AddAfter(LinkedListNode<Cell> toAddAfter, Cell cell)
		{
			var prevCell = toAddAfter.Value;
			if (prevCell.Row == cell.Row)
			{
                if (cell.Col < prevCell.Col)
                {
                    cell.AddPipe(PipeDirection.Right);
                    prevCell.AddPipe(PipeDirection.Left);
                }
                else
                {
                    cell.AddPipe(PipeDirection.Left);
                    prevCell.AddPipe(PipeDirection.Right);
                }
			}
			if (prevCell.Col == cell.Col)
			{
                if (prevCell.Row < cell.Row)
                {
                    prevCell.AddPipe(PipeDirection.Down);
                    cell.AddPipe(PipeDirection.Up);
                }
                else
                {
                    prevCell.AddPipe(PipeDirection.Up);
                    cell.AddPipe(PipeDirection.Down);
                }
			}
			return PathList.AddAfter(toAddAfter, cell);
		}

        public LinkedListNode<Cell> AddBefore(LinkedListNode<Cell> toAddBefore, Cell cell)
        {
            var prevCell = toAddBefore.Value;
            if (prevCell.Row == cell.Row)
            {
                if (cell.Col < prevCell.Col)
                {
                    cell.AddPipe(PipeDirection.Right);
                    prevCell.AddPipe(PipeDirection.Left);
                }
                else if (cell.Col > prevCell.Col)
                {
                    cell.AddPipe(PipeDirection.Left);
                    prevCell.AddPipe(PipeDirection.Right);
                }
            }
            if (prevCell.Col == cell.Col)
            {
                if (prevCell.Row < cell.Row)
                {
                    prevCell.AddPipe(PipeDirection.Down);
                    cell.AddPipe(PipeDirection.Up);
                }
                else if (prevCell.Row > cell.Row)
                {
                    prevCell.AddPipe(PipeDirection.Up);
                    cell.AddPipe(PipeDirection.Down);
                }
            }
            return PathList.AddBefore(PathList.Last, cell);
        }

        public bool AreAdjacent(Cell one, Cell two)
        {
            return Math.Abs(one.Col - two.Col) + Math.Abs(one.Row - two.Row) <= 1;
            //return Math.Abs(one.Col - two.Col) == 1 || Math.Abs(one.Row - two.Row) == 1;
        }
    }
}
