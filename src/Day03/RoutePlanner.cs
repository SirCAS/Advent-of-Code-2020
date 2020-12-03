using System.Collections.Generic;
using System.Linq;

namespace Day03.Test
{
    public class RoutePlanner
    {
        private readonly ScreenBuffer _screen;

        public RoutePlanner(ScreenBuffer screen)
        {
            _screen = screen;
        }
        
        public int CountTrees(SlopeModel slope)
        {
            var x = 0;
            var y = 0;

            var count = 0;
            while (y + slope.Down < _screen.Height)
            {
                if(_screen.Get(x + slope.Right, y + slope.Down))
                    count += 1;
                
                x += slope.Right;
                y += slope.Down;
            }

            return count;
        }

        public int MultiplyTreeCounts(IList<SlopeModel> slopes)
        {
            return slopes.Select(CountTrees).Aggregate(1, (a, b) => a * b);
        }
    }

    public class SlopeModel
    {
        public int Right { get; set; }
        public int Down { get; set; }
    }
}