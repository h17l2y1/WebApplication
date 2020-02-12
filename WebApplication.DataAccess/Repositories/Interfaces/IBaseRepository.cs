using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApplication.DataAccess.Repositories.Interfaces
{
	public interface IBaseRepository<TEntity>
	{
		Task<TEntity> Get(string Id);

		Task<IEnumerable<TEntity>> GetAll();

		Task<string> Add(TEntity entity);
	}

}
