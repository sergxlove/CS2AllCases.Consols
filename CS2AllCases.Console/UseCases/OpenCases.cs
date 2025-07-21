using CS2AllCases.Consols.Interfaces;
using CS2AllCases.Lib;
using CS2AllCases.Lib.Models;
using System.ComponentModel;
using System.Reflection;

namespace CS2AllCases.Consols.UseCases
{
    public class OpenCases
    {
        public static ICommand[] UseOpenCases()
        {
            ICommand[] command =
            {
                new GetNameCases(),
                new SelectCase(),
                new OpenCase(),
                new GetSkins()
            };
            return command;
        }

        public static CasesEnum SelectedCase { get; set; }
    }

    public class GetNameCases : ICommand
    {
        public string Name => "cases";

        public string Description => "\n" +
                        "Структура: [command] [argument] \n" +
                        "Отвечает за вывод названий всей кейсов\n" +
                        "Аргументы: \n";

        public void Execute(string[] args, InventoryCore inventory)
        {
            var values = Enum.GetValues(typeof(CasesEnum));
            foreach (var value in values)
            {
                Console.WriteLine($"{(int)value} - {GetSkinString<CasesEnum>((CasesEnum)value)}");
            }
        }

        public static string GetSkinString<T>(T value)
        {
            FieldInfo field = value!.GetType().GetField(value.ToString()!)!;
            DescriptionAttribute attribute = field?.GetCustomAttribute<DescriptionAttribute>()!;
            return attribute?.Description ?? value.ToString()!;
        }
    }

    public class SelectCase : ICommand
    {
        public string Name => "select";

        public string Description => "\n" +
                        "Структура: [command] [argument] \n" +
                        "Отвечает за выбор кейса\n" +
                        "Аргументы: \n";

