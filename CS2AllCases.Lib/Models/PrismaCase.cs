using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class PrismaCase : ICases
    {
        public PrismaCase(ProbabilitiesDropOptions? options = null)
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
            [Description("P90 | Off World")]
            P90OffWorld = 1,
            [Description("P250 | Verdigris")]
            P250Verdigris = 2,
            [Description("MP7 | Mischief")]
            MP7Mischief = 3,
            [Description("MAC-10 | Whitefish")]
            MAC10Whitefish = 4,
            [Description("Galil AR | Akoben")]
            GalilARAkoben = 5,
            [Description("FAMAS | Crypsis")]
            FAMASCrypsis = 6,
            [Description("AK-47 | Uncharted")]
            AK47Uncharted = 7,
            [Description("UMP-45 | Moonrise")]
            UMP45Moonrise = 8,
            [Description("Tec-9 | Bamboozle")]
            Tec9Bamboozle = 9,
            [Description("MP5-SD | Gauss")]
            MP5SDGauss = 10,
            [Description("Desert Eagle | Light Rail")]
            DesertEagleLightRail = 11,
            [Description("AWP | Atheris")]
            AWPAtheris = 12,
            [Description("XM1014 | Incinegator")]
            XM1014Incinegator = 13,
            [Description("R8 Revolver | Skull Crusher")]
            R8RevolverSkullCrusher = 14,
            [Description("AUG | Momentum")]
            AUGMomentum = 15,
            [Description("M4A4 | The Emperor")]
            M4A4TheEmperor = 16,
            [Description("Five-SeveN | Angry Mob")]
            FiveSevenAngryMob = 17,
            [Description("Talon Knife | Doppler Ruby")]
            TalonKnifeDopplerRuby = 18,
            [Description("Talon Knife | Doppler Sapphire")]
            TalonKnifeDopplerSapphire = 19,
            [Description("Stiletto Knife | Doppler Ruby")]
            StilettoKnifeDopplerRuby = 20,
            [Description("Talon Knife | Doppler Black Pearl")]
            TalonKnifeDopplerBlackPearl = 21,
            [Description("Stiletto Knife | Doppler Sapphire")]
            StilettoKnifeDopplerSapphire = 22,
            [Description("Stiletto Knife | Doppler Black Pearl")]
            StilettoKnifeDopplerBlackPearl = 23,
            [Description("Talon Knife | Doppler Phase 2")]
            TalonKnifeDopplerPhase2 = 24,
            [Description("Ursus Knife | Doppler Ruby")]
            UrsusKnifeDopplerRuby = 25,
            [Description("Ursus Knife | Doppler Black Pearl")]
            UrsusKnifeDopplerBlackPearl = 26,
            [Description("Talon Knife | Doppler Phase 4")]
            TalonKnifeDopplerPhase4 = 27,
            [Description("Talon Knife | Doppler Phase 3")]
            TalonKnifeDopplerPhase3 = 28,
            [Description("Ursus Knife | Doppler Sapphire")]
            UrsusKnifeDopplerSapphire = 29,
            [Description("Talon Knife | Doppler Phase 1")]
            TalonKnifeDopplerPhase1 = 30,
            [Description("Stiletto Knife | Doppler Phase 2")]
            StilettoKnifeDopplerPhase2 = 31,
            [Description("Talon Knife | Marble Fade")]
            TalonKnifeMarbleFade = 32,
            [Description("Stiletto Knife | Doppler Phase 1")]
            StilettoKnifeDopplerPhase1 = 33,
            [Description("Stiletto Knife | Doppler Phase 4")]
            StilettoKnifeDopplerPhase4 = 34,
            [Description("Talon Knife | Ultraviolet")]
            TalonKnifeUltraviolet = 35,
            [Description("Stiletto Knife | Doppler Phase 3")]
            StilettoKnifeDopplerPhase3 = 36,
            [Description("Talon Knife | Tiger Tooth")]
            TalonKnifeTigerTooth = 37,
            [Description("Stiletto Knife | Marble Fade")]
            StilettoKnifeMarbleFade = 38,
            [Description("Ursus Knife | Doppler Phase 2")]
            UrsusKnifeDopplerPhase2 = 39,
            [Description("Talon Knife | Damascus Steel")]
            TalonKnifeDamascusSteel = 40,
            [Description("Stiletto Knife | Ultraviolet")]
            StilettoKnifeUltraviolet = 41,
            [Description("Stiletto Knife | Tiger Tooth")]
            StilettoKnifeTigerTooth = 42,
            [Description("Ursus Knife | Doppler Phase 4")]
            UrsusKnifeDopplerPhase4 = 43,
            [Description("Ursus Knife | Doppler Phase 1")]
            UrsusKnifeDopplerPhase1 = 44,
            [Description("Ursus Knife | Doppler Phase 3")]
            UrsusKnifeDopplerPhase3 = 45,
            [Description("Navaja Knife | Doppler Black Pearl")]
            NavajaKnifeDopplerBlackPearl = 46,
            [Description("Navaja Knife | Doppler Ruby")]
            NavajaKnifeDopplerRuby = 47,
            [Description("Talon Knife | Rust Coat")]
            TalonKnifeRustCoat = 48,
            [Description("Ursus Knife | Ultraviolet")]
            UrsusKnifeUltraviolet = 49,
            [Description("Stiletto Knife | Damascus Steel")]
            StilettoKnifeDamascusSteel = 50,
            [Description("Ursus Knife | Marble Fade")]
            UrsusKnifeMarbleFade = 51,
            [Description("Navaja Knife | Doppler Sapphire")]
            NavajaKnifeDopplerSapphire = 52,
            [Description("Ursus Knife | Tiger Tooth")]
            UrsusKnifeTigerTooth = 53,
            [Description("Stiletto Knife | Rust Coat")]
            StilettoKnifeRustCoat = 54,
            [Description("Navaja Knife | Doppler Phase 2")]
            NavajaKnifeDopplerPhase2 = 55,
            [Description("Ursus Knife | Damascus Steel")]
            UrsusKnifeDamascusSteel = 56,
            [Description("Navaja Knife | Doppler Phase 4")]
            NavajaKnifeDopplerPhase4 = 57,
            [Description("Navaja Knife | Doppler Phase 1")]
            NavajaKnifeDopplerPhase1 = 58,
            [Description("Navaja Knife | Doppler Phase 3")]
            NavajaKnifeDopplerPhase3 = 59,
            [Description("Navaja Knife | Marble Fade")]
            NavajaKnifeMarbleFade = 60,
            [Description("Ursus Knife | Rust Coat")]
            UrsusKnifeRustCoat = 61,
            [Description("Navaja Knife | Tiger Tooth")]
            NavajaKnifeTigerTooth = 62,
            [Description("Navaja Knife | Ultraviolet")]
            NavajaKnifeUltraviolet = 63,
            [Description("Navaja Knife | Damascus Steel")]
            NavajaKnifeDamascusSteel = 64,
            [Description("Navaja Knife | Rust Coat")]
            NavajaKnifeRustCoat = 65
        }

        private List<Skins> SkinsArmy =
        [
            Skins.P90OffWorld,
            Skins.P250Verdigris,
            Skins.MP7Mischief,
            Skins.MAC10Whitefish,
            Skins.GalilARAkoben,
            Skins.FAMASCrypsis,
            Skins.AK47Uncharted
        ];

        private List<Skins> SkinsForbidden =
        [
            Skins.UMP45Moonrise,
            Skins.Tec9Bamboozle,
            Skins.MP5SDGauss,
            Skins.DesertEagleLightRail,
            Skins.AWPAtheris
        ];

        private List<Skins> SkinsClassified =
        [
            Skins.XM1014Incinegator,
            Skins.R8RevolverSkullCrusher,
            Skins.AUGMomentum
        ];

        private List<Skins> SkinsSecret =
        [
            Skins.M4A4TheEmperor,
            Skins.FiveSevenAngryMob
        ];

        private List<Skins> SkinsRareItem =
        [
            Skins.TalonKnifeDopplerRuby,
            Skins.TalonKnifeDopplerSapphire,
            Skins.StilettoKnifeDopplerRuby,
            Skins.TalonKnifeDopplerBlackPearl,
            Skins.StilettoKnifeDopplerSapphire,
            Skins.StilettoKnifeDopplerBlackPearl,
            Skins.TalonKnifeDopplerPhase2,
            Skins.UrsusKnifeDopplerRuby,
            Skins.UrsusKnifeDopplerBlackPearl,
            Skins.TalonKnifeDopplerPhase4,
            Skins.TalonKnifeDopplerPhase3,
            Skins.UrsusKnifeDopplerSapphire,
            Skins.TalonKnifeDopplerPhase1,
            Skins.StilettoKnifeDopplerPhase2,
            Skins.TalonKnifeMarbleFade,
            Skins.StilettoKnifeDopplerPhase1,
            Skins.StilettoKnifeDopplerPhase4,
            Skins.TalonKnifeUltraviolet,
            Skins.StilettoKnifeDopplerPhase3,
            Skins.TalonKnifeTigerTooth,
            Skins.StilettoKnifeMarbleFade,
            Skins.UrsusKnifeDopplerPhase2,
            Skins.TalonKnifeDamascusSteel,
            Skins.StilettoKnifeUltraviolet,
            Skins.StilettoKnifeTigerTooth,
            Skins.UrsusKnifeDopplerPhase4,
            Skins.UrsusKnifeDopplerPhase1,
            Skins.UrsusKnifeDopplerPhase3,
            Skins.NavajaKnifeDopplerBlackPearl,
            Skins.NavajaKnifeDopplerRuby,
            Skins.TalonKnifeRustCoat,
            Skins.UrsusKnifeUltraviolet,
            Skins.StilettoKnifeDamascusSteel,
            Skins.UrsusKnifeMarbleFade,
            Skins.NavajaKnifeDopplerSapphire,
            Skins.UrsusKnifeTigerTooth,
            Skins.StilettoKnifeRustCoat,
            Skins.NavajaKnifeDopplerPhase2,
            Skins.UrsusKnifeDamascusSteel,
            Skins.NavajaKnifeDopplerPhase4,
            Skins.NavajaKnifeDopplerPhase1,
            Skins.NavajaKnifeDopplerPhase3,
            Skins.NavajaKnifeMarbleFade,
            Skins.UrsusKnifeRustCoat,
            Skins.NavajaKnifeTigerTooth,
            Skins.NavajaKnifeUltraviolet,
            Skins.NavajaKnifeDamascusSteel,
            Skins.NavajaKnifeRustCoat
        ];
    }
}
