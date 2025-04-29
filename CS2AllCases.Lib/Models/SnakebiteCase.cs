using CS2AllCases.Lib.Abstractios;
using PropertyItems;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace CS2AllCases.Lib.Models
{
    public class SnakebiteCase : ICases
    {
        public SnakebiteCase(ProbabilitiesDropOptions? options = null)
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
                    varSkin = random.Next(0, QuantityaArmy);
                    result.Name = GetSkinString(SkinsArmy[varSkin]);
                    result.Rarity = RarityItems.Army;
                    break;
                case int s when (s >= _options.ProbabilityArmy &&
                    s < _options.ValueTwoFirstRarity):
                    varSkin = random.Next(0, QuantityForbidden);
                    result.Name = GetSkinString(SkinsForbidden[varSkin]);
                    result.Rarity = RarityItems.Forbidden;
                    break;
                case int s when (s >= _options.ValueTwoFirstRarity &&
                    s < _options.ValueThreeFirstRarity):
                    varSkin = random.Next(0, QuantityClassified);
                    result.Name = GetSkinString(SkinsClassified[varSkin]);
                    result.Rarity = RarityItems.Classified;
                    break;
                case int s when (s >= _options.ValueThreeFirstRarity &&
                    s < _options.ValueFourFirstRarity):
                    varSkin = random.Next(0, QuantitySecret);
                    result.Name = GetSkinString(SkinsSecret[varSkin]);
                    result.Rarity = RarityItems.Secret;
                    break;
                case int s when (s >= _options.ValueFourFirstRarity &&
                    s < _options.ValueFiveFirstRarity):
                    varSkin = random.Next(0, QuantityRareItem);
                    result.Name = GetSkinString(SkinsRareItem[varSkin]);
                    result.Rarity = RarityItems.Secret;
                    break;
                default:
                    break;
            }
            result.Quality = PropertyItems.PropertyItems.GetQuality(_options, varQuality);
            result.Statrack = PropertyItems.PropertyItems.GetStatrack(_options, varStatrack);
            return result;
        }

        public enum Skins
        {
            [Description("None")]
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

        public static string GetSkinString(Skins value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString())!;
            DescriptionAttribute attribute = field?.GetCustomAttribute<DescriptionAttribute>()!;
            return attribute?.Description ?? value.ToString();
        }

        public string GetNameSkinsAll(bool IsSkinArmy = false, bool isSkinForbidden = false,
            bool isSkinClassified = false, bool isSkinSecret = false, bool isSkinRareItem = false)
        {
            StringBuilder result = new StringBuilder();
            if (IsSkinArmy)
            {
                foreach (var item in SkinsArmy)
                {
                    result.Append($"{GetSkinString(item)} \n");
                }
            }
            if (isSkinForbidden)
            {
                foreach (var item in SkinsForbidden)
                {
                    result.Append($"{GetSkinString(item)} \n");
                }
            }
            if (isSkinClassified)
            {
                foreach (var item in SkinsClassified)
                {
                    result.Append($"{GetSkinString(item)} \n");
                }
            }
            if (isSkinSecret)
            {
                foreach (var item in SkinsSecret)
                {
                    result.Append($"{GetSkinString(item)} \n");
                }
            }
            if (isSkinRareItem)
            {
                foreach (var item in SkinsRareItem)
                {
                    result.Append($"{GetSkinString(item)} \n");
                }
            }
            return result.ToString();
        }

        public string GetNameSkinsAll()
        {
            return GetNameSkinsAll(true, true, true, true, true);
        }


        private List<Skins> SkinsArmy =
        [
            Skins.Ump45Oscillator,
            Skins.NovaWindblown,
            Skins.M249OSIPR,
            Skins.R8RevolverJunkYard,
            Skins.SG553HeavyMetal,
            Skins.CZ75AutoCircaetus,
            Skins.Glock18ClearPolymer
        ];

        private List<Skins> SkinsForbidden =
        [
            Skins.NegevDevTexture,
            Skins.Mac10ButtonMasher,
            Skins.P250CyberShell,
            Skins.DesertEagleTriggerDiscipline,
            Skins.AK47Slate
        ];

        private List<Skins> SkinsClassified =
        [
            Skins.XM1014XOXO,
            Skins.GalilARChromaticAberration,
            Skins.MP9FoodChain
        ];

        private List<Skins> SkinsSecret =
        [
            Skins.M4A4InLivingColor,
            Skins.USPSTheTraitor
        ];

        private List<Skins> SkinsRareItem =
        [
            Skins.SportGlovesSlingShot,
            Skins.DriverGlovesSnowLeopard,
            Skins.SpecialistGlovesMarbleFade,
            Skins.DriverGlovesBlackTie,
            Skins.SportGlovesScarletShamagh,
            Skins.SpecialistGlovesFieldAgent,
            Skins.SportGlovesNocts,
            Skins.HandWrapsCaution,
            Skins.SpecialistGlovesTigerStrike,
            Skins.MotoGlovesBloodPressure,
            Skins.SportGlovesBigGame,
            Skins.SpecialistGlovesLtCommander,
            Skins.MotoGlovesFinishLine,
            Skins.BrokenFangGlovesJade,
            Skins.DriverGlovesRezanTheRed,
            Skins.DriverGlovesQueenJaguar,
            Skins.HandWrapsDesertShamagh,
            Skins.BrokenFangGlovesUnhigned,
            Skins.MotoGlovesSnoukOut,
            Skins.BrokenFangGlovesYellowBanded,
            Skins.HandWrapsGiraffe,
            Skins.MotoGloves3rdCommandoCompany,
            Skins.HandWrapsConstrictor,
            Skins.BrokerFangGlovesNeedlePoint
        ];
    }
}
