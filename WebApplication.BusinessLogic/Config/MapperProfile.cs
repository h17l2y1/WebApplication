using WebApplication.Entities.Entities;
using WebApplication.ViewModels.Note.Request;
using WebApplication.ViewModels.Note.Response;

namespace WebApplication.BusinessLogic.Config
{
	public class MapperProfile : AutoMapper.Profile
	{
		public MapperProfile()
		{
			CreateMap<EditNoteRequest, Note>().ReverseMap();
			CreateMap<EditNoteResponse, Note>().ReverseMap();
			CreateMap<AddNoteRequest, Note>().ReverseMap();
			CreateMap<AddNoteResponse, Note>().ReverseMap();
			CreateMap<GetByIdNoteResponse, Note>().ReverseMap();
			CreateMap<GetAllNotesResponseItem, Note>().ReverseMap();
		}
	}
}
