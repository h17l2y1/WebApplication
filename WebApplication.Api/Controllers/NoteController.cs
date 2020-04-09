using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication.BusinessLogic.Services.Interfaces;
using WebApplication.ViewModels.Note.Request;
using WebApplication.ViewModels.Note.Response;

namespace WebApplication.Api.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class NoteController : ControllerBase
	{
		private readonly INoteService _service;

		public NoteController(INoteService service)
		{
			_service = service;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			GetAllNotesResponse response = _service.GetAll();
			return Ok(response);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(string Id)
		{
			GetByIdNoteResponse response = _service.GetById(Id);
			return Ok(response);
		}

		[HttpPost]
		public async Task<IActionResult> Add([FromBody] AddNoteRequest request)
		{
			AddNoteResponse response = _service.Add(request);
			return Ok(response);
		}

		[HttpPut]
		public async Task<IActionResult> Update([FromBody] EditNoteRequest request)
		{
			EditNoteResponse response = _service.Update(request);
			return Ok(response);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(string Id)
		{
			DeleteNoteResponse response = _service.Delete(Id);
			return Ok(response);
		}

	}
}