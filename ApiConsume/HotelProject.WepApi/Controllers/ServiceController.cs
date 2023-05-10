using HotelProject.BAL.Abstract;
using HotelProject.EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace HotelWepApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ServiceController : Controller
{
    private readonly IServiceService _serviceService;

    public ServiceController(IServiceService serviceService)
    {
        _serviceService = serviceService;
    }

    [HttpGet]
    public IActionResult ServiceList()
    {
        
        return Ok(_serviceService.TGetList());
    }
    [HttpPost]
    public IActionResult AddService(Service service)
    {
        _serviceService.TInsert(service);
        return Ok();
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeleteService(int id)
    {
        var remove=_serviceService.TGetById(id);
        _serviceService.TDelete(remove);
        return Ok();
    }
    [HttpPut]
    public IActionResult UpdateService(Service service)
    {
        _serviceService.TUpdate(service);
        return Ok();
    }
    [HttpGet("{id}")]
    public IActionResult GetService(int id)
    {
        return Ok(_serviceService.TGetById(id));
    }
}