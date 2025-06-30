using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class OperationHydraCase : ICases
    {
        public OperationHydraCase(ProbabilitiesDropOptions? options = null)
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
            [Description("USP-S | Blueprint")]
            USPSBlueprint = 1,
            [Description("UMP-45 | Metal Flowers")]
            UMP45MetalFlowers = 2,
            [Description("Tec-9 | Cut Out")]
            Tec9CutOut = 3,
            [Description("MAG-7 | Hard Water")]
            MAG7HardWater = 4,
            [Description("MAC-10 | Aloha")]
            MAC10Aloha = 5,
            [Description("M4A1-S | Briefing")]
            M4A1SBriefing = 6,
            [Description("FAMAS | Macabre")]
            FAMASMacabre = 7,
            [Description("SSG 08 | Death's Head")]
            SSG08DeathsHead = 8,
            [Description("P90 | Death Grip")]
            P90DeathGrip = 9,
            [Description("P250 | Red Rock")]
            P250RedRock = 10,
            [Description("P2000 | Woodsman")]
            P2000Woodsman = 11,
            [Description("AK-47 | Orbit Mk01")]
            AK47OrbitMk01 = 12,
            [Description("M4A4 | Hellfire")]
            M4A4Hellfire = 13,
            [Description("Galil AR | Sugar Rush")]
            GalilARSugarRush = 14,
            [Description("Dual Berettas | Cobra Strike")]
            DualBerettasCobraStrike = 15,
            [Description("Five-SeveN | Hyper Beast")]
            FiveSevenHyperBeast = 16,
            [Description("AWP | Oni Taiji")]
            AWPOniTaiji = 17,
            [Description("Sport Gloves | Pandora's Box")]
            SportGlovesPandorasBox = 18,
            [Description("Sport Gloves | Hedge Maze")]
            SportGlovesHedgeMaze = 19,
            [Description("Moto Gloves | Spearmint")]
            MotoGlovesSpearmint = 20,
            [Description("Sport Gloves | Superconductor")]
            SportGlovesSuperconductor = 21,
            [Description("Specialist Gloves | Crimson Kimono")]
            SpecialistGlovesCrimsonKimono = 22,
            [Description("Specialist Gloves | Emerald Web")]
            SpecialistGlovesEmeraldWeb = 23,
            [Description("Sport Gloves | Arid")]
            SportGlovesArid = 24,
            [Description("Moto Gloves | Cool Mint")]
            MotoGlovesCoolMint = 25,
            [Description("Driver Gloves | Lunar Weave")]
            DriverGlovesLunarWeave = 26,
            [Description("Specialist Gloves | Foundation")]
            SpecialistGlovesFoundation = 27,
            [Description("Specialist Gloves | Forest DDPAT")]
            SpecialistGlovesForestDDPAT = 28,
            [Description("Bloodhound Gloves | Charred")]
            BloodhoundGlovesCharred = 29,
            [Description("Hand Wraps | Spruce DDPAT")]
            HandWrapsSpruceDDPAT = 30,
            [Description("Hand Wraps | Slaughter")]
            HandWrapsSlaughter = 31,
            [Description("Driver Gloves | Crimson Weave")]
            DriverGlovesCrimsonWeave = 32,
            [Description("Hand Wraps | Badlands")]
            HandWrapsBadlands = 33,
            [Description("Moto Gloves | Boom!")]
            MotoGlovesBoom = 34,
            [Description("Driver Gloves | Diamondback")]
            DriverGlovesDiamondback = 35,
            [Description("Moto Gloves | Eclipse")]
            MotoGlovesEclipse = 36,
            [Description("Hand Wraps | Leather")]
            HandWrapsLeather = 37,
            [Description("Driver Gloves | Convoy")]
            DriverGlovesConvoy = 38,
            [Description("Bloodhound Gloves | Snakebite")]
            BloodhoundGlovesSnakebite = 39,
            [Description("Bloodhound Gloves | Bronzed")]
            BloodhoundGlovesBronzed = 40,
            [Description("Bloodhound Gloves | Guerrilla")]
            BloodhoundGlovesGuerrilla = 41
        }

        private List<Skins> SkinsArmy =
        [
            Skins.USPSBlueprint,
            Skins.UMP45MetalFlowers,
            Skins.Tec9CutOut,
            Skins.MAG7HardWater,
            Skins.MAC10Aloha,
            Skins.M4A1SBriefing,
            Skins.FAMASMacabre
        ];

        private List<Skins> SkinsForbidden =
        [
            Skins.SSG08DeathsHead,
            Skins.P90DeathGrip,
            Skins.P250RedRock,
            Skins.P2000Woodsman,
            Skins.AK47OrbitMk01
        ];

        private List<Skins> SkinsClassified =
        [
            Skins.M4A4Hellfire,
            Skins.GalilARSugarRush, 
            Skins.DualBerettasCobraStrike
        ];

        private List<Skins> SkinsSecret =
        [
            Skins.FiveSevenHyperBeast,
            Skins.AWPOniTaiji
        ];

        private List<Skins> SkinsRareItem =
        [
            Skins.SportGlovesPandorasBox,
            Skins.SportGlovesHedgeMaze,
            Skins.MotoGlovesSpearmint,
            Skins.SportGlovesSuperconductor,
            Skins.SpecialistGlovesCrimsonKimono,
            Skins.SpecialistGlovesEmeraldWeb,
            Skins.SportGlovesArid,
            Skins.MotoGlovesCoolMint,
            Skins.DriverGlovesLunarWeave,
            Skins.SpecialistGlovesFoundation,
            Skins.SpecialistGlovesForestDDPAT,
            Skins.BloodhoundGlovesCharred,
            Skins.HandWrapsSpruceDDPAT,
            Skins.HandWrapsSlaughter,
            Skins.DriverGlovesCrimsonWeave,
            Skins.HandWrapsBadlands,
            Skins.MotoGlovesBoom,
            Skins.DriverGlovesDiamondback,
            Skins.MotoGlovesEclipse,
            Skins.HandWrapsLeather,
            Skins.DriverGlovesConvoy,
            Skins.BloodhoundGlovesSnakebite,
            Skins.BloodhoundGlovesBronzed,
            Skins.BloodhoundGlovesGuerrilla
        ];
    }
}
