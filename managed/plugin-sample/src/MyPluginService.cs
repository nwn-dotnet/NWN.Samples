using NWN.API;
using NWN.API.Events;
using NWN.Services;

namespace Sample
{
  // [ServiceBinding] indicates that this class will be created during server startup.
  [ServiceBinding(typeof(MyPluginService))]
  public class MyPluginService
  {
    // Called at startup. NWN.Managed resolves EventService for us.
    public MyPluginService(NativeEventService eventService)
    {
      // Subscribe to the OnClientEnter event, and call our OnClientEnter function when someone connects.
      eventService.Subscribe<NwModule, ModuleEvents.OnClientEnter>(NwModule.Instance, OnClientEnter);
    }

    private void OnClientEnter(ModuleEvents.OnClientEnter onClientEnter)
    {
      // Send a welcome message to the player who just connected
      onClientEnter.Player.SendServerMessage($"Hello {onClientEnter.Player.Name}! Welcome to the server!", Color.PINK);
    }
  }
}