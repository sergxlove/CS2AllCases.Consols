using CS2AllCases.Lib.Contracts;

namespace CS2AllCases.Lib
{
    public class ProbabilitiesDropOptions
    {
        public ProbabilitiesDropOptions(RarityRequest? rarityRequest = null, 
            QualityRequest? qualityRequest = null,
            StatrackRequest? statrackRequest = null)
        {
            rarityRequest ??= new RarityRequest();
            qualityRequest ??= new QualityRequest();
            statrackRequest ??= new StatrackRequest();

            ProbabilityArmy = rarityRequest.ProbabilityArmy;
            ProbabilityForbidden = rarityRequest.ProbabilityForbidden;
            ProbabilityClassified = rarityRequest.ProbabilityClassified;
            ProbabilitySecret = rarityRequest.ProbabilitySecret;
            ProbabilityRareItem = rarityRequest.ProbabilityRareItem;

            ProbabilityBattleHardeend = qualityRequest.ProbabilityBattleHardeend;
            ProbabilityWorn = qualityRequest.ProbabilityWorn;
            ProbabilityAfterFieldTesting = qualityRequest.ProbabilityAfterFieldTesting;
            ProbabilitySlightlyWorn = qualityRequest.ProbabilitySlightlyWorn;
            ProbabilityStraightFromTheFactory = qualityRequest.ProbabilityStraightFromTheFactory;

            ProbabilityStatrack = statrackRequest.ProbabilityStatrack;
            ProbabilityNoStatrack = statrackRequest.ProbabilityNoStatrack;
        }
        public int ProbabilityArmy { get; set; }

        public int ProbabilityForbidden { get; set; }

        public int ProbabilityClassified { get; set; }

        public int ProbabilitySecret { get; set; }

        public int ProbabilityRareItem { get; set; }

        public int ProbabilityBattleHardeend { get; set; }

        public int ProbabilityWorn { get; set; }

        public int ProbabilityAfterFieldTesting { get; set; }

        public int ProbabilitySlightlyWorn { get; set; } 

        public int ProbabilityStraightFromTheFactory { get; set; } 

        public int ProbabilityStatrack {  get; set; } 

        public int ProbabilityNoStatrack { get; set; } 

        public int MaxValueForRarity
        {
            get
            {
                return ProbabilityArmy + ProbabilityForbidden + 
                    ProbabilityClassified + ProbabilitySecret + ProbabilityRareItem;
            }
        }

        public int MaxValueForQuality
        {
            get
            {
                return ProbabilityBattleHardeend + ProbabilityWorn + ProbabilityAfterFieldTesting
                    + ProbabilitySlightlyWorn + ProbabilityStraightFromTheFactory;
            }
        }

        public int MaxValueForStatrack
        {
            get
            {
                return ProbabilityStatrack + ProbabilityNoStatrack;
            }
        }

        public int ValueTwoFirstRarity
        {
            get
            {
                return ProbabilityArmy + ProbabilityForbidden;
            }
        }

        public int ValueThreeFirstRarity
        {
            get
            {
                return ProbabilityArmy + ProbabilityForbidden + ProbabilityClassified;
            }
        }

        public int ValueFourFirstRarity
        {
            get
            {
                return ProbabilityArmy + ProbabilityForbidden + ProbabilityClassified
                    + ProbabilitySecret;
            }
        }

        public int ValueFiveFirstRarity
        {
            get
            {
                return ProbabilityArmy + ProbabilityForbidden + ProbabilityClassified
                    + ProbabilitySecret + ProbabilityRareItem;
            }
        }

        public int ValueTwoFirstQuality
        {
            get
            {
                return ProbabilityBattleHardeend + ProbabilityWorn;
            }
        }

        public int ValueThreeFirstQuality
        {
            get
            {
                return ProbabilityBattleHardeend + ProbabilityWorn + ProbabilityAfterFieldTesting;
            }
        }

        public int ValueFourFirstQuality
        {
            get
            {
                return ProbabilityBattleHardeend + ProbabilityWorn + ProbabilityAfterFieldTesting
                    + ProbabilitySlightlyWorn;
            }
        }

        public int ValueFiveFirstQuality
        {
            get
            {
                return ProbabilityBattleHardeend + ProbabilityWorn + ProbabilityAfterFieldTesting
                    + ProbabilitySlightlyWorn + ProbabilityStraightFromTheFactory;
            }
        }
    
    }
}
