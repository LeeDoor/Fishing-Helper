using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Helper.Model
{
    public class FishType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Bait Bait { get; set; }

        public List<Fish> Variations { get; set; } = new();
    }
}
