using System.Collections.Generic;
using System.Linq;
using WebApplication.DataAccess.Repositories.Interfaces;
using WebApplication.Entities.Entities;

namespace WebApplication.DataAccess.Repositories
{
	public class NoteRepository : INoteRepository
	{
		private readonly List<Note> _notes;

		public NoteRepository()
		{
			_notes = new List<Note>();
			AddDefaultNotes();
		}

		public string Add(Note entity)
		{
			_notes.Add(entity);
			return entity.Id;
		}

		public Note Get(string Id)
		{
			Note entity = _notes.SingleOrDefault(x => x.Id == Id);
			return entity;
		}

		public IEnumerable<Note> GetAll()
		{
			return _notes;
		}

		public string Remove(string Id)
		{
			var entity = _notes.FirstOrDefault(x => x.Id == Id);
			_notes.Remove(entity);
			return entity.Id;
		}

		public Note Update(Note entity)
		{
			var updatedEntity = _notes.FirstOrDefault(x => x.Id == entity.Id);
			updatedEntity.Name = entity.Name;
			updatedEntity.Description = entity.Description;
			updatedEntity.Data = entity.Data;
			return updatedEntity;
		}

		private void AddDefaultNotes()
		{
			for (int i = 0; i < 5; i++)
			{
				_notes.Add(
					new Note()
					{
						Name = $"Note {i}",
						Description = $"Description {i}",
						Data = $"Data {i}"
					});
			}
		}

	}
}
