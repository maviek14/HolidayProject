using Domain.Entities;

namespace Domain.Repositories;

public class DummyPropertyRepository : IPropertyRepository
{
    private List<Property> properties = new()
    {
        new()
        {
            PropertyId = 1,
            Name = "Rose Cottage",
            Blurb = "Beautiful cottage on the Cornwall coast",
            Location = "Cornwall",
            NumberOfBedrooms = 3,
            CostPerNight = 350,
            Description = "Wake up to the sound of waves and enjoy breathtaking ocean views from your private deck",
            //Amenities = new(){ "Free Wi-Fi", "Fully Equipped Kitchen" },
            BookedNights = new List<BookedNight>(){ }
        },

        new()
        {
            PropertyId = 2,
            Name = "Safron House",
            Blurb = "Stately home on the Devon moores",
            Location = "Devon",
            NumberOfBedrooms = 7,
            CostPerNight = 730,
            Description="Enjoy the tranquility of the forest, with hiking trails right at your doorstep",
            //Amenities = new(){ "Wine Cellar", "Balinese Decor" },
            BookedNights = new List<BookedNight>(){ }
        },

        new()
        {
            PropertyId = 3,
            Name = "Seaside Retreat",
            Blurb = "Experience coastal living at its finest in this charming 2-bedroom beachfront cottage.",
            Location = "Malibu",
            NumberOfBedrooms = 2,
            CostPerNight = 250,
            Description="Wake up to the sound of waves and enjoy breathtaking ocean views from your private deck",
            //Amenities = new(){ "Private Beach Access", "Oceanfront Deck", "Fully Equipped Kitchen", "Free Wi-Fi" },
            BookedNights = new List<BookedNight>(){ }
        },

        new()
        {
            PropertyId = 4,
            Name = "City Lights Penthouse",
            Blurb = "Indulge in luxury at this sleek and modern 3-bedroom penthouse with panoramic city views.",
            Location = "New York City",
            NumberOfBedrooms = 3,
            CostPerNight = 500,
            Description="Wake up to the sound of waves and enjoy breathtaking ocean views from your private deck",
            //Amenities = new(){ "Skyline View Terrace", "High-End Kitchen Appliances", "Smart Home Technology", "Fitness Center Access" },
            BookedNights = new List<BookedNight>(){ }
        }
    };

    public void AddProperty(Property property)
    {
        properties.Add(property);
    }

    public IEnumerable<Property> GetProperties()
    {
        return properties;
    }

    public Property GetPropertyById(int id)
    {
        return properties.FirstOrDefault(p => p.PropertyId == id);
    }
}
