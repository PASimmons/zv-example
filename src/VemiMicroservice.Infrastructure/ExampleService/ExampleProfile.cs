using AutoMapper;
using VemiMicroservice.Domain.Models;

namespace VemiMicroservice.Infrastructure.ExampleService
{
    public class ExampleProfile : Profile
    {
        public ExampleProfile()
        {
            CreateMap<ExampleEntity, Example>()
                .ReverseMap();
        }
    }
}