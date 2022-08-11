using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Helper
{
    public class FishDataBase
    {
        public List<FishType> Fishes { get; set; }
        public FishDataBase()
        {
            Initialize();
        }

        public void Initialize()
        {
            Fishes = new List<FishType>();
            var builder = FishType.GetBuilder();
            Fishes.Add(builder
                .BuildName("Splashtail")
                .BuildBait(Bait.None)
                .BuildFish(
                    "Ruby Splashtail", 
                    "images\\fishes\\Ruby_Splashtail.png", 
                    new Location(), 
                    new Price(75, 190, 115, 285))
                //.BuildFish("Ruby Splashtail", "images\\fishes\\Ruby_Splashtail.png", new Location())
                .Reset()
            );
        }
    }
}
