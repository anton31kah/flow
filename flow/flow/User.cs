using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flow
{
	[Serializable]
    public class User
    {
        public Levels Levels { get; set; }
        public Game MyGame { get; set; }
        public string Name { get; set; }
		public Dictionary<int, HashSet<int>> SolvedLevels { get; set; } = new Dictionary<int, HashSet<int>>();
        public int CompletedLevels => SolvedLevels.Values.Sum(s => s.Count);
		public bool ChangedSomething { get; set; }

        public User(string name)
        {
            Name = name;
            MyGame = new Game();
            Levels = new Levels();
        }

		public override string ToString()
		{
			return String.Join(";;", SolvedLevels.Select(e => $"{e.Key} {String.Join(", ", e.Value)}"));
		}
	}
}
