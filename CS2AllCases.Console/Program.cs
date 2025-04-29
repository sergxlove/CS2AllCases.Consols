using CS2AllCases.Lib.Models;

namespace CS2AllCases.Consols
{
    public class Program
    {
        static void Main(string[] args)
        {
            SnakebiteCase snakebiteCase = new SnakebiteCase();
            var result = snakebiteCase.GetDrop();
            Console.WriteLine(result);
        }
    }
}
