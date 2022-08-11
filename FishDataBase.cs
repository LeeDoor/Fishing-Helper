using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Helper
{
    public class FishDataBase
    {
        List<FishType> fishes;
        public FishDataBase()
        {
            Initialize();
        }

        public void Initialize()
        {
            var builder = FishType.GetBuilder();
            fishes.Add(
                builder
                .BuildName("Splashtail")
                .BuildFish("Ruby Splashtail", "images\\fishes\\Ruby_Splashtail.png", new Location())
                //.BuildFish("Ruby Splashtail", "images\\fishes\\Ruby_Splashtail.png", new Location())
                .Reset()
            );
        }
    }
}
