using Microsoft.AspNetCore.Mvc;

namespace HolidayProject.Controllers;
public class PropertyListingController : Controller
{
    public IActionResult ListAll()
    {
        return View();
    }

    public IActionResult ListAvailable(DateTime start, DateTime end)
    {
        return View();
    }
}
