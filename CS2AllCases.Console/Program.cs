using CS2AllCases.Lib.Abstractios;
using CS2AllCases.Lib.Models;

namespace CS2AllCases.Consols
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICases snakebiteCase = new GalleryCase();
            Console.WriteLine(snakebiteCase.GetNameSkinsAll());
            for (int i = 0; i < 100; i++)
            {
                var result = snakebiteCase.GetDrop();
                switch (result.Rarity)
                {
                    case PropertyItem.RarityItems.Army:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case PropertyItem.RarityItems.Forbidden:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        break;
                    case PropertyItem.RarityItems.Classified:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case PropertyItem.RarityItems.Secret:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                }
                Console.WriteLine(result);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
