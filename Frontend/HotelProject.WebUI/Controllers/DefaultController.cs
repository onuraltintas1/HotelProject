using System.Text;
using HotelProject.EntityLayer;
using HotelProject.WebUI.Dtos.RoomDto;
using HotelProject.WebUI.Dtos.SubscribeDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Controllers;

public class DefaultController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public DefaultController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public PartialViewResult SubscribePartial()
    {
        return PartialView();
    }
    [HttpPost]
    public async Task<IActionResult> SubscribePartial(CreateSubscribeDto createSubscribeDto)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(createSubscribeDto);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PostAsync("https://localhost:7117/api/Subscribe", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }

        return View();
    }
}