using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class CSGOWeaponCase3 : ICases
    {
        public CSGOWeaponCase3(ProbabilitiesDropOptions? options = null)
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
            [Description("USP-S | Stainless")]
            USPSStainless = 1,
            [Description("P2000 | Red FragCam")]
            P2000RedFragCam = 2,
            [Description("Glock-18 | Blue Fissure")]
            Glock18BlueFissure = 3,
            [Description("Dual Berettas | Panther")]
            DualBerettasPanther = 4,
            [Description("CZ75-Auto | Crimson Web")]
            CZ75AutoCrimsonWeb = 5,
            [Description("Tec-9 | Titanium Bit")]
            Tec9TitaniumBit = 6,
            [Description("Five-SeveN | Copper Galaxy")]
            FiveSevenCopperGalaxy = 7,
            [Description("Desert Eagle | Heirloom")]
            DesertEagleHeirloom = 8,
            [Description("CZ75-Auto | Tread Plate")]
            CZ75AutoTreadPlate = 9,
            [Description("P250 | Undertow")]
            P250Undertow = 10,
            [Description("CZ75-Auto | The Fuschia Is Now")]
            CZ75AutoTheFuschiaIsNow = 11,
            [Description("CZ75-Auto | Victoria")]
            CZ75AutoVictoria = 12,
            [Description("Karambit | Fade")]
            KarambitFade = 13,
            [Description("Karambit | Vanilla")]
            KarambitVanilla = 14,
            [Description("Karambit | Slaughter")]
            KarambitSlaughter = 15,
            [Description("M9 Bayonet | Fade")]
            M9BayonetFade = 16,
            [Description("Karambit | Case Hardened")]
            KarambitCaseHardened = 17,
            [Description("M9 Bayonet | Slaughter")]
            M9BayonetSlaughter = 18,
            [Description("Karambit | Crimson Web")]
            KarambitCrimsonWeb = 19,
            [Description("Karambit | Blue Steel")]
            KarambitBlueSteel = 20,
            [Description("M9 Bayonet | Vanilla")]
            M9BayonetVanilla = 21,
            [Description("M9 Bayonet | Crimson Web")]
            M9BayonetCrimsonWeb = 22,
            [Description("M9 Bayonet | Case Hardened")]
            M9BayonetCaseHardened = 23,
            [Description("Karambit | Night")]
            KarambitNight = 24,
            [Description("Karambit | Stained")]
            KarambitStained = 25,
            [Description("M9 Bayonet | Blue Steel")]
            M9BayonetBlueSteel = 26,
            [Description("Karambit | Scorched")]
            KarambitScorched = 27,
            [Description("Karambit | Urban Masked")]
            KarambitUrbanMasked = 28,
            [Description("M9 Bayonet | Stained")]
            M9BayonetStained = 29,
            [Description("Karambit | Boreal Forest")]
            KarambitBorealForest = 30,
            [Description("M9 Bayonet | Night")]
            M9BayonetNight = 31,
            [Description("Bayonet | Fade")]
            BayonetFade = 32,
            [Description("Karambit | Forest DDPAT")]
            KarambitForestDDPAT = 33,
            [Description("Karambit | Safari Mesh")]
            KarambitSafariMesh = 34,
            [Description("Bayonet | Slaughter")]
            BayonetSlaughter = 35,
            [Description("Flip Knife | Fade")]
            FlipKnifeFade = 36,
            [Description("M9 Bayonet | Urban Masked")]
            M9BayonetUrbanMasked = 37,
            [Description("M9 Bayonet | Scorched")]
            M9BayonetScorched = 38,
            [Description("M9 Bayonet | Forest DDPAT")]
            M9BayonetForestDDPAT = 39,
            [Description("M9 Bayonet | Boreal Forest")]
            M9BayonetBorealForest = 40,
            [Description("M9 Bayonet | Safari Mesh")]
            M9BayonetSafariMesh = 41,
            [Description("Bayonet | Case Hardened")]
            BayonetCaseHardened = 42,
            [Description("Bayonet | Crimson Web")]
            BayonetCrimsonWeb = 43,
            [Description("Flip Knife | Slaughter")]
            FlipKnifeSlaughter = 44,
            [Description("Bayonet | Vanilla")]
            BayonetVanilla = 45,
            [Description("Flip Knife | Crimson Web")]
            FlipKnifeCrimsonWeb = 46,
            [Description("Bayonet | Blue Steel")]
            BayonetBlueSteel = 47,
            [Description("Flip Knife | Vanilla")]
            FlipKnifeVanilla = 48,
            [Description("Flip Knife | Case Hardened")]
            FlipKnifeCaseHardened = 49,
            [Description("Gut Knife | Case Hardened")]
            GutKnifeCaseHardened = 50,
            [Description("Bayonet | Stained")]
            BayonetStained = 51,
            [Description("Flip Knife | Blue Steel")]
            FlipKnifeBlueSteel = 52,
            [Description("Bayonet | Night")]
            BayonetNight = 53,
            [Description("Bayonet | Urban Masked")]
            BayonetUrbanMasked = 54,
            [Description("Flip Knife | Stained")]
            FlipKnifeStained = 55,
            [Description("Flip Knife | Night")]
            FlipKnifeNight = 56,
            [Description("Bayonet | Scorched")]
            BayonetScorched = 57,
            [Description("Gut Knife | Fade")]
            GutKnifeFade = 58,
            [Description("Bayonet | Forest DDPAT")]
            BayonetForestDDPAT = 59,
            [Description("Bayonet | Boreal Forest")]
            BayonetBorealForest = 60,
            [Description("Bayonet | Safari Mesh")]
            BayonetSafariMesh = 61,
            [Description("Gut Knife | Slaughter")]
            GutKnifeSlaughter = 62,
            [Description("Flip Knife | Urban Masked")]
            FlipKnifeUrbanMasked = 63,
            [Description("Flip Knife | Scorched")]
            FlipKnifeScorched = 64,
            [Description("Flip Knife | Boreal Forest")]
            FlipKnifeBorealForest = 65,
            [Description("Flip Knife | Forest DDPAT")]
            FlipKnifeForestDDPAT = 66,
            [Description("Flip Knife | Safari Mesh")]
            FlipKnifeSafariMesh = 67,
            [Description("Gut Knife | Crimson Web")]
            GutKnifeCrimsonWeb = 68,
            [Description("Gut Knife | Stained")]
            GutKnifeStained = 69,
            [Description("Gut Knife | Vanilla")]
            GutKnifeVanilla = 70,
            [Description("Gut Knife | Blue Steel")]
            GutKnifeBlueSteel = 71,
            [Description("Gut Knife | Urban Masked")]
            GutKnifeUrbanMasked = 72,
            [Description("Gut Knife | Night")]
            GutKnifeNight = 73,
            [Description("Gut Knife | Boreal Forest")]
            GutKnifeBorealForest = 74,
            [Description("Gut Knife | Scorched")]
            GutKnifeScorched = 75,
            [Description("Gut Knife | Forest DDPAT")]
            GutKnifeForestDDPAT = 76,
            [Description("Gut Knife | Safari Mesh")]
            GutKnifeSafariMesh = 77
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
