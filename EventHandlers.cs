using CustomPlayerEffects;
using Exiled.API.Enums;
using Exiled.API.Features.DamageHandlers;
using Exiled.API.Features.Items;
using Exiled.Events.EventArgs;

namespace Test1
{
    public class EventHandlers
    {
        public void HurtingEvent(HurtingEventArgs ev)
        {
            if (ev.Attacker.Role == RoleType.Scp0492)
            {
                ev.Target.GetEffectIntensity<Poisoned>();
                ev.Target.ShowHint("You've been infected...", 5f);
            }
        }
        public void UsedItemEvent(UsedItemEventArgs ev)
        {
            if (ev.Item.Type == ItemType.Painkillers)
            {
                ev.Player.DisableEffect<Poisoned>();
                ev.Player.EnableEffect<Amnesia>(5f);
                ev.Player.ShowHint("You've been cured", 5f);
            }
        }
    }
}