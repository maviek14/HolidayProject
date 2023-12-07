using HolidayProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace HolidayProject.Controllers;

public class PropertyManagementController : Controller
{
    [HttpGet]
    public IActionResult AddProperty()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddProperty(PropertyDetailsModel model)
    {
       if (ModelState.IsValid)
            return View("PropertyAdded", model);
       else
            return View(model);
    }
}
