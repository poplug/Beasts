using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Beasts.Api;

public static class PoeNinja
{
    private static readonly string PoeNinjaUrl = "https://poe.ninja/api/data/itemoverview?league=Settlers&type=Beast";

    private class PoeNinjaLine
    {
        [JsonProperty("name")] public string Name;
        [JsonProperty("chaosValue")] public float ChaosValue;
    }

    private class PoeNinjaResponse
    {
        [JsonProperty("lines")] public List<PoeNinjaLine> Lines;
    }

    public static async Task<Dictionary<string, float>> GetBeastsPrices()
    {
        using var httpClient = new HttpClient();
        var response = await httpClient.GetAsync(PoeNinjaUrl);
        if (!response.IsSuccessStatusCode) throw new HttpRequestException("Failed to get poe.ninja response");

        var json = await response.Content.ReadAsStringAsync();
        var poeNinjaResponse = JsonConvert.DeserializeObject<PoeNinjaResponse>(json);

        return poeNinjaResponse.Lines.ToDictionary(line => line.Name, line => line.ChaosValue);
    }
}