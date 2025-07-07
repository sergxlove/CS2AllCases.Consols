namespace CS2AllCases.Consols.Interfaces
{
    public interface ICommand
    {
        string Name { get; }
        string Description { get; }
        void Execute(string[] args, InventoryCore inventory);
    }
}
