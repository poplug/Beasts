using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Beasts.Data;
using Beasts.ExileCore;
using ExileCore.PoEMemory.Components;
using ExileCore.Shared.Enums;
using ImGuiNET;
using SharpDX;
using Vector2 = System.Numerics.Vector2;
using Vector3 = System.Numerics.Vector3;

namespace Beasts;

public partial class Beasts
{
    public override void Render()
    {
        DrawInGameBeasts();
        DrawInGameHarvestMemoryBeasts();
        DrawBestiaryPanel();
        DrawBeastsWindow();
    }

    private void DrawInGameBeasts()
    {
        foreach (var positioned in _trackedBeasts
                     .Select(beast => beast.Value.GetComponent<Positioned>())
                     .Where(positioned => positioned != null))
        {
            DrawFilledCircleInWorldPosition(
                GameController.IngameState.Data.ToWorldWithTerrainHeight(positioned.GridPosition), 50, Color.Red
            );
        }
    }

    private void DrawInGameHarvestMemoryBeasts()
    {
        foreach (var trackedBeast in _trackedHarvestMemoryBeasts
                     .Select(beast => new { Positioned = beast.Value.GetComponent<Positioned>(), beast.Value.Metadata })
                     .Where(beast => beast.Positioned != null))
        {
            var beast = BeastsDatabase.HarvestMemoryBeasts.Where(beast => trackedBeast.Metadata == beast.Path).First();

            var pos = GameController.IngameState.Data.ToWorldWithTerrainHeight(trackedBeast.Positioned.GridPosition);
            Graphics.DrawText(beast.DisplayName, GameController.IngameState.Camera.WorldToScreen(pos), Color.White, FontAlign.Center);

            DrawFilledCircleInWorldPosition(pos, 50, GetHarvestMemoryBeastColor(beast.DisplayName));
        }
    }

    private Color GetHarvestMemoryBeastColor(string beastName)
    {
        if (beastName.Contains("Vivid"))
        {
            return new Color(255, 250, 0);
        }

        if (beastName.Contains("Wild"))
        {
            return new Color(255, 0, 235);
        }

        if (beastName.Contains("Primal"))
        {
            return new Color(0, 245, 255);
        }

        return Color.Red;
    }

    private void DrawBestiaryPanel()
    {
        var bestiary = GameController.IngameState.IngameUi.GetBestiaryPanel();
        if (bestiary == null || bestiary.IsVisible == false) return;

        var capturedBeastsPanel = bestiary.CapturedBeastsPanel;
        if (capturedBeastsPanel == null || capturedBeastsPanel.IsVisible == false) return;

        var beasts = bestiary.CapturedBeastsPanel.CapturedBeasts;
        foreach (var beast in beasts)
        {
            var beastMetadata = BeastsDatabase.AllBeasts.Find(b => b.DisplayName == beast.DisplayName);
            if (beastMetadata == null) continue;
            if (!Prices.ContainsKey(beastMetadata.DisplayName)) continue;

            var center = new Vector2(beast.GetClientRect().Center.X, beast.GetClientRect().Center.Y);

            Graphics.DrawBox(beast.GetClientRect(), new Color(0, 0, 0, 0.5f));
            Graphics.DrawFrame(beast.GetClientRect(), Color.White, 2);
            Graphics.DrawText(beastMetadata.DisplayName, center, Color.White, FontAlign.Center);

            var text = Prices[beastMetadata.DisplayName].ToString(CultureInfo.InvariantCulture) + "c";
            var textPos = center + new Vector2(0, 20);
            Graphics.DrawText(text, textPos, Color.White, FontAlign.Center);
        }
    }

    private void DrawBeastsWindow()
    {
        ImGui.SetNextWindowSize(new Vector2(0, 0));
        ImGui.SetNextWindowBgAlpha(0.6f);
        ImGui.Begin("Beasts Window", ImGuiWindowFlags.NoDecoration);

        if (ImGui.BeginTable("Beasts Table", 2, ImGuiTableFlags.RowBg | ImGuiTableFlags.BordersOuter | ImGuiTableFlags.BordersV))
        {
            ImGui.TableSetupColumn("Price", ImGuiTableColumnFlags.WidthFixed, 48);
            ImGui.TableSetupColumn("Beast");

            foreach (var beastMetadata in _trackedBeasts
                         .Select(trackedBeast => trackedBeast.Value)
                         .Select(beast => BeastsDatabase.AllBeasts.Find(b => b.Path == beast.Metadata))
                         .Where(beastMetadata => beastMetadata != null))
            {
                ImGui.TableNextRow();

                ImGui.TableNextColumn();

                ImGui.Text(Prices.TryGetValue(beastMetadata.DisplayName, out var price)
                    ? $"{price.ToString(CultureInfo.InvariantCulture)}c"
                    : "0c");

                ImGui.TableNextColumn();

                ImGui.Text(beastMetadata.DisplayName);
                foreach (var craft in beastMetadata.Crafts)
                {
                    ImGui.Text(craft);
                }
            }

            foreach (var beastMetadata in _trackedHarvestMemoryBeasts
                .Select(trackedBeast => trackedBeast.Value)
                .Select(beast => BeastsDatabase.AllBeasts.Find(b => b.Path == beast.Metadata))
                .Where(beastMetadata => beastMetadata != null))
            {
                ImGui.TableNextRow();

                ImGui.TableNextColumn();

                ImGui.Text(Prices.TryGetValue(beastMetadata.DisplayName, out var price)
                    ? $"{price.ToString(CultureInfo.InvariantCulture)}c"
                    : "0c");

                ImGui.TableNextColumn();

                ImGui.Text(beastMetadata.DisplayName);
                foreach (var craft in beastMetadata.Crafts)
                {
                    ImGui.Text(craft);
                }
            }

            ImGui.EndTable();
        }

        ImGui.End();
    }

    private void DrawFilledCircleInWorldPosition(Vector3 position, float radius, Color color)
    {
        var circlePoints = new List<Vector2>();
        const int segments = 15;
        const float segmentAngle = 2f * MathF.PI / segments;

        for (var i = 0; i < segments; i++)
        {
            var angle = i * segmentAngle;
            var currentOffset = new Vector2(MathF.Cos(angle), MathF.Sin(angle)) * radius;
            var nextOffset = new Vector2(MathF.Cos(angle + segmentAngle), MathF.Sin(angle + segmentAngle)) * radius;

            var currentWorldPos = position + new Vector3(currentOffset, 0);
            var nextWorldPos = position + new Vector3(nextOffset, 0);

            circlePoints.Add(GameController.Game.IngameState.Camera.WorldToScreen(currentWorldPos));
            circlePoints.Add(GameController.Game.IngameState.Camera.WorldToScreen(nextWorldPos));
        }

        Graphics.DrawConvexPolyFilled(circlePoints.ToArray(), color with { A = Color.ToByte((int)((double)0.2f * byte.MaxValue)) });
        Graphics.DrawPolyLine(circlePoints.ToArray(), color, 2);
    }
}