using AutoMapper;
using System.Collections.Generic;
using WebApplication.BusinessLogic.Services.Interfaces;
using WebApplication.DataAccess.Repositories.Interfaces;
using WebApplication.Entities.Entities;
using WebApplication.ViewModels.Note.Request;
using WebApplication.ViewModels.Note.Response;

namespace WebApplication.BusinessLogic.Services
{
	public class NoteService : INoteService
	{
		private readonly IMapper _mapper;
		private readonly INoteRepository _noteRepository;

		public NoteService(IMapper mapper, INoteRepository productRepository)
		{
			_mapper = mapper;
			_noteRepository = productRepository;
		}

		public GetAllNotesResponse GetAll()
		{
			IEnumerable<Note> notes = _noteRepository.GetAll();
			var response = new GetAllNotesResponse();
			response.Notes = _mapper.Map<IEnumerable<GetAllNotesResponseItem>>(notes);

			return response;
		}

		public GetByIdNoteResponse GetById(string Id)
		{
			Note note = _noteRepository.Get(Id);
			GetByIdNoteResponse response = _mapper.Map<GetByIdNoteResponse>(note);
			return response;
		}

		public AddNoteResponse Add(AddNoteRequest request)
		{
			Note entity = _mapper.Map<Note>(request);
			_noteRepository.Add(entity);
			AddNoteResponse response = _mapper.Map<AddNoteResponse>(entity);
			return response;
		}

		public EditNoteResponse Update(EditNoteRequest request)
		{
			Note entity = _mapper.Map<Note>(request);
			Note updatedEntity = _noteRepository.Update(entity);
			var response = _mapper.Map<EditNoteResponse>(updatedEntity);
			return response;
		}

		public DeleteNoteResponse Delete(string Id)
		{
			_noteRepository.Remove(Id);
			var response = new DeleteNoteResponse(Id);
			return response;
		}

	}
}
