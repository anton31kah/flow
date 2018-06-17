using System;
using System.Collections.Generic;

namespace flow
{
    [Serializable]
    public class Path
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

        public void Update()
        {
			foreach (var cell in PathList)
				cell.PipeDirection.Clear();
			var current = PathList.First;
            for (int i = 0, size = PathList.Count; i < size - 1; i++)
            {
                var next = current.Next;
                if (current.Value.Row == next.Value.Row && Math.Abs(next.Value.Col - current.Value.Col) == 1)
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
                if (current.Value.Col == next.Value.Col && Math.Abs(next.Value.Row - current.Value.Row) == 1)
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
    }
}
