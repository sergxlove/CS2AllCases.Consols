using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class ChromaCase : ICases
    {
        public ChromaCase(ProbabilitiesDropOptions? options = null)
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
            [Description("XM1014 | Quicksilver")]
            XM1014Quicksilver = 1,
            [Description("SCAR-20 | Grotto")]
            SCAR20Grotto = 2,
            [Description("MP9 | Deadly Poison")]
            MP9DeadlyPoison = 3,
            [Description("M249 | System Lock")]
            M249SystemLock = 4,
            [Description("Glock-18 | Catacombs")]
            Glock18Catacombs = 5,
            [Description("Sawed-Off | Serenity")]
            SawedOffSerenity = 6,
            [Description("MAC-10 | Malachite")]
            MAC10Malachite = 7,
            [Description("Dual Berettas | Urban Shock")]
            DualBerettasUrbanShock = 8,
            [Description("Desert Eagle | Naga")]
            DesertEagleNaga = 9,
            [Description("P250 | Muertos")]
            P250Muertos = 10,
            [Description("M4A4 | Dragon King")]
            M4A4DragonKing = 11,
            [Description("AK-47 | Cartel")]
            AK47Cartel = 12,
            [Description("Galil AR | Chatterbox")]
            GalilARChatterbox = 13,
            [Description("AWP | Man-o'-war")]
            AWPManoWar = 14,
            [Description("Karambit | Doppler Ruby")]
            KarambitDopplerRuby = 15,
            [Description("M9 Bayonet | Doppler Ruby")]
            M9BayonetDopplerRuby = 16,
            [Description("M9 Bayonet | Doppler Sapphire")]
            M9BayonetDopplerSapphire = 17,
            [Description("Karambit | Doppler Sapphire")]
            KarambitDopplerSapphire = 18,
            [Description("M9 Bayonet | Doppler Black Pearl")]
            M9BayonetDopplerBlackPearl = 19,
            [Description("Karambit | Doppler Phase 2")]
            KarambitDopplerPhase2 = 20,
            [Description("M9 Bayonet | Doppler Phase 2")]
            M9BayonetDopplerPhase2 = 21,
            [Description("Karambit | Doppler Phase 4")]
            KarambitDopplerPhase4 = 22,
            [Description("Bayonet | Doppler Ruby")]
            BayonetDopplerRuby = 23,
            [Description("Flip Knife | Doppler Ruby")]
            FlipKnifeDopplerRuby = 24,
            [Description("Karambit | Doppler Black Pearl")]
            KarambitDopplerBlackPearl = 25,
            [Description("Karambit | Doppler Phase 1")]
            KarambitDopplerPhase1 = 26,
            [Description("Karambit | Doppler Phase 3")]
            KarambitDopplerPhase3 = 27,
            [Description("Bayonet | Doppler Black Pearl")]
            BayonetDopplerBlackPearl = 28,
            [Description("Bayonet | Doppler Sapphire")]
            BayonetDopplerSapphire = 29,
            [Description("M9 Bayonet | Doppler Phase 4")]
            M9BayonetDopplerPhase4 = 30,
            [Description("Flip Knife | Doppler Sapphire")]
            FlipKnifeDopplerSapphire = 31,
            [Description("Karambit | Marble Fade")]
            KarambitMarbleFade = 32,
            [Description("M9 Bayonet | Doppler Phase 1")]
            M9BayonetDopplerPhase1 = 33,
            [Description("M9 Bayonet | Doppler Phase 3")]
            M9BayonetDopplerPhase3 = 34,
            [Description("Flip Knife | Doppler Black Pearl")]
            FlipKnifeDopplerBlackPearl = 35,
            [Description("Karambit | Tiger Tooth")]
            KarambitTigerTooth = 36,
            [Description("M9 Bayonet | Marble Fade")]
            M9BayonetMarbleFade = 37,
            [Description("M9 Bayonet | Tiger Tooth")]
            M9BayonetTigerTooth = 38,
            [Description("Karambit | Damascus Steel")]
            KarambitDamascusSteel = 39,
            [Description("Karambit | Ultraviolet")]
            KarambitUltraviolet = 40,
            [Description("Bayonet | Doppler Phase 2")]
            BayonetDopplerPhase2 = 41,
            [Description("M9 Bayonet | Damascus Steel")]
            M9BayonetDamascusSteel = 42,
            [Description("M9 Bayonet | Ultraviolet")]
            M9BayonetUltraviolet = 43,
            [Description("Bayonet | Doppler Phase 4")]
            BayonetDopplerPhase4 = 44,
            [Description("Bayonet | Doppler Phase 1")]
            BayonetDopplerPhase1 = 45,
            [Description("Bayonet | Doppler Phase 3")]
            BayonetDopplerPhase3 = 46,
            [Description("M9 Bayonet | Rust Coat")]
            M9BayonetRustCoat = 47,
            [Description("Gut Knife | Doppler Ruby")]
            GutKnifeDopplerRuby = 48,
            [Description("Gut Knife | Doppler Black Pearl")]
            GutKnifeDopplerBlackPearl = 49,
            [Description("Bayonet | Marble Fade")]
            BayonetMarbleFade = 50,
            [Description("Bayonet | Ultraviolet")]
            BayonetUltraviolet = 51,
            [Description("Bayonet | Tiger Tooth")]
            BayonetTigerTooth = 52,
            [Description("Gut Knife | Doppler Sapphire")]
            GutKnifeDopplerSapphire = 53,
            [Description("Flip Knife | Marble Fade")]
            FlipKnifeMarbleFade = 54,
            [Description("Flip Knife | Tiger Tooth")]
            FlipKnifeTigerTooth = 55,
            [Description("Flip Knife | Ultraviolet")]
            FlipKnifeUltraviolet = 56,
            [Description("Bayonet | Damascus Steel")]
            BayonetDamascusSteel = 57,
            [Description("Flip Knife | Damascus Steel")]
            FlipKnifeDamascusSteel = 58,
            [Description("Bayonet | Rust Coat")]
            BayonetRustCoat = 59,
            [Description("Gut Knife | Doppler Phase 1")]
            GutKnifeDopplerPhase1 = 60,
            [Description("Gut Knife | Doppler Phase 4")]
            GutKnifeDopplerPhase4 = 61,
            [Description("Gut Knife | Marble Fade")]
            GutKnifeMarbleFade = 62,
            [Description("Flip Knife | Rust Coat")]
            FlipKnifeRustCoat = 63,
            [Description("Gut Knife | Tiger Tooth")]
            GutKnifeTigerTooth = 64,
            [Description("Gut Knife | Damascus Steel")]
            GutKnifeDamascusSteel = 65,
            [Description("Gut Knife | Ultraviolet")]
            GutKnifeUltraviolet = 66,
            [Description("Gut Knife | Rust Coat")]
            GutKnifeRustCoat = 67
        }

        private List<Skins> SkinsArmy =
        [
            Skins.XM1014Quicksilver,
            Skins.SCAR20Grotto,
            Skins.MP9DeadlyPoison,
            Skins.M249SystemLock,
            Skins.Glock18Catacombs
        ];

        private List<Skins> SkinsForbidden =
        [
            Skins.SawedOffSerenity,
            Skins.MAC10Malachite,
            Skins.DualBerettasUrbanShock, 
            Skins.DesertEagleNaga
        ];

        private List<Skins> SkinsClassified =
        [
            Skins.P250Muertos,
            Skins.M4A4DragonKing,
            Skins.AK47Cartel
        ];

        private List<Skins> SkinsSecret =
        [
            Skins.GalilARChatterbox,
            Skins.AWPManoWar
        ];

        private List<Skins> SkinsRareItem =
        [
            Skins.KarambitDopplerRuby,
            Skins.M9BayonetDopplerRuby,
            Skins.M9BayonetDopplerSapphire,
            Skins.KarambitDopplerSapphire,
            Skins.M9BayonetDopplerBlackPearl,
            Skins.KarambitDopplerPhase2,
            Skins.M9BayonetDopplerPhase2,
            Skins.KarambitDopplerPhase4,
            Skins.BayonetDopplerRuby,
            Skins.FlipKnifeDopplerRuby,
            Skins.KarambitDopplerBlackPearl,
            Skins.KarambitDopplerPhase1,
            Skins.KarambitDopplerPhase3,
            Skins.BayonetDopplerBlackPearl,
            Skins.BayonetDopplerSapphire,
            Skins.M9BayonetDopplerPhase4,
            Skins.FlipKnifeDopplerSapphire,
            Skins.KarambitMarbleFade,
            Skins.M9BayonetDopplerPhase1,
            Skins.M9BayonetDopplerPhase3,
            Skins.FlipKnifeDopplerBlackPearl,
            Skins.KarambitTigerTooth,
            Skins.M9BayonetMarbleFade,
            Skins.M9BayonetTigerTooth,
            Skins.KarambitDamascusSteel,
            Skins.KarambitUltraviolet,
            Skins.BayonetDopplerPhase2,
            Skins.M9BayonetDamascusSteel,
            Skins.M9BayonetUltraviolet,
            Skins.BayonetDopplerPhase4,
            Skins.BayonetDopplerPhase1,
            Skins.BayonetDopplerPhase3,
            Skins.M9BayonetRustCoat,
            Skins.GutKnifeDopplerRuby,
            Skins.GutKnifeDopplerBlackPearl,
            Skins.BayonetMarbleFade,
            Skins.BayonetUltraviolet,
            Skins.BayonetTigerTooth,
            Skins.GutKnifeDopplerSapphire,
            Skins.FlipKnifeMarbleFade,
            Skins.FlipKnifeTigerTooth,
            Skins.FlipKnifeUltraviolet,
            Skins.BayonetDamascusSteel,
            Skins.FlipKnifeDamascusSteel,
            Skins.BayonetRustCoat,
            Skins.GutKnifeDopplerPhase1,
            Skins.GutKnifeDopplerPhase4,
            Skins.GutKnifeMarbleFade,
            Skins.FlipKnifeRustCoat,
            Skins.GutKnifeTigerTooth,
            Skins.GutKnifeDamascusSteel,
            Skins.GutKnifeUltraviolet,
            Skins.GutKnifeRustCoat
        ];
    }
}
