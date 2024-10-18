using Exiled.API.Features;
using System;
using CommandSystem;

namespace CassieCommands.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class Startup : ICommand
    {
        public string Command { get; } = "cstartup";

        public string[] Aliases { get; } = new[] { "cs" };

        public string Description { get; } = "A command that makes CASSIE say a specified message.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Cassie.Message("Light Systems . .  <color=#00FF00><size=30> Online. </size></color> Door Systems . .  <color=#00FF00> <size=30> Online. </size></color> Welcome to <color=#800080> <size=35> Site 2. </size></color> Today's testing will be on<color=#FF0000><size=35> SCP 9 3 9", false, true, false);
            response = "Successfully played the command.";
            return true;
        }
    }
}
