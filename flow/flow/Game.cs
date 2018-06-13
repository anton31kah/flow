using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flow
{
    public class Game
    {
        public Grid Grid { get; set; } = Grid.Empty;
        public Color FirstColor { get; set; }
        public int ConnectedPipes { get; set; }
        public Stopwatch TimeElapsed { get; set; } = new Stopwatch();
    }
}
