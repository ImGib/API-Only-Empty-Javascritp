using AppAPI.DTO.CategoryDTO;
using AppAPI.Models;
using AutoMapper;

namespace AppAPI.Utils.Automapper
{
    public class CategoryMappers : Profile
    {
        public CategoryMappers()
        {
            CreateMap<Category, CategoryResponse>();
            CreateMap<CategoryRequest, Category>();
        }
    }
}
