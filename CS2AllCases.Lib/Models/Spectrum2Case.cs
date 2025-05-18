using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class Spectrum2Case : ICases
    {
        public Spectrum2Case(ProbabilitiesDropOptions? options = null)
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
            [Description("Tec-9 | Cracked Opal")]
            Tec9CrackedOpal = 1,
            [Description("SCAR-20 | Jungle Slipstream")]
            SCAR20JungleSlipstream = 2,
            [Description("Sawed-Off | Morris")]
            SawedOffMorris = 3,
            [Description("MAC-10 | Oceanic")]
            MAC10Oceanic = 4,
            [Description("Glock-18 | Off World")]
            Glock18OffWorld = 5,
            [Description("G3SG1 | Hunter")]
            G3SG1Hunter = 6,
            [Description("AUG | Triqua")]
            AUGTriqua = 7,
            [Description("XM1014 | Ziggy")]
            XM1014Ziggy = 8,
            [Description("UMP-45 | Exposure")]
            UMP45Exposure = 9,
            [Description("SG 553 | Phantom")]
            SG553Phantom = 10,
            [Description("MP9 | Goo")]
            MP9Goo = 11,
            [Description("CZ75-Auto | Tacticat")]
            CZ75AutoTacticat = 12,
            [Description("R8 Revolver | Llama Cannon")]
            R8RevolverLlamaCannon = 13,
            [Description("PP-Bizon | High Roller")]
            PPBizonHighRoller = 14,
            [Description("M4A1-S | Leaded Glass")]
            M4A1SLeadedGlass = 15,
            [Description("P250 | See Ya Later")]
            P250SeeYaLater = 16,
            [Description("AK-47 | The Empress")]
            AK47TheEmpress = 17,
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
