using System.Text;
using HotelProject.WebUI.Dtos.BookingDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Controllers;

public class BookingAdminController : Controller
{
    private readonly IHttpClientFactory _httpClientFactory;

    public BookingAdminController(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<IActionResult> Index()
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync("https://localhost:7117/api/Booking");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
            return View(values);
        }

        return View();
    }

    public async Task<IActionResult> ApprovedReservation(ApprovedReservationDto approvedReservationDto)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(approvedReservationDto);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PutAsync("https://localhost:7117/api/Booking/bbbb", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }

        return View();
    }
}