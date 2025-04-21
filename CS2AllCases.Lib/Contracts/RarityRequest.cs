namespace CS2AllCases.Lib.Contracts
{
    public class RarityRequest
    {
        public int ProbabilityArmy { get; set; } = 750;
        public int ProbabilityForbidden { get; set; } = 150;
        public int ProbabilityClassified { get; set; } = 85;
        public int ProbabilitySecret { get; set; } = 10;
        public int ProbabilityRareItem { get; set; } = 5;
    }
}
