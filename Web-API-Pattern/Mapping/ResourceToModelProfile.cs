using AutoMapper;
using Web_API_Pattern.Domain.Models;
using Web_API_Pattern.Domain.Models.Queries;
using Web_API_Pattern.Resources;

namespace Web_API_Pattern.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();

            CreateMap<SaveProductResource, Product>()
                .ForMember(src => src.UnitOfMeasurement, opt => opt.MapFrom(src => (EUnitOfMeasurement)src.UnitOfMeasurement));

            CreateMap<ProductsQueryResource, ProductsQuery>();
        }
    }
}