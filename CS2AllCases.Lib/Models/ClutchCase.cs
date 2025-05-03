using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class ClutchCase : ICases
    {
        public ClutchCase(ProbabilitiesDropOptions? options = null)
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
            [Description("XM1014 | Oxide Blaze")]
            XM1014OxideBlaze = 1,
            [Description("MP9 | Black Sand")]
            MP9BlackSand = 2,
            [Description("SG 553 | Aloha")]
            SG553Aloha = 3,
            [Description("Five-SeveN | Flame Test")]
            FiveSevenFlameTest = 4,
            [Description("PP-Bizon | Night Riot")]
            PPBizonNightRiot = 5,
            [Description("P2000 | Urban Hazard")]
            P2000UrbanHazard = 6,
            [Description("R8 Revolver | Grip")]
            R8RevolverGrip = 7,
            [Description("Negev | Lionfish")]
            NegevLionfish = 8,
            [Description("UMP-45 | Arctic Wolf")]
            UMP45ArcticWolf = 9,
            [Description("Nova | Wild Six")]
            NovaWildSix = 10,
            [Description("Glock-18 | Moonrise")]
            Glock18Moonrise = 11,
            [Description("MAG-7 | SWAG-7")]
            MAG7SWAG7 = 12,
            [Description("AUG | Stymphalian")]
            AUGStymphalian = 13,
            [Description("AWP | Mortis")]
            AWPMortis = 14,
            [Description("USP-S | Cortex")]
            USPSCortex = 15,
            [Description("MP7 | Bloodsport")]
            MP7Bloodsport = 16,
            [Description("M4A4 | Neo-Noir")]
            M4A4NeoNoir = 17,
            [Description("Sport Gloves | Vice")]
            SportGlovesVice = 18,
            [Description("Sport Gloves | Omega")]
            SportGlovesOmega = 19,
            [Description("Specialist Gloves | Fade")]
            SpecialistGlovesFade = 20,
            [Description("Specialist Gloves | Crimson Web")]
            SpecialistGlovesCrimsonWeb = 21,
            [Description("Hand Wraps | Cobalt Skulls")]
            HandWrapsCobaltSkulls = 22,
            [Description("Sport Gloves | Amphibious")]
            SportGlovesAmphibious = 23,
            [Description("Driver Gloves | Imperial Plaid")]
            DriverGlovesImperialPlaid = 24,
            [Description("Moto Gloves | POW!")]
            MotoGlovesPOW = 25,
            [Description("Driver Gloves | King Snake")]
            DriverGlovesKingSnake = 26,
            [Description("Specialist Gloves | Mogul")]
            SpecialistGlovesMogul = 27,
            [Description("Sport Gloves | Bronze Morph")]
            SportGlovesBronzeMorph = 28,
            [Description("Moto Gloves | Polygon")]
            MotoGlovesPolygon = 29,
            [Description("Hand Wraps | Overprint")]
            HandWrapsOverprint = 30,
            [Description("Moto Gloves | Turtle")]
            MotoGlovesTurtle = 31,
            [Description("Driver Gloves | Overtake")]
            DriverGlovesOvertake = 32,
            [Description("Specialist Gloves | Buckshot")]
            SpecialistGlovesBuckshot = 33,
            [Description("Hand Wraps | Duct Tape")]
            HandWrapsDuctTape = 34,
            [Description("Hand Wraps | Arboreal")]
            HandWrapsArboreal = 35,
            [Description("Hydra Gloves | Emerald")]
            HydraGlovesEmerald = 36,
            [Description("Hydra Gloves | Mangrove")]
            HydraGlovesMangrove = 37,
            [Description("Driver Gloves | Racing Green")]
            DriverGlovesRacingGreen = 38,
            [Description("Hydra Gloves | Rattler")]
            HydraGlovesRattler = 39,
            [Description("Hydra Gloves | Case Hardened")]
            HydraGlovesCaseHardened = 40,
            [Description("Moto Gloves | Transport")]
            MotoGlovesTransport = 41
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
