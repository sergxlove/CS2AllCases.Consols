using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class Chroma2Case : ICases
    {
        public Chroma2Case(ProbabilitiesDropOptions? options = null)
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
            [Description("Negev | Man-o'-war")]
            NegevManOWar = 1,
            [Description("MP7 | Armor Core")]
            MP7ArmorCore = 2,
            [Description("Sawed-Off | Origami")]
            SawedOffOrigami = 3,
            [Description("AK-47 | Elite Build")]
            AK47EliteBuild = 4,
            [Description("Desert Eagle | Bronze Deco")]
            DesertEagleBronzeDeco = 5,
            [Description("P250 | Valence")]
            P250Valence = 6,
            [Description("UMP-45 | Grand Prix")]
            UMP45GrandPrix = 7,
            [Description("CZ75-Auto | Pole Position")]
            CZ75AutoPolePosition = 8,
            [Description("AWP | Worm God")]
            AWPWormGod = 9,
            [Description("MAG-7 | Heat")]
            MAG7Heat = 10,
            [Description("Five-SeveN | Monkey Business")]
            FiveSevenMonkeyBusiness = 11,
            [Description("FAMAS | Djinn")]
            FAMASDjinn = 12,
            [Description("Galil AR | Eco")]
            GalilAREco = 13,
            [Description("MAC-10 | Neon Rider")]
            MAC10NeonRider = 14,
            [Description("M4A1-S | Hyper Beast")]
            M4A1SHyperBeast = 15,
            [Description("Karambit | Doppler Ruby")]
            KarambitDopplerRuby = 16,
            [Description("M9 Bayonet | Doppler Ruby")]
            M9BayonetDopplerRuby = 17,
            [Description("M9 Bayonet | Doppler Sapphire")]
            M9BayonetDopplerSapphire = 18,
            [Description("Karambit | Doppler Sapphire")]
            KarambitDopplerSapphire = 19,
            [Description("M9 Bayonet | Doppler Black Pearl")]
            M9BayonetDopplerBlackPearl = 20,
            [Description("Karambit | Doppler Phase 2")]
            KarambitDopplerPhase2 = 21,
            [Description("M9 Bayonet | Doppler Phase 2")]
            M9BayonetDopplerPhase2 = 22,
            [Description("Karambit | Doppler Phase 4")]
            KarambitDopplerPhase4 = 23,
            [Description("Bayonet | Doppler Ruby")]
            BayonetDopplerRuby = 24,
            [Description("Flip Knife | Doppler Ruby")]
            FlipKnifeDopplerRuby = 25,
            [Description("Karambit | Doppler Black Pearl")]
            KarambitDopplerBlackPearl = 26,
            [Description("Karambit | Doppler Phase 1")]
            KarambitDopplerPhase1 = 27,
            [Description("Karambit | Doppler Phase 3")]
            KarambitDopplerPhase3 = 28,
            [Description("Bayonet | Doppler Black Pearl")]
            BayonetDopplerBlackPearl = 29,
            [Description("Bayonet | Doppler Sapphire")]
            BayonetDopplerSapphire = 30,
            [Description("M9 Bayonet | Doppler Phase 4")]
            M9BayonetDopplerPhase4 = 31,
            [Description("Flip Knife | Doppler Sapphire")]
            FlipKnifeDopplerSapphire = 32,
            [Description("Karambit | Marble Fade")]
            KarambitMarbleFade = 33,
            [Description("M9 Bayonet | Doppler Phase 1")]
            M9BayonetDopplerPhase1 = 34,
            [Description("M9 Bayonet | Doppler Phase 3")]
            M9BayonetDopplerPhase3 = 35,
            [Description("Flip Knife | Doppler Black Pearl")]
            FlipKnifeDopplerBlackPearl = 36,
            [Description("Karambit | Tiger Tooth")]
            KarambitTigerTooth = 37,
            [Description("M9 Bayonet | Marble Fade")]
            M9BayonetMarbleFade = 38,
            [Description("M9 Bayonet | Tiger Tooth")]
            M9BayonetTigerTooth = 39,
            [Description("Karambit | Damascus Steel")]
            KarambitDamascusSteel = 40,
            [Description("Karambit | Ultraviolet")]
            KarambitUltraviolet = 41,
            [Description("Bayonet | Doppler Phase 2")]
            BayonetDopplerPhase2 = 42,
            [Description("M9 Bayonet | Damascus Steel")]
            M9BayonetDamascusSteel = 43,
            [Description("M9 Bayonet | Ultraviolet")]
            M9BayonetUltraviolet = 44,
            [Description("Bayonet | Doppler Phase 4")]
            BayonetDopplerPhase4 = 45,
            [Description("Bayonet | Doppler Phase 1")]
            BayonetDopplerPhase1 = 46,
            [Description("Bayonet | Doppler Phase 3")]
            BayonetDopplerPhase3 = 47,
            [Description("M9 Bayonet | Rust Coat")]
            M9BayonetRustCoat = 48,
            [Description("Gut Knife | Doppler Ruby")]
            GutKnifeDopplerRuby = 49,
            [Description("Gut Knife | Doppler Black Pearl")]
            GutKnifeDopplerBlackPearl = 50,
            [Description("Bayonet | Marble Fade")]
            BayonetMarbleFade = 51,
            [Description("Bayonet | Ultraviolet")]
            BayonetUltraviolet = 52,
            [Description("Bayonet | Tiger Tooth")]
            BayonetTigerTooth = 53,
            [Description("Gut Knife | Doppler Sapphire")]
            GutKnifeDopplerSapphire = 54,
            [Description("Flip Knife | Marble Fade")]
            FlipKnifeMarbleFade = 55,
            [Description("Flip Knife | Tiger Tooth")]
            FlipKnifeTigerTooth = 56,
            [Description("Flip Knife | Ultraviolet")]
            FlipKnifeUltraviolet = 57,
            [Description("Bayonet | Damascus Steel")]
            BayonetDamascusSteel = 58,
            [Description("Flip Knife | Damascus Steel")]
            FlipKnifeDamascusSteel = 59,
            [Description("Bayonet | Rust Coat")]
            BayonetRustCoat = 60,
            [Description("Gut Knife | Doppler Phase 1")]
            GutKnifeDopplerPhase1 = 61,
            [Description("Gut Knife | Doppler Phase 4")]
            GutKnifeDopplerPhase4 = 62,
            [Description("Gut Knife | Marble Fade")]
            GutKnifeMarbleFade = 63,
            [Description("Flip Knife | Rust Coat")]
            FlipKnifeRustCoat = 64,
            [Description("Gut Knife | Tiger Tooth")]
            GutKnifeTigerTooth = 65,
            [Description("Gut Knife | Damascus Steel")]
            GutKnifeDamascusSteel = 66,
            [Description("Gut Knife | Ultraviolet")]
            GutKnifeUltraviolet = 67,
            [Description("Gut Knife | Rust Coat")]
            GutKnifeRustCoat = 68
        }

        private List<Skins> SkinsArmy =
        [
            Skins.NegevManOWar,
            Skins.SawedOffOrigami,
            Skins.MP7ArmorCore,
            Skins.DesertEagleBronzeDeco,
            Skins.P250Valence,
            Skins.AK47EliteBuild
        ];

        private List<Skins> SkinsForbidden =
        [
            Skins.UMP45GrandPrix,
            Skins.CZ75AutoPolePosition,
            Skins.AWPWormGod,
            Skins.MAG7Heat
        ];

        private List<Skins> SkinsClassified =
        [
            Skins.FAMASDjinn,
            Skins.FiveSevenMonkeyBusiness,
            Skins.GalilAREco
        ];

        private List<Skins> SkinsSecret =
        [
            Skins.MAC10NeonRider,
            Skins.M4A1SHyperBeast
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
