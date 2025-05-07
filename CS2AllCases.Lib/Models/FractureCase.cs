using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class FractureCase : ICases
    {
        public FractureCase(ProbabilitiesDropOptions? options = null)
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
            [Description("SSG 08 | Mainframe 001")]
            SSG08Mainframe001 = 1,
            [Description("SG 553 | Ol' Rusty")]
            SG553OlRusty = 2,
            [Description("PP-Bizon | Runic")]
            PPBizonRunic = 3,
            [Description("P90 | Freight")]
            P90Freight = 4,
            [Description("P250 | Cassette")]
            P250Cassette = 5,
            [Description("P2000 | Gnarled")]
            P2000Gnarled = 6,
            [Description("Negev | Ultralight")]
            NegevUltralight = 7,
            [Description("Tec-9 | Brother")]
            Tec9Brother = 8,
            [Description("MP5-SD | Kitbash")]
            MP5SDKitbash = 9,
            [Description("MAG-7 | Monster Call")]
            MAG7MonsterCall = 10,
            [Description("MAC-10 | Allure")]
            MAC10Allure = 11,
            [Description("Galil AR | Connexion")]
            GalilARConnexion = 12,
            [Description("XM1014 | Entombed")]
            XM1014Entombed = 13,
            [Description("M4A4 | Tooth Fairy")]
            M4A4ToothFairy = 14,
            [Description("Glock-18 | Vogue")]
            Glock18Vogue = 15,
            [Description("Desert Eagle | Printstream")]
            DesertEaglePrintstream = 16,
            [Description("AK-47 | Legion of Anubis")]
            AK47LegionOfAnubis = 17,
            [Description("Skeleton Knife | Fade")]
            SkeletonKnifeFade = 18,
            [Description("Skeleton Knife | Crimson Web")]
            SkeletonKnifeCrimsonWeb = 19,
            [Description("Nomad Knife | Fade")]
            NomadKnifeFade = 20,
            [Description("Skeleton Knife | Slaughter")]
            SkeletonKnifeSlaughter = 21,
            [Description("Skeleton Knife | Case Hardened")]
            SkeletonKnifeCaseHardened = 22,
            [Description("Skeleton Knife | Vanilla")]
            SkeletonKnifeVanilla = 23,
            [Description("Survival Knife | Crimson Web")]
            SurvivalKnifeCrimsonWeb = 24,
            [Description("Skeleton Knife | Blue Steel")]
            SkeletonKnifeBlueSteel = 25,
            [Description("Nomad Knife | Case Hardened")]
            NomadKnifeCaseHardened = 26,
            [Description("Nomad Knife | Slaughter")]
            NomadKnifeSlaughter = 27,
            [Description("Skeleton Knife | Stained")]
            SkeletonKnifeStained = 28,
            [Description("Skeleton Knife | Night Stripe")]
            SkeletonKnifeNightStripe = 29,
            [Description("Nomad Knife | Crimson Web")]
            NomadKnifeCrimsonWeb = 30,
            [Description("Nomad Knife | Vanilla")]
            NomadKnifeVanilla = 31,
            [Description("Skeleton Knife | Urban Masked")]
            SkeletonKnifeUrbanMasked = 32,
            [Description("Paracord Knife | Fade")]
            ParacordKnifeFade = 33,
            [Description("Skeleton Knife | Scorched")]
            SkeletonKnifeScorched = 34,
            [Description("Nomad Knife | Stained")]
            NomadKnifeStained = 35,
            [Description("Survival Knife | Fade")]
            SurvivalKnifeFade = 36,
            [Description("Nomad Knife | Blue Steel")]
            NomadKnifeBlueSteel = 37,
            [Description("Skeleton Knife | Forest DDPAT")]
            SkeletonKnifeForestDDPAT = 38,
            [Description("Skeleton Knife | Boreal Forest")]
            SkeletonKnifeBorealForest = 39,
            [Description("Paracord Knife | Case Hardened")]
            ParacordKnifeCaseHardened = 40,
            [Description("Skeleton Knife | Safari Mesh")]
            SkeletonKnifeSafariMesh = 41,
            [Description("Paracord Knife | Slaughter")]
            ParacordKnifeSlaughter = 42,
            [Description("Paracord Knife | Night Stripe")]
            ParacordKnifeNightStripe = 43,
            [Description("Survival Knife | Case Hardened")]
            SurvivalKnifeCaseHardened = 44,
            [Description("Paracord Knife | Crimson Web")]
            ParacordKnifeCrimsonWeb = 45,
            [Description("Survival Knife | Slaughter")]
            SurvivalKnifeSlaughter = 46,
            [Description("Nomad Knife | Scorched")]
            NomadKnifeScorched = 47,
            [Description("Paracord Knife | Urban Masked")]
            ParacordKnifeUrbanMasked = 48,
            [Description("Paracord Knife | Blue Steel")]
            ParacordKnifeBlueSteel = 49,
            [Description("Nomad Knife | Urban Masked")]
            NomadKnifeUrbanMasked = 50,
            [Description("Nomad Knife | Night Stripe")]
            NomadKnifeNightStripe = 51,
            [Description("Survival Knife | Night Stripe")]
            SurvivalKnifeNightStripe = 52,
            [Description("Survival Knife | Blue Steel")]
            SurvivalKnifeBlueSteel = 53,
            [Description("Nomad Knife | Forest DDPAT")]
            NomadKnifeForestDDPAT = 54,
            [Description("Paracord Knife | Stained")]
            ParacordKnifeStained = 55,
            [Description("Paracord Knife | Vanilla")]
            ParacordKnifeVanilla = 56,
            [Description("Nomad Knife | Boreal Forest")]
            NomadKnifeBorealForest = 57,
            [Description("Survival Knife | Vanilla")]
            SurvivalKnifeVanilla = 58,
            [Description("Paracord Knife | Forest DDPAT")]
            ParacordKnifeForestDDPAT = 59,
            [Description("Survival Knife | Stained")]
            SurvivalKnifeStained = 60,
            [Description("Survival Knife | Boreal Forest")]
            SurvivalKnifeBorealForest = 61,
            [Description("Nomad Knife | Safari Mesh")]
            NomadKnifeSafariMesh = 62,
            [Description("Paracord Knife | Safari Mesh")]
            ParacordKnifeSafariMesh = 63,
            [Description("Paracord Knife | Boreal Forest")]
            ParacordKnifeBorealForest = 64,
            [Description("Survival Knife | Scorched")]
            SurvivalKnifeScorched = 65,
            [Description("Survival Knife | Safari Mesh")]
            SurvivalKnifeSafariMesh = 66,
            [Description("Survival Knife | Forest DDPAT")]
            SurvivalKnifeForestDDPAT = 67,
            [Description("Survival Knife | Urban Masked")]
            SurvivalKnifeUrbanMasked = 68,
            [Description("Paracord Knife | Scorched")]
            ParacordKnifeScorched = 69
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
