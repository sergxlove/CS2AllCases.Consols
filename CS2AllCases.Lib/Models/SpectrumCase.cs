using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class SpectrumCase : ICases
    {
        public SpectrumCase(ProbabilitiesDropOptions? options = null)
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
            [Description("P250 | Ripple")]
            P250Ripple = 1,
            [Description("Five-SeveN | Capillary")]
            FiveSevenCapillary = 2,
            [Description("SCAR-20 | Blueprint")]
            SCAR20Blueprint = 3,
            [Description("MP7 | Akoben")]
            MP7Akoben = 4,
            [Description("Desert Eagle | Oxide Blaze")]
            DesertEagleOxideBlaze = 5,
            [Description("Sawed-Off | Zander")]
            SawedOffZander = 6,
            [Description("PP-Bizon | Jungle Slipstream")]
            PPBizonJungleSlipstream = 7,
            [Description("XM1014 | Seasons")]
            XM1014Seasons = 8,
            [Description("M249 | Emerald Poison Dart")]
            M249EmeraldPoisonDart = 9,
            [Description("MAC-10 | Last Dive")]
            MAC10LastDive = 10,
            [Description("Galil AR | Crimson Tsunami")]
            GalilARCrimsonTsunami = 11,
            [Description("UMP-45 | Scaffold")]
            UMP45Scaffold = 12,
            [Description("CZ75-Auto | Xiangliu")]
            CZ75AutoXiangliu = 13,
            [Description("AWP | Fever Dream")]
            AWPFeverDream = 14,
            [Description("USP-S | Neo-Noir")]
            USPSNeoNoir = 15,
            [Description("M4A1-S | Decimator")]
            M4A1SDecimator = 16,
            [Description("AK-47 | Bloodsport")]
            AK47Bloodsport = 17,
            [Description("Butterfly Knife | Doppler Ruby")]
            ButterflyKnifeDopplerRuby = 18,
            [Description("Butterfly Knife | Doppler Sapphire")]
            ButterflyKnifeDopplerSapphire = 19,
            [Description("Butterfly Knife | Doppler Phase 2")]
            ButterflyKnifeDopplerPhase2 = 20,
            [Description("Butterfly Knife | Doppler Black Pearl")]
            ButterflyKnifeDopplerBlackPearl = 21,
            [Description("Butterfly Knife | Doppler Phase 4")]
            ButterflyKnifeDopplerPhase4 = 22,
            [Description("Butterfly Knife | Doppler Phase 1")]
            ButterflyKnifeDopplerPhase1 = 23,
            [Description("Butterfly Knife | Doppler Phase 3")]
            ButterflyKnifeDopplerPhase3 = 24,
            [Description("Butterfly Knife | Marble Fade")]
            ButterflyKnifeMarbleFade = 25,
            [Description("Butterfly Knife | Tiger Tooth")]
            ButterflyKnifeTigerTooth = 26,
            [Description("Huntsman Knife | Doppler Black Pearl")]
            HuntsmanKnifeDopplerBlackPearl = 27,
            [Description("Huntsman Knife | Doppler Ruby")]
            HuntsmanKnifeDopplerRuby = 28,
            [Description("Butterfly Knife | Damascus Steel")]
            ButterflyKnifeDamascusSteel = 29,
            [Description("Bowie Knife | Doppler Ruby")]
            BowieKnifeDopplerRuby = 30,
            [Description("Butterfly Knife | Ultraviolet")]
            ButterflyKnifeUltraviolet = 31,
            [Description("Huntsman Knife | Doppler Sapphire")]
            HuntsmanKnifeDopplerSapphire = 32,
            [Description("Falchion Knife | Doppler Ruby")]
            FalchionKnifeDopplerRuby = 33,
            [Description("Falchion Knife | Doppler Black Pearl")]
            FalchionKnifeDopplerBlackPearl = 34,
            [Description("Butterfly Knife | Rust Coat")]
            ButterflyKnifeRustCoat = 35,
            [Description("Bowie Knife | Doppler Sapphire")]
            BowieKnifeDopplerSapphire = 36,
            [Description("Falchion Knife | Doppler Sapphire")]
            FalchionKnifeDopplerSapphire = 37,
            [Description("Shadow Daggers | Doppler Black Pearl")]
            ShadowDaggersDopplerBlackPearl = 38,
            [Description("Bowie Knife | Doppler Black Pearl")]
            BowieKnifeDopplerBlackPearl = 39,
            [Description("Huntsman Knife | Doppler Phase 2")]
            HuntsmanKnifeDopplerPhase2 = 40,
            [Description("Falchion Knife | Doppler Phase 2")]
            FalchionKnifeDopplerPhase2 = 41,
            [Description("Shadow Daggers | Doppler Ruby")]
            ShadowDaggersDopplerRuby = 42,
            [Description("Huntsman Knife | Doppler Phase 1")]
            HuntsmanKnifeDopplerPhase1 = 43,
            [Description("Huntsman Knife | Doppler Phase 4")]
            HuntsmanKnifeDopplerPhase4 = 44,
            [Description("Bowie Knife | Doppler Phase 2")]
            BowieKnifeDopplerPhase2 = 45,
            [Description("Huntsman Knife | Doppler Phase 3")]
            HuntsmanKnifeDopplerPhase3 = 46,
            [Description("Bowie Knife | Doppler Phase 4")]
            BowieKnifeDopplerPhase4 = 47,
            [Description("Bowie Knife | Doppler Phase 3")]
            BowieKnifeDopplerPhase3 = 48,
            [Description("Falchion Knife | Doppler Phase 1")]
            FalchionKnifeDopplerPhase1 = 49,
            [Description("Falchion Knife | Doppler Phase 4")]
            FalchionKnifeDopplerPhase4 = 50,
            [Description("Bowie Knife | Doppler Phase 1")]
            BowieKnifeDopplerPhase1 = 51,
            [Description("Falchion Knife | Doppler Phase 3")]
            FalchionKnifeDopplerPhase3 = 52,
            [Description("Shadow Daggers | Doppler Sapphire")]
            ShadowDaggersDopplerSapphire = 53,
            [Description("Huntsman Knife | Marble Fade")]
            HuntsmanKnifeMarbleFade = 54,
            [Description("Bowie Knife | Marble Fade")]
            BowieKnifeMarbleFade = 55,
            [Description("Falchion Knife | Marble Fade")]
            FalchionKnifeMarbleFade = 56,
            [Description("Shadow Daggers | Doppler Phase 2")]
            ShadowDaggersDopplerPhase2 = 57,
            [Description("Huntsman Knife | Tiger Tooth")]
            HuntsmanKnifeTigerTooth = 58,
            [Description("Bowie Knife | Ultraviolet")]
            BowieKnifeUltraviolet = 59,
            [Description("Huntsman Knife | Ultraviolet")]
            HuntsmanKnifeUltraviolet = 60,
            [Description("Bowie Knife | Tiger Tooth")]
            BowieKnifeTigerTooth = 61,
            [Description("Falchion Knife | Tiger Tooth")]
            FalchionKnifeTigerTooth = 62,
            [Description("Shadow Daggers | Doppler Phase 4")]
            ShadowDaggersDopplerPhase4 = 63,
            [Description("Shadow Daggers | Doppler Phase 1")]
            ShadowDaggersDopplerPhase1 = 64,
            [Description("Shadow Daggers | Doppler Phase 3")]
            ShadowDaggersDopplerPhase3 = 65,
            [Description("Huntsman Knife | Damascus Steel")]
            HuntsmanKnifeDamascusSteel = 66,
            [Description("Bowie Knife | Damascus Steel")]
            BowieKnifeDamascusSteel = 67,
            [Description("Shadow Daggers | Ultraviolet")]
            ShadowDaggersUltraviolet = 68,
            [Description("Shadow Daggers | Marble Fade")]
            ShadowDaggersMarbleFade = 69,
            [Description("Falchion Knife | Damascus Steel")]
            FalchionKnifeDamascusSteel = 70,
            [Description("Falchion Knife | Ultraviolet")]
            FalchionKnifeUltraviolet = 71,
            [Description("Shadow Daggers | Tiger Tooth")]
            ShadowDaggersTigerTooth = 72,
            [Description("Falchion Knife | Rust Coat")]
            FalchionKnifeRustCoat = 73,
            [Description("Bowie Knife | Rust Coat")]
            BowieKnifeRustCoat = 74,
            [Description("Huntsman Knife | Rust Coat")]
            HuntsmanKnifeRustCoat = 75,
            [Description("Shadow Daggers | Damascus Steel")]
            ShadowDaggersDamascusSteel = 76,
            [Description("Shadow Daggers | Rust Coat")]
            ShadowDaggersRustCoat = 77
        }

        private List<Skins> SkinsArmy =
        [
            Skins.SCAR20Blueprint,
            Skins.SawedOffZander,
            Skins.PPBizonJungleSlipstream,
            Skins.P250Ripple,
            Skins.MP7Akoben,
            Skins.FiveSevenCapillary,
            Skins.DesertEagleOxideBlaze
        ];

        private List<Skins> SkinsForbidden =
        [
            Skins.XM1014Seasons,
            Skins.UMP45Scaffold,
            Skins.MAC10LastDive,
            Skins.M249EmeraldPoisonDart,
            Skins.GalilARCrimsonTsunami
        ];

        private List<Skins> SkinsClassified =
        [
            Skins.M4A1SDecimator,
            Skins.CZ75AutoXiangliu,
            Skins.AWPFeverDream
        ];

        private List<Skins> SkinsSecret =
        [
            Skins.USPSNeoNoir,
            Skins.AK47Bloodsport
        ];

        private List<Skins> SkinsRareItem =
        [
            Skins.ButterflyKnifeDopplerRuby,
            Skins.ButterflyKnifeDopplerSapphire,
            Skins.ButterflyKnifeDopplerPhase2,
            Skins.ButterflyKnifeDopplerBlackPearl,
            Skins.ButterflyKnifeDopplerPhase4,
            Skins.ButterflyKnifeDopplerPhase1,
            Skins.ButterflyKnifeDopplerPhase3,
            Skins.ButterflyKnifeMarbleFade,
            Skins.ButterflyKnifeTigerTooth,
            Skins.HuntsmanKnifeDopplerBlackPearl,
            Skins.HuntsmanKnifeDopplerRuby,
            Skins.ButterflyKnifeDamascusSteel,
            Skins.BowieKnifeDopplerRuby,
            Skins.ButterflyKnifeUltraviolet,
            Skins.HuntsmanKnifeDopplerSapphire,
            Skins.FalchionKnifeDopplerRuby,
            Skins.FalchionKnifeDopplerBlackPearl,
            Skins.ButterflyKnifeRustCoat,
            Skins.BowieKnifeDopplerSapphire,
            Skins.FalchionKnifeDopplerSapphire,
            Skins.ShadowDaggersDopplerBlackPearl,
            Skins.BowieKnifeDopplerBlackPearl,
            Skins.HuntsmanKnifeDopplerPhase2,
            Skins.FalchionKnifeDopplerPhase2,
            Skins.ShadowDaggersDopplerRuby,
            Skins.HuntsmanKnifeDopplerPhase1,
            Skins.HuntsmanKnifeDopplerPhase4,
            Skins.BowieKnifeDopplerPhase2,
            Skins.HuntsmanKnifeDopplerPhase3,
            Skins.BowieKnifeDopplerPhase4,
            Skins.BowieKnifeDopplerPhase3,
            Skins.FalchionKnifeDopplerPhase1,
            Skins.FalchionKnifeDopplerPhase4,
            Skins.BowieKnifeDopplerPhase1,
            Skins.FalchionKnifeDopplerPhase3,
            Skins.ShadowDaggersDopplerSapphire,
            Skins.HuntsmanKnifeMarbleFade,
            Skins.BowieKnifeMarbleFade,
            Skins.FalchionKnifeMarbleFade,
            Skins.ShadowDaggersDopplerPhase2,
            Skins.HuntsmanKnifeTigerTooth,
            Skins.BowieKnifeUltraviolet,
            Skins.HuntsmanKnifeUltraviolet,
            Skins.BowieKnifeTigerTooth,
            Skins.FalchionKnifeTigerTooth,
            Skins.ShadowDaggersDopplerPhase4,
            Skins.ShadowDaggersDopplerPhase1,
            Skins.ShadowDaggersDopplerPhase3,
            Skins.HuntsmanKnifeDamascusSteel,
            Skins.BowieKnifeDamascusSteel,
            Skins.ShadowDaggersUltraviolet,
            Skins.ShadowDaggersMarbleFade,
            Skins.FalchionKnifeDamascusSteel,
            Skins.FalchionKnifeUltraviolet,
            Skins.ShadowDaggersTigerTooth,
            Skins.FalchionKnifeRustCoat,
            Skins.BowieKnifeRustCoat,
            Skins.HuntsmanKnifeRustCoat,
            Skins.ShadowDaggersDamascusSteel,
            Skins.ShadowDaggersRustCoat
        ];
    }
}
