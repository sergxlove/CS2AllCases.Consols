using CS2AllCases.Lib;
using CS2AllCases.Lib.Contracts;
using System.ComponentModel;
using System.Reflection;

namespace PropertyItems
{
    public class PropertyItems
    {
        public static QualityItems GetQuality(ProbabilitiesDropOptions options, int value)
        {
            switch (value)
            {
                case int s when (s >= 0 && s < options.ProbabilityBattleHardeend):
                    return QualityItems.BattleHardened;
                case int s when (s >= options.ProbabilityBattleHardeend &&
                    s < options.ValueTwoFirstQuality):
                    return QualityItems.Worn;
                case int s when (s >= options.ValueTwoFirstQuality &&
                    s < options.ValueThreeFirstQuality):
                    return QualityItems.AfterFieldTesting;
                case int s when (s >= options.ValueThreeFirstQuality &&
                    s < options.ValueFourFirstQuality):
                    return QualityItems.SlightlyWorn;
                case int s when (s >= options.ValueFourFirstQuality &&
                    s < options.ValueFiveFirstQuality):
                    return QualityItems.StraightFromTheFactory;
                default:
                    return QualityItems.None;
            }
        }

        public static StatrackItems GetStatrack(ProbabilitiesDropOptions options, int value)
        {
            switch (value)
            {
                case int s when (s >= 0 && s < options.ProbabilityStatrack):
                    return StatrackItems.Yes;
                case int s when (s>=options.ProbabilityStatrack && s < 
                    options.ProbabilityStatrack + options.ProbabilityNoStatrack):
                    return StatrackItems.No;
                default:
                    return StatrackItems.No;
            }
        }

        public static ResultsItems GetDrop<T>(ProbabilitiesDropOptions options, 
            ListSkinsRequest<T> skins)
        {
            ResultsItems result = new ResultsItems();
            Random random = new Random();
            int varRarity = random.Next(0, options.MaxValueForRarity);
            int varQuality = random.Next(0, options.MaxValueForQuality);
            int varStatrack = random.Next(0, options.MaxValueForStatrack);
            string nameSkin = string.Empty;
            int varSkin;
            switch (varRarity)
            {
                case int s when (s >= 0 && s < options.ProbabilityArmy):
                    varSkin = random.Next(0, skins.QuantityaArmy);
                    result.Name = GetSkinString<T>(skins.SkinsArmy[varSkin]);
                    result.Rarity = RarityItems.Army;
                    break;
                case int s when (s >= options.ProbabilityArmy &&
                    s < options.ValueTwoFirstRarity):
                    varSkin = random.Next(0, skins.QuantityForbidden);
                    result.Name = GetSkinString<T>(skins.SkinsForbidden[varSkin]);
                    result.Rarity = RarityItems.Forbidden;
                    break;
                case int s when (s >= options.ValueTwoFirstRarity &&
                    s < options.ValueThreeFirstRarity):
                    varSkin = random.Next(0, skins.QuantityClassified);
                    result.Name = GetSkinString<T>(skins.SkinsClassified[varSkin]);
                    result.Rarity = RarityItems.Classified;
                    break;
                case int s when (s >= options.ValueThreeFirstRarity &&
                    s < options.ValueFourFirstRarity):
                    varSkin = random.Next(0, skins.QuantitySecret);
                    result.Name = GetSkinString<T>(skins.SkinsSecret[varSkin]);
                    result.Rarity = RarityItems.Secret;
                    break;
                case int s when (s >= options.ValueFourFirstRarity &&
                    s < options.ValueFiveFirstRarity):
                    varSkin = random.Next(0, skins.QuantityRareItem);
                    result.Name = GetSkinString<T>(skins.SkinsRareItem[varSkin]);
                    result.Rarity = RarityItems.Secret;
                    break;
                default:
                    break;
            }
            result.Quality = GetQuality(options, varQuality);
            result.Statrack = GetStatrack(options, varStatrack);
            return result;
        }

        public static string GetSkinString<T>(T value)
        {
            FieldInfo field = value!.GetType().GetField(value.ToString()!)!;
            DescriptionAttribute attribute = field?.GetCustomAttribute<DescriptionAttribute>()!;
            return attribute?.Description ?? value.ToString()!;
        }
    }
    public enum RarityItems
    {
        Crap = 0,
        Industrial = 1,
        Army = 2,
        Forbidden = 3,
        Classified = 4,
        Secret = 5,
        None = 6
    }

    public enum QualityItems
    {
        BattleHardened = 0,
        Worn = 1,
        AfterFieldTesting = 2,
        SlightlyWorn = 3,
        StraightFromTheFactory = 4,
        None = 5
    }

    public enum StatrackItems
    {
        No = 0,
        Yes = 1
    }

    public enum SouvenirItems
    {
        No = 0,
        Yes = 1
    }
}
