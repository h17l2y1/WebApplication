using System.Collections.Generic;
using WebApplication.Entities.Entities;

namespace WebApplication.DataAccess.Repositories.Interfaces
{
	public interface INoteRepository
	{
		string Add(Note entity);

		Note Get(string Id);

		IEnumerable<Note> GetAll();

		string Remove(string Id);

		Note Update(Note entity);
	}
}
