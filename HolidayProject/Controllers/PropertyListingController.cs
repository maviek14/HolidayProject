using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using HolidayProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace HolidayProject.Controllers;

public class PropertyListingController : Controller
{
    private readonly IPropertyRepository repository;
    private readonly IMapper mapper;

    public PropertyListingController(IPropertyRepository repository, IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;
    }

    public IActionResult ListAll()
    {
        return View("ListProperties", mapper.Map<IEnumerable<PropertyDetailsModel>>(repository.GetProperties()));
    }

    public IActionResult ListAvailable(DateTime start, DateTime end)
    {
        var availableProperties = repository.GetProperties().Where(p => !p.BookedNights.Any(d => d.Night >= start && d.Night <= end));
        return View("ListProperties", mapper.Map<IEnumerable<PropertyDetailsModel>>(availableProperties));
    }

    public IActionResult ViewPropertyDetails(int id)
    {
        PropertyDetailsModel model = mapper.Map<PropertyDetailsModel>(repository.GetPropertyById(id));
        return View("PropertyDetails", model);
    }
}
