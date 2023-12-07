using Domain.Entities;

namespace Domain.Repositories;

public interface IPropertyRepository
{
    IEnumerable<Property> GetProperties();
    IEnumerable<Property> GetPropertiesBetweenDates(DateTime start, DateTime end);
    Property GetPropertyById(int id);
    void AddProperty(Property property);
}
