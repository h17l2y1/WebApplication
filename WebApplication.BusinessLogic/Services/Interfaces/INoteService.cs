using WebApplication.ViewModels.Note.Request;
using WebApplication.ViewModels.Note.Response;

namespace WebApplication.BusinessLogic.Services.Interfaces
{
	public interface INoteService
	{
		GetAllNotesResponse GetAll();

		GetByIdNoteResponse GetById(string request);

		AddNoteResponse Add(AddNoteRequest request);

		EditNoteResponse Update(EditNoteRequest request);

		DeleteNoteResponse Delete(string request);
	}
}
