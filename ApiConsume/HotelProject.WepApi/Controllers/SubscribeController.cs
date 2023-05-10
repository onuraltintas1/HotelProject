using HotelProject.BAL.Abstract;
using HotelProject.EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace HotelWepApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SubscribeController : Controller
{
    private ISubscribeService _subscribeService;

    public SubscribeController(ISubscribeService subscribeService)
    {
        _subscribeService = subscribeService;
    }

    [HttpGet]
    public IActionResult SubscribeList()
    {

        return Ok(_subscribeService.TGetList());
    }

    [HttpPost]
    public IActionResult AddSubscribe(Subscribe subscribe)
    {
        _subscribeService.TInsert(subscribe);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteSubscribe(int id)
    {
        var remove = _subscribeService.TGetById(id);
        _subscribeService.TDelete(remove);
        return Ok();
    }

    [HttpPut]
    public IActionResult UpdateSubscribe(Subscribe subscribe)
    {
        _subscribeService.TUpdate(subscribe);
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult GetSubcribe(int id)
    {
        return Ok(_subscribeService.TGetById(id));
    }
}
