using Domain.Entities;
using Domain.Repositories;
using HolidayProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace HolidayProject.Controllers;

public class PropertyListingController : Controller
{
    private readonly IPropertyRepository repository;

    public PropertyListingController(IPropertyRepository repository)
    {
        this.repository = repository;
    }

    public IActionResult ListAll()
    {
        return View("ListProperties", repository.GetProperties());
    }

    public IActionResult ListAvailable(DateTime start, DateTime end)
    {
        return View("ListProperties", repository.GetProperties().Where(p => !p.BookedDates.Any(d => d >= start && d <= end)).ToList());
    }

    public IActionResult ViewPropertyDetails(int id)
    {
        Property model = repository.GetPropertyById(id);

        return View("PropertyDetails", model);
    }
}