        public void Execute(string[] args, InventoryCore inventory)
        {
            if (args.Length == 0) Console.WriteLine("Invalid argumentss");
            try
            {
                CasesEnum selectCase = (CasesEnum)Convert.ToInt32(args[0]);
                switch(selectCase)
                {
                    case CasesEnum.Chroma2Case:
                        inventory.SelectedCase = new Chroma2Case();
                        break;
                    case CasesEnum.Chroma3Case:
                        inventory.SelectedCase = new Chroma3Case();
                        break;
                    case CasesEnum.ChromaCase:
                        inventory.SelectedCase = new ChromaCase();
                        break;
                    case CasesEnum.ClutchCase:
                        inventory.SelectedCase = new ClutchCase();
                        break;
                    case CasesEnum.CS20Case:
                        inventory.SelectedCase = new CS20Case();
                        break;
                    case CasesEnum.CSGOWeaponCase:
                        inventory.SelectedCase = new CSGOWeaponCase();
                        break;
                    case CasesEnum.CSGOWeapon2Case:
                        inventory.SelectedCase = new CSGOWeaponCase2();
                        break;
                    case CasesEnum.CSGOWeapon3Case:
                        inventory.SelectedCase = new CSGOWeaponCase3();
                        break;
                    case CasesEnum.DangerZoneCase:
                        inventory.SelectedCase = new DangerZoneCase();
                        break;
                    case CasesEnum.DreamAndHightmaresCases:
                        inventory.SelectedCase = new DreamsAndNightmaresCase();
                        break;
                    case CasesEnum.ESports2013Case:
                        inventory.SelectedCase = new ESports2013Case();
                        break;
                    case CasesEnum.ESports2014WinterCase:
                        inventory.SelectedCase = new ESports2013WinterCase();
                        break;
                    case CasesEnum.Esports2014SummerCase:
                        inventory.SelectedCase = new ESports2014SummerCase();
                        break;
                    case CasesEnum.FalchionCase:
                        inventory.SelectedCase = new FalchionCase();
                        break;
                    case CasesEnum.FractureCase:
                        inventory.SelectedCase = new FractureCase();
                        break;
                    case CasesEnum.GalleryCase:
                        inventory.SelectedCase = new GalleryCase();
                        break;
                    case CasesEnum.Gamma2Case:
                        inventory.SelectedCase = new Gamma2Case();
                        break;
                    case CasesEnum.GammaCase:
                        inventory.SelectedCase = new GammaCase();
                        break;
                    case CasesEnum.GloveCase:
                        inventory.SelectedCase = new GloveCase();
                        break;
                    case CasesEnum.HorizonCase:
                        inventory.SelectedCase = new HorizonCase();
                        break;
                    case CasesEnum.HuntsmanWeaponCase:
                        inventory.SelectedCase = new HuntsmanWeaponCase();
                        break;
                    case CasesEnum.KilowattCase:
                        inventory.SelectedCase = new KilowattCase();
                        break;
                    case CasesEnum.OperationBravoCase:
                        inventory.SelectedCase= new OperationBravoCase();
                        break;
                    case CasesEnum.OperationBreakoutWeaponCase:
                        inventory.SelectedCase = new OperationBreakoutWeaponCase();
                        break;
                    case CasesEnum.OperationBrokenFangCase:
                        inventory.SelectedCase = new OperationBrokenFangCase();
                        break;
                    case CasesEnum.OperationHydraCase:
                        inventory.SelectedCase = new OperationHydraCase();
                        break;
                    case CasesEnum.OperationPhoenixWeaponCase:
                        inventory.SelectedCase = new OperationPhoenixWeaponCase();
                        break;
                    case CasesEnum.OperationRiptideCase:
                        inventory.SelectedCase = new OperationRiptideCase();
                        break;
                    case CasesEnum.OperationVanguardWeaponCase:
                        inventory.SelectedCase = new OperationVanguardWeaponCase();
                        break;
                    case CasesEnum.OperationWildfireCase:
                        inventory.SelectedCase = new OperationWildfireCase();
                        break;
                    case CasesEnum.Prisma2Case:
                        inventory.SelectedCase = new Prisma2Case();
                        break;
                    case CasesEnum.PrismaCase:
                        inventory.SelectedCase = new PrismaCase();
                        break;
                    case CasesEnum.RecoilCase:
                        inventory.SelectedCase = new RecoilCase();
                        break;
                    case CasesEnum.RevolutionCase:
                        inventory.SelectedCase = new RevolutionCase();
                        break;
                    case CasesEnum.RevolverCase:
                        inventory.SelectedCase = new RevolverCase();
                        break;
                    case CasesEnum.ShadowCase:
                        inventory.SelectedCase = new ShadowCase();
                        break;
                    case CasesEnum.ShatteredWebCase:
                        inventory.SelectedCase = new ShatteredWebCase();
                        break;
                    case CasesEnum.SnakebiteCase:
                        inventory.SelectedCase = new SnakebiteCase();
                        break;
                    case CasesEnum.Spectrum2Case:
                        inventory.SelectedCase = new Spectrum2Case();
                        break;
                    case CasesEnum.SpectrumCase:
                        inventory.SelectedCase = new SpectrumCase();
                        break;
                    case CasesEnum.WinterOffensiveWeaponCase:
                        inventory.SelectedCase = new WinterOffensiveWeaponCase();
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Invalid argumentss");
            }
        }
    }

    public class OpenCase : ICommand
    {
        public string Name => "open";

        public string Description => "\n" +
                        "Структура: [command] [argument] \n" +
                        "Отвечает за открытие кейса\n" +
                        "Аргументы: \n";

        public void Execute(string[] args, InventoryCore inventory)
        {
            try
            {
                var result = inventory.SelectedCase!.GetDrop();
                switch(result.Rarity)
                {
                    case PropertyItem.RarityItems.Army:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case PropertyItem.RarityItems.Forbidden:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        break;
                    case PropertyItem.RarityItems.Classified:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        break;
                    case PropertyItem.RarityItems.Secret:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    default:
                        break;
                }
                Console.WriteLine(result);
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch
            {
                Console.WriteLine("No select case");
            }
        }
    }

    public class GetSkins : ICommand
    {
        public string Name => "skins";

        public string Description => "\n" +
                        "Структура: [command] [argument] \n" +
                        "Отвечает за вывод скинов текущего кейса\n" +
                        "Аргументы: \n";

        public void Execute(string[] args, InventoryCore inventory)
        {
            try
            {
                var result = inventory.SelectedCase!.GetNameSkinsAll();
                Console.WriteLine(result);
            }
            catch
            {
                Console.WriteLine("No select case");
            }
        }
    }
}
