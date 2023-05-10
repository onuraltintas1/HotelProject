using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApi.Consume.Models;

namespace RapidApi.Consume.Controllers;

public class ExchangeController : Controller
{
    // GET
    public async Task<IActionResult> Index()
    {
        List<ExchangeViewModel> exchangeViewModels = new List<ExchangeViewModel>();
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?currency=TRY&locale=en-gb"),
            Headers =
            {
                { "X-RapidAPI-Key", "54dbe9ac94mshd6abff7e5124bf3p106656jsn3a9ff3ebef47" },
                { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
            },
        };
        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<ExchangeViewModel>(body);
            return View(values.exchange_rates.ToList());
        }
    }
}