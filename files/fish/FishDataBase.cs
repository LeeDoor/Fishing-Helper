﻿using System;
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

            #region fish filler
            Fishes.Add(builder
            .BuildName("splashtail")
            .BuildBait(Bait.None)
            .BuildFish(
            "Ruby Splashtail",
            "images\\fishes\\Ruby_Splashtail.png",
            "Base variant",
            new Location(),
            new Price(75, 190, 115, 285))

            .BuildFish(
            "Sunny Splashtail",
            "images\\fishes\\Sunny_Splashtail.png",
            "Common variant",
            new Location(),
            new Price(150, 375, 225, 565))

            .BuildFish(
            "Indigo Splashtail",
            "images\\fishes\\Indigo_Splashtail.png",
            "Uncommon variant",
            new Location(),
            new Price(255, 565, 340, 850))

            .BuildFish(
            "Umber Splashtail",
            "images\\fishes\\Umber_Splashtail.png",
            "Rare variant",
            new Location(),
            new Price(375, 940, 565, 1410))

            .BuildFish(
            "Seafoam Splashtail",
            "images\\fishes\\Seafoam_Splashtail.png",
            "Night variant",
            new Location(),
            new Price(150, 375, 225, 565))

            .Reset());

            Fishes.Add(builder
                .BuildName("pondie")
                .BuildBait(Bait.None)
            .BuildFish(
            "Charcoal Pondie",
            "images\\fishes\\Charcoal_Pondie.png",
            "Base variant",
            new Location(),
            new Price(75, 190, 115, 285))

            .BuildFish(
            "Orchid Pondie",
            "images\\fishes\\Orchid_Pondie.png",
            "Common variant",
            new Location(),
            new Price(150, 375, 225, 565))

            .BuildFish(
            "Bronze Pondie",
            "images\\fishes\\Bronze_Pondie.png",
            "Uncommon variant",
            new Location(),
            new Price(255, 565, 340, 850))

            .BuildFish(
            "Bright Pondie",
            "images\\fishes\\Bright_Pondie.png",
            "Rare variant",
            new Location(),
            new Price(375, 940, 565, 1410))

            .BuildFish(
            "Moonsky Pondie",
            "images\\fishes\\Moonsky_Pondie.png",
            "Night variant",
            new Location(),
            new Price(150, 375, 225, 565))

            .Reset());

            Fishes.Add(builder
                .BuildName("islehopper")
                .BuildBait(Bait.None)

            .BuildFish(
            "Stone Islehopper",
            "images\\fishes\\Stone_Islehopper.png",
            "",
            new Location(),
            new Price(105, 265, 160, 400))

            .BuildFish(
            "Moss Islehopper",
            "images\\fishes\\Moss_Islehopper.png",
            "",
            new Location(),
            new Price(105, 265, 160, 400))

            .BuildFish(
            "Honey Islehopper",
            "images\\fishes\\Honey_Islehopper.png",
            "",
            new Location(),
            new Price(105, 265, 160, 400))

            .BuildFish(
            "Raven Islehopper",
            "images\\fishes\\Raven_Islehopper.png",
            "",
            new Location(),
            new Price(1050, 2625, 1575, 3940))

            .BuildFish(
            "Amethyst Islehopper",
            "images\\fishes\\Amethyst_Islehopper.png",
            "",
            new Location(),
            new Price(105, 265, 160, 400))

            .Reset());

            Fishes.Add(builder
                .BuildName("ancientscale")
                .BuildBait(Bait.Leeches)

            .BuildFish(
            "Almond Ancientscale",
            "images\\fishes\\Almond_Ancientscale.png",
            "Base variant",
            new Location(),
            new Price(225, 565, 340, 850))

            .BuildFish(
            "Sapphire Ancientscale",
            "images\\fishes\\Sapphire_Ancientscale.png",
            "Common variant",
            new Location(),
            new Price(300, 750, 450, 1125))

            .BuildFish(
            "Smoke Ancientscale",
            "images\\fishes\\Smoke_Ancientscale.png",
            "Uncommon variant",
            new Location(),
            new Price(375, 940, 565, 1410))

            .BuildFish(
            "Bone Ancientscale",
            "images\\fishes\\Bone_Ancientscale.png",
            "Rare variant",
            new Location(),
            new Price(3000, 7500, 4500, 11250))

            .BuildFish(
            "Starshine Ancientscale",
            "images\\fishes\\Starshine_Ancientscale.png",
            "Night variant",
            new Location(),
            new Price(300, 750, 450, 1125))

            .Reset());

            Fishes.Add(builder
                .BuildName("plentifin")
                .BuildBait(Bait.Earthworms)

            .BuildFish(
            "Olive Plentifin",
            "images\\fishes\\Olive_Plentifin.png",
            "Base variant",
            new Location(),
            new Price(225, 565, 340, 850))

            .BuildFish(
            "Amber Plentifin",
            "images\\fishes\\Amber_Plentifin.png",
            "Common variant",
            new Location(),
            new Price(300, 750, 450, 1125))

            .BuildFish(
            "Cloudy Plentifin",
            "images\\fishes\\Cloudy_Plentifin.png",
            "Uncommon variant",
            new Location(),
            new Price(375, 940, 565, 1410))

            .BuildFish(
            "Bonedust Plentifin",
            "images\\fishes\\Bonedust_Plentifin.png",
            "Rare variant",
            new Location(),
            new Price(3000, 7500, 4500, 11250))

            .BuildFish(
            "Watery Plentifin",
            "images\\fishes\\Watery_Plentifin.png",
            "Night variant",
            new Location(),
            new Price(300, 750, 450, 1125))

            .Reset());

            Fishes.Add(builder
                .BuildName("wildsplash")
                .BuildBait(Bait.Earthworms)

            .BuildFish(
            "Russet Wildsplash",
            "images\\fishes\\Russet_Wildsplash.png",
            "Base variant",
            new Location(),
            new Price(225, 565, 340, 850))

            .BuildFish(
            "Sandy Wildsplash",
            "images\\fishes\\Sandy_Wildsplash.png",
            "Common variant",
            new Location(),
            new Price(300, 750, 450, 1125))

            .BuildFish(
            "Ocean Wildsplash",
            "images\\fishes\\Ocean_Wildsplash.png",
            "Uncommon variant",
            new Location(),
            new Price(375, 940, 565, 1410))

            .BuildFish(
            "Muddy Wildsplash",
            "images\\fishes\\Muddy_Wildsplash.png",
            "Rare variant",
            new Location(),
            new Price(3000, 7500, 4500, 11250))

            .BuildFish(
            "Coral Wildsplash",
            "images\\fishes\\Coral_Wildsplash.png",
            "Night variant",
            new Location(),
            new Price(300, 750, 450, 1125))

            .Reset());

            Fishes.Add(builder
                .BuildName("devilfish")
                .BuildBait(Bait.Grubs)

            .BuildFish(
            "Ashen Devilfish",
            "images\\fishes\\Ashen_Devilfish.png",
            "Base variant",
            new Location(),
            new Price(225, 565, 340, 850))

            .BuildFish(
            "Seashell Devilfish",
            "images\\fishes\\Seashell_Devilfish.png",
            "Common variant",
            new Location(),
            new Price(300, 750, 450, 1125))

            .BuildFish(
            "Lava Devilfish",
            "images\\fishes\\Lava_Devilfish.png",
            "Uncommon variant",
            new Location(),
            new Price(375, 940, 565, 1410))

            .BuildFish(
            "Forsaken Devilfish",
            "images\\fishes\\Forsaken_Devilfish.png",
            "Rare variant",
            new Location(),
            new Price(3000, 7500, 4500, 11250))

            .BuildFish(
            "Firelight Devilfish",
            "images\\fishes\\Firelight_Devilfish.png",
            "Night variant",
            new Location(),
            new Price(300, 750, 450, 1125))

            .Reset());

            Fishes.Add(builder
                .BuildName("battlegill")
                .BuildBait(Bait.Grubs)

            .BuildFish(
            "Jade Battlegill",
            "images\\fishes\\Jade_Battlegill.png",
            "Base variant",
            new Location(),
            new Price(375, 940, 565, 1410))

            .BuildFish(
            "Sky Battlegill",
            "images\\fishes\\Sky_Battlegill.png",
            "Common variant",
            new Location(),
            new Price(450, 1125, 675, 1690))

            .BuildFish(
            "Rum Battlegill",
            "images\\fishes\\Rum_Battlegill.png",
            "Uncommon variant",
            new Location(),
            new Price(525, 1315, 790, 1975))

            .BuildFish(
            "Sand Battlegill",
            "images\\fishes\\Sand_Battlegill.png",
            "Rare variant",
            new Location(),
            new Price(3750, 9375, 5625, 14065))

            .BuildFish(
            "Bittersweet Battlegill",
            "images\\fishes\\Bittersweet_Battlegill.png",
            "Night variant",
            new Location(),
            new Price(450, 1125, 675, 1690))

            .Reset());

            Fishes.Add(builder
                .BuildName("wrecker")
                .BuildBait(Bait.Earthworms)

            .BuildFish(
            "Rose Wrecker",
            "images\\fishes\\Rose_Wrecker.png",
            "Base variant",
            new Location(),
            new Price(375, 940, 565, 1410))

            .BuildFish(
            "Sun Wrecker",
            "images\\fishes\\Sun_Wrecker.png",
            "Common variant",
            new Location(),
            new Price(450, 1125, 675, 1690))

            .BuildFish(
            "Blackcloud Wrecker",
            "images\\fishes\\Blackcloud_Wrecker.png",
            "Storm variant",
            new Location(),
            new Price(525, 1315, 790, 1975))

            .BuildFish(
            "Snow Wrecker",
            "images\\fishes\\Snow_Wrecker.png",
            "Rare variant",
            new Location(),
            new Price(3750, 9375, 5625, 14065))

            .BuildFish(
            "Moon Wrecker",
            "images\\fishes\\Moon_Wrecker.png",
            "Night variant",
            new Location(),
            new Price(450, 1125, 675, 1690))

            .Reset());

            Fishes.Add(builder
                .BuildName("stormfish")
                .BuildBait(Bait.Leeches)

            .BuildFish(
            "Ancient Stormfish",
            "images\\fishes\\Ancient_Stormfish.png",
            "The Ancient Isles variant",
            new Location(),
            new Price(450, 1125, 675, 1690))

            .BuildFish(
            "Shores Stormfish",
            "images\\fishes\\Shores_Stormfish.png",
            "The Shores of Plenty variant",
            new Location(),
            new Price(450, 1125, 675, 1690))

            .BuildFish(
            "Wild Stormfish",
            "images\\fishes\\Wild_Stormfish.png",
            "The Wilds variant",
            new Location(),
            new Price(450, 1125, 675, 1690))

            .BuildFish(
            "Shadow Stormfish",
            "images\\fishes\\Shadow_Stormfish.png",
            "Rare variant",
            new Location(),
            new Price(4500, 11250, 6750, 16875))

            .BuildFish(
            "Twilight Stormfish",
            "images\\fishes\\Twilight_Stormfish.png",
            "Night variant",
            new Location(),
            new Price(450, 1125, 675, 1690))

            .Reset()
            );
#endregion
        }
    }
}
