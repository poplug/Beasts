using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;

namespace Beasts;

public class BeastsSettings : ISettings
{
    public ToggleNode Enable { get; set; } = new ToggleNode(false);
}