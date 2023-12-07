using Domain.Entities;
using Domain.Repositories;
using HolidayProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace HolidayProject.Controllers;

public class PropertyManagementController : Controller
{
    private readonly IPropertyRepository repository;

    public PropertyManagementController(IPropertyRepository repository)
    {
        this.repository = repository;
    }

    [HttpGet]
    public IActionResult AddProperty()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddProperty(Property model)
    {
        if (ModelState.IsValid)
        {
            repository.AddProperty(model);
            return View("PropertyAdded", model);
        }
        else
            return View(model);
    }
}
