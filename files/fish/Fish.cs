using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Helper
{
    public class Fish
    {
        public string Name { get; }
        public string Path { get; }
        public Location Location { get; }
        public Price Price { get; }
        public Fish(string name, string path, Location location, Price price)
        {
            Name = name;
            Path = path;
            Location = Location;
            Price = price;
        }
    }
}
