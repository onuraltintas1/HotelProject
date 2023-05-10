using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApi.Consume.Models;

namespace RapidApi.Consume.Controllers;

public class ImdbController : Controller
{
    // GET
    public async Task<IActionResult> Index()
    {
        List<ApiMovieViewModel> apiMovieViewModels = new List<ApiMovieViewModel>();
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
            Headers =
            {
                { "X-RapidAPI-Key", "54dbe9ac94mshd6abff7e5124bf3p106656jsn3a9ff3ebef47" },
                { "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
            },
        };
        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            apiMovieViewModels = JsonConvert.DeserializeObject<List<ApiMovieViewModel>>(body);
            return View(apiMovieViewModels);
        }
    }
}