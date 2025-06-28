using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class FalchionCase : ICases
    {
        public FalchionCase(ProbabilitiesDropOptions? options = null)
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
            [Description("UMP-45 | Riot")]
            UMP45Riot = 1,
            [Description("USP-S | Torque")]
            USPSTorque = 2,
            [Description("P90 | Elite Build")]
            P90EliteBuild = 3,
            [Description("Nova | Ranger")]
            NovaRanger = 4,
            [Description("Glock-18 | Bunsen Burner")]
            Glock18BunsenBurner = 5,
            [Description("Galil AR | Rocket Pop")]
            GalilARRocketPop = 6,
            [Description("P2000 | Handgun")]
            P2000Handgun = 7,
            [Description("Negev | Loudmouth")]
            NegeVLoudmouth = 8,
            [Description("MP9 | Ruby Poison Dart")]
            MP9RubyPoisonDart = 9,
            [Description("M4A4 | Evil Daimyo")]
            M4A4EvilDaimyo = 10,
            [Description("FAMAS | Neural Net")]
            FAMASNeuralNet = 11,
            [Description("SG 553 | Cyrex")]
            SG553Cyrex = 12,
            [Description("MP7 | Nemesis")]
            MP7Nemesis = 13,
            [Description("CZ75-Auto | Yellow Jacket")]
            CZ75AutoYellowJacket = 14,
            [Description("AWP | Hyper Beast")]
            AWPHyperBeast = 15,
            [Description("AK-47 | Aquamarine Revenge")]
            AK47AquamarineRevenge = 16,
            [Description("Falchion Knife | Fade")]
            FalchionKnifeFade = 17,
            [Description("Falchion Knife | Slaughter")]
            FalchionKnifeSlaughter = 18,
            [Description("Falchion Knife | Case Hardened")]
            FalchionKnifeCaseHardened = 19,
            [Description("Falchion Knife | Crimson Web")]
            FalchionKnifeCrimsonWeb = 20,
            [Description("Falchion Knife | Blue Steel")]
            FalchionKnifeBlueSteel = 21,
            [Description("Falchion Knife | Vanilla")]
            FalchionKnifeVanilla = 22,
            [Description("Falchion Knife | Night")]
            FalchionKnifeNight = 23,
            [Description("Falchion Knife | Stained")]
            FalchionKnifeStained = 24,
            [Description("Falchion Knife | Urban Masked")]
            FalchionKnifeUrbanMasked = 25,
            [Description("Falchion Knife | Scorched")]
            FalchionKnifeScorched = 26,
            [Description("Falchion Knife | Forest DDPAT")]
            FalchionKnifeForestDDPAT = 27,
            [Description("Falchion Knife | Boreal Forest")]
            FalchionKnifeBorealForest = 28,
            [Description("Falchion Knife | Safari Mesh")]
            FalchionKnifeSafariMesh = 29
        }

        private List<Skins> SkinsArmy =
        [
            Skins.USPSTorque,
            Skins.UMP45Riot,
            Skins.P90EliteBuild,
            Skins.NovaRanger,
            Skins.Glock18BunsenBurner,
            Skins.GalilARRocketPop
        ];

        private List<Skins> SkinsForbidden =
        [
            Skins.P2000Handgun,
            Skins.NegeVLoudmouth,
            Skins.MP9RubyPoisonDart,
            Skins.M4A4EvilDaimyo,
            Skins.FAMASNeuralNet
        ];

        private List<Skins> SkinsClassified =
        [
            Skins.SG553Cyrex,
            Skins.MP7Nemesis,
            Skins.CZ75AutoYellowJacket
        ];

        private List<Skins> SkinsSecret =
        [
            Skins.AWPHyperBeast,
            Skins.AK47AquamarineRevenge
        ];

        private List<Skins> SkinsRareItem =
        [
            Skins.FalchionKnifeFade,
            Skins.FalchionKnifeSlaughter,
            Skins.FalchionKnifeCaseHardened,
            Skins.FalchionKnifeCrimsonWeb,
            Skins.FalchionKnifeBlueSteel,
            Skins.FalchionKnifeVanilla,
            Skins.FalchionKnifeNight,
            Skins.FalchionKnifeStained,
            Skins.FalchionKnifeUrbanMasked,
            Skins.FalchionKnifeScorched,
            Skins.FalchionKnifeForestDDPAT,
            Skins.FalchionKnifeBorealForest,
            Skins.FalchionKnifeSafariMesh
        ];
    }
}
