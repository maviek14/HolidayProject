using Domain.Entities;

namespace Domain.Repositories;

public interface IPropertyRepository
{
    IEnumerable<Property> GetProperties();
    void AddProperty(Property property);
}
