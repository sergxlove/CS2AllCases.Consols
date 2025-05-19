using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class CS20Case : ICases
    {
        public CS20Case(ProbabilitiesDropOptions? options = null)
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
            [Description("SCAR-20 | Assault")]
            SCAR20Assault = 1,
            [Description("MAG-7 | Popdog")]
            MAGPopdog = 2,
            [Description("Tec-9 | Flash Out")]
            Tec9FlashOut = 3,
            [Description("MAC-10 | Classic Crate")]
            MAC10ClassicCrate = 4,
            [Description("Dual Berettas | Elite 1.6")]
            DualBerettasElite16 = 5,
            [Description("FAMAS | Decommissioned")]
            FAMASDecommissioned = 6,
            [Description("Glock-18 | Sacrifice")]
            Glock18Sacrifice = 7,
            [Description("M249 | Aztec")]
            M249Aztec = 8,
            [Description("P250 | Inferno")]
            P250Inferno = 9,
            [Description("UMP-45 | Plastique")]
            UMP45Plastique = 10,
            [Description("Five-SeveN | Buddy")]
            FiveSevenBuddy = 11,
            [Description("MP5-SD | Agent")]
            MP5SDAgent = 12,
            [Description("AUG | Death by Puppy")]
            AUGDeathByPuppy = 13,
            [Description("P90 | Nostalgia")]
            P90Nostalgia = 14,
            [Description("MP9 | Hydra")]
            MP9Hydra = 15,
            [Description("FAMAS | Commemoration")]
            FAMASCommemoratiion = 16,
            [Description("AWP | Wildfire")]
            AWPWildfire = 17,
            [Description("Classic Knife | Fade")]
            ClassicKnifeFade = 18,
            [Description("Classic Knife | Slaughter")]
            ClassicKnifeSlaughter = 19,
            [Description("Classic Knife | Crimson Web")]
            ClassicKnifeCrimsonWeb = 20,
            [Description("Classic Knife | Case Hardened")]
            ClassicKnifeCaseHardened = 21,
            [Description("Classic Knife | Vanilla")]
            ClassicKnifeVanilla = 22,
            [Description("Classic Knife | Blue Steel")]
            ClassicKnifeBlueSteel = 23,
            [Description("Classic Knife | Boreal Forest")]
            ClassicKnifeBorealForest = 24,
            [Description("Classic Knife | Safari Mesh")]
            ClassicKnifeSafariMesh = 25,
            [Description("Classic Knife | Night Stripe")]
            ClassicKnifeNightStripe = 26,
            [Description("Classic Knife | Stained")]
            ClassicKnifeStained = 27,
            [Description("Classic Knife | Scorched")]
            ClassicKnifeScorched = 28,
            [Description("Classic Knife | Urban Masked")]
            ClassicKnifeUrbanMasked = 29,
            [Description("Classic Knife | Forest DDPAT")]
            ClassicKnifeForestDDPAT = 30
        }

        private List<Skins> SkinsArmy =
        [
            Skins.Tec9FlashOut,
            Skins.SCAR20Assault,
            Skins.MAGPopdog,
            Skins.MAC10ClassicCrate,
            Skins.Glock18Sacrifice,
            Skins.FAMASDecommissioned,
            Skins.DualBerettasElite16
        ];

        private List<Skins> SkinsForbidden =
        [
            Skins.UMP45Plastique, 
            Skins.P250Inferno,
            Skins.MP5SDAgent,
            Skins.M249Aztec,
            Skins.FiveSevenBuddy
        ];

        private List<Skins> SkinsClassified =
        [
            Skins.P90Nostalgia,
            Skins.MP9Hydra,
            Skins.AUGDeathByPuppy
        ];

        private List<Skins> SkinsSecret =
        [
            Skins.FAMASCommemoratiion,
            Skins.AWPWildfire
        ];

        private List<Skins> SkinsRareItem =
        [
            Skins.ClassicKnifeFade,
            Skins.ClassicKnifeSlaughter,
            Skins.ClassicKnifeCrimsonWeb,
            Skins.ClassicKnifeCaseHardened,
            Skins.ClassicKnifeVanilla,
            Skins.ClassicKnifeBlueSteel,
            Skins.ClassicKnifeBorealForest,
            Skins.ClassicKnifeSafariMesh,
            Skins.ClassicKnifeNightStripe,
            Skins.ClassicKnifeStained,
            Skins.ClassicKnifeScorched,
            Skins.ClassicKnifeUrbanMasked,
            Skins.ClassicKnifeForestDDPAT
        ];
    }
}
