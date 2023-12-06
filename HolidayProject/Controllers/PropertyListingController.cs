using HolidayProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace HolidayProject.Controllers;

public class PropertyListingController : Controller
{
    private static List<PropertyDetailsModel> properties = new()
    {
        new()
        {
            Id = 1,
            Name = "Rose Cottage",
            Blurb = "Beautiful cottage on the Cornwall coast",
            Location = "Cornwall",
            NumberOfBedrooms = 3,
            CostPerNight = 350,
            Description = "Wake up to the sound of waves and enjoy breathtaking ocean views from your private deck",
            Amenities = new(){ "Free Wi-Fi", "Fully Equipped Kitchen" },
            BookedDates = new()
            {
                DateTime.Parse("2024-01-04"),
                DateTime.Parse("2024-01-05"),
                DateTime.Parse("2024-01-06")
            }
        },

        new()
        {
            Id = 2,
            Name = "Safron House",
            Blurb = "Stately home on the Devon moores",
            Location = "Devon",
            NumberOfBedrooms = 7,
            CostPerNight = 730,
            Description="Enjoy the tranquility of the forest, with hiking trails right at your doorstep",
            Amenities = new(){ "Wine Cellar", "Balinese Decor" },
            BookedDates = new()
            {
                DateTime.Parse("2023-12-04"),
                DateTime.Parse("2023-12-05"),
                DateTime.Parse("2023-12-06")
            }
        },

        new()
        {
            Id = 3,
            Name = "Seaside Retreat",
            Blurb = "Experience coastal living at its finest in this charming 2-bedroom beachfront cottage.",
            Location = "Malibu",
            NumberOfBedrooms = 2,
            CostPerNight = 250,
            Description="Wake up to the sound of waves and enjoy breathtaking ocean views from your private deck",
            Amenities = new(){ "Private Beach Access", "Oceanfront Deck", "Fully Equipped Kitchen", "Free Wi-Fi" },
            BookedDates = new()
            {
                DateTime.Parse("2023-12-15"),
                DateTime.Parse("2023-12-16"),
                DateTime.Parse("2023-12-17"),
                DateTime.Parse("2023-12-18")
            }
        },

        new()
        {
            Id = 4,
            Name = "City Lights Penthouse",
            Blurb = "Indulge in luxury at this sleek and modern 3-bedroom penthouse with panoramic city views.",
            Location = "New York City",
            NumberOfBedrooms = 3,
            CostPerNight = 500,
            Description="Wake up to the sound of waves and enjoy breathtaking ocean views from your private deck",
            Amenities = new(){ "Skyline View Terrace", "High-End Kitchen Appliances", "Smart Home Technology", "Fitness Center Access" },
            BookedDates = new()
            {
                DateTime.Parse("2023-12-21"),
                DateTime.Parse("2023-12-22"),
                DateTime.Parse("2024-02-17"),
                DateTime.Parse("2024-02-18")
            }
        },

        new()
        {
            Id = 5,
            Name = "Mountain Chalet Retreat",
            Blurb = "Escape to the mountains and unwind in this cozy 1-bedroom chalet surrounded by nature.",
            Location = "Aspen",
            NumberOfBedrooms = 1,
            CostPerNight = 150,
            Description="Wake up to the sound of waves and enjoy breathtaking ocean views from your private deck",
            Amenities = new(){ "Private Forest Trails", "Fireplace", "Outdoor Hot Tub", "Wi-Fi" },
            BookedDates = new()
            {
                DateTime.Parse("2024-03-04"),
                DateTime.Parse("2024-03-05"),
                DateTime.Parse("2024-03-06"),
                DateTime.Parse("2024-03-07")
            }
        },

        new()
        {
            Id = 6,
            Name = "Historic Villa Oasis",
            Blurb = "Immerse yourself in history at this elegant 4-bedroom villa, nestled in the heart of an ancient European town.",
            Location = "Tuscany",
            NumberOfBedrooms = 4,
            CostPerNight = 300,
            Description="Wake up to the sound of waves and enjoy breathtaking ocean views from your private deck",
            Amenities = new(){ "Private Forest Trails", "Fireplace", "Outdoor Hot Tub", "Wi-Fi" },
            BookedDates = new()
            {
                DateTime.Parse("2024-03-04"),
                DateTime.Parse("2024-03-05"),
                DateTime.Parse("2024-03-06"),
                DateTime.Parse("2024-03-07")
            }
        },

        new()
        {
            Id = 7,
            Name = "Tropical Paradise Bungalow",
            Blurb = "Unwind in this tropical 2-bedroom bungalow surrounded by lush gardens and just steps away from the beach.",
            Location = "Bali",
            NumberOfBedrooms = 2,
            CostPerNight = 200,
            Description="Wake up to the sound of waves and enjoy breathtaking ocean views from your private deck",
            Amenities = new(){ "Private Forest Trails", "Fireplace", "Outdoor Hot Tub", "Wi-Fi" },
            BookedDates = new()
            {
                DateTime.Parse("2024-03-04"),
                DateTime.Parse("2024-03-05"),
                DateTime.Parse("2024-03-06"),
                DateTime.Parse("2024-03-07")
            }
        }
    };

    public IActionResult ListAll()
    {
        return View("ListProperties", properties);
    }

    public IActionResult ListAvailable(DateTime start, DateTime end)
    {
        return View("ListProperties", properties.Where(p => !p.BookedDates.Any(d => d >= start && d <= end)).ToList());
    }

    public IActionResult ViewPropertyDetails(int id)
    {
        PropertyListingModel model = properties.FirstOrDefault(x => x.Id == id);

        return View("PropertyDetails", model);
    }
}
