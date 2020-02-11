using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.Entities.Entities.Interfaces;

namespace WebApplication.DataAccess.Repositories.Interfaces
{
	public interface IBaseRepository<TEntity> where TEntity : IBaseEntity
	{
		Task<TEntity> Get(string id);

		Task<IEnumerable<TEntity>> GetAll();

		Task Add(TEntity entity);

		Task Update(TEntity entity);

		Task Remove(string id);
	}

}
