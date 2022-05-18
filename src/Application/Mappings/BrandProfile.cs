using AutoMapper;
using MinhasNoticias.Application.Features.Brands.Commands.AddEdit;
using MinhasNoticias.Application.Features.Brands.Queries.GetAll;
using MinhasNoticias.Application.Features.Brands.Queries.GetById;
using MinhasNoticias.Domain.Entities.Catalog;

namespace MinhasNoticias.Application.Mappings
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<AddEditBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsResponse, Brand>().ReverseMap();
        }
    }
}