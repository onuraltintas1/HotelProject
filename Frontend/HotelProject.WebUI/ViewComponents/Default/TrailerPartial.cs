using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Default;

public class TrailerPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}