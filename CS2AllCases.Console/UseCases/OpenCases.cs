using CS2AllCases.Consols.Interfaces;
using CS2AllCases.Lib;
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
                new GetNameCases()
            };
            return command;
        }

        public CasesEnum SelectedCase { get; set; }
    }

    public class GetNameCases : ICommand
    {
        public string Name => "cases";

        public string Description => throw new NotImplementedException();

        public void Execute(string[] args)
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
        public string Name => throw new NotImplementedException();

        public string Description => throw new NotImplementedException();

        public void Execute(string[] args)
        {
            throw new NotImplementedException();
        }
    }
}
