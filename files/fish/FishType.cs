using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Helper
{
    public class FishType
    {
        public string Name { get; set; }
        public List<Fish> Variations { get; set; }
        public Bait Bait { get; set; }
        public static FishTypeBuilder GetBuilder() => new FishTypeBuilder();

    }
}
