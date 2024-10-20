using CommandSystem;
using System;
using Exiled.API.Features;

namespace CassieCommands.Commands.Startup
{
    public class cg : ICommand
    {
        public string Command { get; } = "cg";

        public string[] Aliases { get; } = Array.Empty<string>();

        public string Description { get; } = "Plays the code green facility sequence.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (arguments.Count != 0)
            {
                response = "Usage: cc cg";
                return false;
            }

            Cassie.Message("pitch_0.20 .G4 .G4 .G4 pitch_1.00 <color=#FF0000> <size=35> ATTENTION ALL PERSONNEL. <color=#00FF00><size=35> CODE GREEN <color=#FF0000> <size=30> is now in effect . Please evacuate to the nearest breach shelter . pitch_0.20 .G4 .G4 .G4", false, true, false);
            response = "Successfully played the announcement.";
            return true;
        }
    }
}