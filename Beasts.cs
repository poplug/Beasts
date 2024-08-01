using System;
using System.Collections.Generic;
using System.Linq;
using Beasts.Api;
using Beasts.Data;
using ExileCore;
using ExileCore.PoEMemory.MemoryObjects;
using ExileCore.Shared.Enums;

namespace Beasts;

using BeastDisplayName = String;

public partial class Beasts : BaseSettingsPlugin<BeastsSettings>
{
    private Dictionary<BeastDisplayName, float> Prices { get; set; }
    private readonly Dictionary<long, Entity> _trackedBeasts = new();
    private readonly Dictionary<long, Entity> _trackedHarvestMemoryBeasts = new();

    public override bool Initialise()
    {
        Prices = PoeNinja.GetBeastsPrices().Result;
        return true;
    }

    public override void OnLoad()
    {
        Graphics.InitImage("chaos.png");
    }

    public override void AreaChange(AreaInstance area)
    {
        _trackedBeasts.Clear();
        _trackedHarvestMemoryBeasts.Clear();
    }

    public override void EntityAdded(Entity entity)
    {
        if (entity.Rarity != MonsterRarity.Rare) return;
        foreach (var _ in BeastsDatabase.AllBeasts.Where(beast => entity.Metadata == beast.Path))
        {
            _trackedBeasts.Add(entity.Id, entity);
        }

        foreach (var _ in BeastsDatabase.HarvestMemoryBeasts.Where(beast => entity.Metadata == beast.Path))
        {
            _trackedHarvestMemoryBeasts.Add(entity.Id, entity);
        }
    }

    public override void EntityRemoved(Entity entity)
    {
        if (_trackedBeasts.ContainsKey(entity.Id))
        {
            _trackedBeasts.Remove(entity.Id);
        }

        if (_trackedHarvestMemoryBeasts.ContainsKey(entity.Id))
        {
            _trackedHarvestMemoryBeasts.Remove(entity.Id);
        }
    }
}