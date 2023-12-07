using Domain.Data;
using Domain.Entities;

namespace Domain.Repositories;

public class EfPropertyRepository : IPropertyRepository
{
    private readonly ApplicationDbContext context;

    public EfPropertyRepository(ApplicationDbContext context)
    {
        this.context = context;
    }

    public void AddProperty(Property property)
    {
        context.Properties.Add(property);
        context.SaveChanges();
    }

    public IEnumerable<Property> GetProperties()
    {
        return context.Properties;
    }

    public IEnumerable<Property> GetPropertiesBetweenDates(DateTime start, DateTime end)
    {
        return context.Properties.Where(p => !p.BookedNights.Any(d => d.Night >= start && d.Night <= end));
    }

    public Property GetPropertyById(int id)
    {
        return context.Properties.FirstOrDefault(p => p.PropertyId == id);
    }


}
