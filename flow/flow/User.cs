using System;
using System.Collections.Generic;
using System.Linq;

namespace flow
{
    [Serializable]
    public class User
    {
        [NonSerialized] private bool _changedSomething;

        public Levels Levels { get; set; }
        public Game MyGame { get; set; }
        public string Name { get; set; }
        public Dictionary<int, HashSet<int>> SolvedLevels { get; set; } = new Dictionary<int, HashSet<int>>();
        public int CompletedLevels => SolvedLevels.Values.Sum(s => s.Count);

        public bool ChangedSomething
        {
            get => _changedSomething;
            set => _changedSomething = value;
        }

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

        public bool IsLevelSolved(int group, int level)
        {
            return SolvedLevels.ContainsKey(group) && SolvedLevels[group].Contains(level);
        }
    }
}