using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class OperationRiptideCase : ICases
    {
        public OperationRiptideCase(ProbabilitiesDropOptions? options = null)
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
            [Description("G3SG1 | Keeping Tabs")]
            G3SG1KeepingTabs = 1,
            [Description("MP7 | Guerrilla")]
            MP7Guerrilla = 2,
            [Description("AUG | Plague")]
            AUGPlague = 3,
            [Description("PP-Bizon | Lumen")]
            PPBizonLumen = 4,
            [Description("Dual Berettas | Tread")]
            DualBerettasTread = 5,
            [Description("USP-S | Black Lotus")]
            USPSBlackLotus = 6,
            [Description("MAG-7 | BI83 Spectrum")]
            MAG7BI83Spectrum = 7,
            [Description("XM1014 | Watchdog")]
            XM1014Watchdog = 8,
            [Description("Five-SeveN | Boost Protocol")]
            FiveSevenBoostProtocol = 9,
            [Description("FAMAS | ZX Spectron")]
            FAMASZXSpectron = 10,
            [Description("MP9 | Mount Fuji")]
            MP9MountFuji = 11,
            [Description("MAC-10 | Toybox")]
            MAC10Toybox = 12,
            [Description("M4A4 | Spider Lily")]
            M4A4SpiderLily = 13,
            [Description("SSG 08 | Turbo Peek")]
            SSG08TurboPeek = 14,
            [Description("Glock-18 | Snack Attack")]
            Glock18SnackAttack = 15,
            [Description("Desert Eagle | Ocean Drive")]
            DesertEagleOceanDrive = 16,
            [Description("AK-47 | Leet Museo")]
            AK47LeetMuseo = 17,
            [Description("Butterfly Knife | Gamma Doppler Emerald")]
            ButterflyKnifeGammaDopplerEmerald = 18,
            [Description("Butterfly Knife | Gamma Doppler Phase 2")]
            ButterflyKnifeGammaDopplerPhase2 = 19,
            [Description("Butterfly Knife | Gamma Doppler Phase 3")]
            ButterflyKnifeGammaDopplerPhase3 = 20,
            [Description("Butterfly Knife | Gamma Doppler Phase 1")]
            ButterflyKnifeGammaDopplerPhase1 = 21,
            [Description("Butterfly Knife | Gamma Doppler Phase 4")]
            ButterflyKnifeGammaDopplerPhase4 = 22,
            [Description("Butterfly Knife | Lore")]
            ButterflyKnifeLore = 23,
            [Description("Butterfly Knife | Autotronic")]
            ButterflyKnifeAutotronic = 24,
            [Description("Butterfly Knife | Black Laminate")]
            ButterflyKnifeBlackLaminate = 25,
            [Description("Butterfly Knife | Freehand")]
            ButterflyKnifeFreehand = 26,
            [Description("Huntsman Knife | Gamma Doppler Emerald")]
            HuntsmanKnifeGammaDopplerEmerald = 27,
            [Description("Butterfly Knife | Bright Water")]
            ButterflyKnifeBrightWater = 28,
            [Description("Bowie Knife | Gamma Doppler Emerald")]
            BowieKnifeGammaDopplerEmerald = 29,
            [Description("Falchion Knife | Gamma Doppler Emerald")]
            FalchionKnifeGammaDopplerEmerald = 30,
            [Description("Huntsman Knife | Gamma Doppler Phase 2")]
            HuntsmanKnifeGammaDopplerPhase2 = 31,
            [Description("Falchion Knife | Gamma Doppler Phase 2")]
            FalchionKnifeGammaDopplerPhase2 = 32,
            [Description("Huntsman Knife | Gamma Doppler Phase 1")]
            HuntsmanKnifeGammaDopplerPhase1 = 33,
            [Description("Huntsman Knife | Gamma Doppler Phase 4")]
            HuntsmanKnifeGammaDopplerPhase4 = 34,
            [Description("Huntsman Knife | Gamma Doppler Phase 3")]
            HuntsmanKnifeGammaDopplerPhase3 = 35,
            [Description("Shadow Daggers | Gamma Doppler Emerald")]
            ShadowDaggersGammaDopplerEmerald = 36,
            [Description("Falchion Knife | Gamma Doppler Phase 1")]
            FalchionKnifeGammaDopplerPhase1 = 37,
            [Description("Falchion Knife | Gamma Doppler Phase 4")]
            FalchionKnifeGammaDopplerPhase4 = 38,
            [Description("Falchion Knife | Gamma Doppler Phase 3")]
            FalchionKnifeGammaDopplerPhase3 = 39,
            [Description("Bowie Knife | Gamma Doppler Phase 2")]
            BowieKnifeGammaDopplerPhase2 = 40,
            [Description("Bowie Knife | Gamma Doppler Phase 1")]
            BowieKnifeGammaDopplerPhase1 = 41,
            [Description("Bowie Knife | Gamma Doppler Phase 4")]
            BowieKnifeGammaDopplerPhase4 = 42,
            [Description("Bowie Knife | Gamma Doppler Phase 3")]
            BowieKnifeGammaDopplerPhase3 = 43,
            [Description("Bowie Knife | Lore")]
            BowieKnifeLore = 44,
            [Description("Huntsman Knife | Autotronic")]
            HuntsmanKnifeAutotronic = 45,
            [Description("Falchion Knife | Autotronic")]
            FalchionKnifeAutotronic = 46,
            [Description("Huntsman Knife | Lore")]
            HuntsmanKnifeLore = 47,
            [Description("Falchion Knife | Lore")]
            FalchionKnifeLore = 48,
            [Description("Bowie Knife | Autotronic")]
            BowieKnifeAutotronic = 49,
            [Description("Shadow Daggers | Gamma Doppler Phase 4")]
            ShadowDaggersGammaDopplerPhase4 = 50,
            [Description("Shadow Daggers | Lore")]
            ShadowDaggersLore = 51,
            [Description("Huntsman Knife | Black Laminate")]
            HuntsmanKnifeBlackLaminate = 52,
            [Description("Shadow Daggers | Gamma Doppler Phase 3")]
            ShadowDaggersGammaDopplerPhase3 = 53,
            [Description("Shadow Daggers | Gamma Doppler Phase 1")]
            ShadowDaggersGammaDopplerPhase1 = 54,
            [Description("Falchion Knife | Freehand")]
            FalchionKnifeFreehand = 55,
            [Description("Shadow Daggers | Gamma Doppler Phase 2")]
            ShadowDaggersGammaDopplerPhase2 = 56,
            [Description("Bowie Knife | Freehand")]
            BowieKnifeFreehand = 57,
            [Description("Huntsman Knife | Freehand")]
            HuntsmanKnifeFreehand = 58,
            [Description("Bowie Knife | Black Laminate")]
            BowieKnifeBlackLaminate = 59,
            [Description("Falchion Knife | Bright Water")]
            FalchionKnifeBrightWater = 60,
            [Description("Huntsman Knife | Bright Water")]
            HuntsmanKnifeBrightWater = 61,
            [Description("Falchion Knife | Black Laminate")]
            FalchionKnifeBlackLaminate = 62,
            [Description("Bowie Knife | Bright Water")]
            BowieKnifeBrightWater = 63,
            [Description("Shadow Daggers | Autotronic")]
            ShadowDaggersAutotronic = 64,
            [Description("Shadow Daggers | Freehand")]
            ShadowDaggersFreehand = 65,
            [Description("Shadow Daggers | Black Laminate")]
            ShadowDaggersBlackLaminate = 66,
            [Description("Shadow Daggers | Bright Water")]
            ShadowDaggersBrightWater = 67
        }

        private List<Skins> SkinsArmy =
        [
            Skins.XM1014Watchdog,
            Skins.USPSBlackLotus,
            Skins.PPBizonLumen,
            Skins.MP7Guerrilla,
            Skins.G3SG1KeepingTabs,
            Skins.DualBerettasTread,
            Skins.AUGPlague
        ];

        private List<Skins> SkinsForbidden =
        [
            Skins.MP9MountFuji,
            Skins.MAG7BI83Spectrum,
            Skins.M4A4SpiderLily,
            Skins.FiveSevenBoostProtocol,
            Skins.FAMASZXSpectron,
        ];

        private List<Skins> SkinsClassified =
        [
            Skins.SSG08TurboPeek,
            Skins.MAC10Toybox,
            Skins.Glock18SnackAttack
        ];

        private List<Skins> SkinsSecret =
        [
            Skins.DesertEagleOceanDrive,
            Skins.AK47LeetMuseo
        ];

        private List<Skins> SkinsRareItem =
        [
            Skins.ButterflyKnifeGammaDopplerEmerald,
            Skins.ButterflyKnifeGammaDopplerPhase2,
            Skins.ButterflyKnifeGammaDopplerPhase3,
            Skins.ButterflyKnifeGammaDopplerPhase1,
            Skins.ButterflyKnifeGammaDopplerPhase4,
            Skins.ButterflyKnifeLore,
            Skins.ButterflyKnifeAutotronic,
            Skins.ButterflyKnifeBlackLaminate,
            Skins.ButterflyKnifeFreehand,
            Skins.HuntsmanKnifeGammaDopplerEmerald,
            Skins.ButterflyKnifeBrightWater,
            Skins.BowieKnifeGammaDopplerEmerald,
            Skins.FalchionKnifeGammaDopplerEmerald,
            Skins.HuntsmanKnifeGammaDopplerPhase2,
            Skins.FalchionKnifeGammaDopplerPhase2,
            Skins.HuntsmanKnifeGammaDopplerPhase1,
            Skins.HuntsmanKnifeGammaDopplerPhase4,
            Skins.HuntsmanKnifeGammaDopplerPhase3,
            Skins.ShadowDaggersGammaDopplerEmerald,
            Skins.FalchionKnifeGammaDopplerPhase1,
            Skins.FalchionKnifeGammaDopplerPhase4,
            Skins.FalchionKnifeGammaDopplerPhase3,
            Skins.BowieKnifeGammaDopplerPhase2,
            Skins.BowieKnifeGammaDopplerPhase1,
            Skins.BowieKnifeGammaDopplerPhase4,
            Skins.BowieKnifeGammaDopplerPhase3,
            Skins.BowieKnifeLore,
            Skins.HuntsmanKnifeAutotronic,
            Skins.FalchionKnifeAutotronic,
            Skins.HuntsmanKnifeLore,
            Skins.FalchionKnifeLore,
            Skins.BowieKnifeAutotronic,
            Skins.ShadowDaggersGammaDopplerPhase4,
            Skins.ShadowDaggersLore,
            Skins.HuntsmanKnifeBlackLaminate,
            Skins.ShadowDaggersGammaDopplerPhase3,
            Skins.ShadowDaggersGammaDopplerPhase1,
            Skins.FalchionKnifeFreehand,
            Skins.ShadowDaggersGammaDopplerPhase2,
            Skins.BowieKnifeFreehand,
            Skins.HuntsmanKnifeFreehand,
            Skins.BowieKnifeBlackLaminate,
            Skins.FalchionKnifeBrightWater,
            Skins.HuntsmanKnifeBrightWater,
            Skins.FalchionKnifeBlackLaminate,
            Skins.BowieKnifeBrightWater,
            Skins.ShadowDaggersAutotronic,
            Skins.ShadowDaggersFreehand,
            Skins.ShadowDaggersBlackLaminate,
            Skins.ShadowDaggersBrightWater
        ];
    }
}
