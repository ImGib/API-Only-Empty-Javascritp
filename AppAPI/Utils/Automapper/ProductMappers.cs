using AppAPI.DTO.ProductDTO;
using AppAPI.Models;
using AutoMapper;

namespace AppAPI.Utils.Automapper
{
    public class ProductMappers : Profile
    {
        public ProductMappers()
        {
            CreateMap<ProductRequest, Product>();
            CreateMap<Product, ProductResponse>();
        }
    }
}
