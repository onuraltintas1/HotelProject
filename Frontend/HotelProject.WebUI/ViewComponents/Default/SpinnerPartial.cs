using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Default;

public class SpinnerPartial : ViewComponent 
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}