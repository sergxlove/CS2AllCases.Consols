using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class HuntsmanWeaponCase : ICases
    {
        public HuntsmanWeaponCase(ProbabilitiesDropOptions? options = null)
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
            [Description("Tec-9 | Isaac")]
            Tec9Isaac = 1,
            [Description("SSG 08 | Slashed")]
            SSG08Slashed = 2,
            [Description("P90 | Module")]
            P90Module = 3,
            [Description("P90 | Desert Warfare")]
            P90DesertWarfare = 4,
            [Description("P2000 | Pulse")]
            P2000Pulse = 5,
            [Description("Galil AR | Kami")]
            GalilARKami = 6,
            [Description("CZ75-Auto | Twist")]
            CZ75AutoTwist = 7,
            [Description("CZ75-Auto | Poison Dart")]
            CZ75AutoPoisonDart = 8,
            [Description("XM1014 | Heaven Guard")]
            XM1014HeavenGuard = 9,
            [Description("PP-Bizon | Antique")]
            PPBizonAntique = 10,
            [Description("MAC-10 | Tatter")]
            MAC10Tatter = 11,
            [Description("MAC-10 | Curse")]
            MAC10Curse = 12,
            [Description("AUG | Torque")]
            AUGTorque = 13,
            [Description("USP-S | Orion")]
            USPSOrion = 14,
            [Description("USP-S | Caiman")]
            USPSCaiman = 15,
            [Description("SCAR-20 | Cyrex")]
            SCAR20Cyrex = 16,
            [Description("M4A1-S | Atomic Alloy")]
            M4A1SAtomicAlloy = 17,
            [Description("M4A4 | Desert-Strike")]
            M4A4DesertStrike = 18,
            [Description("AK-47 | Vulcan")]
            AK47Vulcan = 19,
            [Description("Huntsman Knife | Crimson Web")]
            HuntsmanKnifeCrimsonWeb = 20,
            [Description("Huntsman Knife | Fade")]
            HuntsmanKnifeFade = 21,
            [Description("Huntsman Knife | Case Hardened")]
            HuntsmanKnifeCaseHardened = 22,
            [Description("Huntsman Knife | Slaughter")]
            HuntsmanKnifeSlaughter = 23,
            [Description("Huntsman Knife | Vanilla")]
            HuntsmanKnifeVanilla = 24,
            [Description("Huntsman Knife | Blue Steel")]
            HuntsmanKnifeBlueSteel = 25,
            [Description("Huntsman Knife | Stained")]
            HuntsmanKnifeStained = 26,
            [Description("Huntsman Knife | Night")]
            HuntsmanKnifeNight = 27,
            [Description("Huntsman Knife | Safari Mesh")]
            HuntsmanKnifeSafariMesh = 28,
            [Description("Huntsman Knife | Urban Masked")]
            HuntsmanKnifeUrbanMasked = 29,
            [Description("Huntsman Knife | Forest DDPAT")]
            HuntsmanKnifeForestDDPAT = 30,
            [Description("Huntsman Knife | Boreal Forest")]
            HuntsmanKnifeBorealForest = 31,
            [Description("Huntsman Knife | Scorched")]
            HuntsmanKnifeScorched = 32
        }

        private List<Skins> SkinsArmy =
        [
            Skins.Tec9Isaac,
            Skins.SSG08Slashed,
            Skins.P90Module,
            Skins.P90DesertWarfare,
            Skins.P2000Pulse,
            Skins.GalilARKami,
            Skins.CZ75AutoTwist,
            Skins.CZ75AutoPoisonDart
        ];

        private List<Skins> SkinsForbidden =
        [
            Skins.XM1014HeavenGuard,
            Skins.PPBizonAntique,
            Skins.MAC10Curse,
            Skins.MAC10Tatter,
            Skins.AUGTorque
        ];

        private List<Skins> SkinsClassified =
        [
            Skins.USPSOrion,
            Skins.USPSCaiman,
            Skins.SCAR20Cyrex,
            Skins.M4A1SAtomicAlloy
        ];

        private List<Skins> SkinsSecret =
        [
            Skins.M4A4DesertStrike,
            Skins.AK47Vulcan
        ];

        private List<Skins> SkinsRareItem =
        [
            Skins.HuntsmanKnifeCrimsonWeb,
            Skins.HuntsmanKnifeFade,
            Skins.HuntsmanKnifeCaseHardened,
            Skins.HuntsmanKnifeSlaughter,
            Skins.HuntsmanKnifeVanilla,
            Skins.HuntsmanKnifeBlueSteel,
            Skins.HuntsmanKnifeStained,
            Skins.HuntsmanKnifeNight,
            Skins.HuntsmanKnifeSafariMesh,
            Skins.HuntsmanKnifeUrbanMasked,
            Skins.HuntsmanKnifeForestDDPAT,
            Skins.HuntsmanKnifeBorealForest,
            Skins.HuntsmanKnifeScorched
        ];
    }
}
