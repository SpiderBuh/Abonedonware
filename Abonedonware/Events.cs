using PluginAPI.Core.Attributes;
using PluginAPI.Enums;
using PluginAPI.Events;

namespace Abonedonware
{
    public class Events
    {
        [PluginEvent(ServerEventType.PlayerSpawn)]
        public void PlayerSpawn(PlayerSpawnEvent args)
        {
            var plr = args.Player;
            if (plr.Role == PlayerRoles.RoleTypeId.Scp079)
                plr.SetRole(PlayerRoles.RoleTypeId.Scp3114, PlayerRoles.RoleChangeReason.RoundStart);
        }
    }
}
