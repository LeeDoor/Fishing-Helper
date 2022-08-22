using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Helper
{
    public class FishTypeBuilder
    {
        private FishType _product;

        public FishTypeBuilder()
        {
            Reset();
        }

        public FishType Reset()
        {
            var buf = _product;
            _product = new FishType();
            return buf;
        }

        public FishTypeBuilder BuildName(string name)
        {
            _product.Name = name;
            return this;
        }

        public FishTypeBuilder BuildFish(string name, string path, string type, Location location, Price price)
        {
            _product.Variations.Add(new Fish(name, path, type, location, price));
            return this;
        }
        public FishTypeBuilder BuildFish(Fish fish)
        {
            _product.Variations.Add(fish);
            return this;
        }

        public FishTypeBuilder BuildBait(Bait bait)
        {
            _product.Bait = bait;
            return this;
        }

        public FishType Build()
        {
            return _product;
        }
    }
}
