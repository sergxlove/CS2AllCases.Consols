using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class OperationBravoCase : ICases
    {
        public OperationBravoCase(ProbabilitiesDropOptions? options = null)
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
            [Description("UMP-45 | Bone Pile")]
            UMP45BonePile = 1,
            [Description("SG 553 | Wave Spray")]
            SG553WaveSpray = 2,
            [Description("Nova | Tempest")]
            NovaTempest = 3,
            [Description("Galil AR | Shattered")]
            GalilARShattered = 4,
            [Description("G3SG1 | Demeter")]
            G3SG1Demeter = 5,
            [Description("Dual Berettas | Black Limba")]
            DualBerettasBlackLimba = 6,
            [Description("USP-S | Overgrowth")]
            USPSOvergrowth = 7,
            [Description("MAC-10 | Graven")]
            MAC10Graven = 8,
            [Description("M4A4 | Zirka")]
            M4A4Zirka = 9,
            [Description("M4A1-S | Bright Water")]
            M4A1SBrightWater = 10,
            [Description("P90 | Emerald Dragon")]
            P90EmeraldDragon = 11,
            [Description("P2000 | Ocean Foam")]
            P2000OceanFoam = 12,
            [Description("AWP | Graphite")]
            AWPGraphite = 13,
            [Description("Desert Eagle | Golden Koi")]
            DesertEagleGoldenKoi = 14,
            [Description("AK-47 | Fire Serpent")]
            AK47FireSerpent = 15,
            [Description("Karambit | Fade")]
            KarambitFade = 16,
            [Description("M9 Bayonet | Fade")]
            M9BayonetFade = 17,
            [Description("Karambit | Vanilla")]
            KarambitVanilla = 18,
            [Description("Karambit | Slaughter")]
            KarambitSlaughter = 19,
            [Description("Karambit | Case Hardened")]
            KarambitCaseHardened = 20,
            [Description("M9 Bayonet | Vanilla")]
            M9BayonetVanilla = 21,
            [Description("Karambit | Crimson Web")]
            KarambitCrimsonWeb = 22,
            [Description("M9 Bayonet | Slaughter")]
            M9BayonetSlaughter = 23,
            [Description("M9 Bayonet | Crimson Web")]
            M9BayonetCrimsonWeb = 24,
            [Description("Karambit | Blue Steel")]
            KarambitBlueSteel = 25,
            [Description("Karambit | Night")]
            KarambitNight = 26,
            [Description("Karambit | Stained")]
            KarambitStained = 27,
            [Description("M9 Bayonet | Case Hardened")]
            M9BayonetCaseHardened = 28,
            [Description("M9 Bayonet | Blue Steel")]
            M9BayonetBlueSteel = 29,
            [Description("Karambit | Urban Masked")]
            KarambitUrbanMasked = 30,
            [Description("Karambit | Scorched")]
            KarambitScorched = 31,
            [Description("M9 Bayonet | Stained")]
            M9BayonetStained = 32,
            [Description("Bayonet | Fade")]
            BayonetFade = 33,
            [Description("M9 Bayonet | Night")]
            M9BayonetNight = 34,
            [Description("Karambit | Boreal Forest")]
            KarambitBorealForest = 35,
            [Description("Karambit | Forest DDPAT")]
            KarambitForestDDPAT = 36,
            [Description("Karambit | Safari Mesh")]
            KarambitSafariMesh = 37,
            [Description("Flip Knife | Fade")]
            FlipKnifeFade = 38,
            [Description("Bayonet | Slaughter")]
            BayonetSlaughter = 39,
            [Description("M9 Bayonet | Scorched")]
            M9BayonetScorched = 40,
            [Description("M9 Bayonet | Forest DDPAT")]
            M9BayonetForestDDPAT = 41,
            [Description("M9 Bayonet | Urban Masked")]
            M9BayonetUrbanMasked = 42,
            [Description("M9 Bayonet | Boreal Forest")]
            M9BayonetBorealForest = 43,
            [Description("Bayonet | Case Hardened")]
            BayonetCaseHardened = 44,
            [Description("M9 Bayonet | Safari Mesh")]
            M9BayonetSafariMesh = 45,
            [Description("Flip Knife | Slaughter")]
            FlipKnifeSlaughter = 46,
            [Description("Bayonet | Crimson Web")]
            BayonetCrimsonWeb = 47,
            [Description("Bayonet | Vanilla")]
            BayonetVanilla = 48,
            [Description("Bayonet | Blue Steel")]
            BayonetBlueSteel = 49,
            [Description("Flip Knife | Crimson Web")]
            FlipKnifeCrimsonWeb = 50,
            [Description("Flip Knife | Vanilla")]
            FlipKnifeVanilla = 51,
            [Description("Gut Knife | Case Hardened")]
            GutKnifeCaseHardened = 52,
            [Description("Bayonet | Night")]
            BayonetNight = 53,
            [Description("Flip Knife | Case Hardened")]
            FlipKnifeCaseHardened = 54,
            [Description("Flip Knife | Blue Steel")]
            FlipKnifeBlueSteel = 55,
            [Description("Bayonet | Stained")]
            BayonetStained = 56,
            [Description("Bayonet | Urban Masked")]
            BayonetUrbanMasked = 57,
            [Description("Gut Knife | Fade")]
            GutKnifeFade = 58,
            [Description("Flip Knife | Night")]
            FlipKnifeNight = 59,
            [Description("Bayonet | Scorched")]
            BayonetScorched = 60,
            [Description("Bayonet | Forest DDPAT")]
            BayonetForestDDPAT = 61,
            [Description("Bayonet | Boreal Forest")]
            BayonetBorealForest = 62,
            [Description("Gut Knife | Slaughter")]
            GutKnifeSlaughter = 63,
            [Description("Bayonet | Safari Mesh")]
            BayonetSafariMesh = 64,
            [Description("Flip Knife | Stained")]
            FlipKnifeStained = 65,
            [Description("Flip Knife | Scorched")]
            FlipKnifeScorched = 66,
            [Description("Flip Knife | Urban Masked")]
            FlipKnifeUrbanMasked = 67,
            [Description("Flip Knife | Boreal Forest")]
            FlipKnifeBorealForest = 68,
            [Description("Flip Knife | Forest DDPAT")]
            FlipKnifeForestDDPAT = 69,
            [Description("Flip Knife | Safari Mesh")]
            FlipKnifeSafariMesh = 70,
            [Description("Gut Knife | Crimson Web")]
            GutKnifeCrimsonWeb = 71,
            [Description("Gut Knife | Vanilla")]
            GutKnifeVanilla = 72,
            [Description("Gut Knife | Blue Steel")]
            GutKnifeBlueSteel = 73,
            [Description("Gut Knife | Stained")]
            GutKnifeStained = 74,
            [Description("Gut Knife | Night")]
            GutKnifeNight = 75,
            [Description("Gut Knife | Safari Mesh")]
            GutKnifeSafariMesh = 76,
            [Description("Gut Knife | Forest DDPAT")]
            GutKnifeForestDDPAT = 77,
            [Description("Gut Knife | Scorched")]
            GutKnifeScorched = 78,
            [Description("Gut Knife | Boreal Forest")]
            GutKnifeBorealForest = 79,
            [Description("Gut Knife | Urban Masked")]
            GutKnifeUrbanMasked = 80
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
