using CS2AllCases.Consols.UseCases;
using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Models;

namespace CS2AllCases.Consols
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            ExecuteCommandsCore cmd = new ExecuteCommandsCore();
            InventoryCore inventory = new InventoryCore();
            cmd.AddRange(ConsoleCases.UseConsoleCases());
            cmd.AddRange(OpenCases.UseOpenCases());
            string str = string.Empty;
            bool exit = false;
            while(!exit)
            {
                Console.Write("user> ");
                str = Console.ReadLine()!;
                if (str == "exit") break;
                cmd.ExecuteCommand(str, inventory);
            }
        }
    }
}
