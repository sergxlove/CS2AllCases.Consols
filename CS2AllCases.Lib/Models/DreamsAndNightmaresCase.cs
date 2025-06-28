using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class DreamsAndNightmaresCase : ICases
    {
        public DreamsAndNightmaresCase(ProbabilitiesDropOptions? options = null)
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
            [Description("SCAR-20 | Poultrygeist")]
            SCAR20Poultrygeist = 1,
            [Description("MAG-7 | Foresight")]
            MAG7Foresight = 2,
            [Description("MP5-SD | Necro Jr.")]
            MP5SDNecroJr = 3,
            [Description("P2000 | Lifted Spirits")]
            P2000LiftedSpirits = 4,
            [Description("MAC-10 | Ensnared")]
            MAC10Ensnared = 5,
            [Description("Sawed-Off | Spirit Board")]
            SawedOffSpiritBoard = 6,
            [Description("Five-SeveN | Scrawl")]
            FiveSevenScrawl = 7,
            [Description("XM1014 | Zombie Offensive")]
            XM1014ZombieOffensive = 8,
            [Description("PP-Bizon | Space Cat")]
            PPBizonSpaceCat = 9,
            [Description("G3SG1 | Dream Glade")]
            G3SG1DreamGlade = 10,
            [Description("USP-S | Ticket to Hell")]
            USPSTicketToHell = 11,
            [Description("M4A1-S | Night Terror")]
            M4A1SNightTerror = 12,
            [Description("MP7 | Abyssal Apparition")]
            MP7AbyssalApparition = 13,
            [Description("Dual Berettas | Melondrama")]
            DualBerettasMelondrama = 14,
            [Description("FAMAS | Rapid Eye Movement")]
            FAMASRapidEyeMovement = 15,
            [Description("MP9 | Starlight Protector")]
            MP9StarlightProtector = 16,
            [Description("AK-47 | Nightwish")]
            AK47Nightwish = 17,
            [Description("Butterfly Knife | Gamma Doppler Emerald")]
            ButterflyKnifeGammaDopplerEmerald = 18,
            [Description("Butterfly Knife | Gamma Doppler Phase 2")]
            ButterflyKnifeGammaDopplerPhase2 = 19,
            [Description("Butterfly Knife | Gamma Doppler Phase 1")]
            ButterflyKnifeGammaDopplerPhase1 = 20,
            [Description("Butterfly Knife | Gamma Doppler Phase 3")]
            ButterflyKnifeGammaDopplerPhase3 = 21,
            [Description("Butterfly Knife | Gamma Doppler Phase 4")]
            ButterflyKnifeGammaDopplerPhase4 = 22,
            [Description("Butterfly Knife | Lore")]
            ButterflyKnifeLore = 23,
            [Description("Butterfly Knife | Autotronic")]
            ButterflyKnifeAutotronic = 24,
            [Description("Butterfly Knife | Black Laminate")]
            ButterflyKnifeBlackLaminate = 25,
            [Description("Huntsman Knife | Gamma Doppler Emerald")]
            HuntsmanKnifeGammaDopplerEmerald = 26,
            [Description("Butterfly Knife | Freehand")]
            ButterflyKnifeFreehand = 27,
            [Description("Butterfly Knife | Bright Water")]
            ButterflyKnifeBrightWater = 28,
            [Description("Bowie Knife | Gamma Doppler Emerald")]
            BowieKnifeGammaDopplerEmerald = 29,
            [Description("Falchion Knife | Gamma Doppler Emerald")]
            FalchionKnifeGammaDopplerEmerald = 30,
            [Description("Huntsman Knife | Gamma Doppler Phase 2")]
            HuntsmanKnifeGammaDopplerPhase2 = 31,
            [Description("Huntsman Knife | Gamma Doppler Phase 1")]
            HuntsmanKnifeGammaDopplerPhase1 = 32,
            [Description("Huntsman Knife | Gamma Doppler Phase 3")]
            HuntsmanKnifeGammaDopplerPhase3 = 33,
            [Description("Huntsman Knife | Gamma Doppler Phase 4")]
            HuntsmanKnifeGammaDopplerPhase4 = 34,
            [Description("Falchion Knife | Gamma Doppler Phase 2")]
            FalchionKnifeGammaDopplerPhase2 = 35,
            [Description("Falchion Knife | Gamma Doppler Phase 1")]
            FalchionKnifeGammaDopplerPhase1 = 36,
            [Description("Shadow Daggers | Gamma Doppler Emerald")]
            ShadowDaggersGammaDopplerEmerald = 37,
            [Description("Falchion Knife | Gamma Doppler Phase 4")]
            FalchionKnifeGammaDopplerPhase4 = 38,
            [Description("Bowie Knife | Gamma Doppler Phase 2")]
            BowieKnifeGammaDopplerPhase2 = 39,
            [Description("Falchion Knife | Gamma Doppler Phase 3")]
            FalchionKnifeGammaDopplerPhase3 = 40,
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
            [Description("Bowie Knife | Autotronic")]
            BowieKnifeAutotronic = 48,
            [Description("Falchion Knife | Lore")]
            FalchionKnifeLore = 49,
            [Description("Shadow Daggers | Lore")]
            ShadowDaggersLore = 50,
            [Description("Shadow Daggers | Gamma Doppler Phase 4")]
            ShadowDaggersGammaDopplerPhase4 = 51,
            [Description("Huntsman Knife | Black Laminate")]
            HuntsmanKnifeBlackLaminate = 52,
            [Description("Shadow Daggers | Gamma Doppler Phase 2")]
            ShadowDaggersGammaDopplerPhase2 = 53,
            [Description("Shadow Daggers | Gamma Doppler Phase 3")]
            ShadowDaggersGammaDopplerPhase3 = 54,
            [Description("Shadow Daggers | Gamma Doppler Phase 1")]
            ShadowDaggersGammaDopplerPhase1 = 55,
            [Description("Bowie Knife | Black Laminate")]
            BowieKnifeBlackLaminate = 56,
            [Description("Falchion Knife | Freehand")]
            FalchionKnifeFreehand = 57,
            [Description("Huntsman Knife | Freehand")]
            HuntsmanKnifeFreehand = 58,
            [Description("Bowie Knife | Freehand")]
            BowieKnifeFreehand = 59,
            [Description("Falchion Knife | Bright Water")]
            FalchionKnifeBrightWater = 60,
            [Description("Huntsman Knife | Bright Water")]
            HuntsmanKnifeBrightWater = 61,
            [Description("Falchion Knife | Black Laminate")]
            FalchionKnifeBlackLaminate = 62,
            [Description("Shadow Daggers | Autotronic")]
            ShadowDaggersAutotronic = 63,
            [Description("Bowie Knife | Bright Water")]
            BowieKnifeBrightWater = 64,
            [Description("Shadow Daggers | Freehand")]
            ShadowDaggersFreehand = 65,
            [Description("Shadow Daggers | Black Laminate")]
            ShadowDaggersBlackLaminate = 66,
            [Description("Shadow Daggers | Bright Water")]
            ShadowDaggersBrightWater = 67
        }

        private List<Skins> SkinsArmy =
        [
            Skins.SCAR20Poultrygeist,
            Skins.SawedOffSpiritBoard,
            Skins.P2000LiftedSpirits,
            Skins.MP5SDNecroJr,
            Skins.MAG7Foresight,
            Skins.MAC10Ensnared,
            Skins.FiveSevenScrawl
        ];

        private List<Skins> SkinsForbidden =
        [
            Skins.XM1014ZombieOffensive,
            Skins.USPSTicketToHell,
            Skins.PPBizonSpaceCat,
            Skins.M4A1SNightTerror,
            Skins.G3SG1DreamGlade
        ];

        private List<Skins> SkinsClassified =
        [
            Skins.MP7AbyssalApparition,
            Skins.FAMASRapidEyeMovement,
            Skins.DualBerettasMelondrama
        ];

        private List<Skins> SkinsSecret =
        [
            Skins.MP9StarlightProtector,
            Skins.AK47Nightwish
        ];

        private List<Skins> SkinsRareItem =
        [
            Skins.ButterflyKnifeGammaDopplerEmerald,
            Skins.ButterflyKnifeGammaDopplerPhase2,
            Skins.ButterflyKnifeGammaDopplerPhase1,
            Skins.ButterflyKnifeGammaDopplerPhase3,
            Skins.ButterflyKnifeGammaDopplerPhase4,
            Skins.ButterflyKnifeLore,
            Skins.ButterflyKnifeAutotronic,
            Skins.ButterflyKnifeBlackLaminate,
            Skins.HuntsmanKnifeGammaDopplerEmerald,
            Skins.ButterflyKnifeFreehand,
            Skins.ButterflyKnifeBrightWater,
            Skins.BowieKnifeGammaDopplerEmerald,
            Skins.FalchionKnifeGammaDopplerEmerald,
            Skins.HuntsmanKnifeGammaDopplerPhase2,
            Skins.HuntsmanKnifeGammaDopplerPhase1,
            Skins.HuntsmanKnifeGammaDopplerPhase3,
            Skins.HuntsmanKnifeGammaDopplerPhase4,
            Skins.FalchionKnifeGammaDopplerPhase2,
            Skins.FalchionKnifeGammaDopplerPhase1,
            Skins.ShadowDaggersGammaDopplerEmerald,
            Skins.FalchionKnifeGammaDopplerPhase4,
            Skins.BowieKnifeGammaDopplerPhase2,
            Skins.FalchionKnifeGammaDopplerPhase3,
            Skins.BowieKnifeGammaDopplerPhase1,
            Skins.BowieKnifeGammaDopplerPhase4,
            Skins.BowieKnifeGammaDopplerPhase3,
            Skins.BowieKnifeLore,
            Skins.HuntsmanKnifeAutotronic,
            Skins.FalchionKnifeAutotronic,
            Skins.HuntsmanKnifeLore,
            Skins.BowieKnifeAutotronic,
            Skins.FalchionKnifeLore,
            Skins.ShadowDaggersLore,
            Skins.ShadowDaggersGammaDopplerPhase4,
            Skins.HuntsmanKnifeBlackLaminate,
            Skins.ShadowDaggersGammaDopplerPhase2,
            Skins.ShadowDaggersGammaDopplerPhase3,
            Skins.ShadowDaggersGammaDopplerPhase1,
            Skins.BowieKnifeBlackLaminate,
            Skins.FalchionKnifeFreehand,
            Skins.HuntsmanKnifeFreehand,
            Skins.BowieKnifeFreehand,
            Skins.FalchionKnifeBrightWater,
            Skins.HuntsmanKnifeBrightWater,
            Skins.FalchionKnifeBlackLaminate,
            Skins.ShadowDaggersAutotronic,
            Skins.BowieKnifeBrightWater,
            Skins.ShadowDaggersFreehand,
            Skins.ShadowDaggersBlackLaminate,
            Skins.ShadowDaggersBrightWater
        ];
    }
}
