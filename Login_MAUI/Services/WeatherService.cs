using Login_MAUI.Interfaces;
using Login_MAUI.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace Login_MAUI.Services
{
    public class WeatherService : IWeather
    {
        HttpClient client;
        string WebAPIUrl = string.Empty;


        public WeatherService()
        {
            client = new HttpClient();
        }

        public async Task<List<Weather>> GetWeathers(String token)
        {
            await Task.Delay(1000);

            WebAPIUrl = "https://localhost:44395/api/auth/weather";

            var uri = new Uri(WebAPIUrl);

            try
            {

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    List<Weather> weather = new List<Weather>();
                    var content = await response.Content.ReadAsStringAsync();
                    weather = JsonConvert.DeserializeObject<List<Weather>>(content);
                    return weather;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }

            return null;

        }
    }
}
