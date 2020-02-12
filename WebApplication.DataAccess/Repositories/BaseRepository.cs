using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.DataAccess.Config;
using WebApplication.DataAccess.Repositories.Interfaces;
using WebApplication.Entities.Entities.Interfaces;

namespace WebApplication.DataAccess.Repositories
{
	public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, IBaseEntity
	{
		private ApplicationContext _сontext { get; set; }

		protected DbSet<TEntity> _dbSet { get; set; }

		public BaseRepository(ApplicationContext context)
		{
			_сontext = context;
			_dbSet = _сontext.Set<TEntity>();
		}

		public virtual async Task<string> Add(TEntity entity)
		{
			await _dbSet.AddAsync(entity);
			await _сontext.SaveChangesAsync();
			return entity.Id;
		}

		public virtual async Task<TEntity> Get(string Id)
		{
			return await _dbSet.SingleOrDefaultAsync(x => x.Id == Id);
		}

		public virtual async Task<IEnumerable<TEntity>> GetAll()
		{
			return await _dbSet.ToListAsync();
		}

	}
}
