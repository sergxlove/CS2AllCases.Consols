using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class OperationBreakoutWeaponCase : ICases
    {
        public OperationBreakoutWeaponCase(ProbabilitiesDropOptions? options = null)
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
            [Description("UMP-45 | Labyrinth")]
            UMP45Labyrinth = 1,
            [Description("SSG 08 | Abyss")]
            SSG08Abyss = 2,
            [Description("P2000 | Ivory")]
            P2000Ivory = 3,
            [Description("Negev | Desert-Strike")]
            NegevDesertStrike = 4,
            [Description("MP7 | Urban Hazard")]
            MP7UrbanHazard = 5,
            [Description("PP-Bizon | Osiris")]
            PPBizonOsiris = 6,
            [Description("P250 | Supernova")]
            P250Supernova = 7,
            [Description("Nova | Koi")]
            NovaKoi = 8,
            [Description("CZ75-Auto | Tigris")]
            CZ75AutoTigris = 9,
            [Description("Glock-18 | Water Elemental")]
            Glock18WaterElemental = 10,
            [Description("Five-SeveN | Fowl Play")]
            FiveSevenFowlPlay = 11,
            [Description("Desert Eagle | Conspiracy")]
            DesertEagleConspiracy = 12,
            [Description("P90 | Asiimov")]
            P90Asiimov = 13,
            [Description("M4A1-S | Cyrex")]
            M4A1SCyrex = 14,
            [Description("Butterfly Knife | Fade")]
            ButterflyKnifeFade = 15,
            [Description("Butterfly Knife | Vanilla")]
            ButterflyKnifeVanilla = 16,
            [Description("Butterfly Knife | Slaughter")]
            ButterflyKnifeSlaughter = 17,
            [Description("Butterfly Knife | Crimson Web")]
            ButterflyKnifeCrimsonWeb = 18,
            [Description("Butterfly Knife | Case Hardened")]
            ButterflyKnifeCaseHardened = 19,
            [Description("Butterfly Knife | Blue Steel")]
            ButterflyKnifeBlueSteel = 20,
            [Description("Butterfly Knife | Stained")]
            ButterflyKnifeStained = 21,
            [Description("Butterfly Knife | Night")]
            ButterflyKnifeNight = 22,
            [Description("Butterfly Knife | Scorched")]
            ButterflyKnifeScorched = 23,
            [Description("Butterfly Knife | Boreal Forest")]
            ButterflyKnifeBorealForest = 24,
            [Description("Butterfly Knife | Urban Masked")]
            ButterflyKnifeUrbanMasked = 25,
            [Description("Butterfly Knife | Forest DDPAT")]
            ButterflyKnifeForestDDPAT = 26,
            [Description("Butterfly Knife | Safari Mesh")]
            ButterflyKnifeSafariMesh = 27
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
