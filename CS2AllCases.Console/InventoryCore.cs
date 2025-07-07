using CS2AllCases.Lib;
using CS2AllCases.Lib.Abstractios;

namespace CS2AllCases.Consols
{
    public class InventoryCore
    {
        public ICases? SelectedCase { get; set; }

        public Dictionary<string, int> Skins { get; set; } = [];
    }
}
