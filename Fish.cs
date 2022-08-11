using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Helper
{
    public class Fish
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public Location Location { get; set; }

        public Fish(string name, string path, Location location)
        {
            Name = name;
            Path = path;
            Location = Location;
        }
    }
}
