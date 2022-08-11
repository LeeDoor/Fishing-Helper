using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Helper
{
    public struct Location
    {
        public const int MAP_WIDTH = 467;
        public const int MAP_HEIGHT = 365;

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Location()
        {
            X = 0;
            Y = 0;
            Width = MAP_WIDTH;
            Height = MAP_HEIGHT;
        }
        public Location(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
    }
}
