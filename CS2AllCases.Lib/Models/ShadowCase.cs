using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class ShadowCase : ICases
    {
        public ShadowCase(ProbabilitiesDropOptions? options = null)
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
            [Description("XM1014 | Scumbria")]
            XM1014Scumbria = 1,
            [Description("SCAR-20 | Green Marine")]
            SCAR20GreenMarine = 2,
            [Description("MAG-7 | Cobalt Core")]
            MAG7CobaltCore = 3,
            [Description("MAC-10 | Rangeen")]
            MAC10Rangeen = 4,
            [Description("Glock-18 | Wraiths")]
            Glock18Wraiths = 5,
            [Description("FAMAS | Survivor Z")]
            FAMASSurvivorZ = 6,
            [Description("Dual Berettas | Dualing Dragons")]
            DualBerettasDualingDragons = 7,
            [Description("P250 | Wingshot")]
            P250Wingshot = 8,
            [Description("MP7 | Special Delivery")]
            MP7SpecialDelivery = 9,
            [Description("M249 | Nebula Crusader")]
            M249NebulaCrusader = 10,
            [Description("Galil AR | Stone Cold")]
            GalilARStoneCold = 11,
            [Description("SSG 08 | Big Iron")]
            SSG08BigIron = 12,
            [Description("G3SG1 | Flux")]
            G3SG1Flux = 13,
            [Description("AK-47 | Frontside Misty")]
            AK47FrontsideMisty = 14,
            [Description("USP-S | Kill Confirmed")]
            USPSKillConfirmed = 15,
            [Description("M4A1-S | Golden Coil")]
            M4A1SGoldenCoil = 16,
            [Description("Shadow Daggers | Fade")]
            ShadowDaggersFade = 17,
            [Description("Shadow Daggers | Case Hardened")]
            ShadowDaggersCaseHardened = 18,
            [Description("Shadow Daggers | Slaughter")]
            ShadowDaggersSlaughter = 19,
            [Description("Shadow Daggers | Crimson Web")]
            ShadowDaggersCrimsonWeb = 20,
            [Description("Shadow Daggers | Vanilla")]
            ShadowDaggersVanilla = 21,
            [Description("Shadow Daggers | Blue Steel")]
            ShadowDaggersBlueSteel = 22,
            [Description("Shadow Daggers | Stained")]
            ShadowDaggersStained = 23,
            [Description("Shadow Daggers | Night")]
            ShadowDaggersNight = 24,
            [Description("Shadow Daggers | Urban Masked")]
            ShadowDaggersUrbanMasked = 25,
            [Description("Shadow Daggers | Scorched")]
            ShadowDaggersScorched = 26,
            [Description("Shadow Daggers | Boreal Forest")]
            ShadowDaggersBorealForest = 27,
            [Description("Shadow Daggers | Safari Mesh")]
            ShadowDaggersSafariMesh = 28,
            [Description("Shadow Daggers | Forest DDPAT")]
            ShadowDaggersForestDDPAT = 29
        }

        private List<Skins> SkinsArmy =
        [
            Skins.XM1014Scumbria,
            Skins.SCAR20GreenMarine, 
            Skins.MAG7CobaltCore,
            Skins.MAC10Rangeen,
            Skins.Glock18Wraiths,
            Skins.FAMASSurvivorZ,
            Skins.DualBerettasDualingDragons,

        ];

        private List<Skins> SkinsForbidden =
        [
            Skins.P250Wingshot,
            Skins.MP7SpecialDelivery,
            Skins.M249NebulaCrusader,
            Skins.GalilARStoneCold,
        ];

        private List<Skins> SkinsClassified =
        [
            Skins.SSG08BigIron,
            Skins.G3SG1Flux,
            Skins.AK47FrontsideMisty
        ];

        private List<Skins> SkinsSecret =
        [
            Skins.USPSKillConfirmed,
            Skins.M4A1SGoldenCoil
        ];

        private List<Skins> SkinsRareItem =
        [
            Skins.ShadowDaggersFade,
            Skins.ShadowDaggersCaseHardened,
            Skins.ShadowDaggersSlaughter,
            Skins.ShadowDaggersCrimsonWeb,
            Skins.ShadowDaggersVanilla,
            Skins.ShadowDaggersBlueSteel,
            Skins.ShadowDaggersStained,
            Skins.ShadowDaggersNight,
            Skins.ShadowDaggersUrbanMasked,
            Skins.ShadowDaggersScorched,
            Skins.ShadowDaggersBorealForest,
            Skins.ShadowDaggersSafariMesh,
            Skins.ShadowDaggersForestDDPAT
        ];
    }
}
