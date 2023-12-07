using AutoMapper;
using Domain.Entities;
using HolidayProject.Models;

namespace HolidayProject.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Property, PropertyDetailsModel>();
        CreateMap<PropertyDetailsModel, Property>();
    }
}
