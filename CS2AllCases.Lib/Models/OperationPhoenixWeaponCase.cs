using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class OperationPhoenixWeaponCase : ICases
    {
        public OperationPhoenixWeaponCase(ProbabilitiesDropOptions? options = null)
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
            [Description("UMP-45 | Corporal")]
            UMP45Corporal = 1,
            [Description("Tec-9 | Sandstorm")]
            Tec9Sandstorm = 2,
            [Description("Negev | Terrain")]
            NegevTerrain = 3,
            [Description("MAG-7 | Heaven Guard")]
            MAG7HeavenGuard = 4,
            [Description("USP-S | Guardian")]
            USPSGuardian = 5,
            [Description("SG 553 | Pulse")]
            SG553Pulse = 6,
            [Description("MAC-10 | Heat")]
            MAC10Heat = 7,
            [Description("FAMAS | Sergeant")]
            FAMASSergeant = 8,
            [Description("P90 | Trigon")]
            P90Trigon = 9,
            [Description("Nova | Antique")]
            NovaAntique = 10,
            [Description("AK-47 | Redline")]
            AK47Redline = 11,
            [Description("AWP | Asiimov")]
            AWPAsiimov = 12,
            [Description("AUG | Chameleon")]
            AUGChameleon = 13,
            [Description("Karambit | Fade")]
            KarambitFade = 14,
            [Description("Karambit | Vanilla")]
            KarambitVanilla = 15,
            [Description("M9 Bayonet | Fade")]
            M9BayonetFade = 16,
            [Description("Karambit | Case Hardened")]
            KarambitCaseHardened = 17,
            [Description("Karambit | Slaughter")]
            KarambitSlaughter = 18,
            [Description("M9 Bayonet | Vanilla")]
            M9BayonetVanilla = 19,
            [Description("Karambit | Crimson Web")]
            KarambitCrimsonWeb = 20,
            [Description("M9 Bayonet | Slaughter")]
            M9BayonetSlaughter = 21,
            [Description("M9 Bayonet | Crimson Web")]
            M9BayonetCrimsonWeb = 22,
            [Description("Karambit | Blue Steel")]
            KarambitBlueSteel = 23,
            [Description("Karambit | Night")]
            KarambitNight = 24,
            [Description("Karambit | Stained")]
            KarambitStained = 25,
            [Description("M9 Bayonet | Case Hardened")]
            M9BayonetCaseHardened = 26,
            [Description("M9 Bayonet | Blue Steel")]
            M9BayonetBlueSteel = 27,
            [Description("Karambit | Scorched")]
            KarambitScorched = 28,
            [Description("Karambit | Urban Masked")]
            KarambitUrbanMasked = 29,
            [Description("M9 Bayonet | Stained")]
            M9BayonetStained = 30,
            [Description("Karambit | Boreal Forest")]
            KarambitBorealForest = 31,
            [Description("M9 Bayonet | Night")]
            M9BayonetNight = 32,
            [Description("Bayonet | Fade")]
            BayonetFade = 33,
            [Description("Karambit | Forest DDPAT")]
            KarambitForestDDPAT = 34,
            [Description("Karambit | Safari Mesh")]
            KarambitSafariMesh = 35,
            [Description("Bayonet | Slaughter")]
            BayonetSlaughter = 36,
            [Description("Flip Knife | Fade")]
            FlipKnifeFade = 37,
            [Description("M9 Bayonet | Scorched")]
            M9BayonetScorched = 38,
            [Description("M9 Bayonet | Urban Masked")]
            M9BayonetUrbanMasked = 39,
            [Description("M9 Bayonet | Forest DDPAT")]
            M9BayonetForestDDPAT = 40,
            [Description("M9 Bayonet | Boreal Forest")]
            M9BayonetBorealForest = 41,
            [Description("M9 Bayonet | Safari Mesh")]
            M9BayonetSafariMesh = 42,
            [Description("Bayonet | Case Hardened")]
            BayonetCaseHardened = 43,
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
            [Description("Flip Knife | Stained")]
            FlipKnifeStained = 56,
            [Description("Bayonet | Scorched")]
            BayonetScorched = 57,
            [Description("Gut Knife | Fade")]
            GutKnifeFade = 58,
            [Description("Flip Knife | Night")]
            FlipKnifeNight = 59,
            [Description("Bayonet | Forest DDPAT")]
            BayonetForestDDPAT = 60,
            [Description("Bayonet | Boreal Forest")]
            BayonetBorealForest = 61,
            [Description("Gut Knife | Slaughter")]
            GutKnifeSlaughter = 62,
            [Description("Bayonet | Safari Mesh")]
            BayonetSafariMesh = 63,
            [Description("Flip Knife | Scorched")]
            FlipKnifeScorched = 64,
            [Description("Flip Knife | Urban Masked")]
            FlipKnifeUrbanMasked = 65,
            [Description("Flip Knife | Boreal Forest")]
            FlipKnifeBorealForest = 66,
            [Description("Flip Knife | Forest DDPAT")]
            FlipKnifeForestDDPAT = 67,
            [Description("Flip Knife | Safari Mesh")]
            FlipKnifeSafariMesh = 68,
            [Description("Gut Knife | Crimson Web")]
            GutKnifeCrimsonWeb = 69,
            [Description("Gut Knife | Vanilla")]
            GutKnifeVanilla = 70,
            [Description("Gut Knife | Stained")]
            GutKnifeStained = 71,
            [Description("Gut Knife | Blue Steel")]
            GutKnifeBlueSteel = 72,
            [Description("Gut Knife | Safari Mesh")]
            GutKnifeSafariMesh = 73,
            [Description("Gut Knife | Forest DDPAT")]
            GutKnifeForestDDPAT = 74,
            [Description("Gut Knife | Urban Masked")]
            GutKnifeUrbanMasked = 75,
            [Description("Gut Knife | Night")]
            GutKnifeNight = 76,
            [Description("Gut Knife | Scorched")]
            GutKnifeScorched = 77,
            [Description("Gut Knife | Boreal Forest")]
            GutKnifeBorealForest = 78
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
