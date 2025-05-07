using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class ESports2014SummerCase : ICases
    {
        public ESports2014SummerCase(ProbabilitiesDropOptions? options = null)
        {
            options ??= new ProbabilitiesDropOptions();
            _options = options;

            QuantityaArmy = SkinsArmy.Count;
            QuantityForbidden = SkinsForbidden.Count;
            QuantityClassified = SkinsClassified.Count;
            QuantitySecret = SkinsSecret.Count;
            QuantityRareItem = SkinsRareItem.Count;
        }
        private readonly ProbabilitiesDropOptions _options;

        public int QuantityaArmy;
        public int QuantityForbidden;
        public int QuantityClassified;
        public int QuantitySecret;
        public int QuantityRareItem;

        public ResultsItems GetDrop()
        {
            return PropertyItems.GetDrop(_options, new ListSkinsRequest<Skins>()
            {
                SkinsArmy = SkinsArmy,
                SkinsForbidden = SkinsForbidden,
                SkinsClassified = SkinsClassified,
                SkinsSecret = SkinsSecret,
                SkinsRareItem = SkinsRareItem,
                QuantityaArmy = QuantityaArmy,
                QuantityClassified = QuantityClassified,
                QuantityForbidden = QuantityForbidden,
                QuantitySecret = QuantitySecret,
                QuantityRareItem = QuantityRareItem
            });
        }

        public string GetNameSkinsAll(bool IsSkinArmy = false, bool isSkinForbidden = false,
            bool isSkinClassified = false, bool isSkinSecret = false, bool isSkinRareItem = false)
        {
            return PropertyItems.GetAllNamesSkin(new OnlyListSkinsRequest<Skins>
            {
                SkinsArmy = SkinsArmy,
                SkinsForbidden = SkinsForbidden,
                SkinsClassified = SkinsClassified,
                SkinsSecret = SkinsSecret,
                SkinsRareItem = SkinsRareItem
            },
            IsSkinArmy, isSkinForbidden, isSkinClassified, isSkinSecret, isSkinRareItem);
        }

        public string GetNameSkinsAll()
        {
            return GetNameSkinsAll(true, true, true, true, true);
        }

        public enum Skins
        {
            [Description("None")]
            None = 0,
            [Description("XM1014 | Red Python")]
            XM1014RedPython = 1,
            [Description("USP-S | Blood Tiger")]
            USPSBloodTiger = 2,
            [Description("SSG 08 | Dark Water")]
            SSG08DarkWater = 3,
            [Description("Negev | Bratatat")]
            NegevBratatat = 4,
            [Description("MAC-10 | Ultraviolet")]
            MAC10Ultraviolet = 5,
            [Description("CZ75-Auto | Hexane")]
            CZ75AutoHexane = 6,
            [Description("PP-Bizon | Blue Streak")]
            PPBizonBlueStreak = 7,
            [Description("P90 | Virus")]
            P90Virus = 8,
            [Description("MP7 | Ocean Foam")]
            MP7OceanFoam = 9,
            [Description("Glock-18 | Steel Disruption")]
            Glock18SteelDisruption = 10,
            [Description("Desert Eagle | Crimson Web")]
            DesertEagleCrimsonWeb = 11,
            [Description("P2000 | Corticera")]
            P2000Corticera = 12,
            [Description("Nova | Bloomstick")]
            NovaBloomstick = 13,
            [Description("AWP | Corticera")]
            AWPCorticera = 14,
            [Description("AUG | Bengal Tiger")]
            AUGBengalTiger = 15,
            [Description("M4A4 | Bullet Rain")]
            M4A4BulletRain = 16,
            [Description("AK-47 | Jaguar")]
            AK47Jaguar = 17,
            [Description("Karambit | Fade")]
            KarambitFade = 18,
            [Description("Karambit | Vanilla")]
            KarambitVanilla = 19,
            [Description("Karambit | Slaughter")]
            KarambitSlaughter = 20,
            [Description("M9 Bayonet | Fade")]
            M9BayonetFade = 21,
            [Description("Karambit | Case Hardened")]
            KarambitCaseHardened = 22,
            [Description("M9 Bayonet | Vanilla")]
            M9BayonetVanilla = 23,
            [Description("Karambit | Crimson Web")]
            KarambitCrimsonWeb = 24,
            [Description("M9 Bayonet | Slaughter")]
            M9BayonetSlaughter = 25,
            [Description("Karambit | Blue Steel")]
            KarambitBlueSteel = 26,
            [Description("M9 Bayonet | Crimson Web")]
            M9BayonetCrimsonWeb = 27,
            [Description("Karambit | Night")]
            KarambitNight = 28,
            [Description("Karambit | Stained")]
            KarambitStained = 29,
            [Description("M9 Bayonet | Blue Steel")]
            M9BayonetBlueSteel = 30,
            [Description("M9 Bayonet | Case Hardened")]
            M9BayonetCaseHardened = 31,
            [Description("Karambit | Scorched")]
            KarambitScorched = 32,
            [Description("Karambit | Urban Masked")]
            KarambitUrbanMasked = 33,
            [Description("M9 Bayonet | Stained")]
            M9BayonetStained = 34,
            [Description("M9 Bayonet | Night")]
            M9BayonetNight = 35,
            [Description("Bayonet | Fade")]
            BayonetFade = 36,
            [Description("Karambit | Boreal Forest")]
            KarambitBorealForest = 37,
            [Description("Karambit | Forest DDPAT")]
            KarambitForestDDPAT = 38,
            [Description("Karambit | Safari Mesh")]
            KarambitSafariMesh = 39,
            [Description("Flip Knife | Fade")]
            FlipKnifeFade = 40,
            [Description("Bayonet | Slaughter")]
            BayonetSlaughter = 41,
            [Description("M9 Bayonet | Urban Masked")]
            M9BayonetUrbanMasked = 42,
            [Description("M9 Bayonet | Scorched")]
            M9BayonetScorched = 43,
            [Description("M9 Bayonet | Forest DDPAT")]
            M9BayonetForestDDPAT = 44,
            [Description("M9 Bayonet | Boreal Forest")]
            M9BayonetBorealForest = 45,
            [Description("M9 Bayonet | Safari Mesh")]
            M9BayonetSafariMesh = 46,
            [Description("Bayonet | Case Hardened")]
            BayonetCaseHardened = 47,
            [Description("Bayonet | Crimson Web")]
            BayonetCrimsonWeb = 48,
            [Description("Flip Knife | Slaughter")]
            FlipKnifeSlaughter = 49,
            [Description("Bayonet | Vanilla")]
            BayonetVanilla = 50,
            [Description("Flip Knife | Crimson Web")]
            FlipKnifeCrimsonWeb = 51,
            [Description("Bayonet | Blue Steel")]
            BayonetBlueSteel = 52,
            [Description("Flip Knife | Vanilla")]
            FlipKnifeVanilla = 53,
            [Description("Gut Knife | Case Hardened")]
            GutKnifeCaseHardened = 54,
            [Description("Bayonet | Night")]
            BayonetNight = 55,
            [Description("Flip Knife | Case Hardened")]
            FlipKnifeCaseHardened = 56,
            [Description("Flip Knife | Blue Steel")]
            FlipKnifeBlueSteel = 57,
            [Description("Bayonet | Stained")]
            BayonetStained = 58,
            [Description("Bayonet | Urban Masked")]
            BayonetUrbanMasked = 59,
            [Description("Flip Knife | Night")]
            FlipKnifeNight = 60,
            [Description("Bayonet | Scorched")]
            BayonetScorched = 61,
            [Description("Bayonet | Boreal Forest")]
            BayonetBorealForest = 62,
            [Description("Gut Knife | Fade")]
            GutKnifeFade = 63,
            [Description("Bayonet | Forest DDPAT")]
            BayonetForestDDPAT = 64,
            [Description("Bayonet | Safari Mesh")]
            BayonetSafariMesh = 65,
            [Description("Flip Knife | Stained")]
            FlipKnifeStained = 66,
            [Description("Flip Knife | Urban Masked")]
            FlipKnifeUrbanMasked = 67,
            [Description("Gut Knife | Slaughter")]
            GutKnifeSlaughter = 68,
            [Description("Flip Knife | Scorched")]
            FlipKnifeScorched = 69,
            [Description("Flip Knife | Forest DDPAT")]
            FlipKnifeForestDDPAT = 70,
            [Description("Flip Knife | Boreal Forest")]
            FlipKnifeBorealForest = 71,
            [Description("Flip Knife | Safari Mesh")]
            FlipKnifeSafariMesh = 72,
            [Description("Gut Knife | Crimson Web")]
            GutKnifeCrimsonWeb = 73,
            [Description("Gut Knife | Stained")]
            GutKnifeStained = 74,
            [Description("Gut Knife | Vanilla")]
            GutKnifeVanilla = 75,
            [Description("Gut Knife | Blue Steel")]
            GutKnifeBlueSteel = 76,
            [Description("Gut Knife | Night")]
            GutKnifeNight = 77,
            [Description("Gut Knife | Urban Masked")]
            GutKnifeUrbanMasked = 78,
            [Description("Gut Knife | Scorched")]
            GutKnifeScorched = 79,
            [Description("Gut Knife | Forest DDPAT")]
            GutKnifeForestDDPAT = 80,
            [Description("Gut Knife | Boreal Forest")]
            GutKnifeBorealForest = 81,
            [Description("Gut Knife | Safari Mesh")]
            GutKnifeSafariMesh = 82
        }

        private List<Skins> SkinsArmy =
        [

        ];

        private List<Skins> SkinsForbidden =
        [

        ];

        private List<Skins> SkinsClassified =
        [

        ];

        private List<Skins> SkinsSecret =
        [

        ];

        private List<Skins> SkinsRareItem =
        [

        ];
    }
}
