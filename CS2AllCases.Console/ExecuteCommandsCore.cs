using CS2AllCases.Consols.Interfaces;

namespace CS2AllCases.Consols
{
    public class ExecuteCommandsCore
    {
        public List<ICommand> Commands { get; } = [];

        public void ExecuteCommand(string command)
        {
            string[] parts = command.Split(' ');
            string cmdName = parts[0];
            string[] args = parts.Skip(1).ToArray();
            var cmd = Commands.FirstOrDefault(a => a.Name == cmdName);
            if (cmd != null)
            {
                cmd.Execute(args);
            }
        }

        public void Add(ICommand command)
        {
            Commands.Add(command);
        }

        public void AddRange(ICommand[] commands)
        {
            Commands.AddRange(commands);
        }
    }
}
