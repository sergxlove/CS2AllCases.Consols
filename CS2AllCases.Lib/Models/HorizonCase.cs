using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class HorizonCase : ICases
    {
        public HorizonCase(ProbabilitiesDropOptions? options = null)
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
            [Description("Tec-9 | Snek-9")]
            Tec9Snek9 = 1,
            [Description("R8 Revolver | Survivalist")]
            R8RevolverSurvivalist = 2,
            [Description("P90 | Traction")]
            P90Traction = 3,
            [Description("MP9 | Capillary")]
            MP9Capillary = 4,
            [Description("Glock-18 | Warhawk")]
            Glock18Warhawk = 5,
            [Description("Dual Berettas | Shred")]
            DualBerettasShred = 6,
            [Description("AUG | Amber Slipstream")]
            AUGAmberSlipstream = 7,
            [Description("Nova | Toy Soldier")]
            NovaToySoldier = 8,
            [Description("MP7 | Powercore")]
            MP7Powercore = 9,
            [Description("G3SG1 | High Seas")]
            G3SG1HighSeas = 10,
            [Description("CZ75-Auto | Eco")]
            CZ75AutoEco = 11,
            [Description("AWP | PAW")]
            AWPPAW = 12,
            [Description("Sawed-Off | Devourer")]
            SawedOffDevourer = 13,
            [Description("M4A1-S | Nightmare")]
            M4A1SNightmare = 14,
            [Description("FAMAS | Eye of Athena")]
            FAMASEyeOfAthena = 15,
            [Description("Desert Eagle | Code Red")]
            DesertEagleCodeRed = 16,
            [Description("AK-47 | Neon Rider")]
            AK47NeonRider = 17,
            [Description("Talon Knife | Fade")]
            TalonKnifeFade = 18,
            [Description("Talon Knife | Slaughter")]
            TalonKnifeSlaughter = 19,
            [Description("Stiletto Knife | Fade")]
            StilettoKnifeFade = 20,
            [Description("Talon Knife | Case Hardened")]
            TalonKnifeCaseHardened = 21,
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
            [Description("Ursus Knife | Fade")]
            UrsusKnifeFade = 27,
            [Description("Stiletto Knife | Crimson Web")]
            StilettoKnifeCrimsonWeb = 28,
            [Description("Talon Knife | Stained")]
            TalonKnifeStained = 29,
            [Description("Stiletto Knife | Blue Steel")]
            StilettoKnifeBlueSteel = 30,
            [Description("Talon Knife | Forest DDPAT")]
            TalonKnifeForestDDPAT = 31,
            [Description("Stiletto Knife | Vanilla")]
            StilettoKnifeVanilla = 32,
            [Description("Talon Knife | Night Stripe")]
            TalonKnifeNightStripe = 33,
            [Description("Talon Knife | Scorched")]
            TalonKnifeScorched = 34,
            [Description("Talon Knife | Urban Masked")]
            TalonKnifeUrbanMasked = 35,
            [Description("Stiletto Knife | Stained")]
            StilettoKnifeStained = 36,
            [Description("Navaja Knife | Crimson Web")]
            NavajaKnifeCrimsonWeb = 37,
            [Description("Talon Knife | Boreal Forest")]
            TalonKnifeBorealForest = 38,
            [Description("Ursus Knife | Slaughter")]
            UrsusKnifeSlaughter = 39,
            [Description("Talon Knife | Safari Mesh")]
            TalonKnifeSafariMesh = 40,
            [Description("Ursus Knife | Crimson Web")]
            UrsusKnifeCrimsonWeb = 41,
            [Description("Ursus Knife | Case Hardened")]
            UrsusKnifeCaseHardened = 42,
            [Description("Stiletto Knife | Scorched")]
            StilettoKnifeScorched = 43,
            [Description("Stiletto Knife | Night Stripe")]
            StilettoKnifeNightStripe = 44,
            [Description("Stiletto Knife | Urban Masked")]
            StilettoKnifeUrbanMasked = 45,
            [Description("Stiletto Knife | Boreal Forest")]
            StilettoKnifeBorealForest = 46,
            [Description("Ursus Knife | Vanilla")]
            UrsusKnifeVanilla = 47,
            [Description("Ursus Knife | Urban Masked")]
            UrsusKnifeUrbanMasked = 48,
            [Description("Ursus Knife | Night Stripe")]
            UrsusKnifeNightStripe = 49,
            [Description("Stiletto Knife | Forest DDPAT")]
            StilettoKnifeForestDDPAT = 50,
            [Description("Stiletto Knife | Safari Mesh")]
            StilettoKnifeSafariMesh = 51,
            [Description("Navaja Knife | Case Hardened")]
            NavajaKnifeCaseHardened = 52,
            [Description("Navaja Knife | Fade")]
            NavajaKnifeFade = 53,
            [Description("Ursus Knife | Stained")]
            UrsusKnifeStained = 54,
            [Description("Ursus Knife | Blue Steel")]
            UrsusKnifeBlueSteel = 55,
            [Description("Ursus Knife | Boreal Forest")]
            UrsusKnifeBorealForest = 56,
            [Description("Navaja Knife | Slaughter")]
            NavajaKnifeSlaughter = 57,
            [Description("Ursus Knife | Scorched")]
            UrsusKnifeScorched = 58,
            [Description("Ursus Knife | Forest DDPAT")]
            UrsusKnifeForestDDPAT = 59,
            [Description("Navaja Knife | Stained")]
            NavajaKnifeStained = 60,
            [Description("Ursus Knife | Safari Mesh")]
            UrsusKnifeSafariMesh = 61,
            [Description("Navaja Knife | Blue Steel")]
            NavajaKnifeBlueSteel = 62,
            [Description("Navaja Knife | Vanilla")]
            NavajaKnifeVanilla = 63,
            [Description("Navaja Knife | Urban Masked")]
            NavajaKnifeUrbanMasked = 64,
            [Description("Navaja Knife | Forest DDPAT")]
            NavajaKnifeForestDDPAT = 65,
            [Description("Navaja Knife | Night Stripe")]
            NavajaKnifeNightStripe = 66,
            [Description("Navaja Knife | Scorched")]
            NavajaKnifeScorched = 67,
            [Description("Navaja Knife | Boreal Forest")]
            NavajaKnifeBorealForest = 68,
            [Description("Navaja Knife | Safari Mesh")]
            NavajaKnifeSafariMesh = 69
        }

        private List<Skins> SkinsArmy =
        [
            Skins.Tec9Snek9,
            Skins.R8RevolverSurvivalist,
            Skins.P90Traction,
            Skins.MP9Capillary,
            Skins.Glock18Warhawk,
            Skins.DualBerettasShred,
            Skins.AUGAmberSlipstream
        ];

        private List<Skins> SkinsForbidden =
        [
            Skins.NovaToySoldier,
            Skins.MP7Powercore,
            Skins.G3SG1HighSeas,
            Skins.CZ75AutoEco,
            Skins.AWPPAW
        ];

        private List<Skins> SkinsClassified =
        [
            Skins.SawedOffDevourer,
            Skins.M4A1SNightmare,
            Skins.FAMASEyeOfAthena
        ];

        private List<Skins> SkinsSecret =
        [
            Skins.DesertEagleCodeRed,
            Skins.AK47NeonRider
        ];

        private List<Skins> SkinsRareItem =
        [
            Skins.TalonKnifeFade,
            Skins.TalonKnifeSlaughter,
            Skins.StilettoKnifeFade,
            Skins.TalonKnifeCaseHardened,
            Skins.TalonKnifeCrimsonWeb,
            Skins.StilettoKnifeSlaughter,
            Skins.TalonKnifeBlueSteel,
            Skins.TalonKnifeVanilla,
            Skins.StilettoKnifeCaseHardened,
            Skins.UrsusKnifeFade,
            Skins.StilettoKnifeCrimsonWeb,
            Skins.TalonKnifeStained,
            Skins.StilettoKnifeBlueSteel,
            Skins.TalonKnifeForestDDPAT,
            Skins.StilettoKnifeVanilla,
            Skins.TalonKnifeNightStripe,
            Skins.TalonKnifeScorched,
            Skins.TalonKnifeUrbanMasked,
            Skins.StilettoKnifeStained,
            Skins.NavajaKnifeCrimsonWeb,
            Skins.TalonKnifeBorealForest,
            Skins.UrsusKnifeSlaughter,
            Skins.TalonKnifeSafariMesh,
            Skins.UrsusKnifeCrimsonWeb,
            Skins.UrsusKnifeCaseHardened,
            Skins.StilettoKnifeScorched,
            Skins.StilettoKnifeNightStripe,
            Skins.StilettoKnifeUrbanMasked,
            Skins.StilettoKnifeBorealForest,
            Skins.UrsusKnifeVanilla,
            Skins.UrsusKnifeUrbanMasked,
            Skins.UrsusKnifeNightStripe,
            Skins.StilettoKnifeForestDDPAT,
            Skins.StilettoKnifeSafariMesh,
            Skins.NavajaKnifeCaseHardened,
            Skins.NavajaKnifeFade,
            Skins.UrsusKnifeStained,
            Skins.UrsusKnifeBlueSteel,
            Skins.UrsusKnifeBorealForest,
            Skins.NavajaKnifeSlaughter,
            Skins.UrsusKnifeScorched,
            Skins.UrsusKnifeForestDDPAT,
            Skins.NavajaKnifeStained,
            Skins.UrsusKnifeSafariMesh,
            Skins.NavajaKnifeBlueSteel,
            Skins.NavajaKnifeVanilla,
            Skins.NavajaKnifeUrbanMasked,
            Skins.NavajaKnifeForestDDPAT,
            Skins.NavajaKnifeNightStripe,
            Skins.NavajaKnifeScorched,
            Skins.NavajaKnifeBorealForest,
            Skins.NavajaKnifeSafariMesh
        ];
    }
}
