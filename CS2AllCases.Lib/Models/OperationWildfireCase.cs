using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class OperationWildfireCase : ICases
    {
        public OperationWildfireCase(ProbabilitiesDropOptions? options = null)
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
            [Description("USP-S | Lead Conduit")]
            USPSLeadConduit = 1,
            [Description("Tec-9 | Jambiya")]
            Tec9Jambiya = 2,
            [Description("SSG 08 | Necropos")]
            SSG08Necropos = 3,
            [Description("PP-Bizon | Photic Zone")]
            PPBizonPhoticZone = 4,
            [Description("MAC-10 | Lapis Gator")]
            MAC10LapisGator = 5,
            [Description("Dual Berettas | Cartel")]
            DualBerettasCartel = 6,
            [Description("MP7 | Impire")]
            MP7Impire = 7,
            [Description("MAG-7 | Praetorian")]
            MAG7Praetorian = 8,
            [Description("Glock-18 | Royal Legion")]
            Glock18RoyalLegion = 9,
            [Description("Five-SeveN | Triumvirate")]
            FiveSevenTriumvirate = 10,
            [Description("FAMAS | Valence")]
            FAMASValence = 11,
            [Description("Nova | Hyper Beast")]
            NovaHyperBeast = 12,
            [Description("Desert Eagle | Kumicho Dragon")]
            DesertEagleKumichoDragon = 13,
            [Description("AWP | Elite Build")]
            AWPEliteBuild = 14,
            [Description("M4A4 | The Battlestar")]
            M4A4TheBattlestar = 15,
            [Description("AK-47 | Fuel Injector")]
            AK47FuelInjector = 16,
            [Description("Bowie Knife | Case Hardened")]
            BowieKnifeCaseHardened = 17,
            [Description("Bowie Knife | Fade")]
            BowieKnifeFade = 18,
            [Description("Bowie Knife | Slaughter")]
            BowieKnifeSlaughter = 19,
            [Description("Bowie Knife | Crimson Web")]
            BowieKnifeCrimsonWeb = 20,
            [Description("Bowie Knife | Blue Steel")]
            BowieKnifeBlueSteel = 21,
            [Description("Bowie Knife | Vanilla")]
            BowieKnifeVanilla = 22,
            [Description("Bowie Knife | Stained")]
            BowieKnifeStained = 23,
            [Description("Bowie Knife | Night")]
            BowieKnifeNight = 24,
            [Description("Bowie Knife | Boreal Forest")]
            BowieKnifeBorealForest = 25,
            [Description("Bowie Knife | Forest DDPAT")]
            BowieKnifeForestDDPAT = 26,
            [Description("Bowie Knife | Urban Masked")]
            BowieKnifeUrbanMasked = 27,
            [Description("Bowie Knife | Scorched")]
            BowieKnifeScorched = 28,
            [Description("Bowie Knife | Safari Mesh")]
            BowieKnifeSafariMesh = 29
        }

        private List<Skins> SkinsArmy =
        [
            Skins.USPSLeadConduit,
            Skins.Tec9Jambiya,
            Skins.SSG08Necropos,
            Skins.PPBizonPhoticZone,
            Skins.MAC10LapisGator,
            Skins.DualBerettasCartel
        ];

        private List<Skins> SkinsForbidden =
        [
            Skins.MP7Impire,
            Skins.MAG7Praetorian,
            Skins.Glock18RoyalLegion,
            Skins.FiveSevenTriumvirate,
            Skins.FAMASValence
        ];

        private List<Skins> SkinsClassified =
        [
            Skins.NovaHyperBeast,
            Skins.DesertEagleKumichoDragon,
            Skins.AWPEliteBuild
        ];

        private List<Skins> SkinsSecret =
        [
            Skins.M4A4TheBattlestar,
            Skins.AK47FuelInjector
        ];

        private List<Skins> SkinsRareItem =
        [
            Skins.BowieKnifeCaseHardened,
            Skins.BowieKnifeFade,
            Skins.BowieKnifeSlaughter,
            Skins.BowieKnifeCrimsonWeb,
            Skins.BowieKnifeBlueSteel,
            Skins.BowieKnifeVanilla,
            Skins.BowieKnifeStained,
            Skins.BowieKnifeNight,
            Skins.BowieKnifeBorealForest,
            Skins.BowieKnifeForestDDPAT,
            Skins.BowieKnifeUrbanMasked,
            Skins.BowieKnifeScorched,
            Skins.BowieKnifeSafariMesh
        ];
    }
}
