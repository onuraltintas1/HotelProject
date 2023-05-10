using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApi.Consume.Models;

namespace RapidApi.Consume.Controllers;

public class SearchLocationIDController : Controller
{
    // GET
    public async Task<IActionResult> Index(string cityName)
    {
        // Set default city name if not provided
        if (string.IsNullOrEmpty(cityName))
        {
            cityName = "paris";
        }

        var client = new HttpClient();
        client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "54dbe9ac94mshd6abff7e5124bf3p106656jsn3a9ff3ebef47");
        client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "booking-com.p.rapidapi.com");

        var requestUri = $"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={cityName}&locale=en-gb";
        var response = await client.GetAsync(requestUri);
        response.EnsureSuccessStatusCode();
        var body = await response.Content.ReadAsStringAsync();
        var model = JsonConvert.DeserializeObject<List<BookingApiLocationSearchViewModel>>(body);

        return View(model.Take(1).ToList());
    }
}