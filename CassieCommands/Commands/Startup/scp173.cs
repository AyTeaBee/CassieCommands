using CommandSystem;
using System;
using Exiled.API.Features;

namespace CassieCommands.Commands.Startup
{
    public class scp173 : ICommand
    {
        public string Command { get; } = "scp173";

        public string[] Aliases { get; } = Array.Empty<string>();

        public string Description { get; } = "Plays the SCP 173 facility start up theme.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (arguments.Count != 0)
            {
                response = "Usage: cs scp173";
                return false;
            }

            Cassie.Message("Light Systems . .  <color=#00FF00><size=30> Online .</size></color> Door Systems . .  <color=#00FF00> <size=30> Online .</size></color> Welcome to <color=#800080> <size=35> Site 2. </size></color> Today's testing will be on <color=#FF0000><size=35> SCP 1 7 3", false, true, false);
            response = "Successfully played the announcement.";
            return true;
        }
    }
}