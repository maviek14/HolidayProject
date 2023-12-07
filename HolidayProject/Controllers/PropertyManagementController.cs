using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using HolidayProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace HolidayProject.Controllers;

public class PropertyManagementController : Controller
{
    private readonly IPropertyRepository repository;
    private readonly IMapper mapper;

    public PropertyManagementController(IPropertyRepository repository, IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;
    }

    [HttpGet]
    public IActionResult AddProperty()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddProperty(PropertyDetailsModel model)
    {
        if (ModelState.IsValid)
        {
            repository.AddProperty(mapper.Map<Property>(model));
            return View();
        }
        else
            return View(model);
    }
}
