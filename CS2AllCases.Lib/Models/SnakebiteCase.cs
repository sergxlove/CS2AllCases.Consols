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



        public ResultsItems GetDrop()
        {
            ResultsItems result = new ResultsItems();
            
            return result;
        }

    }


}
