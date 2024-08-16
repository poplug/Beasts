using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Beasts.Data;
using ExileCore.Shared.Attributes;
using ExileCore.Shared.Helpers;
using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;
using ImGuiNET;
using Newtonsoft.Json;
using SharpDX;

namespace Beasts;

public class BeastsSettings : ISettings
{

    public List<Beast> Beasts { get; set; } = new();
    public Dictionary<string, float> BeastPrices { get; set; } = new();
    public DateTime LastUpdate { get; set; } = DateTime.MinValue;

    public BeastsSettings()
    {
        BeastPicker = new CustomNode
        {
            DrawDelegate = () =>
            {
                ImGui.Separator();
                if (ImGui.BeginTable("BeastsTable", 4, ImGuiTableFlags.Resizable | ImGuiTableFlags.Reorderable | ImGuiTableFlags.Sortable | ImGuiTableFlags.RowBg | ImGuiTableFlags.BordersOuter | ImGuiTableFlags.BordersV | ImGuiTableFlags.NoBordersInBody | ImGuiTableFlags.ScrollY))
                {
                    ImGui.TableSetupColumn("Enabled", ImGuiTableColumnFlags.WidthFixed, 24);
                    ImGui.TableSetupColumn("Price", ImGuiTableColumnFlags.WidthFixed, 48);
                    ImGui.TableSetupColumn("Name", ImGuiTableColumnFlags.WidthFixed, 256);
                    ImGui.TableSetupColumn("Description", ImGuiTableColumnFlags.WidthStretch);
                    ImGui.TableSetupScrollFreeze(0, 1);
                    ImGui.TableHeadersRow();

                    var sortedBeasts = BeastsDatabase.AllBeasts;
                    if (ImGui.TableGetSortSpecs() is { SpecsDirty: true } sortSpecs)
                    {
                        int sortedColumn = sortSpecs.Specs.ColumnIndex;
                        var sortAscending = sortSpecs.Specs.SortDirection == ImGuiSortDirection.Ascending;

                        sortedBeasts = sortedColumn switch
                        {
                            0 => sortAscending ? [.. sortedBeasts.OrderBy(b => Beasts.Any(eb => eb.Path == b.Path))] : [.. sortedBeasts.OrderByDescending(b => Beasts.Any(eb => eb.Path == b.Path))],
                            1 => sortAscending ? [.. sortedBeasts.OrderBy(b => BeastPrices[b.DisplayName])] : [.. sortedBeasts.OrderByDescending(b => BeastPrices[b.DisplayName])],
                            2 => sortAscending ? [.. sortedBeasts.OrderBy(b => b.DisplayName)] : [.. sortedBeasts.OrderByDescending(x => x.DisplayName)],
                            3 => sortAscending ? [.. sortedBeasts.OrderBy(b => b.Crafts[0])] : [.. sortedBeasts.OrderByDescending(x => x.Crafts[0])],
                            _ => sortAscending ? [.. sortedBeasts.OrderBy(b => b.DisplayName)] : [.. sortedBeasts.OrderByDescending(x => x.DisplayName)]
                        };
                    }

                    foreach (var beast in sortedBeasts)
                    {
                        ImGui.TableNextRow();
                        ImGui.TableNextColumn();

                        var isChecked = Beasts.Any(eb => eb.Path == beast.Path);
                        if (ImGui.Checkbox($"##{beast.Path}", ref isChecked))
                        {
                            if (isChecked)
                            {
                                Beasts.Add(beast);
                            }
                            else
                            {
                                Beasts.RemoveAll(eb => eb.Path == beast.Path);
                            }
                        }

                        if (isChecked)
                        {
                            ImGui.PushStyleColor(ImGuiCol.Text, Color.Green.ToImguiVec4());
                        }

                        ImGui.TableNextColumn();
                        ImGui.Text(BeastPrices.TryGetValue(beast.DisplayName, out var price) ? $"{price}c" : "0c");

                        ImGui.TableNextColumn();
                        ImGui.Text(beast.DisplayName);

                        ImGui.TableNextColumn();
                        // display all the crafts for the beast seperated by newline
                        foreach (var craft in beast.Crafts)
                        {
                            ImGui.Text(craft);
                        }

                        if (isChecked)
                        {
                            ImGui.PopStyleColor();
                        }

                        ImGui.NextColumn();
                    }
                    ImGui.EndTable();
                }
            }
        };

        LastUpdated = new CustomNode
        {
            DrawDelegate = () =>
            {
                ImGui.Text("PoeNinja prices as of:");
                ImGui.SameLine();
                ImGui.Text(LastUpdate.ToString("HH:mm:ss"));
            }
        };
    }

    public ToggleNode Enable { get; set; } = new ToggleNode(false);

    public ButtonNode FetchBeastPrices { get; set; } = new ButtonNode();

    [JsonIgnore] public CustomNode LastUpdated { get; set; }

    [JsonIgnore] public CustomNode BeastPicker { get; set; }
}