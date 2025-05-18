using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class RevolverCase : ICases
    {
        public RevolverCase(ProbabilitiesDropOptions? options = null)
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
            [Description("SCAR-20 | Outbreak")]
            SCAR20Outbreak = 1,
            [Description("Sawed-Off | Yorick")]
            SawedOffYorick = 2,
            [Description("R8 Revolver | Crimson Web")]
            R8RevolverCrimsonWeb = 3,
            [Description("P2000 | Imperial")]
            P2000Imperial = 4,
            [Description("Desert Eagle | Corinthian")]
            DesertEagleCorinthian = 5,
            [Description("AUG | Ricochet")]
            AUGRicochet = 6,
            [Description("XM1014 | Teclu Burner")]
            XM1014TecluBurner = 7,
            [Description("Tec-9 | Avalanche")]
            Tec9Avalanche = 8,
            [Description("SG 553 | Tiger Moth")]
            SG553TigerMoth = 9,
            [Description("PP-Bizon | Fuel Rod")]
            PPBizonFuelRod = 10,
            [Description("Negev | Power Loader")]
            NegevPowerLoader = 11,
            [Description("Five-SeveN | Retrobution")]
            FiveSevenRetrobution = 12,
            [Description("P90 | Shapewood")]
            P90Shapewood = 13,
            [Description("G3SG1 | The Executioner")]
            G3SG1TheExecutioner = 14,
            [Description("AK-47 | Point Disarray")]
            AK47PointDisarray = 15,
            [Description("R8 Revolver | Fade")]
            R8RevolverFade = 16,
            [Description("M4A4 | Royal Paladin")]
            M4A4RoyalPaladin = 17,
            [Description("Karambit | Fade")]
            KarambitFade = 18,
            [Description("Karambit | Vanilla")]
            KarambitVanilla = 19,
            [Description("M9 Bayonet | Fade")]
            M9BayonetFade = 20,
            [Description("Karambit | Slaughter")]
            KarambitSlaughter = 21,
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
            [Description("M9 Bayonet | Case Hardened")]
            M9BayonetCaseHardened = 27,
            [Description("M9 Bayonet | Crimson Web")]
            M9BayonetCrimsonWeb = 28,
            [Description("Karambit | Stained")]
            KarambitStained = 29,
            [Description("Karambit | Night")]
            KarambitNight = 30,
            [Description("M9 Bayonet | Blue Steel")]
            M9BayonetBlueSteel = 31,
            [Description("Karambit | Scorched")]
            KarambitScorched = 32,
            [Description("Karambit | Urban Masked")]
            KarambitUrbanMasked = 33,
            [Description("M9 Bayonet | Stained")]
            M9BayonetStained = 34,
            [Description("Bayonet | Fade")]
            BayonetFade = 35,
            [Description("Karambit | Boreal Forest")]
            KarambitBorealForest = 36,
            [Description("M9 Bayonet | Night")]
            M9BayonetNight = 37,
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
            [Description("Bayonet | Case Hardened")]
            BayonetCaseHardened = 46,
            [Description("M9 Bayonet | Safari Mesh")]
            M9BayonetSafariMesh = 47,
            [Description("Bayonet | Crimson Web")]
            BayonetCrimsonWeb = 48,
            [Description("Flip Knife | Slaughter")]
            FlipKnifeSlaughter = 49,
            [Description("Bayonet | Vanilla")]
            BayonetVanilla = 50,
            [Description("Bayonet | Blue Steel")]
            BayonetBlueSteel = 51,
            [Description("Flip Knife | Crimson Web")]
            FlipKnifeCrimsonWeb = 52,
            [Description("Flip Knife | Case Hardened")]
            FlipKnifeCaseHardened = 53,
            [Description("Flip Knife | Vanilla")]
            FlipKnifeVanilla = 54,
            [Description("Gut Knife | Case Hardened")]
            GutKnifeCaseHardened = 55,
            [Description("Bayonet | Night")]
            BayonetNight = 56,
            [Description("Flip Knife | Blue Steel")]
            FlipKnifeBlueSteel = 57,
            [Description("Bayonet | Stained")]
            BayonetStained = 58,
            [Description("Bayonet | Urban Masked")]
            BayonetUrbanMasked = 59,
            [Description("Bayonet | Scorched")]
            BayonetScorched = 60,
            [Description("Bayonet | Forest DDPAT")]
            BayonetForestDDPAT = 61,
            [Description("Flip Knife | Stained")]
            FlipKnifeStained = 62,
            [Description("Gut Knife | Fade")]
            GutKnifeFade = 63,
            [Description("Flip Knife | Night")]
            FlipKnifeNight = 64,
            [Description("Bayonet | Boreal Forest")]
            BayonetBorealForest = 65,
            [Description("Bayonet | Safari Mesh")]
            BayonetSafariMesh = 66,
            [Description("Gut Knife | Slaughter")]
            GutKnifeSlaughter = 67,
            [Description("Flip Knife | Scorched")]
            FlipKnifeScorched = 68,
            [Description("Flip Knife | Urban Masked")]
            FlipKnifeUrbanMasked = 69,
            [Description("Flip Knife | Forest DDPAT")]
            FlipKnifeForestDDPAT = 70,
            [Description("Flip Knife | Boreal Forest")]
            FlipKnifeBorealForest = 71,
            [Description("Flip Knife | Safari Mesh")]
            FlipKnifeSafariMesh = 72,
            [Description("Gut Knife | Crimson Web")]
            GutKnifeCrimsonWeb = 73,
            [Description("Gut Knife | Vanilla")]
            GutKnifeVanilla = 74,
            [Description("Gut Knife | Blue Steel")]
            GutKnifeBlueSteel = 75,
            [Description("Gut Knife | Stained")]
            GutKnifeStained = 76,
            [Description("Gut Knife | Safari Mesh")]
            GutKnifeSafariMesh = 77,
            [Description("Gut Knife | Urban Masked")]
            GutKnifeUrbanMasked = 78,
            [Description("Gut Knife | Scorched")]
            GutKnifeScorched = 79,
            [Description("Gut Knife | Forest DDPAT")]
            GutKnifeForestDDPAT = 80,
            [Description("Gut Knife | Boreal Forest")]
            GutKnifeBorealForest = 81,
            [Description("Gut Knife | Night")]
            GutKnifeNight = 82
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
