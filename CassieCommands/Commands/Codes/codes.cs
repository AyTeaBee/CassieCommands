using Exiled.API.Features;
using System;
using CommandSystem;

namespace CassieCommands.Commands.Startup
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class codes : ParentCommand
    {
        public codes() => LoadGeneratedCommands();
        public override string Command { get; } = "ccodes";

        public override string[] Aliases { get; } = new[] { "cc" };

        public override string Description { get; } = "A command that makes CASSIE say a code sequence.";

        public override void LoadGeneratedCommands()
        {
            RegisterCommand(new cb());
            RegisterCommand(new cg());
            RegisterCommand(new co());
        }

        protected override bool ExecuteParent(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            response = "Invalid subcommand. Choose from: cb, cg, co";
            return true;
        }
    }
}