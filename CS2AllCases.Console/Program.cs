using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Models;

namespace CS2AllCases.Consols
{
    public class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i< 100;i++)
            {
                ICases snakebiteCase = new GalleryCase();
                var result = snakebiteCase.GetDrop();
                switch(result.Rarity)
                {
                    case PropertyItems.RarityItems.Army:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case PropertyItems.RarityItems.Forbidden:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        break;
                    case PropertyItems.RarityItems.Classified:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case PropertyItems.RarityItems.Secret:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                }
                Console.WriteLine(result);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
