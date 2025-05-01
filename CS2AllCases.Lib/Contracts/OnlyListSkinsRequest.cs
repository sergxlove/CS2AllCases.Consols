namespace CS2AllCases.Lib.Contracts
{
    public class OnlyListSkinsRequest<T>
    {
        public List<T> SkinsArmy { get; set; } = [];
        public List<T> SkinsForbidden { get; set; } = [];
        public List<T> SkinsClassified { get; set; } = [];
        public List<T> SkinsSecret { get; set; } = [];
        public List<T> SkinsRareItem { get; set; } = [];
    }
}
