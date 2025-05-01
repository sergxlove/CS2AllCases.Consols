using PropertyItem;

namespace CS2AllCases.Lib
{
    public class ResultsItems
    {
        public string Name { get; set; } = string.Empty;

        public RarityItems Rarity { get; set; } = RarityItems.None;

        public QualityItems Quality { get; set; } = QualityItems.None;

        public StatrackItems Statrack { get; set; } = StatrackItems.No;

        public SouvenirItems Souvenir { get; set; } = SouvenirItems.No;

        public override string ToString()
        {
            string result = Name + " | " + Rarity + "/" + Quality;
            if (Statrack == StatrackItems.Yes) result += " Statrack";
            if (Souvenir == SouvenirItems.Yes) result += " Souvenir";
            return result;
        }
    }
}
