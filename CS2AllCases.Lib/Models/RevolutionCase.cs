using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class RevolutionCase : ICases
    {
        public RevolutionCase(ProbabilitiesDropOptions? options = null)
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
            [Description("Tec-9 | Rebel")]
            Tec9Rebel = 1,
            [Description("SG 553 | Cyberforce")]
            SG553Cyberforce = 2,
            [Description("SCAR-20 | Fragments")]
            SCAR20Fragments = 3,
            [Description("P250 | Re.built")]
            P250Rebuilt = 4,
            [Description("MP9 | Featherweight")]
            MP9Featherweight = 5,
            [Description("MP5-SD | Liquidation")]
            MP5SDLiquidation = 6,
            [Description("MAG-7 | Insomnia")]
            MAG7Insomnia = 7,
            [Description("R8 Revolver | Banana Cannon")]
            R8RevolverBananaCannon = 8,
            [Description("P90 | Neoqueen")]
            P90Neoqueen = 9,
            [Description("MAC-10 | Sakkaku")]
            MAC10Sakkaku = 10,
            [Description("M4A1-S | Emphorosaur-S")]
            M4A1SEmphorosaurS = 11,
            [Description("Glock-18 | Umbral Rabbit")]
            Glock18UmbralRabbit = 12,
            [Description("UMP-45 | Wild Child")]
            UMP45WildChild = 13,
            [Description("P2000 | Wicked Sick")]
            P2000WickedSick = 14,
            [Description("AWP | Duality")]
            AWPDuality = 15,
            [Description("M4A4 | Temukau")]
            M4A4Temukau = 16,
            [Description("AK-47 | Head Shot")]
            AK47HeadShot = 17,
            [Description("Sport Gloves | Vice")]
            SportGlovesVice = 18,
            [Description("Specialist Gloves | Fade")]
            SpecialistGlovesFade = 19,
            [Description("Sport Gloves | Omega")]
            SportGlovesOmega = 20,
            [Description("Hand Wraps | Cobalt Skulls")]
            HandWrapsCobaltSkulls = 21,
            [Description("Sport Gloves | Amphibious")]
            SportGlovesAmphibious = 22,
            [Description("Moto Gloves | POW!")]
            MotoGlovesPOW = 23,
            [Description("Driver Gloves | King Snake")]
            DriverGlovesKingSnake = 24,
            [Description("Specialist Gloves | Mogul")]
            SpecialistGlovesMogul = 25,
            [Description("Moto Gloves | Polygon")]
            MotoGlovesPolygon = 26,
            [Description("Moto Gloves | Turtle")]
            MotoGlovesTurtle = 27,
            [Description("Hand Wraps | Overprint")]
            HandWrapsOverprint = 28,
            [Description("Driver Gloves | Imperial Plaid")]
            DriverGlovesImperialPlaid = 29,
            [Description("Specialist Gloves | Crimson Web")]
            SpecialistGlovesCrimsonWeb = 30,
            [Description("Hydra Gloves | Mangrove")]
            HydraGlovesMangrove = 31,
            [Description("Hand Wraps | Arboreal")]
            HandWrapsArboreal = 32,
            [Description("Hydra Gloves | Emerald")]
            HydraGlovesEmerald = 33,
            [Description("Driver Gloves | Racing Green")]
            DriverGlovesRacingGreen = 34,
            [Description("Sport Gloves | Bronze Morph")]
            SportGlovesBronzeMorph = 35,
            [Description("Hydra Gloves | Rattler")]
            HydraGlovesRattler = 36,
            [Description("Driver Gloves | Overtake")]
            DriverGlovesOvertake = 37,
            [Description("Hydra Gloves | Case Hardened")]
            HydraGlovesCaseHardened = 38,
            [Description("Specialist Gloves | Buckshot")]
            SpecialistGlovesBuckshot = 39,
            [Description("Hand Wraps | Duct Tape")]
            HandWrapsDuctTape = 40,
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
