using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace flow
{
	[Serializable]
	public class Game
    {
		[NonSerialized] private Stopwatch _timeElapsed = new Stopwatch();

		public Grid Grid { get; set; } = Grid.Empty;
        public Color FirstColor { get; set; }
		public int LevelGroup { get; set; }
		public int LevelNumber { get; set; }
		public Stopwatch TimeElapsed
		{
			get => _timeElapsed;
			set => _timeElapsed = value;
		}
	}
}
