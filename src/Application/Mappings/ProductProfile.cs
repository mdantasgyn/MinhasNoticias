using AutoMapper;
using MinhasNoticias.Application.Features.Products.Commands.AddEdit;
using MinhasNoticias.Domain.Entities.Catalog;

namespace MinhasNoticias.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}