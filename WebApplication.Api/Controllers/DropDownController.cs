using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication.BusinessLogic.Services.Interfaces;
using WebApplication.ViewModels.Category.Response;

namespace WebApplication.Api.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class DropDownController : ControllerBase
	{
		private readonly IDropDownService _service;

		public DropDownController(IDropDownService service)
		{
			_service = service;
		}

		[HttpGet]
		public async Task<IActionResult> GetCategories()
		{
			GetAllCategoryResponse response = await _service.GetAllCategories();
			return Ok(response);
		}
	}
}