using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class Chroma3Case : ICases
    {
        public Chroma3Case(ProbabilitiesDropOptions? options = null)
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
            [Description("SG 553 | Atlas")]
            SG553Atlas = 1,
            [Description("Sawed-Off | Fubar")]
            SawedOffFubar = 2,
            [Description("P2000 | Oceanic")]
            P2000Oceanic = 3,
            [Description("MP9 | Bioleak")]
            MP9Bioleak = 4,
            [Description("M249 | Spectre")]
            M249Spectre = 5,
            [Description("G3SG1 | Orange Crash")]
            G3SG1OrangeCrash = 6,
            [Description("Dual Berettas | Ventilators")]
            DualBerettasVentilators = 7,
            [Description("XM1014 | Black Tie")]
            XM1014BlackTie = 8,
            [Description("Tec-9 | Re-Entry")]
            Tec9ReEntry = 9,
            [Description("SSG 08 | Ghost Crusader")]
            SSG08GhostCrusader = 10,
            [Description("Galil AR | Firefight")]
            GalilARFirefight = 11,
            [Description("CZ75-Auto | Red Astor")]
            CZ75AutoRedAstor = 12,
            [Description("UMP-45 | Primal Saber")]
            UMP45PrimalSaber = 13,
            [Description("P250 | Asiimov")]
            P250Asiimov = 14,
            [Description("AUG | Fleet Flock")]
            AUGFleetFlock = 15,
            [Description("PP-Bizon | Judgement of Anubis")]
            PPBizonJudgementOfAnubis = 16,
            [Description("M4A1-S | Chantico's Fire")]
            M4A1SChanticosFire = 17,
            [Description("Karambit | Doppler Ruby")]
            KarambitDopplerRuby = 18,
            [Description("M9 Bayonet | Doppler Ruby")]
            M9BayonetDopplerRuby = 19,
            [Description("M9 Bayonet | Doppler Sapphire")]
            M9BayonetDopplerSapphire = 20,
            [Description("Karambit | Doppler Sapphire")]
            KarambitDopplerSapphire = 21,
            [Description("M9 Bayonet | Doppler Black Pearl")]
            M9BayonetDopplerBlackPearl = 22,
            [Description("Karambit | Doppler Phase 2")]
            KarambitDopplerPhase2 = 23,
            [Description("M9 Bayonet | Doppler Phase 2")]
            M9BayonetDopplerPhase2 = 24,
            [Description("Karambit | Doppler Phase 4")]
            KarambitDopplerPhase4 = 25,
            [Description("Bayonet | Doppler Ruby")]
            BayonetDopplerRuby = 26,
            [Description("Flip Knife | Doppler Ruby")]
            FlipKnifeDopplerRuby = 27,
            [Description("Karambit | Doppler Black Pearl")]
            KarambitDopplerBlackPearl = 28,
            [Description("Karambit | Doppler Phase 1")]
            KarambitDopplerPhase1 = 29,
            [Description("Karambit | Doppler Phase 3")]
            KarambitDopplerPhase3 = 30,
            [Description("Bayonet | Doppler Black Pearl")]
            BayonetDopplerBlackPearl = 31,
            [Description("Bayonet | Doppler Sapphire")]
            BayonetDopplerSapphire = 32,
            [Description("M9 Bayonet | Doppler Phase 4")]
            M9BayonetDopplerPhase4 = 33,
            [Description("Flip Knife | Doppler Sapphire")]
            FlipKnifeDopplerSapphire = 34,
            [Description("Karambit | Marble Fade")]
            KarambitMarbleFade = 35,
            [Description("M9 Bayonet | Doppler Phase 1")]
            M9BayonetDopplerPhase1 = 36,
            [Description("M9 Bayonet | Doppler Phase 3")]
            M9BayonetDopplerPhase3 = 37,
            [Description("Flip Knife | Doppler Black Pearl")]
            FlipKnifeDopplerBlackPearl = 38,
            [Description("Karambit | Tiger Tooth")]
            KarambitTigerTooth = 39,
            [Description("M9 Bayonet | Marble Fade")]
            M9BayonetMarbleFade = 40,
            [Description("M9 Bayonet | Tiger Tooth")]
            M9BayonetTigerTooth = 41,
            [Description("Karambit | Damascus Steel")]
            KarambitDamascusSteel = 42,
            [Description("Karambit | Ultraviolet")]
            KarambitUltraviolet = 43,
            [Description("Bayonet | Doppler Phase 2")]
            BayonetDopplerPhase2 = 44,
            [Description("M9 Bayonet | Damascus Steel")]
            M9BayonetDamascusSteel = 45,
            [Description("M9 Bayonet | Ultraviolet")]
            M9BayonetUltraviolet = 46,
            [Description("Bayonet | Doppler Phase 4")]
            BayonetDopplerPhase4 = 47,
            [Description("Bayonet | Doppler Phase 1")]
            BayonetDopplerPhase1 = 48,
            [Description("Bayonet | Doppler Phase 3")]
            BayonetDopplerPhase3 = 49,
            [Description("M9 Bayonet | Rust Coat")]
            M9BayonetRustCoat = 50,
            [Description("Gut Knife | Doppler Ruby")]
            GutKnifeDopplerRuby = 51,
            [Description("Gut Knife | Doppler Black Pearl")]
            GutKnifeDopplerBlackPearl = 52,
            [Description("Bayonet | Marble Fade")]
            BayonetMarbleFade = 53,
            [Description("Bayonet | Ultraviolet")]
            BayonetUltraviolet = 54,
            [Description("Bayonet | Tiger Tooth")]
            BayonetTigerTooth = 55,
            [Description("Gut Knife | Doppler Sapphire")]
            GutKnifeDopplerSapphire = 56,
            [Description("Flip Knife | Marble Fade")]
            FlipKnifeMarbleFade = 57,
            [Description("Flip Knife | Tiger Tooth")]
            FlipKnifeTigerTooth = 58,
            [Description("Flip Knife | Ultraviolet")]
            FlipKnifeUltraviolet = 59,
            [Description("Bayonet | Damascus Steel")]
            BayonetDamascusSteel = 60,
            [Description("Flip Knife | Damascus Steel")]
            FlipKnifeDamascusSteel = 61,
            [Description("Bayonet | Rust Coat")]
            BayonetRustCoat = 62,
            [Description("Gut Knife | Doppler Phase 1")]
            GutKnifeDopplerPhase1 = 63,
            [Description("Gut Knife | Doppler Phase 4")]
            GutKnifeDopplerPhase4 = 64,
            [Description("Gut Knife | Marble Fade")]
            GutKnifeMarbleFade = 65,
            [Description("Flip Knife | Rust Coat")]
            FlipKnifeRustCoat = 66,
            [Description("Gut Knife | Tiger Tooth")]
            GutKnifeTigerTooth = 67,
            [Description("Gut Knife | Damascus Steel")]
            GutKnifeDamascusSteel = 68,
            [Description("Gut Knife | Ultraviolet")]
            GutKnifeUltraviolet = 69,
            [Description("Gut Knife | Rust Coat")]
            GutKnifeRustCoat = 70
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
