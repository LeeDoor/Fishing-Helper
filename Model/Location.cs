using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Helper.Model
{
    public class Location
    {
        public const int MAP_WIDTH = 467;
        public const int MAP_HEIGHT = 365;

        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Fish Fish { get; set; }
    }
}
