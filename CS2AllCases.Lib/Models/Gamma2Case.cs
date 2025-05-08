using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class Gamma2Case : ICases
    {
        public Gamma2Case(ProbabilitiesDropOptions? options = null)
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
            [Description("XM1014 | Slipstream")]
            XM1014Slipstream = 1,
            [Description("UMP-45 | Briefing")]
            UMP45Briefing = 2,
            [Description("P90 | Grim")]
            P90Grim = 3,
            [Description("Negev | Dazzle")]
            NegevDazzle = 4,
            [Description("G3SG1 | Ventilator")]
            G3SG1Ventilator = 5,
            [Description("Five-SeveN | Scumbria")]
            FiveSevenScumbria = 6,
            [Description("CZ75-Auto | Imprint")]
            CZ75AutoImprint = 7,
            [Description("SG 553 | Triarch")]
            SG553Triarch = 8,
            [Description("SCAR-20 | Powercore")]
            SCAR20Powercore = 9,
            [Description("MAG-7 | Petroglyph")]
            MAG7Petroglyph = 10,
            [Description("Glock-18 | Weasel")]
            Glock18Weasel = 11,
            [Description("Desert Eagle | Directive")]
            DesertEagleDirective = 12,
            [Description("Tec-9 | Fuel Injector")]
            Tec9FuelInjector = 13,
            [Description("MP9 | Airlock")]
            MP9Airlock = 14,
            [Description("AUG | Syd Mead")]
            AUGSydMead = 15,
            [Description("FAMAS | Roll Cage")]
            FAMASRollCage = 16,
            [Description("AK-47 | Neon Revolution")]
            AK47NeonRevolution = 17,
            [Description("Karambit | Gamma Doppler Emerald")]
            KarambitGammaDopplerEmerald = 18,
            [Description("M9 Bayonet | Gamma Doppler Emerald")]
            M9BayonetGammaDopplerEmerald = 19,
            [Description("Karambit | Gamma Doppler Phase 2")]
            KarambitGammaDopplerPhase2 = 20,
            [Description("Karambit | Gamma Doppler Phase 1")]
            KarambitGammaDopplerPhase1 = 21,
            [Description("Karambit | Gamma Doppler Phase 3")]
            KarambitGammaDopplerPhase3 = 22,
            [Description("Karambit | Gamma Doppler Phase 4")]
            KarambitGammaDopplerPhase4 = 23,
            [Description("M9 Bayonet | Gamma Doppler Phase 2")]
            M9BayonetGammaDopplerPhase2 = 24,
            [Description("Bayonet | Gamma Doppler Emerald")]
            BayonetGammaDopplerEmerald = 25,
            [Description("Flip Knife | Gamma Doppler Emerald")]
            FlipKnifeGammaDopplerEmerald = 26,
            [Description("M9 Bayonet | Gamma Doppler Phase 1")]
            M9BayonetGammaDopplerPhase1 = 27,
            [Description("M9 Bayonet | Gamma Doppler Phase 3")]
            M9BayonetGammaDopplerPhase3 = 28,
            [Description("M9 Bayonet | Gamma Doppler Phase 4")]
            M9BayonetGammaDopplerPhase4 = 29,
            [Description("M9 Bayonet | Lore")]
            M9BayonetLore = 30,
            [Description("Karambit | Lore")]
            KarambitLore = 31,
            [Description("Karambit | Autotronic")]
            KarambitAutotronic = 32,
            [Description("M9 Bayonet | Autotronic")]
            M9BayonetAutotronic = 33,
            [Description("Karambit | Black Laminate")]
            KarambitBlackLaminate = 34,
            [Description("Bayonet | Gamma Doppler Phase 2")]
            BayonetGammaDopplerPhase2 = 35,
            [Description("Flip Knife | Gamma Doppler Phase 2")]
            FlipKnifeGammaDopplerPhase2 = 36,
            [Description("Karambit | Freehand")]
            KarambitFreehand = 37,
            [Description("M9 Bayonet | Black Laminate")]
            M9BayonetBlackLaminate = 38,
            [Description("Flip Knife | Doppler Phase 2")]
            FlipKnifeDopplerPhase2 = 39,
            [Description("Bayonet | Gamma Doppler Phase 1")]
            BayonetGammaDopplerPhase1 = 40,
            [Description("Bayonet | Gamma Doppler Phase 4")]
            BayonetGammaDopplerPhase4 = 41,
            [Description("Bayonet | Gamma Doppler Phase 3")]
            BayonetGammaDopplerPhase3 = 42,
            [Description("Karambit | Bright Water")]
            KarambitBrightWater = 43,
            [Description("Flip Knife | Gamma Doppler Phase 3")]
            FlipKnifeGammaDopplerPhase3 = 44,
            [Description("Flip Knife | Gamma Doppler Phase 4")]
            FlipKnifeGammaDopplerPhase4 = 45,
            [Description("Flip Knife | Gamma Doppler Phase 1")]
            FlipKnifeGammaDopplerPhase1 = 46,
            [Description("M9 Bayonet | Bright Water")]
            M9BayonetBrightWater = 47,
            [Description("M9 Bayonet | Freehand")]
            M9BayonetFreehand = 48,
            [Description("Bayonet | Autotronic")]
            BayonetAutotronic = 49,
            [Description("Bayonet | Lore")]
            BayonetLore = 50,
            [Description("Gut Knife | Gamma Doppler Emerald")]
            GutKnifeGammaDopplerEmerald = 51,
            [Description("Flip Knife | Doppler Phase 4")]
            FlipKnifeDopplerPhase4 = 52,
            [Description("Flip Knife | Doppler Phase 1")]
            FlipKnifeDopplerPhase1 = 53,
            [Description("Flip Knife | Doppler Phase 3")]
            FlipKnifeDopplerPhase3 = 54,
            [Description("Flip Knife | Autotronic")]
            FlipKnifeAutotronic = 55,
            [Description("Flip Knife | Lore")]
            FlipKnifeLore = 56,
            [Description("Bayonet | Black Laminate")]
            BayonetBlackLaminate = 57,
            [Description("Bayonet | Bright Water")]
            BayonetBrightWater = 58,
            [Description("Bayonet | Freehand")]
            BayonetFreehand = 59,
            [Description("Flip Knife | Black Laminate")]
            FlipKnifeBlackLaminate = 60,
            [Description("Gut Knife | Gamma Doppler Phase 2")]
            GutKnifeGammaDopplerPhase2 = 61,
            [Description("Gut Knife | Gamma Doppler Phase 4")]
            GutKnifeGammaDopplerPhase4 = 62,
            [Description("Gut Knife | Gamma Doppler Phase 3")]
            GutKnifeGammaDopplerPhase3 = 63,
            [Description("Gut Knife | Gamma Doppler Phase 1")]
            GutKnifeGammaDopplerPhase1 = 64,
            [Description("Gut Knife | Doppler Phase 2")]
            GutKnifeDopplerPhase2 = 65,
            [Description("Flip Knife | Bright Water")]
            FlipKnifeBrightWater = 66,
            [Description("Gut Knife | Autotronic")]
            GutKnifeAutotronic = 67,
            [Description("Gut Knife | Lore")]
            GutKnifeLore = 68,
            [Description("Flip Knife | Freehand")]
            FlipKnifeFreehand = 69,
            [Description("Gut Knife | Doppler Phase 3")]
            GutKnifeDopplerPhase3 = 70,
            [Description("Gut Knife | Black Laminate")]
            GutKnifeBlackLaminate = 71,
            [Description("Gut Knife | Freehand")]
            GutKnifeFreehand = 72,
            [Description("Gut Knife | Bright Water")]
            GutKnifeBrightWater = 73
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
