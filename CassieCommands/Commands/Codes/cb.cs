using CommandSystem;
using System;
using Exiled.API.Features;

namespace CassieCommands.Commands.Startup
{
    public class cb : ICommand
    {
        public string Command { get; } = "cb";

        public string[] Aliases { get; } = Array.Empty<string>();

        public string Description { get; } = "Plays the code black facility sequence.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (arguments.Count != 0)
            {
                response = "Usage: cc cb";
                return false;
            }



            Cassie.Message("pitch_0.20 .G4 .G4 .G4 pitch_1.00 <color=#FF0000> <size=25> THE SITE HAS BEEN LOST. INITIATING <color=#000000><size=40> CODE BLACK <color=#FF0000> <size=35> EVACUATE jam_056_9 NOW", false, true, false);
            response = "Successfully played the announcement.";
            return true;
        }
    }
}