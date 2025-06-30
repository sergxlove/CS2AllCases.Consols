using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class KilowattCase : ICases
    {
        public KilowattCase(ProbabilitiesDropOptions? options = null)
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
            [Description("Dual Berettas | Hideout")]
            DualBerettasHideout = 1,
            [Description("Nova | Dark Sigil")]
            NovaDarkSigil = 2,
            [Description("XM1014 | Irezumi")]
            XM1014Irezumi = 3,
            [Description("UMP-45 | Motorized")]
            UMP45Motorized = 4,
            [Description("Tec-9 | Slag")]
            Tec9Slag = 5,
            [Description("SSG 08 | Dezastre")]
            SSG08Dezastre = 6,
            [Description("MAC-10 | Light Box")]
            MAC10LightBox = 7,
            [Description("Sawed-Off | Analog Input")]
            SawedOffAnalogInput = 8,
            [Description("MP7 | Just Smile")]
            MP7JustSmile = 9,
            [Description("Glock-18 | Block-18")]
            Glock18Block18 = 10,
            [Description("M4A4 | Etch Lord")]
            M4A4EtchLord = 11,
            [Description("Five-SeveN | Hybrid")]
            FiveSevenHybrid = 12,
            [Description("Zeus x27 | Olympus")]
            ZeusX27Olympus = 13,
            [Description("USP-S | Jawbreaker")]
            USPSJawbreaker = 14,
            [Description("M4A1-S | Black Lotus")]
            M4A1SBlackLotus = 15,
            [Description("AWP | Chrome Cannon")]
            AWPChromeCannon = 16,
            [Description("AK-47 | Inheritance")]
            AK47Inheritance = 17,
            [Description("Kukri Knife | Crimson Web")]
            KukriKnifeCrimsonWeb = 18,
            [Description("Kukri Knife | Fade")]
            KukriKnifeFade = 19,
            [Description("Kukri Knife | Slaughter")]
            KukriKnifeSlaughter = 20,
            [Description("Kukri Knife | Vanilla")]
            KukriKnifeVanilla = 21,
            [Description("Kukri Knife | Case Hardened")]
            KukriKnifeCaseHardened = 22,
            [Description("Kukri Knife | Stained")]
            KukriKnifeStained = 23,
            [Description("Kukri Knife | Blue Steel")]
            KukriKnifeBlueSteel = 24,
            [Description("Kukri Knife | Night Stripe")]
            KukriKnifeNightStripe = 25,
            [Description("Kukri Knife | Urban Masked")]
            KukriKnifeUrbanMasked = 26,
            [Description("Kukri Knife | Scorched")]
            KukriKnifeScorched = 27,
            [Description("Kukri Knife | Forest DDPAT")]
            KukriKnifeForestDDPAT = 28,
            [Description("Kukri Knife | Boreal Forest")]
            KukriKnifeBorealForest = 29,
            [Description("Kukri Knife | Safari Mesh")]
            KukriKnifeSafariMesh = 30
        }

        private List<Skins> SkinsArmy =
        [
            Skins.XM1014Irezumi,
            Skins.UMP45Motorized,
            Skins.Tec9Slag,
            Skins.SSG08Dezastre,
            Skins.NovaDarkSigil,
            Skins.MAC10LightBox,
            Skins.DualBerettasHideout
        ];

        private List<Skins> SkinsForbidden =
        [
            Skins.SawedOffAnalogInput,
            Skins.MP7JustSmile,
            Skins.M4A4EtchLord,
            Skins.Glock18Block18,
            Skins.FiveSevenHybrid
        ];

        private List<Skins> SkinsClassified =
        [
            Skins.ZeusX27Olympus,
            Skins.USPSJawbreaker,
            Skins.M4A1SBlackLotus
        ];

        private List<Skins> SkinsSecret =
        [
            Skins.AWPChromeCannon,
            Skins.AK47Inheritance
        ];

        private List<Skins> SkinsRareItem =
        [
            Skins.KukriKnifeCrimsonWeb,
            Skins.KukriKnifeFade,
            Skins.KukriKnifeSlaughter,
            Skins.KukriKnifeVanilla,
            Skins.KukriKnifeCaseHardened,
            Skins.KukriKnifeStained,
            Skins.KukriKnifeBlueSteel,
            Skins.KukriKnifeNightStripe,
            Skins.KukriKnifeUrbanMasked,
            Skins.KukriKnifeScorched,
            Skins.KukriKnifeForestDDPAT,
            Skins.KukriKnifeBorealForest,
            Skins.KukriKnifeSafariMesh
        ];
    }
}
