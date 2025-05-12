using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Contracts;
using PropertyItem;
using System.ComponentModel;

namespace CS2AllCases.Lib.Models
{
    public class OperationBrokenFangCase : ICases
    {
        public OperationBrokenFangCase(ProbabilitiesDropOptions? options = null)
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
            [Description("P90 | Cocoa Rampage")]
            P90CocoaRampage = 1,
            [Description("P250 | Contaminant")]
            P250Contaminant = 2,
            [Description("MP5-SD | Condition Zero")]
            MP5SDConditionZero = 3,
            [Description("M249 | Deep Relief")]
            M249DeepRelief = 4,
            [Description("Galil AR | Vandal")]
            GalilARVandal = 5,
            [Description("G3SG1 | Digital Mesh")]
            G3SG1DigitalMesh = 6,
            [Description("CZ75-Auto | Vendetta")]
            CZ75AutoVendetta = 7,
            [Description("UMP-45 | Gold Bismuth")]
            UMP45GoldBismuth = 8,
            [Description("SSG 08 | Parallax")]
            SSG08Parallax = 9,
            [Description("Nova | Clear Polymer")]
            NovaClearPolymer = 10,
            [Description("Dual Berettas | Dezastre")]
            DualBerettasDezastre = 11,
            [Description("AWP | Exoskeleton")]
            AWPExoskeleton = 12,
            [Description("USP-S | Monster Mashup")]
            USPSMonsterMashup = 13,
            [Description("M4A4 | Cyber Security")]
            M4A4CyberSecurity = 14,
            [Description("Five-SeveN | Fairy Tale")]
            FiveSevenFairyTale = 15,
            [Description("Glock-18 | Neo-Noir")]
            Glock18NeoNoir = 16,
            [Description("M4A1-S | Printstream")]
            M4A1SPrintstream = 17,
            [Description("Sport Gloves | Nocts")]
            SportGlovesNocts = 18,
            [Description("Specialist Gloves | Marble Fade")]
            SpecialistGlovesMarbleFade = 19,
            [Description("Driver Gloves | Snow Leopard")]
            DriverGlovesSnowLeopard = 20,
            [Description("Sport Gloves | Big Game")]
            SportGlovesBigGame = 21,
            [Description("Hand Wraps | CAUTION!")]
            HandWrapsCAUTION = 22,
            [Description("Moto Gloves | Blood Pressure")]
            MotoGlovesBloodPressure = 23,
            [Description("Sport Gloves | Slingshot")]
            SportGlovesSlingshot = 24,
            [Description("Specialist Gloves | Lt. Commander")]
            SpecialistGlovesLtCommander = 25,
            [Description("Specialist Gloves | Tiger Strike")]
            SpecialistGlovesTigerStrike = 26,
            [Description("Moto Gloves | Finish Line")]
            MotoGlovesFinishLine = 27,
            [Description("Broken Fang Gloves | Jade")]
            BrokenFangGlovesJade = 28,
            [Description("Driver Gloves | Rezan the Red")]
            DriverGlovesRezanTheRed = 29,
            [Description("Sport Gloves | Scarlet Shamagh")]
            SportGlovesScarletShamagh = 30,
            [Description("Specialist Gloves | Field Agent")]
            SpecialistGlovesFieldAgent = 31,
            [Description("Driver Gloves | Black Tie")]
            DriverGlovesBlackTie = 32,
            [Description("Driver Gloves | Queen Jaguar")]
            DriverGlovesQueenJaguar = 33,
            [Description("Hand Wraps | Desert Shamagh")]
            HandWrapsDesertShamagh = 34,
            [Description("Broken Fang Gloves | Unhinged")]
            BrokenFangGlovesUnhinged = 35,
            [Description("Broken Fang Gloves | Yellow-banded")]
            BrokenFangGlovesYellowBanded = 36,
            [Description("Moto Gloves | Smoke Out")]
            MotoGlovesSmokeOut = 37,
            [Description("Hand Wraps | Giraffe")]
            HandWrapsGiraffe = 38,
            [Description("Moto Gloves | 3rd Commando Company")]
            MotoGloves3rdCommandoCompany = 39,
            [Description("Hand Wraps | Constrictor")]
            HandWrapsConstrictor = 40,
            [Description("Broken Fang Gloves | Needle Point")]
            BrokenFangGlovesNeedlePoint = 41
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
