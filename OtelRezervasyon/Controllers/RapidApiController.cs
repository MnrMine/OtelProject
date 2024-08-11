using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OtelRezervasyon.Models;

namespace OtelRezervasyon.Controllers
{
    public class RapidApiController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://tripadvisor16.p.rapidapi.com/api/v1/rentals/searchLocation?query=new"),
                Headers =
        {
            { "x-rapidapi-key", "4268250e9amsh944d049f1a046b0p1d44b5jsn236e496eb6e7" },
            { "x-rapidapi-host", "tripadvisor16.p.rapidapi.com" },
        },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<RapidApiResponseModel>(body);
                return View(values.Data); // Listeyi View'e geçiyoruz
            }
        }

    }
}