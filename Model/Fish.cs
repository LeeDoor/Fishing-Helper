using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Helper.Model
{
    public class Fish
    {
        public int Id { get; set; }
        public string Name { get; }
        public string Path { get; }
        public string Type { get; }

        public Location Location { get; }
        public int LocationId { get; }

        public Price Price { get; }
        public int PriceId { get; }

        public FishType FishType { get; }
        public int FishTypeId { get; }
    }
}
