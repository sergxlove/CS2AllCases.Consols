using PropertyItems;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Security;

namespace CS2AllCases.Lib.Models
{
    public class SnakebiteCase
    {
        public SnakebiteCase(ProbabilitiesDropOptions? options = null)
        {
            options ??= new ProbabilitiesDropOptions();
            _options = options;
        }
        private readonly ProbabilitiesDropOptions _options;

        public const int QUANTITY_ARMY = 7; 
        public const int QUANTITY_FORBIDDEN = 5;
        public const int QUANTITY_CLASSIFIED = 3;
        public const int QUANTITY_SECRET = 2;
        public const int QUANTITY_RAREITEM = 24;

        public ResultsItems GetDrop()
        {
            ResultsItems result = new ResultsItems();
            Random random = new Random();
            int varRarity = random.Next(0, _options.MaxValueForRarity);
            int varQuality = random.Next(0, _options.MaxValueForQuality);
            int varStatrack = random.Next(0, _options.MaxValueForStatrack);
            string nameSkin = string.Empty;
            int varSkin;
            switch (varRarity)
            {
                case int s when (s >= 0 && s < _options.ProbabilityArmy):
                    varSkin = random.Next(0, QUANTITY_ARMY);
                    result.Name = GetSkinArmy(varSkin);
                    break;
                case int s when (s >= _options.ProbabilityArmy &&
                    s < _options.ValueTwoFirstRarity):
                    varSkin = random.Next(0, QUANTITY_FORBIDDEN);
                    result.Name = GetSkinForbidden(varSkin);
                    break;
                case int s when (s >= _options.ValueTwoFirstRarity &&
                    s < _options.ValueThreeFirstRarity):
                    varSkin = random.Next(0, QUANTITY_CLASSIFIED);
                    result.Name = GetSkinClassified(varSkin);
                    break;
                case int s when (s >= _options.ValueThreeFirstRarity &&
                    s < _options.ValueFourFirstRarity):
                    varSkin = random.Next(0, QUANTITY_SECRET);
                    result.Name = GetSkinSecret(varSkin);
                    break;
                case int s when (s >= _options.ValueFourFirstRarity &&
                    s < _options.ValueFiveFirstRarity):
                    varSkin = random.Next(0, QUANTITY_RAREITEM);
                    result.Name = GetSkinRareItem(varSkin);
                    break;
                default:
                    break;
            }
            result.Statrack = PropertyItems.PropertyItems.GetStatrack(_options, varStatrack);
            return result;
        }

        public enum SnakebiteCaseSkins
        {
            None = 0,
            [Description("UMP-45 Oscillator")]
            Ump45Oscillator = 1,
            [Description("Nova Windblown")]
            NovaWindblown = 2,
            [Description("M249 O.S.I.P.R")]
            M249OSIPR = 3,
            [Description("R8 Revolver Junk Yard")]
            R8RevolverJunkYard = 4,
            [Description("SG 553 Heavy Metal")]
            SG553HeavyMetal = 5,
            [Description("CZ75-Auto Circaetus")]
            CZ75AutoCircaetus = 6,
            [Description("Glock-18 Clear Polymer")]
            Glock18ClearPolymer = 7,
            [Description("Negev dev_texture")]
            NegevDevTexture = 8,
            [Description("MAC-10 Button Masher")]
            Mac10ButtonMasher = 9,
            [Description("P250 Cyber Shell")]
            P250CyberShell = 10,
            [Description("Desert Eagle Trigger Discipline")]
            DesertEagleTriggerDiscipline = 11,
            [Description("AK-47 Slate")]
            AK47Slate = 12,
            [Description("XM1014 XOXO")]
            XM1014XOXO = 13,
            [Description("Galil AR Chromatic Aberration")]
            GalilARChromaticAberration = 14,
            [Description("MP9 Food Chain")]
            MP9FoodChain = 15,
            [Description("M4A4 In Living Color")]
            M4A4InLivingColor = 16,
            [Description("USP-S The Traitor")]
            USPSTheTraitor = 17,
            [Description("Sport Gloves SlingShot")]
            SportGlovesSlingShot = 18,
            [Description("Driver Gloves Snow Leopard")]
            DriverGlovesSnowLeopard = 19,
            [Description("Specialist Gloves Marble Fade")]
            SpecialistGlovesMarbleFade = 20,
            [Description("Driver Gloves Black Tie")]
            DriverGlovesBlackTie = 21,
            [Description("Sport Gloves Scarlet Shamagh")]
            SportGlovesScarletShamagh = 22,
            [Description("Specialist Gloves Field Agent")]
            SpecialistGlovesFieldAgent = 23,
            [Description("Sport Gloves Nocts")]
            SportGlovesNocts = 24,
            [Description("Hand Wraps Caution")]
            HandWrapsCaution = 25,
            [Description("Specialist Gloves Tiger Strike")]
            SpecialistGlovesTigerStrike = 26,
            [Description("Moto Gloves Blood Pressure")]
            MotoGlovesBloodPressure = 27,
            [Description("Sport Gloves Big Game")]
            SportGlovesBigGame = 28,
            [Description("Specialist Gloves Lt. Commander")]
            SpecialistGlovesLtCommander = 29,
            [Description("Moto Gloves Finish Line")]
            MotoGlovesFinishLine = 30,
            [Description("Broken Fang Gloves Jade")]
            BrokenFangGlovesJade = 31,
            [Description("Driver Gloves Rezan the Red")]
            DriverGlovesRezanTheRed = 32,
            [Description("Driver Gloves Queen Jaguar")]
            DriverGlovesQueenJaguar = 33,
            [Description("Hand Wraps Desert Shamagh")]
            HandWrapsDesertShamagh = 34,
            [Description("Broken Fang Gloves Unhigned")]
            BrokenFangGlovesUnhigned = 35,
            [Description("Moto Gloves Snouk Out")]
            MotoGlovesSnoukOut = 36,
            [Description("Broken Fang Gloves Yellow-banded")]
            BrokenFangGlovesYellowBanded = 37,
            [Description("Hand Wraps Giraffe")]
            HandWrapsGiraffe = 38,
            [Description("Moto Gloves 3rd Commando Company")]
            MotoGloves3rdCommandoCompany = 39,
            [Description("Hand Wraps Constrictor")]
            HandWrapsConstrictor = 40,
            [Description("Broken Fang Gloves Needle Point")]
            BrokerFangGlovesNeedlePoint = 41
        }

