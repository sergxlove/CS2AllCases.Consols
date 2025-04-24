using CS2AllCases.Lib;

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
