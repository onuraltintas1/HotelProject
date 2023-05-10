using HotelProject.BAL.Abstract;
using HotelProject.EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace HotelWepApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookingController : Controller
{
    private readonly IBookingService _bookingService;

    public BookingController(IBookingService bookingService)
    {
        _bookingService = bookingService;
    }

    [HttpGet]
    public IActionResult BookingList()
    {
        var values = _bookingService.TGetList();
        return Ok(values);
    }

    [HttpPost]
    public IActionResult AddBooking(Booking booking)
    {
        _bookingService.TInsert(booking);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteBooking(int id)
    {
        var values = _bookingService.TGetById(id);
        _bookingService.TDelete(values);
        return Ok();
    }

    [HttpPut("UpdateBooking")]
    public IActionResult UpdateBooking(Booking booking)
    {
        _bookingService.TUpdate(booking);
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult GetBooking(int id)
    {
        var values = _bookingService.TGetById(id);
        return Ok(values);
    }

    [HttpPut("aaaaa")]
    public IActionResult aaaaa(Booking booking)
    {
        _bookingService.TBookingStatusChangeApproved(booking);
        return Ok();
    }
    [HttpPut("bbbb")]
    public IActionResult bbbb(int id)
    {
        _bookingService.BookingStatusChangeApproved2(id);
        return Ok();
    }

}
