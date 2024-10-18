using Exiled.API.Features;
using System;
using CommandSystem;

namespace CassieCommands.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class CodeGreen : ICommand
    {
        public string Command { get; } = "ccodegreen";

        public string[] Aliases { get; } = new[] { "ccg" };

        public string Description { get; } = "A command that makes CASSIE say a specified message.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Cassie.Message("Code Green", false, true, false);
            response = "Successfully played the command.";
            return true;
        }
    }
}
