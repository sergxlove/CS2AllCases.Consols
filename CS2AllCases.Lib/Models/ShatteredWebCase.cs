using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class ShatteredWebCase : ICases
    {
        public ShatteredWebCase(ProbabilitiesDropOptions? options = null)
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
            [Description("SCAR-20 | Torn")]
            SCAR20Torn = 1,
            [Description("R8 Revolver | Memento")]
            R8RevolverMemento = 2,
            [Description("Nova | Plume")]
            NovaPlume = 3,
            [Description("MP5-SD | Acid Wash")]
            MP5SDAcidWash = 4,
            [Description("M249 | Warbird")]
            M249Warbird = 5,
            [Description("G3SG1 | Black Sand")]
            G3SG1BlackSand = 6,
            [Description("Dual Berettas | Balance")]
            DualBerettasBalance = 7,
            [Description("PP-Bizon | Embargo")]
            PPBizonEmbargo = 8,
            [Description("P2000 | Obsidian")]
            P2000Obsidian = 9,
            [Description("MP7 | Neon Ply")]
            MP7NeonPly = 10,
            [Description("AUG | Arctic Wolf")]
            AUGArcticWolf = 11,
            [Description("AK-47 | Rat Rod")]
            AK47RatRod = 12,
            [Description("Tec-9 | Decimator")]
            Tec9Decimator = 13,
            [Description("SSG 08 | Bloodshot")]
            SSG08Bloodshot = 14,
            [Description("SG 553 | Colony IV")]
            SG553ColonyIV = 15,
            [Description("MAC-10 | Stalker")]
            MAC10Stalker = 16,
            [Description("AWP | Containment Breach")]
            AWPContainmentBreach = 17,
            [Description("Skeleton Knife | Fade")]
            SkeletonKnifeFade = 18,
            [Description("Nomad Knife | Fade")]
            NomadKnifeFade = 19,
            [Description("Skeleton Knife | Slaughter")]
            SkeletonKnifeSlaughter = 20,
            [Description("Skeleton Knife | Crimson Web")]
            SkeletonKnifeCrimsonWeb = 21,
            [Description("Skeleton Knife | Case Hardened")]
            SkeletonKnifeCaseHardened = 22,
            [Description("Skeleton Knife | Vanilla")]
            SkeletonKnifeVanilla = 23,
            [Description("Survival Knife | Crimson Web")]
            SurvivalKnifeCrimsonWeb = 24,
            [Description("Skeleton Knife | Blue Steel")]
            SkeletonKnifeBlueSteel = 25,
            [Description("Nomad Knife | Case Hardened")]
            NomadKnifeCaseHardened = 26,
            [Description("Nomad Knife | Slaughter")]
            NomadKnifeSlaughter = 27,
            [Description("Skeleton Knife | Stained")]
            SkeletonKnifeStained = 28,
            [Description("Skeleton Knife | Night Stripe")]
            SkeletonKnifeNightStripe = 29,
            [Description("Nomad Knife | Crimson Web")]
            NomadKnifeCrimsonWeb = 30,
            [Description("Nomad Knife | Vanilla")]
            NomadKnifeVanilla = 31,
            [Description("Skeleton Knife | Urban Masked")]
            SkeletonKnifeUrbanMasked = 32,
            [Description("Skeleton Knife | Scorched")]
            SkeletonKnifeScorched = 33,
            [Description("Paracord Knife | Fade")]
            ParacordKnifeFade = 34,
            [Description("Nomad Knife | Stained")]
            NomadKnifeStained = 35,
            [Description("Nomad Knife | Blue Steel")]
            NomadKnifeBlueSteel = 36,
            [Description("Skeleton Knife | Forest DDPAT")]
            SkeletonKnifeForestDDPAT = 37,
            [Description("Survival Knife | Fade")]
            SurvivalKnifeFade = 38,
            [Description("Skeleton Knife | Boreal Forest")]
            SkeletonKnifeBorealForest = 39,
            [Description("Paracord Knife | Case Hardened")]
            ParacordKnifeCaseHardened = 40,
            [Description("Skeleton Knife | Safari Mesh")]
            SkeletonKnifeSafariMesh = 41,
            [Description("Nomad Knife | Night Stripe")]
            NomadKnifeNightStripe = 42,
            [Description("Paracord Knife | Slaughter")]
            ParacordKnifeSlaughter = 43,
            [Description("Survival Knife | Case Hardened")]
            SurvivalKnifeCaseHardened = 44,
            [Description("Paracord Knife | Crimson Web")]
            ParacordKnifeCrimsonWeb = 45,
            [Description("Nomad Knife | Scorched")]
            NomadKnifeScorched = 46,
            [Description("Survival Knife | Slaughter")]
            SurvivalKnifeSlaughter = 47,
            [Description("Paracord Knife | Blue Steel")]
            ParacordKnifeBlueSteel = 48,
            [Description("Paracord Knife | Urban Masked")]
            ParacordKnifeUrbanMasked = 49,
            [Description("Nomad Knife | Urban Masked")]
            NomadKnifeUrbanMasked = 50,
            [Description("Survival Knife | Blue Steel")]
            SurvivalKnifeBlueSteel = 51,
            [Description("Paracord Knife | Stained")]
            ParacordKnifeStained = 52,
            [Description("Nomad Knife | Forest DDPAT")]
            NomadKnifeForestDDPAT = 53,
            [Description("Nomad Knife | Boreal Forest")]
            NomadKnifeBorealForest = 54,
            [Description("Survival Knife | Vanilla")]
            SurvivalKnifeVanilla = 55,
            [Description("Paracord Knife | Vanilla")]
            ParacordKnifeVanilla = 56,
            [Description("Survival Knife | Night Stripe")]
            SurvivalKnifeNightStripe = 57,
            [Description("Survival Knife | Urban Masked")]
            SurvivalKnifeUrbanMasked = 58,
            [Description("Paracord Knife | Forest DDPAT")]
            ParacordKnifeForestDDPAT = 59,
            [Description("Nomad Knife | Safari Mesh")]
            NomadKnifeSafariMesh = 60,
            [Description("Survival Knife | Scorched")]
            SurvivalKnifeScorched = 61,
            [Description("Survival Knife | Boreal Forest")]
            SurvivalKnifeBorealForest = 62,
            [Description("Survival Knife | Stained")]
            SurvivalKnifeStained = 63,
            [Description("Paracord Knife | Safari Mesh")]
            ParacordKnifeSafariMesh = 64,
            [Description("Survival Knife | Forest DDPAT")]
            SurvivalKnifeForestDDPAT = 65,
            [Description("Paracord Knife | Boreal Forest")]
            ParacordKnifeBorealForest = 66,
            [Description("Paracord Knife | Night Stripe")]
            ParacordKnifeNightStripe = 67,
            [Description("Paracord Knife | Scorched")]
            ParacordKnifeScorched = 68,
            [Description("Survival Knife | Safari Mesh")]
            SurvivalKnifeSafariMesh = 69
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
