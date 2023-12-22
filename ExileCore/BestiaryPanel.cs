using System.Collections.Generic;
using System.Linq;
using ExileCore.PoEMemory;

namespace Beasts.ExileCore;

public class BestiaryPanel : Element
{
    public CapturedBeastsPanel CapturedBeastsPanel =>
        GetObject<CapturedBeastsPanel>(GetChildAtIndex(0)?.GetChildAtIndex(18).Address ?? 0);
}

public class CapturedBeastsPanel : Element
{
    private static readonly List<string> BeastTypes = new()
    {
        "Felines", "Primates", "Canines", "Ursae", "Unnaturals", "Avians", "Reptiles", "Insects", "Arachnids",
        "Cephalopods", "Crustaceans", "Amphibians"
    };

    private Element BeastsDisplay => GetChildAtIndex(1)?.GetChildAtIndex(0);

    public List<CapturedBeast> CapturedBeasts
    {
        get
        {
            var beasts = new List<CapturedBeast>();
            for (var i = 0; i < BeastTypes.Count; i++)
            {
                var beastContainer = BeastsDisplay?.GetChildAtIndex(i);
                if (beastContainer == null || beastContainer.IsVisible == false) continue;

                beasts.AddRange(beastContainer.GetChildAtIndex(1).Children
                    .Select(beast => GetObject<CapturedBeast>(beast.Address)));
            }

            return beasts;
        }
    }
}

public class CapturedBeast : Element
{
    public string DisplayName => Tooltip?.GetChildAtIndex(1)?.GetChildAtIndex(0).Text.Replace("-", "").Trim();
}