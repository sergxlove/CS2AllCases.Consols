using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class DangerZoneCase : ICases
    {
        public DangerZoneCase(ProbabilitiesDropOptions? options = null)
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
            [Description("Tec-9 | Fubar")]
            Tec9Fubar = 1,
            [Description("SG 553 | Danger Close")]
            SG553DangerClose = 2,
            [Description("Sawed-Off | Black Sand")]
            SawedOffBlackSand = 3,
            [Description("Nova | Wood Fired")]
            NovaWoodFired = 4,
            [Description("MP9 | Modest Threat")]
            MP9ModestThreat = 5,
            [Description("M4A4 | Magnesium")]
            M4A4Magnesium = 6,
            [Description("Glock-18 | Oxide Blaze")]
            Glock18OxideBlaze = 7,
            [Description("USP-S | Flashback")]
            USPSFlashback = 8,
            [Description("P250 | Nevermore")]
            P250Nevermore = 9,
            [Description("MAC-10 | Pipe Down")]
            MAC10PipeDown = 10,
            [Description("Galil AR | Signal")]
            GalilARSignal = 11,
            [Description("G3SG1 | Scavenger")]
            G3SG1Scavenger = 12,
            [Description("UMP-45 | Momentum")]
            UMP45Momentum = 13,
            [Description("MP5-SD | Phosphor")]
            MP5SDPhosphor = 14,
            [Description("Desert Eagle | Mecha Industries")]
            DesertEagleMechaIndustries = 15,
            [Description("AWP | Neo-Noir")]
            AWPNeoNoir = 16,
            [Description("AK-47 | Asiimov")]
            AK47Asiimov = 17,
            [Description("Talon Knife | Fade")]
            TalonKnifeFade = 18,
            [Description("Talon Knife | Slaughter")]
            TalonKnifeSlaughter = 19,
            [Description("Talon Knife | Case Hardened")]
            TalonKnifeCaseHardened = 20,
            [Description("Stiletto Knife | Fade")]
            StilettoKnifeFade = 21,
            [Description("Talon Knife | Crimson Web")]
            TalonKnifeCrimsonWeb = 22,
            [Description("Stiletto Knife | Slaughter")]
            StilettoKnifeSlaughter = 23,
            [Description("Talon Knife | Blue Steel")]
            TalonKnifeBlueSteel = 24,
            [Description("Talon Knife | Vanilla")]
            TalonKnifeVanilla = 25,
            [Description("Stiletto Knife | Case Hardened")]
            StilettoKnifeCaseHardened = 26,
            [Description("Stiletto Knife | Crimson Web")]
            StilettoKnifeCrimsonWeb = 27,
            [Description("Talon Knife | Stained")]
            TalonKnifeStained = 28,
            [Description("Ursus Knife | Fade")]
            UrsusKnifeFade = 29,
            [Description("Stiletto Knife | Blue Steel")]
            StilettoKnifeBlueSteel = 30,
            [Description("Talon Knife | Night Stripe")]
            TalonKnifeNightStripe = 31,
            [Description("Stiletto Knife | Vanilla")]
            StilettoKnifeVanilla = 32,
            [Description("Talon Knife | Forest DDPAT")]
            TalonKnifeForestDDPAT = 33,
            [Description("Talon Knife | Scorched")]
            TalonKnifeScorched = 34,
            [Description("Talon Knife | Urban Masked")]
            TalonKnifeUrbanMasked = 35,
            [Description("Stiletto Knife | Stained")]
            StilettoKnifeStained = 36,
            [Description("Navaja Knife | Crimson Web")]
            NavajaKnifeCrimsonWeb = 37,
            [Description("Ursus Knife | Slaughter")]
            UrsusKnifeSlaughter = 38,
            [Description("Talon Knife | Boreal Forest")]
            TalonKnifeBorealForest = 39,
            [Description("Talon Knife | Safari Mesh")]
            TalonKnifeSafariMesh = 40,
            [Description("Ursus Knife | Crimson Web")]
            UrsusKnifeCrimsonWeb = 41,
            [Description("Ursus Knife | Case Hardened")]
            UrsusKnifeCaseHardened = 42,
            [Description("Stiletto Knife | Urban Masked")]
            StilettoKnifeUrbanMasked = 43,
            [Description("Stiletto Knife | Night Stripe")]
            StilettoKnifeNightStripe = 44,
            [Description("Stiletto Knife | Scorched")]
            StilettoKnifeScorched = 45,
            [Description("Stiletto Knife | Boreal Forest")]
            StilettoKnifeBorealForest = 46,
            [Description("Ursus Knife | Blue Steel")]
            UrsusKnifeBlueSteel = 47,
            [Description("Ursus Knife | Urban Masked")]
            UrsusKnifeUrbanMasked = 48,
            [Description("Ursus Knife | Vanilla")]
            UrsusKnifeVanilla = 49,
            [Description("Ursus Knife | Night Stripe")]
            UrsusKnifeNightStripe = 50,
            [Description("Stiletto Knife | Forest DDPAT")]
            StilettoKnifeForestDDPAT = 51,
            [Description("Stiletto Knife | Safari Mesh")]
            StilettoKnifeSafariMesh = 52,
            [Description("Navaja Knife | Case Hardened")]
            NavajaKnifeCaseHardened = 53,
            [Description("Navaja Knife | Fade")]
            NavajaKnifeFade = 54,
            [Description("Ursus Knife | Stained")]
            UrsusKnifeStained = 55,
            [Description("Ursus Knife | Boreal Forest")]
            UrsusKnifeBorealForest = 56,
            [Description("Navaja Knife | Slaughter")]
            NavajaKnifeSlaughter = 57,
            [Description("Ursus Knife | Scorched")]
            UrsusKnifeScorched = 58,
            [Description("Ursus Knife | Forest DDPAT")]
            UrsusKnifeForestDDPAT = 59,
            [Description("Ursus Knife | Safari Mesh")]
            UrsusKnifeSafariMesh = 60,
            [Description("Navaja Knife | Blue Steel")]
            NavajaKnifeBlueSteel = 61,
            [Description("Navaja Knife | Stained")]
            NavajaKnifeStained = 62,
            [Description("Navaja Knife | Vanilla")]
            NavajaKnifeVanilla = 63,
            [Description("Navaja Knife | Urban Masked")]
            NavajaKnifeUrbanMasked = 64,
            [Description("Navaja Knife | Night Stripe")]
            NavajaKnifeNightStripe = 65,
            [Description("Navaja Knife | Scorched")]
            NavajaKnifeScorched = 66,
            [Description("Navaja Knife | Forest DDPAT")]
            NavajaKnifeForestDDPAT = 67,
            [Description("Navaja Knife | Boreal Forest")]
            NavajaKnifeBorealForest = 68,
            [Description("Navaja Knife | Safari Mesh")]
            NavajaKnifeSafariMesh = 69
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
