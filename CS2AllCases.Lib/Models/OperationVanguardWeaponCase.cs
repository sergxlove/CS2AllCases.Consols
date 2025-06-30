using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class OperationVanguardWeaponCase : ICases
    {
        public OperationVanguardWeaponCase(ProbabilitiesDropOptions? options = null)
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
            [Description("UMP-45 | Delusion")]
            UMP45Delusion = 1,
            [Description("MP9 | Dart")]
            MP9Dart = 2,
            [Description("MAG-7 | Firestarter")]
            MAG7Firestarter = 3,
            [Description("G3SG1 | Murky")]
            G3SG1Murky = 4,
            [Description("Five-SeveN | Urban Hazard")]
            FiveSevenUrbanHazard = 5,
            [Description("Sawed-Off | Highwayman")]
            SawedOffHighwayman = 6,
            [Description("M4A4 | Griffin")]
            M4A4Griffin = 7,
            [Description("M4A1-S | Basilisk")]
            M4A1SBasilisk = 8,
            [Description("Glock-18 | Grinder")]
            Glock18Grinder = 9,
            [Description("XM1014 | Tranquility")]
            XM1014Tranquility = 10,
            [Description("SCAR-20 | Cardiac")]
            SCAR20Cardiac = 11,
            [Description("P250 | Cartel")]
            P250Cartel = 12,
            [Description("P2000 | Fire Elemental")]
            P2000FireElemental = 13,
            [Description("AK-47 | Wasteland Rebel")]
            AK47WastelandRebel = 14,
            [Description("Karambit | Fade")]
            KarambitFade = 15,
            [Description("Karambit | Vanilla")]
            KarambitVanilla = 16,
            [Description("Karambit | Case Hardened")]
            KarambitCaseHardened = 17,
            [Description("Karambit | Slaughter")]
            KarambitSlaughter = 18,
            [Description("Karambit | Crimson Web")]
            KarambitCrimsonWeb = 19,
            [Description("Karambit | Blue Steel")]
            KarambitBlueSteel = 20,
            [Description("Karambit | Night")]
            KarambitNight = 21,
            [Description("Karambit | Stained")]
            KarambitStained = 22,
            [Description("Karambit | Scorched")]
            KarambitScorched = 23,
            [Description("Karambit | Urban Masked")]
            KarambitUrbanMasked = 24,
            [Description("Karambit | Boreal Forest")]
            KarambitBorealForest = 25,
            [Description("Karambit | Forest DDPAT")]
            KarambitForestDDPAT = 26,
            [Description("Karambit | Safari Mesh")]
            KarambitSafariMesh = 27,
            [Description("M9 Bayonet | Fade")]
            M9BayonetFade = 28,
            [Description("M9 Bayonet | Vanilla")]
            M9BayonetVanilla = 29,
            [Description("M9 Bayonet | Slaughter")]
            M9BayonetSlaughter = 30,
            [Description("M9 Bayonet | Crimson Web")]
            M9BayonetCrimsonWeb = 31,
            [Description("M9 Bayonet | Case Hardened")]
            M9BayonetCaseHardened = 32,
            [Description("M9 Bayonet | Blue Steel")]
            M9BayonetBlueSteel = 33,
            [Description("M9 Bayonet | Stained")]
            M9BayonetStained = 34,
            [Description("M9 Bayonet | Scorched")]
            M9BayonetScorched = 35,
            [Description("M9 Bayonet | Urban Masked")]
            M9BayonetUrbanMasked = 36,
            [Description("M9 Bayonet | Night")]
            M9BayonetNight = 37,
            [Description("M9 Bayonet | Forest DDPAT")]
            M9BayonetForestDDPAT = 38,
            [Description("M9 Bayonet | Boreal Forest")]
            M9BayonetBorealForest = 39,
            [Description("M9 Bayonet | Safari Mesh")]
            M9BayonetSafariMesh = 40,
            [Description("Bayonet | Fade")]
            BayonetFade = 41,
            [Description("Bayonet | Slaughter")]
            BayonetSlaughter = 42,
            [Description("Bayonet | Case Hardened")]
            BayonetCaseHardened = 43,
            [Description("Bayonet | Crimson Web")]
            BayonetCrimsonWeb = 44,
            [Description("Bayonet | Vanilla")]
            BayonetVanilla = 45,
            [Description("Bayonet | Blue Steel")]
            BayonetBlueSteel = 46,
            [Description("Bayonet | Stained")]
            BayonetStained = 47,
            [Description("Bayonet | Scorched")]
            BayonetScorched = 48,
            [Description("Bayonet | Urban Masked")]
            BayonetUrbanMasked = 49,
            [Description("Bayonet | Night")]
            BayonetNight = 50,
            [Description("Bayonet | Forest DDPAT")]
            BayonetForestDDPAT = 51,
            [Description("Bayonet | Boreal Forest")]
            BayonetBorealForest = 52,
            [Description("Bayonet | Safari Mesh")]
            BayonetSafariMesh = 53,
            [Description("Flip Knife | Fade")]
            FlipKnifeFade = 54,
            [Description("Flip Knife | Slaughter")]
            FlipKnifeSlaughter = 55,
            [Description("Flip Knife | Crimson Web")]
            FlipKnifeCrimsonWeb = 56,
            [Description("Flip Knife | Case Hardened")]
            FlipKnifeCaseHardened = 57,
            [Description("Flip Knife | Vanilla")]
            FlipKnifeVanilla = 58,
            [Description("Flip Knife | Blue Steel")]
            FlipKnifeBlueSteel = 59,
            [Description("Flip Knife | Stained")]
            FlipKnifeStained = 60,
            [Description("Flip Knife | Scorched")]
            FlipKnifeScorched = 61,
            [Description("Flip Knife | Urban Masked")]
            FlipKnifeUrbanMasked = 62,
            [Description("Flip Knife | Night")]
            FlipKnifeNight = 63,
            [Description("Flip Knife | Forest DDPAT")]
            FlipKnifeForestDDPAT = 64,
            [Description("Flip Knife | Boreal Forest")]
            FlipKnifeBorealForest = 65,
            [Description("Flip Knife | Safari Mesh")]
            FlipKnifeSafariMesh = 66,
            [Description("Gut Knife | Case Hardened")]
            GutKnifeCaseHardened = 67,
            [Description("Gut Knife | Fade")]
            GutKnifeFade = 68,
            [Description("Gut Knife | Slaughter")]
            GutKnifeSlaughter = 69,
            [Description("Gut Knife | Crimson Web")]
            GutKnifeCrimsonWeb = 70,
            [Description("Gut Knife | Vanilla")]
            GutKnifeVanilla = 71,
            [Description("Gut Knife | Stained")]
            GutKnifeStained = 72,
            [Description("Gut Knife | Blue Steel")]
            GutKnifeBlueSteel = 73,
            [Description("Gut Knife | Safari Mesh")]
            GutKnifeSafariMesh = 74,
            [Description("Gut Knife | Forest DDPAT")]
            GutKnifeForestDDPAT = 75,
            [Description("Gut Knife | Urban Masked")]
            GutKnifeUrbanMasked = 76,
            [Description("Gut Knife | Night")]
            GutKnifeNight = 77,
            [Description("Gut Knife | Scorched")]
            GutKnifeScorched = 78,
            [Description("Gut Knife | Boreal Forest")]
            GutKnifeBorealForest = 79
        }

        private List<Skins> SkinsArmy =
        [
            Skins.UMP45Delusion,
            Skins.MP9Dart,
            Skins.MAG7Firestarter,
            Skins.G3SG1Murky,
            Skins.FiveSevenUrbanHazard, 
        ];

        private List<Skins> SkinsForbidden =
        [
            Skins.SawedOffHighwayman,
            Skins.M4A4Griffin,
            Skins.M4A1SBasilisk,
            Skins.Glock18Grinder
        ];

        private List<Skins> SkinsClassified =
        [
            Skins.XM1014Tranquility,
            Skins.SCAR20Cardiac,
            Skins.P250Cartel
        ];

        private List<Skins> SkinsSecret =
        [
            Skins.P2000FireElemental,
            Skins.AK47WastelandRebel
        ];

        private List<Skins> SkinsRareItem =
        [
            Skins.KarambitFade,
            Skins.KarambitVanilla,
            Skins.KarambitCaseHardened,
            Skins.KarambitSlaughter,
            Skins.KarambitCrimsonWeb,
            Skins.KarambitBlueSteel,
            Skins.KarambitNight,
            Skins.KarambitStained,
            Skins.KarambitScorched,
            Skins.KarambitUrbanMasked,
            Skins.KarambitBorealForest,
            Skins.KarambitForestDDPAT,
            Skins.KarambitSafariMesh,
            Skins.M9BayonetFade,
            Skins.M9BayonetVanilla,
            Skins.M9BayonetSlaughter,
            Skins.M9BayonetCrimsonWeb,
            Skins.M9BayonetCaseHardened,
            Skins.M9BayonetBlueSteel,
            Skins.M9BayonetStained,
            Skins.M9BayonetScorched,
            Skins.M9BayonetUrbanMasked,
            Skins.M9BayonetNight,
            Skins.M9BayonetForestDDPAT,
            Skins.M9BayonetBorealForest,
            Skins.M9BayonetSafariMesh,
            Skins.BayonetFade,
            Skins.BayonetSlaughter,
            Skins.BayonetCaseHardened,
            Skins.BayonetCrimsonWeb,
            Skins.BayonetVanilla,
            Skins.BayonetBlueSteel,
            Skins.BayonetStained,
            Skins.BayonetScorched,
            Skins.BayonetUrbanMasked,
            Skins.BayonetNight,
            Skins.BayonetForestDDPAT,
            Skins.BayonetBorealForest,
            Skins.BayonetSafariMesh,
            Skins.FlipKnifeFade,
            Skins.FlipKnifeSlaughter,
            Skins.FlipKnifeCrimsonWeb,
            Skins.FlipKnifeCaseHardened,
            Skins.FlipKnifeVanilla,
            Skins.FlipKnifeBlueSteel,
            Skins.FlipKnifeStained,
            Skins.FlipKnifeScorched,
            Skins.FlipKnifeUrbanMasked,
            Skins.FlipKnifeNight,
            Skins.FlipKnifeForestDDPAT,
            Skins.FlipKnifeBorealForest,
            Skins.FlipKnifeSafariMesh,
            Skins.GutKnifeCaseHardened,
            Skins.GutKnifeFade,
            Skins.GutKnifeSlaughter,
            Skins.GutKnifeCrimsonWeb,
            Skins.GutKnifeVanilla,
            Skins.GutKnifeStained,
            Skins.GutKnifeBlueSteel,
            Skins.GutKnifeSafariMesh,
            Skins.GutKnifeForestDDPAT,
            Skins.GutKnifeUrbanMasked,
            Skins.GutKnifeNight,
            Skins.GutKnifeScorched,
            Skins.GutKnifeBorealForest
        ];
    }
}
