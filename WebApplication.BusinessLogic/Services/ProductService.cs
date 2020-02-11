using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.BusinessLogic.Services.Interfaces;
using WebApplication.DataAccess.Repositories.Interfaces;
using WebApplication.Entities.Entities;
using WebApplication.ViewModels.Product.Request;
using WebApplication.ViewModels.Product.Response;

namespace WebApplication.BusinessLogic.Services
{
	public class ProductService : IProductService
	{
		private readonly IMapper _mapper;
		private readonly IProductRepository _productRepository;

		public ProductService(IMapper mapper, IProductRepository productRepository)
		{
			_mapper = mapper;
			_productRepository = productRepository;
		}

		public async Task<GetProductByCategoryResponse> GetProductByCategory(GetProductByCategoryRequest request)
		{
			IEnumerable<Product> products = await GetFilteredProducts(request);
			var response = new GetProductByCategoryResponse();
			response.Products = _mapper.Map<IEnumerable<GetProductByCategoryResponseItem>>(products);
			return response;
		}

		private async Task<IEnumerable<Product>> GetFilteredProducts(GetProductByCategoryRequest request)
		{
			if (request.CategoryId != null)
			{
				IEnumerable<Product> filteredProducts = await _productRepository.GetProductByCategory(request.CategoryId);
				return filteredProducts;
			}
			IEnumerable<Product> categories = await _productRepository.GetAll();
			return categories;
		}
	}
}
