using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class CSGOWeaponCase : ICases
    {
        public CSGOWeaponCase(ProbabilitiesDropOptions? options = null)
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
            [Description("SG 553 | Ultraviolet")]
            SG553Ultraviolet = 1,
            [Description("MP7 | Skulls")]
            MP7Skulls = 2,
            [Description("AUG | Wings")]
            AUGWings = 3,
            [Description("USP-S | Dark Water")]
            USPSDarkWater = 4,
            [Description("M4A1-S | Dark Water")]
            M4A1SDarkWater = 5,
            [Description("Glock-18 | Dragon Tattoo")]
            Glock18DragonTattoo = 6,
            [Description("Desert Eagle | Hypnotic")]
            DesertEagleHypnotic = 7,
            [Description("AK-47 | Case Hardened")]
            AK47CaseHardened = 8,
            [Description("AWP | Lightning Strike")]
            AWPLightningStrike = 9,
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
            [Description("M9 Bayonet | Slaughter")]
            M9BayonetSlaughter = 15,
            [Description("Karambit | Crimson Web")]
            KarambitCrimsonWeb = 16,
            [Description("Karambit | Blue Steel")]
            KarambitBlueSteel = 17,
            [Description("M9 Bayonet | Vanilla")]
            M9BayonetVanilla = 18,
            [Description("M9 Bayonet | Crimson Web")]
            M9BayonetCrimsonWeb = 19,
            [Description("M9 Bayonet | Case Hardened")]
            M9BayonetCaseHardened = 20,
            [Description("Karambit | Night")]
            KarambitNight = 21,
            [Description("Karambit | Stained")]
            KarambitStained = 22,
            [Description("M9 Bayonet | Blue Steel")]
            M9BayonetBlueSteel = 23,
            [Description("Karambit | Scorched")]
            KarambitScorched = 24,
            [Description("Karambit | Urban Masked")]
            KarambitUrbanMasked = 25,
            [Description("M9 Bayonet | Stained")]
            M9BayonetStained = 26,
            [Description("Karambit | Boreal Forest")]
            KarambitBorealForest = 27,
            [Description("M9 Bayonet | Night")]
            M9BayonetNight = 28,
            [Description("Bayonet | Fade")]
            BayonetFade = 29,
            [Description("Karambit | Forest DDPAT")]
            KarambitForestDDPAT = 30,
            [Description("Karambit | Safari Mesh")]
            KarambitSafariMesh = 31,
            [Description("Bayonet | Slaughter")]
            BayonetSlaughter = 32,
            [Description("Flip Knife | Fade")]
            FlipKnifeFade = 33,
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
            [Description("Flip Knife | Case Hardened")]
            FlipKnifeCaseHardened = 45,
            [Description("Flip Knife | Vanilla")]
            FlipKnifeVanilla = 46,
            [Description("Gut Knife | Case Hardened")]
            GutKnifeCaseHardened = 47,
            [Description("Bayonet | Stained")]
            BayonetStained = 48,
            [Description("Flip Knife | Blue Steel")]
            FlipKnifeBlueSteel = 49,
            [Description("Bayonet | Night")]
            BayonetNight = 50,
            [Description("Bayonet | Urban Masked")]
            BayonetUrbanMasked = 51,
            [Description("Flip Knife | Night")]
            FlipKnifeNight = 52,
            [Description("Flip Knife | Stained")]
            FlipKnifeStained = 53,
            [Description("Bayonet | Scorched")]
            BayonetScorched = 54,
            [Description("Gut Knife | Fade")]
            GutKnifeFade = 55,
            [Description("Bayonet | Boreal Forest")]
            BayonetBorealForest = 56,
            [Description("Bayonet | Forest DDPAT")]
            BayonetForestDDPAT = 57,
            [Description("Bayonet | Safari Mesh")]
            BayonetSafariMesh = 58,
            [Description("Gut Knife | Slaughter")]
            GutKnifeSlaughter = 59,
            [Description("Flip Knife | Urban Masked")]
            FlipKnifeUrbanMasked = 60,
            [Description("Flip Knife | Scorched")]
            FlipKnifeScorched = 61,
            [Description("Flip Knife | Boreal Forest")]
            FlipKnifeBorealForest = 62,
            [Description("Flip Knife | Safari Mesh")]
            FlipKnifeSafariMesh = 63,
            [Description("Flip Knife | Forest DDPAT")]
            FlipKnifeForestDDPAT = 64,
            [Description("Gut Knife | Crimson Web")]
            GutKnifeCrimsonWeb = 65,
            [Description("Gut Knife | Vanilla")]
            GutKnifeVanilla = 66,
            [Description("Gut Knife | Blue Steel")]
            GutKnifeBlueSteel = 67,
            [Description("Gut Knife | Stained")]
            GutKnifeStained = 68,
            [Description("Gut Knife | Urban Masked")]
            GutKnifeUrbanMasked = 69,
            [Description("Gut Knife | Night")]
            GutKnifeNight = 70,
            [Description("Gut Knife | Boreal Forest")]
            GutKnifeBorealForest = 71,
            [Description("Gut Knife | Scorched")]
            GutKnifeScorched = 72,
            [Description("Gut Knife | Forest DDPAT")]
            GutKnifeForestDDPAT = 73,
            [Description("Gut Knife | Safari Mesh")]
            GutKnifeSafariMesh = 74
        }

        private List<Skins> SkinsArmy =
        [
            Skins.SG553Ultraviolet,
            Skins.MP7Skulls,
            Skins.AUGWings
        ];

        private List<Skins> SkinsForbidden =
        [
            Skins.USPSDarkWater,
            Skins.M4A1SDarkWater,
            Skins.Glock18DragonTattoo
        ];

        private List<Skins> SkinsClassified =
        [
            Skins.DesertEagleHypnotic,
            Skins.AK47CaseHardened
        ];

        private List<Skins> SkinsSecret =
        [
            Skins.AWPLightningStrike
        ];

        private List<Skins> SkinsRareItem =
        [
            Skins.KarambitFade,
            Skins.KarambitVanilla,
            Skins.KarambitSlaughter,
            Skins.M9BayonetFade,
            Skins.KarambitCaseHardened,
            Skins.M9BayonetSlaughter,
            Skins.KarambitCrimsonWeb,
            Skins.KarambitBlueSteel,
            Skins.M9BayonetVanilla,
            Skins.M9BayonetCrimsonWeb,
            Skins.M9BayonetCaseHardened,
            Skins.KarambitNight,
            Skins.KarambitStained,
            Skins.M9BayonetBlueSteel,
            Skins.KarambitScorched,
            Skins.KarambitUrbanMasked,
            Skins.M9BayonetStained,
            Skins.KarambitBorealForest,
            Skins.M9BayonetNight,
            Skins.BayonetFade,
            Skins.KarambitForestDDPAT,
            Skins.KarambitSafariMesh,
            Skins.BayonetSlaughter,
            Skins.FlipKnifeFade,
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
            Skins.FlipKnifeCaseHardened,
            Skins.FlipKnifeVanilla,
            Skins.GutKnifeCaseHardened,
            Skins.BayonetStained,
            Skins.FlipKnifeBlueSteel,
            Skins.BayonetNight,
            Skins.BayonetUrbanMasked,
            Skins.FlipKnifeNight,
            Skins.FlipKnifeStained,
            Skins.BayonetScorched,
            Skins.GutKnifeFade,
            Skins.BayonetBorealForest,
            Skins.BayonetForestDDPAT,
            Skins.BayonetSafariMesh,
            Skins.GutKnifeSlaughter,
            Skins.FlipKnifeUrbanMasked,
            Skins.FlipKnifeScorched,
            Skins.FlipKnifeBorealForest,
            Skins.FlipKnifeSafariMesh,
            Skins.FlipKnifeForestDDPAT,
            Skins.GutKnifeCrimsonWeb,
            Skins.GutKnifeVanilla,
            Skins.GutKnifeBlueSteel,
            Skins.GutKnifeStained,
            Skins.GutKnifeUrbanMasked,
            Skins.GutKnifeNight,
            Skins.GutKnifeBorealForest,
            Skins.GutKnifeScorched,
            Skins.GutKnifeForestDDPAT,
            Skins.GutKnifeSafariMesh
        ];
    }
}
