using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Helper
{
    public struct Price
    {
        public int rawReg;
        public int rawTroph;
        public int cookReg;
        public int cookTroph;
        public Price(int rawReg, int rawTroph, int cookReg, int cookTroph)
        {
            this.rawReg = rawReg;
            this.rawTroph = rawTroph;
            this.cookReg = cookReg;
            this.cookTroph = cookTroph;
        }
    }
}
