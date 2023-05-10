using HotelProject.BAL.Abstract;
using HotelProject.EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace HotelWepApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class RoomController : Controller
{
    private IRoomService _roomService;

    public RoomController(IRoomService roomService)
    {
        _roomService = roomService;
    }

    
    [HttpGet]
    public IActionResult RoomList()
    {
        
        return Ok(_roomService.TGetList());
    }
    [HttpPost]
    public IActionResult AddRoom(Room room)
    {
        _roomService.TInsert(room);
        return Ok();
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteRoom(int id)
    {
        var remove=_roomService.TGetById(id);
        _roomService.TDelete(remove);
        return Ok();
    }
    [HttpPut]
    public IActionResult UpdateRoom(Room room)
    {
        _roomService.TUpdate(room);
        return Ok();
    }
    [HttpGet("{id}")]
    public IActionResult GetRoom(int id)
    {
        return Ok(_roomService.TGetById(id));
    }
}