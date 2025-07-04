using CS2AllCases.Consols.Interfaces;
using System.ComponentModel.Design;
using System.Threading.Channels;

namespace CS2AllCases.Consols.UseCases
{
    public class ConsoleCases
    {
        public static ICommand[] UseConsoleCases()
        {
            ICommand[] command =
            {
                new GetVersionCommand(),
                new GetDeveloper()
            };
            return command;
        }
    }

    public class GetVersionCommand : ICommand
    {
        public string Name => "version";
        public string Description => "\n" +
                        "Структура: [command] [argument] [parameter]\n" +
                        "Отвечает за вывод текущей версии приложения\n" +
                        "Аргументы: \n";
        public void Execute(string[] args)
        {
            Console.WriteLine("\n" +
                "Версия 1.0.0, developer sergxlove, 2025\n" +
                "Все права защищены\n");
        }
    }

    public class GetDeveloper : ICommand
    {
        public string Name => "developer";

        public string Description => "";

        public void Execute(string[] args)
        {
            Console.WriteLine("\n" +
                "╔══╗╔═══╗╔═══╗╔═══╗╔══╗╔══╗╔╗──╔══╗╔╗╔╗╔═══╗\n" +
                "║╔═╝║╔══╝║╔═╗║║╔══╝╚═╗║║╔═╝║║──║╔╗║║║║║║╔══╝\n" +
                "║╚═╗║╚══╗║╚═╝║║║╔═╗──║╚╝║──║║──║║║║║║║║║╚══╗\n" +
                "╚═╗║║╔══╝║╔╗╔╝║║╚╗║──║╔╗║──║║──║║║║║╚╝║║╔══╝\n" +
                "╔═╝║║╚══╗║║║║─║╚═╝║╔═╝║║╚═╗║╚═╗║╚╝║╚╗╔╝║╚══╗\n" +
                "╚══╝╚═══╝╚╝╚╝─╚═══╝╚══╝╚══╝╚══╝╚══╝─╚╝─╚═══╝\n");
        }
    }


}
