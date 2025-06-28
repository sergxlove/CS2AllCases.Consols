using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class ESports2013Case : ICases
    {
        public ESports2013Case(ProbabilitiesDropOptions? options = null)
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
            [Description("MAG-7 | Memento")]
            MAG7Memento = 1,
            [Description("M4A4 | Faded Zebra")]
            M4A4FadedZebra = 2,
            [Description("FAMAS | Doomkitty")]
            FAMASDoomkitty = 3,
            [Description("Sawed-Off | Orange DDPAT")]
            SawedOffOrangeDDPAT = 4,
            [Description("P250 | Splash")]
            P250Splash = 5,
            [Description("Galil AR | Orange DDPAT")]
            GalilAROrangeDDPAT = 6,
            [Description("AWP | BOOM")]
            AWPBOOM = 7,
            [Description("AK-47 | Red Laminate")]
            AK47RedLaminate = 8,
            [Description("P90 | Death by Kitty")]
            P90DeathByKitty = 9,
            [Description("Karambit | Fade")]
            KarambitFade = 10,
            [Description("Karambit | Vanilla")]
            KarambitVanilla = 11,
            [Description("Karambit | Slaughter")]
            KarambitSlaughter = 12,
            [Description("M9 Bayonet | Fade")]
            M9BayonetFade = 13,
            [Description("Karambit | Case Hardened")]
            KarambitCaseHardened = 14,
            [Description("M9 Bayonet | Vanilla")]
            M9BayonetVanilla = 15,
            [Description("Karambit | Crimson Web")]
            KarambitCrimsonWeb = 16,
            [Description("M9 Bayonet | Slaughter")]
            M9BayonetSlaughter = 17,
            [Description("Karambit | Blue Steel")]
            KarambitBlueSteel = 18,
            [Description("M9 Bayonet | Crimson Web")]
            M9BayonetCrimsonWeb = 19,
            [Description("Karambit | Night")]
            KarambitNight = 20,
            [Description("Karambit | Stained")]
            KarambitStained = 21,
            [Description("M9 Bayonet | Blue Steel")]
            M9BayonetBlueSteel = 22,
            [Description("M9 Bayonet | Case Hardened")]
            M9BayonetCaseHardened = 23,
            [Description("Karambit | Scorched")]
            KarambitScorched = 24,
            [Description("Karambit | Urban Masked")]
            KarambitUrbanMasked = 25,
            [Description("M9 Bayonet | Stained")]
            M9BayonetStained = 26,
            [Description("M9 Bayonet | Night")]
            M9BayonetNight = 27,
            [Description("Bayonet | Fade")]
            BayonetFade = 28,
            [Description("Karambit | Boreal Forest")]
            KarambitBorealForest = 29,
            [Description("Karambit | Forest DDPAT")]
            KarambitForestDDPAT = 30,
            [Description("Karambit | Safari Mesh")]
            KarambitSafariMesh = 31,
            [Description("Flip Knife | Fade")]
            FlipKnifeFade = 32,
            [Description("Bayonet | Slaughter")]
            BayonetSlaughter = 33,
            [Description("M9 Bayonet | Urban Masked")]
            M9BayonetUrbanMasked = 34,
            [Description("M9 Bayonet | Scorched")]
            M9BayonetScorched = 35,
            [Description("M9 Bayonet | Forest DDPAT")]
            M9BayonetForestDDPAT = 36,
            [Description("M9 Bayonet | Boreal Forest")]
            M9BayonetBorealForest = 37,
            [Description("M9 Bayonet | Safari Mesh")]
            M9BayonetSafariMesh = 38,
            [Description("Bayonet | Case Hardened")]
            BayonetCaseHardened = 39,
            [Description("Bayonet | Crimson Web")]
            BayonetCrimsonWeb = 40,
            [Description("Flip Knife | Slaughter")]
            FlipKnifeSlaughter = 41,
            [Description("Bayonet | Vanilla")]
            BayonetVanilla = 42,
            [Description("Flip Knife | Crimson Web")]
            FlipKnifeCrimsonWeb = 43,
            [Description("Bayonet | Blue Steel")]
            BayonetBlueSteel = 44,
            [Description("Flip Knife | Vanilla")]
            FlipKnifeVanilla = 45,
            [Description("Gut Knife | Case Hardened")]
            GutKnifeCaseHardened = 46,
            [Description("Bayonet | Night")]
            BayonetNight = 47,
            [Description("Flip Knife | Case Hardened")]
            FlipKnifeCaseHardened = 48,
            [Description("Flip Knife | Blue Steel")]
            FlipKnifeBlueSteel = 49,
            [Description("Bayonet | Stained")]
            BayonetStained = 50,
            [Description("Bayonet | Urban Masked")]
            BayonetUrbanMasked = 51,
            [Description("Flip Knife | Night")]
            FlipKnifeNight = 52,
            [Description("Bayonet | Scorched")]
            BayonetScorched = 53,
            [Description("Bayonet | Boreal Forest")]
            BayonetBorealForest = 54,
            [Description("Gut Knife | Fade")]
            GutKnifeFade = 55,
            [Description("Bayonet | Forest DDPAT")]
            BayonetForestDDPAT = 56,
            [Description("Bayonet | Safari Mesh")]
            BayonetSafariMesh = 57,
            [Description("Flip Knife | Stained")]
            FlipKnifeStained = 58,
            [Description("Flip Knife | Urban Masked")]
            FlipKnifeUrbanMasked = 59,
            [Description("Gut Knife | Slaughter")]
            GutKnifeSlaughter = 60,
            [Description("Flip Knife | Scorched")]
            FlipKnifeScorched = 61,
            [Description("Flip Knife | Forest DDPAT")]
            FlipKnifeForestDDPAT = 62,
            [Description("Flip Knife | Boreal Forest")]
            FlipKnifeBorealForest = 63,
            [Description("Flip Knife | Safari Mesh")]
            FlipKnifeSafariMesh = 64,
            [Description("Gut Knife | Crimson Web")]
            GutKnifeCrimsonWeb = 65,
            [Description("Gut Knife | Stained")]
            GutKnifeStained = 66,
            [Description("Gut Knife | Vanilla")]
            GutKnifeVanilla = 67,
            [Description("Gut Knife | Blue Steel")]
            GutKnifeBlueSteel = 68,
            [Description("Gut Knife | Night")]
            GutKnifeNight = 69,
            [Description("Gut Knife | Urban Masked")]
            GutKnifeUrbanMasked = 70,
            [Description("Gut Knife | Scorched")]
            GutKnifeScorched = 71,
            [Description("Gut Knife | Forest DDPAT")]
            GutKnifeForestDDPAT = 72,
            [Description("Gut Knife | Boreal Forest")]
            GutKnifeBorealForest = 73,
            [Description("Gut Knife | Safari Mesh")]
            GutKnifeSafariMesh = 74
        }

        private List<Skins> SkinsArmy =
        [
            Skins.MAG7Memento,
            Skins.M4A4FadedZebra,
            Skins.FAMASDoomkitty
        ];

        private List<Skins> SkinsForbidden =
        [
            Skins.SawedOffOrangeDDPAT,
            Skins.P250Splash,
            Skins.GalilAROrangeDDPAT
        ];

        private List<Skins> SkinsClassified =
        [
            Skins.AWPBOOM,
            Skins.AK47RedLaminate
        ];

        private List<Skins> SkinsSecret =
        [
            Skins.P90DeathByKitty
        ];

        private List<Skins> SkinsRareItem =
        [
            Skins.KarambitFade,
            Skins.KarambitVanilla,
            Skins.KarambitSlaughter,
            Skins.M9BayonetFade,
            Skins.KarambitCaseHardened,
            Skins.M9BayonetVanilla,
            Skins.KarambitCrimsonWeb,
            Skins.M9BayonetSlaughter,
            Skins.KarambitBlueSteel,
            Skins.M9BayonetCrimsonWeb,
            Skins.KarambitNight,
            Skins.KarambitStained,
            Skins.M9BayonetBlueSteel,
            Skins.M9BayonetCaseHardened,
            Skins.KarambitScorched,
            Skins.KarambitUrbanMasked,
            Skins.M9BayonetStained,
            Skins.M9BayonetNight,
            Skins.BayonetFade,
            Skins.KarambitBorealForest,
            Skins.KarambitForestDDPAT,
            Skins.KarambitSafariMesh,
            Skins.FlipKnifeFade,
            Skins.BayonetSlaughter,
            Skins.M9BayonetUrbanMasked,
            Skins.M9BayonetScorched,
            Skins.M9BayonetForestDDPAT,
            Skins.M9BayonetBorealForest,
            Skins.M9BayonetSafariMesh,
            Skins.BayonetCaseHardened,
            Skins.BayonetCrimsonWeb,
            Skins.FlipKnifeSlaughter,
            Skins.BayonetVanilla,
            Skins.FlipKnifeCrimsonWeb,
            Skins.BayonetBlueSteel,
            Skins.FlipKnifeVanilla,
            Skins.GutKnifeCaseHardened,
            Skins.BayonetNight,
            Skins.FlipKnifeCaseHardened,
            Skins.FlipKnifeBlueSteel,
            Skins.BayonetStained,
            Skins.BayonetUrbanMasked,
            Skins.FlipKnifeNight,
            Skins.BayonetScorched,
            Skins.BayonetBorealForest,
            Skins.GutKnifeFade,
            Skins.BayonetForestDDPAT,
            Skins.BayonetSafariMesh,
            Skins.FlipKnifeStained,
            Skins.FlipKnifeUrbanMasked,
            Skins.GutKnifeSlaughter,
            Skins.FlipKnifeScorched,
            Skins.FlipKnifeForestDDPAT,
            Skins.FlipKnifeBorealForest,
            Skins.FlipKnifeSafariMesh,
            Skins.GutKnifeCrimsonWeb,
            Skins.GutKnifeStained,
            Skins.GutKnifeVanilla,
            Skins.GutKnifeBlueSteel,
            Skins.GutKnifeNight,
            Skins.GutKnifeUrbanMasked,
            Skins.GutKnifeScorched,
            Skins.GutKnifeForestDDPAT,
            Skins.GutKnifeBorealForest,
            Skins.GutKnifeSafariMesh
        ];
    }
}
