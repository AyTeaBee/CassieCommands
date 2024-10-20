using Exiled.API.Features;
using System;
using CommandSystem;

namespace CassieCommands.Commands.Startup
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class Startup : ParentCommand
    {
        public Startup() => LoadGeneratedCommands();
        public override string Command { get; } = "cstartup";

        public override string[] Aliases { get; } = new[] { "cs" };

        public override string Description { get; } = "A command that makes CASSIE say a specified message.";

        public override void LoadGeneratedCommands()
        {
            RegisterCommand(new scp049());
            RegisterCommand(new scp096());
            RegisterCommand(new scp106());
            RegisterCommand(new scp173());
            RegisterCommand(new scp939());
        }

        protected override bool ExecuteParent(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            response = "Invalid subcommand. Choose from: scp049,scp096,scp106,scp173,scp939";
            return true;
        }
    }
}
