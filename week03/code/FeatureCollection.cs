using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Text.Json;




public class FeatureCollection
{

    public class Earthquake
    {
        public Properties properties { get; set; }
    }


    public class Properties
    {

        public double mag { get; set; }
        public string place { get; set; }
    }


    public List<Earthquake> features { get; set; }



    private static readonly HttpClient server = new()
    {
        BaseAddress = new Uri("https://earthquake.usgs.gov/earthquakes/feed/v1.0/summary/all_day.geojson")


    };

    public static async Task<string[]> EarthquakeDailySummary()
    {
        var data = await server.GetFromJsonAsync<FeatureCollection>("https://earthquake.usgs.gov/earthquakes/feed/v1.0/summary/all_day.geojson");
        List<string> dataList = new();

        foreach (var a in data.features)
        {
            var place = a.properties.place;
            var magnitude = a.properties.mag;

            var result = $"{place} - Mag {magnitude}";
            dataList.Add(result);
        }

        return dataList.ToArray();
    }



}





