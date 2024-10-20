using CommandSystem;
using System;
using Exiled.API.Features;

namespace CassieCommands.Commands.Startup
{
    public class co : ICommand
    {
        public string Command { get; } = "co";

        public string[] Aliases { get; } = Array.Empty<string>();

        public string Description { get; } = "Plays the code orange facility sequence.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (arguments.Count != 0)
            {
                response = "Usage: cc co";
                return false;
            }

            Cassie.Message("pitch_0.50 jam_057_9 .G3  <color=#FF0000><size=30> pitch_1.00 ATTENTION TO ALL PERSONNEL . A <color=#FFA500> Code Orange <color=#FF0000> has been spotted in the <size=35><color=#FFFFFF> Facility.<color=#808080><size=30> Security personnel are needed . pitch_0.50 jam_057_9 .G3", false, true, false);
            response = "Successfully played the announcement.";
            return true;
        }
    }
}