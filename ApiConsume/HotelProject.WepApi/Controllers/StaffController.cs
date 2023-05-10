using HotelProject.BAL.Abstract;
using HotelProject.EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace HotelWepApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class StaffController : Controller
{
    private readonly IStaffService _staffService;

    public StaffController(IStaffService staffService)
    {
        _staffService = staffService;
    }
    
    [HttpGet]
    public IActionResult StaffList()
    {
        
        return Ok(_staffService.TGetList());
    }
    [HttpPost]
    public IActionResult AddStaff(Staff staff)
    {
        _staffService.TInsert(staff);
        return Ok();
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteStaff(int id)
    {
        var remove=_staffService.TGetById(id);
        _staffService.TDelete(remove);
        return Ok();
    }
    [HttpPut]
    public IActionResult UpdateStaff(Staff staff)
    {
        _staffService.TUpdate(staff);
        return Ok();
    }
    [HttpGet("{id}")]
    public IActionResult GetStaff(int id)
    {
        return Ok(_staffService.TGetById(id));
    }
}