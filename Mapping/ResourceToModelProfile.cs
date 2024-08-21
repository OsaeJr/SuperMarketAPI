using AutoMapper;
using SupermarketAPI.Domain.Models;
using SupermarketAPI.Resources;
using SupermarketAPI.Domain.Models;
using SupermarketAPI.Resources;

namespace Supermarket.API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
        }
    }
}