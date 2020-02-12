using WebApplication.Entities.Entities;
using WebApplication.ViewModels.Category.Response;
using WebApplication.ViewModels.Product.Request;
using WebApplication.ViewModels.Product.Response;

namespace WebApplication.BusinessLogic.Config
{
	public class MapperProfile : AutoMapper.Profile
	{
		public MapperProfile()
		{
			CreateMap<GetProductByCategoryResponseItem, Product>().ReverseMap();
			CreateMap<GetAllCategoryItem, Category>().ReverseMap();
			CreateMap<AddProductRequest, Product>().ReverseMap();
			CreateMap<AddProductResponse, Product>().ReverseMap();
		}
	}
}