        private string GetSkinArmy(int value)
        {
            switch (value)
            {
                case 0: return "UMP-45 Oscillator";
                case 1: return "Nova Windblown";
                case 2: return "M249 O.S.I.P.R";
                case 3: return "R8 Revolver Junk Yard";
                case 4: return "SG 553 Heavy Metal";
                case 5: return "CZ75-Auto Circaetus";
                case 6: return "Glock-18 Clear Polymer";
                default: return "None";
            }
        }

        private string GetSkinForbidden(int value)
        {
            switch (value)
            {
                case 0: return "Negev dev_texture";
                case 1: return "MAC-10 Button Masher";
                case 2: return "P250 Cyber Shell";
                case 3: return "Desert Eagle Trigger Discipline";
                case 4: return "AK-47 Slate";
                default: return "None";
            }
        }

        private string GetSkinClassified(int value)
        {
            switch (value)
            {
                case 0: return "XM1014 XOXO";
                case 1: return "Galil AR Chromatic Aberration";
                case 2: return "MP9 Food Chain";
                default: return "None";
            }
        }

        private string GetSkinSecret(int value)
        {
            switch (value)
            {
                case 0: return "M4A4 In Living Color";
                case 1: return "USP-S The Traitor";
                default: return "None";
            }
        }

        private string GetSkinRareItem(int value)
        {
            switch (value)
            {
                case 0: return "Sport Gloves SlingShot";
                case 1: return "Driver Gloves Snow Leopard";
                case 2: return "Specialist Gloves Marble Fade";
                case 3: return "Driver Gloves Black Tie";
                case 4: return "Sport Gloves Scarlet Shamagh";
                case 5: return "Specialist Gloves Field Agent";
                case 6: return "Sport Gloves Nocts";
                case 7: return "Hand Wraps Caution";
                case 8: return "Specialist Gloves Tiger Strike";
                case 9: return "Moto Gloves Blood Pressure";
                case 10: return "Sport Gloves Big Game";
                case 11: return "Specialist Gloves Lt. Commander";
                case 12: return "Moto Gloves Finish Line";
                case 13: return "Broken Fang Gloves Jade";
                case 14: return "Driver Gloves Rezan the Red";
                case 15: return "Driver Gloves Queen Jaguar";
                case 16: return "Hand Wraps Desert Shamagh";
                case 17: return "Broken Fang Gloves Unhigned";
                case 18: return "Moto Gloves Snouk Out";
                case 19: return "Broken Fang Gloves Yellow-banded";
                case 20: return "Hand Wraps Giraffe";
                case 21: return "Moto Gloves 3rd Commando Company";
                case 22: return "Hand Wraps Constrictor";
                case 23: return "Broken Fang Gloves Needle Point";
                default: return "None";
            }
        }
    }
}
