using AutoMapper;
using Web_API_Pattern.Domain.Models;
using Web_API_Pattern.Domain.Models.Queries;
using Web_API_Pattern.Extensions;
using Web_API_Pattern.Resources;

namespace Web_API_Pattern.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();

            CreateMap<Product, ProductResource>()
                .ForMember(src => src.UnitOfMeasurement,
                           opt => opt.MapFrom(src => src.UnitOfMeasurement.ToDescriptionString()));

            CreateMap<QueryResult<Product>, QueryResultResource<ProductResource>>();
        }
    }
}