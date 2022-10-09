using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Helper.Model
{
    public class Price
    {
        public int Id { get; set; }
        public int RawReg { get; set; }
        public int RawTroph { get; set; }
        public int СookReg { get; set; }
        public int CookTroph { get; set; }

        public List<Fish> Fishes { get; set; }
    }
}
