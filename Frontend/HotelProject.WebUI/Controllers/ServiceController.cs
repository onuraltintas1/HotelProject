using System.Text;
using HotelProject.WebUI.Dtos.ServiceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Controllers;

public class ServiceController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public ServiceController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7117/api/Service");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData);
            return View(values);
        }

        return View();
    }

    [HttpGet]
    public IActionResult AddService()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> AddService(AddServiceDto model)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(model);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PostAsync("https://localhost:7117/api/Service", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }

        return View();
    }

    public async Task<IActionResult> DeleteService(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.DeleteAsync($"https://localhost:7117/api/Service/{id}");
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }

        return RedirectToAction("Index");
    }

    [HttpGet]
    public async Task<IActionResult> UpdateService(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync($"https://localhost:7117/api/Service/{id}");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<UpdateServiceDto>(jsonData);
            return View(values);
        }

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> UpdateService(UpdateServiceDto model)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(model);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PutAsync("http://localhost:7117/api/Service/", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }

        return View();
    }
}