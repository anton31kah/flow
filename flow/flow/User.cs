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
        public string Name { get; set; }
        public int CompletedLevels => Levels.RegularLevels.SelectMany(l => l.Value.Select(l2 => l2.Value)).Count(g => g.CompletedPipes > 0);
    }
}
