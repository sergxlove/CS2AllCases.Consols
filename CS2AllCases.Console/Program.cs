using CS2AllCases.Consols.UseCases;

namespace CS2AllCases.Consols
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            ExecuteCommandsCore cmd = new ExecuteCommandsCore();
            cmd.AddRange(ConsoleCases.UseConsoleCases());
            string str = string.Empty;
            bool exit = false;
            while(!exit)
            {
                Console.Write("user> ");
                str = Console.ReadLine()!;
                if (str == "exit") break;
                cmd.ExecuteCommand(str);
            }
        }
    }
}
