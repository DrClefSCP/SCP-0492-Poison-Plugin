using Exiled.API.Features;
using Exiled.Events.EventArgs;


namespace Test1
{
    public class Plugin : Plugin<Config>
    {
        public EventHandlers handler;

        public override void OnEnabled()
        {
            handler = new EventHandlers();
            Exiled.Events.Handlers.Player.Hurting += handler.HurtingEvent;
            Exiled.Events.Handlers.Player.UsedItem += handler.UsedItemEvent;
        }
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Hurting -= handler.HurtingEvent;
            Exiled.Events.Handlers.Player.UsedItem -= handler.UsedItemEvent;
            handler = null;
        }
    }
}