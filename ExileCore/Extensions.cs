using ExileCore.PoEMemory.MemoryObjects;

namespace Beasts.ExileCore;

public static class Extensions
{
    public static BestiaryPanel GetBestiaryPanel(this IngameUIElements ui)
    {
        return ui.GetObject<BestiaryPanel>(
            ui.GetChildAtIndex(50)
                ?.GetChildAtIndex(2)
                ?.GetChildAtIndex(0)
                ?.GetChildAtIndex(1)
                ?.GetChildAtIndex(1)
                ?.GetChildAtIndex(11).Address ?? 0
        );
    }
}