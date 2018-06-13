using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flow
{
    public class User
    {
        public Levels Levels { get; set; }
        public Game MyGame { get; set; }
        public string Name { get; set; }
        public int CompletedLevels => Levels.RegularLevels.SelectMany(l => l.Value.Select(l2 => l2.Value)).Count(g => g.CompletedPipes > 0);

        public User(string name)
        {
            Name = name;
            MyGame = new Game();
            Levels = new Levels();
        }
    }
}
