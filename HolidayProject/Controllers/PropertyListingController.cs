using HolidayProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace HolidayProject.Controllers;
public class PropertyListingController : Controller
{
    private static List<PropertyListingModel> properties = new()
    {
        new()
        {
            Id = 1,
            Name = "Rose Cottage",
            Blurb = "Beautiful cottage on the Cornwall coast",
            Location = "Cornwall",
            NumberOfBedrooms = 3,
            CostPerNight = 350
        },

        new()
        {
            Id = 2,
            Name = "Safron House",
            Blurb = "Stately home on the Devon moores",
            Location = "Devon",
            NumberOfBedrooms = 7,
            CostPerNight = 730
        },

        new()
        {
            Id = 3,
            Name = "Seaside Retreat",
            Blurb = "Experience coastal living at its finest in this charming 2-bedroom beachfront cottage.",
            Location = "Malibu",
            NumberOfBedrooms = 2,
            CostPerNight = 250
        },

        new()
        {
            Id = 4,
            Name = "City Lights Penthouse",
            Blurb = "Indulge in luxury at this sleek and modern 3-bedroom penthouse with panoramic city views.",
            Location = "New York City",
            NumberOfBedrooms = 3,
            CostPerNight = 500
        },

        new()
        {
            Id = 5,
            Name = "Mountain Chalet Retreat",
            Blurb = "Escape to the mountains and unwind in this cozy 1-bedroom chalet surrounded by nature.",
            Location = "Aspen",
            NumberOfBedrooms = 1,
            CostPerNight = 150
        },

        new()
        {
            Id = 6,
            Name = "Historic Villa Oasis",
            Blurb = "Immerse yourself in history at this elegant 4-bedroom villa, nestled in the heart of an ancient European town.",
            Location = "Tuscany",
            NumberOfBedrooms = 4,
            CostPerNight = 300
        },

        new()
        {
            Id = 7,
            Name = "Tropical Paradise Bungalow",
            Blurb = "Unwind in this tropical 2-bedroom bungalow surrounded by lush gardens and just steps away from the beach.",
            Location = "Bali",
            NumberOfBedrooms = 2,
            CostPerNight = 200
        }
    };

    public IActionResult ListAll()
    {
        return View(properties);
    }

    public IActionResult ListAvailable(DateTime start, DateTime end)
    {
        return View(properties);
    }
}
