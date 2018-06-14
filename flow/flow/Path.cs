using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace flow
{
	[Serializable]
	public class Path /*: ISerializable*/
    {
		[NonSerialized] private LinkedListNode<Cell> _lastAddedCell;

		public LinkedList<Cell> PathList { get; set; }

		public LinkedListNode<Cell> LastAddedCell
		{
			get => _lastAddedCell;
			set => _lastAddedCell = value;
		}


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

		//public void GetObjectData(SerializationInfo info, StreamingContext context)
		//{
		//	info.AddValue("PathList", PathList);
		//	info.AddValue("LastAddedCell", LastAddedCell.Value);
		//}

		//public Path(SerializationInfo info, StreamingContext context)
		//{
		//	PathList = (LinkedList<Cell>) info.GetValue("PathList", typeof(LinkedList<Cell>));
		//	LastAddedCell = (Cell) info.GetValue("LastAddedCell", typeof(Cell));
		//}

		public void Update()
        {
			var current = PathList.First;
			for (int i = 0, size = PathList.Count; i < size - 1; i++)
			{
				var next = current.Next;
				if (current.Value.Row == next.Value.Row)
				{
					if (next.Value.Col < current.Value.Col)
					{
						next.Value.AddPipe(PipeDirection.Right);
						current.Value.AddPipe(PipeDirection.Left);
					}
					else if (next.Value.Col > current.Value.Col)
					{
						next.Value.AddPipe(PipeDirection.Left);
						current.Value.AddPipe(PipeDirection.Right);
					}
				}
				if (current.Value.Col == next.Value.Col)
				{
					if (current.Value.Row < next.Value.Row)
					{
						current.Value.AddPipe(PipeDirection.Down);
						next.Value.AddPipe(PipeDirection.Up);
					}
					else if (current.Value.Row > next.Value.Row)
					{
						current.Value.AddPipe(PipeDirection.Up);
						next.Value.AddPipe(PipeDirection.Down);
					}
				}

				current = next;
				next = next.Next;
			}			
        }

		public LinkedListNode<Cell> AddAfter(LinkedListNode<Cell> toAddAfter, Cell cell)
		{
			var prevCell = toAddAfter.Value;
			if (prevCell.Row == cell.Row && Math.Abs(prevCell.Col - cell.Col) == 1)
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
			if (prevCell.Col == cell.Col && Math.Abs(prevCell.Row - cell.Row) == 1)
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
            if (prevCell.Row == cell.Row && Math.Abs(prevCell.Col - cell.Col) == 1)
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
            if (prevCell.Col == cell.Col && Math.Abs(prevCell.Row - cell.Row) == 1)
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
