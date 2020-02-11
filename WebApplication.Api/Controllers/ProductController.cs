using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication.BusinessLogic.Services.Interfaces;
using WebApplication.ViewModels.Product.Request;
using WebApplication.ViewModels.Product.Response;

namespace WebApplication.Api.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IProductService _service;

		public ProductController(IProductService service)
		{
			_service = service;
		}

		[HttpPost]
		public async Task<IActionResult> GetProducts([FromBody] GetProductByCategoryRequest request)
		{
			GetProductByCategoryResponse response = await _service.GetProductByCategory(request);
			return Ok(response);
		}

		[HttpPost]
		public async Task<IActionResult> AddProduct([FromBody] AddProductRequest request)
		{
			AddProductResponse response = await _service.AddProduct(request);
			return Ok(response);
		}

	}
}