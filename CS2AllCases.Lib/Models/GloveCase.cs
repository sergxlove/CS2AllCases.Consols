using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class GloveCase : ICases
    {
        public GloveCase(ProbabilitiesDropOptions? options = null)
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
            [Description("P2000 | Turf")]
            P2000Turf = 1,
            [Description("MP9 | Sand Scale")]
            MP9SandScale = 2,
            [Description("MP7 | Cirrus")]
            MP7Cirrus = 3,
            [Description("MAG-7 | Sonar")]
            MAG7Sonar = 4,
            [Description("Glock-18 | Ironwork")]
            Glock18Ironwork = 5,
            [Description("Galil AR | Black Sand")]
            GalilARBlackSand = 6,
            [Description("CZ75-Auto | Polymer")]
            CZ75AutoPolymer = 7,
            [Description("USP-S | Cyrex")]
            USPSCyrex = 8,
            [Description("Nova | Gila")]
            NovaGila = 9,
            [Description("M4A1-S | Flashback")]
            M4A1SFlashback = 10,
            [Description("G3SG1 | Stinger")]
            G3SG1Stinger = 11,
            [Description("Dual Berettas | Royal Consorts")]
            DualBerettasRoyalConsorts = 12,
            [Description("Sawed-Off | Wasteland Princess")]
            SawedOffWastelandPrincess = 13,
            [Description("P90 | Shallow Grave")]
            P90ShallowGrave = 14,
            [Description("FAMAS | Mecha Industries")]
            FAMASMechaIndustries = 15,
            [Description("SSG 08 | Dragonfire")]
            SSG08Dragonfire = 16,
            [Description("M4A4 | Buzz Kill")]
            M4A4BuzzKill = 17,
            [Description("Sport Gloves | Hedge Maze")]
            SportGlovesHedgeMaze = 18,
            [Description("Sport Gloves | Pandora's Box")]
            SportGlovesPandorasBox = 19,
            [Description("Sport Gloves | Superconductor")]
            SportGlovesSuperconductor = 20,
            [Description("Specialist Gloves | Crimson Kimono")]
            SpecialistGlovesCrimsonKimono = 21,
            [Description("Moto Gloves | Spearmint")]
            MotoGlovesSpearmint = 22,
            [Description("Specialist Gloves | Emerald Web")]
            SpecialistGlovesEmeraldWeb = 23,
            [Description("Specialist Gloves | Foundation")]
            SpecialistGlovesFoundation = 24,
            [Description("Driver Gloves | Lunar Weave")]
            DriverGlovesLunarWeave = 25,
            [Description("Hand Wraps | Slaughter")]
            HandWrapsSlaughter = 26,
            [Description("Hand Wraps | Spruce DDPAT")]
            HandWrapsSpruceDDPAT = 27,
            [Description("Specialist Gloves | Forest DDPAT")]
            SpecialistGlovesForestDDPAT = 28,
            [Description("Bloodhound Gloves | Charred")]
            BloodhoundGlovesCharred = 29,
            [Description("Moto Gloves | Cool Mint")]
            MotoGlovesCoolMint = 30,
            [Description("Sport Gloves | Arid")]
            SportGlovesArid = 31,
            [Description("Hand Wraps | Badlands")]
            HandWrapsBadlands = 32,
            [Description("Hand Wraps | Leather")]
            HandWrapsLeather = 33,
            [Description("Moto Gloves | Boom!")]
            MotoGlovesBoom = 34,
            [Description("Driver Gloves | Diamondback")]
            DriverGlovesDiamondback = 35,
            [Description("Driver Gloves | Crimson Weave")]
            DriverGlovesCrimsonWeave = 36,
            [Description("Moto Gloves | Eclipse")]
            MotoGlovesEclipse = 37,
            [Description("Bloodhound Gloves | Bronzed")]
            BloodhoundGlovesBronzed = 38,
            [Description("Driver Gloves | Convoy")]
            DriverGlovesConvoy = 39,
            [Description("Bloodhound Gloves | Snakebite")]
            BloodhoundGlovesSnakebite = 40,
            [Description("Bloodhound Gloves | Guerrilla")]
            BloodhoundGlovesGuerrilla = 41
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
