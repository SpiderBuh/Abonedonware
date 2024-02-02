using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using PluginAPI.Events;

namespace ScpPcSkeleSwap
{
    public class Plugin
    {
        [PluginEntryPoint("Abonedonware", "0.0.1", "Removes 079 and replaces his role of freeing SCPs with a reworked 3114", "SpiderBuh")]
        public void OnPluginStart()
        {
            Log.Info($"Plugin is loading...");
            EventManager.RegisterEvents<Events>(this);
        }

    }
}
