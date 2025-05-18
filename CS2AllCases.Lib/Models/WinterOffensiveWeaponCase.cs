using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class WinterOffensiveWeaponCase : ICases
    {
        public WinterOffensiveWeaponCase(ProbabilitiesDropOptions? options = null)
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
            [Description("PP-Bizon | Cobalt Halftone")]
            PPBizonCobaltHalftone = 1,
            [Description("M249 | Magma")]
            M249Magma = 2,
            [Description("Galil AR | Sandstorm")]
            GalilARSandstorm = 3,
            [Description("Five-SeveN | Kami")]
            FiveSevenKami = 4,
            [Description("Nova | Rising Skull")]
            NovaRisingSkull = 5,
            [Description("MP9 | Rose Iron")]
            MP9RoseIron = 6,
            [Description("FAMAS | Pulse")]
            FAMASPulse = 7,
            [Description("Dual Berettas | Marina")]
            DualBerettasMarina = 8,
            [Description("P250 | Mehndi")]
            P250Mehndi = 9,
            [Description("M4A1-S | Guardian")]
            M4A1SGuardian = 10,
            [Description("AWP | Redline")]
            AWPRedline = 11,
            [Description("Sawed-Off | The Kraken")]
            SawedOffTheKraken = 12,
            [Description("M4A4 | Asiimov")]
            M4A4Asiimov = 13,
            [Description("Karambit | Fade")]
            KarambitFade = 14,
            [Description("Karambit | Vanilla")]
            KarambitVanilla = 15,
            [Description("M9 Bayonet | Fade")]
            M9BayonetFade = 16,
            [Description("Karambit | Slaughter")]
            KarambitSlaughter = 17,
            [Description("Karambit | Case Hardened")]
            KarambitCaseHardened = 18,
            [Description("M9 Bayonet | Vanilla")]
            M9BayonetVanilla = 19,
            [Description("Karambit | Crimson Web")]
            KarambitCrimsonWeb = 20,
            [Description("M9 Bayonet | Slaughter")]
            M9BayonetSlaughter = 21,
            [Description("Karambit | Blue Steel")]
            KarambitBlueSteel = 22,
            [Description("M9 Bayonet | Case Hardened")]
            M9BayonetCaseHardened = 23,
            [Description("M9 Bayonet | Crimson Web")]
            M9BayonetCrimsonWeb = 24,
            [Description("Karambit | Stained")]
            KarambitStained = 25,
            [Description("Karambit | Night")]
            KarambitNight = 26,
            [Description("M9 Bayonet | Blue Steel")]
            M9BayonetBlueSteel = 27,
            [Description("Karambit | Scorched")]
            KarambitScorched = 28,
            [Description("Karambit | Urban Masked")]
            KarambitUrbanMasked = 29,
            [Description("M9 Bayonet | Stained")]
            M9BayonetStained = 30,
            [Description("Bayonet | Fade")]
            BayonetFade = 31,
            [Description("Karambit | Boreal Forest")]
            KarambitBorealForest = 32,
            [Description("M9 Bayonet | Night")]
            M9BayonetNight = 33,
            [Description("Karambit | Forest DDPAT")]
            KarambitForestDDPAT = 34,
            [Description("Karambit | Safari Mesh")]
            KarambitSafariMesh = 35,
            [Description("Flip Knife | Fade")]
            FlipKnifeFade = 36,
            [Description("Bayonet | Slaughter")]
            BayonetSlaughter = 37,
            [Description("M9 Bayonet | Urban Masked")]
            M9BayonetUrbanMasked = 38,
            [Description("M9 Bayonet | Scorched")]
            M9BayonetScorched = 39,
            [Description("M9 Bayonet | Forest DDPAT")]
            M9BayonetForestDDPAT = 40,
            [Description("M9 Bayonet | Boreal Forest")]
            M9BayonetBorealForest = 41,
            [Description("Bayonet | Case Hardened")]
            BayonetCaseHardened = 42,
            [Description("M9 Bayonet | Safari Mesh")]
            M9BayonetSafariMesh = 43,
            [Description("Bayonet | Crimson Web")]
            BayonetCrimsonWeb = 44,
            [Description("Flip Knife | Slaughter")]
            FlipKnifeSlaughter = 45,
            [Description("Bayonet | Vanilla")]
            BayonetVanilla = 46,
            [Description("Bayonet | Blue Steel")]
            BayonetBlueSteel = 47,
            [Description("Flip Knife | Crimson Web")]
            FlipKnifeCrimsonWeb = 48,
            [Description("Flip Knife | Case Hardened")]
            FlipKnifeCaseHardened = 49,
            [Description("Flip Knife | Vanilla")]
            FlipKnifeVanilla = 50,
            [Description("Gut Knife | Case Hardened")]
            GutKnifeCaseHardened = 51,
            [Description("Bayonet | Night")]
            BayonetNight = 52,
            [Description("Flip Knife | Blue Steel")]
            FlipKnifeBlueSteel = 53,
            [Description("Bayonet | Stained")]
            BayonetStained = 54,
            [Description("Bayonet | Urban Masked")]
            BayonetUrbanMasked = 55,
            [Description("Bayonet | Scorched")]
            BayonetScorched = 56,
            [Description("Bayonet | Forest DDPAT")]
            BayonetForestDDPAT = 57,
            [Description("Flip Knife | Stained")]
            FlipKnifeStained = 58,
            [Description("Gut Knife | Fade")]
            GutKnifeFade = 59,
            [Description("Flip Knife | Night")]
            FlipKnifeNight = 60,
            [Description("Bayonet | Boreal Forest")]
            BayonetBorealForest = 61,
            [Description("Bayonet | Safari Mesh")]
            BayonetSafariMesh = 62,
            [Description("Gut Knife | Slaughter")]
            GutKnifeSlaughter = 63,
            [Description("Flip Knife | Scorched")]
            FlipKnifeScorched = 64,
            [Description("Flip Knife | Urban Masked")]
            FlipKnifeUrbanMasked = 65,
            [Description("Flip Knife | Forest DDPAT")]
            FlipKnifeForestDDPAT = 66,
            [Description("Flip Knife | Boreal Forest")]
            FlipKnifeBorealForest = 67,
            [Description("Flip Knife | Safari Mesh")]
            FlipKnifeSafariMesh = 68,
            [Description("Gut Knife | Crimson Web")]
            GutKnifeCrimsonWeb = 69,
            [Description("Gut Knife | Vanilla")]
            GutKnifeVanilla = 70,
            [Description("Gut Knife | Blue Steel")]
            GutKnifeBlueSteel = 71,
            [Description("Gut Knife | Stained")]
            GutKnifeStained = 72,
            [Description("Gut Knife | Safari Mesh")]
            GutKnifeSafariMesh = 73,
            [Description("Gut Knife | Urban Masked")]
            GutKnifeUrbanMasked = 74,
            [Description("Gut Knife | Scorched")]
            GutKnifeScorched = 75,
            [Description("Gut Knife | Forest DDPAT")]
            GutKnifeForestDDPAT = 76,
            [Description("Gut Knife | Boreal Forest")]
            GutKnifeBorealForest = 77,
            [Description("Gut Knife | Night")]
            GutKnifeNight = 78
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
