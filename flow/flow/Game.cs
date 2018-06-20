using System;
using System.Drawing;

namespace flow
{
    [Serializable]
    public class Game
    {
        public Grid Grid { get; set; } = Grid.Empty;
        public Color FirstColor { get; set; }
        public int LevelGroup { get; set; }
        public int LevelNumber { get; set; }
    }
}