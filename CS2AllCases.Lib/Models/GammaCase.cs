using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class GammaCase : ICases
    {
        public GammaCase(ProbabilitiesDropOptions? options = null)
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
            [Description("Tec-9 | Ice Cap")]
            Tec9IceCap = 1,
            [Description("SG 553 | Aerial")]
            SG553Aerial = 2,
            [Description("PP-Bizon | Harvester")]
            PPBizonHarvester = 3,
            [Description("P250 | Iron Clad")]
            P250IronClad = 4,
            [Description("Nova | Exo")]
            NovaExo = 5,
            [Description("MAC-10 | Carnivore")]
            MAC10Carnivore = 6,
            [Description("Five-SeveN | Violent Daimyo")]
            FiveSevenViolentDaimyo = 7,
            [Description("Sawed-Off | Limelight")]
            SawedOffLimelight = 8,
            [Description("R8 Revolver | Reboot")]
            R8RevolverReboot = 9,
            [Description("P90 | Chopper")]
            P90Chopper = 10,
            [Description("AWP | Phobos")]
            AWPPhobos = 11,
            [Description("AUG | Aristocrat")]
            AUGAristocrat = 12,
            [Description("SCAR-20 | Bloodsport")]
            SCAR20Bloodsport = 13,
            [Description("P2000 | Imperial Dragon")]
            P2000ImperialDragon = 14,
            [Description("M4A4 | Desolate Space")]
            M4A4DesolateSpace = 15,
            [Description("M4A1-S | Mecha Industries")]
            M4A1SMechaIndustries = 16,
            [Description("Glock-18 | Wasteland Rebel")]
            Glock18WastelandRebel = 17,
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
            Skins.Tec9IceCap,
            Skins.SG553Aerial,
            Skins.PPBizonHarvester,
            Skins.P250IronClad,
            Skins.NovaExo,
            Skins.MAC10Carnivore,
            Skins.FiveSevenViolentDaimyo
        ];

        private List<Skins> SkinsForbidden =
        [
            Skins.SawedOffLimelight,
            Skins.R8RevolverReboot,
            Skins.P90Chopper,
            Skins.AWPPhobos,
            Skins.AUGAristocrat
        ];

        private List<Skins> SkinsClassified =
        [
            Skins.SCAR20Bloodsport,
            Skins.P2000ImperialDragon,
            Skins.M4A4DesolateSpace
        ];

        private List<Skins> SkinsSecret =
        [
            Skins.M4A1SMechaIndustries,
            Skins.Glock18WastelandRebel
        ];

        private List<Skins> SkinsRareItem =
        [
            Skins.KarambitGammaDopplerEmerald,
            Skins.M9BayonetGammaDopplerEmerald,
            Skins.KarambitGammaDopplerPhase2,
            Skins.KarambitGammaDopplerPhase1,
            Skins.KarambitGammaDopplerPhase3,
            Skins.KarambitGammaDopplerPhase4,
            Skins.M9BayonetGammaDopplerPhase2,
            Skins.BayonetGammaDopplerEmerald,
            Skins.FlipKnifeGammaDopplerEmerald,
            Skins.M9BayonetGammaDopplerPhase1,
            Skins.M9BayonetGammaDopplerPhase3,
            Skins.M9BayonetGammaDopplerPhase4,
            Skins.M9BayonetLore,
            Skins.KarambitLore,
            Skins.KarambitAutotronic,
            Skins.M9BayonetAutotronic,
            Skins.KarambitBlackLaminate,
            Skins.BayonetGammaDopplerPhase2,
            Skins.FlipKnifeGammaDopplerPhase2,
            Skins.KarambitFreehand,
            Skins.M9BayonetBlackLaminate,
            Skins.FlipKnifeDopplerPhase2,
            Skins.BayonetGammaDopplerPhase1,
            Skins.BayonetGammaDopplerPhase4,
            Skins.BayonetGammaDopplerPhase3,
            Skins.KarambitBrightWater,
            Skins.FlipKnifeGammaDopplerPhase3,
            Skins.FlipKnifeGammaDopplerPhase4,
            Skins.FlipKnifeGammaDopplerPhase1,
            Skins.M9BayonetBrightWater,
            Skins.M9BayonetFreehand,
            Skins.BayonetAutotronic,
            Skins.BayonetLore,
            Skins.GutKnifeGammaDopplerEmerald,
            Skins.FlipKnifeDopplerPhase4,
            Skins.FlipKnifeDopplerPhase1,
            Skins.FlipKnifeDopplerPhase3,
            Skins.FlipKnifeAutotronic,
            Skins.FlipKnifeLore,
            Skins.BayonetBlackLaminate,
            Skins.BayonetBrightWater,
            Skins.BayonetFreehand,
            Skins.FlipKnifeBlackLaminate,
            Skins.GutKnifeGammaDopplerPhase2,
            Skins.GutKnifeGammaDopplerPhase4,
            Skins.GutKnifeGammaDopplerPhase3,
            Skins.GutKnifeGammaDopplerPhase1,
            Skins.GutKnifeDopplerPhase2,
            Skins.FlipKnifeBrightWater,
            Skins.GutKnifeAutotronic,
            Skins.GutKnifeLore,
            Skins.FlipKnifeFreehand,
            Skins.GutKnifeDopplerPhase3,
            Skins.GutKnifeBlackLaminate,
            Skins.GutKnifeFreehand,
            Skins.GutKnifeBrightWater
        ];
    }
}
