using System.Threading.Tasks;
using WebApplication.ViewModels.Product.Request;
using WebApplication.ViewModels.Product.Response;

namespace WebApplication.BusinessLogic.Services.Interfaces
{
	public interface IProductService
	{
		Task<GetProductByCategoryResponse> GetProductByCategory(GetProductByCategoryRequest request);

		Task<AddProductResponse> AddProduct(AddProductRequest request);
	}
}
