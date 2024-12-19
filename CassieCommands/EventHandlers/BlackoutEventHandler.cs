using Exiled.API.Features;
using Exiled.Events.EventArgs.Map;
using PlayerRoles.SpawnData;

namespace CassieCommands.EventHandlers
{
    public class BlackoutEventHandler
    {
        public BlackoutEventHandler()
        {
            Map.TurnOffAllLights(1);
        } 
    }
}
