using Domain.Entities;

namespace Domain.Repositories;

public interface IPropertyRepository
{
    IEnumerable<Property> Properties { get; }

    IEnumerable<Property> GetProperties();
    Property GetPropertyById(int id);
    void AddProperty(Property property);
}
