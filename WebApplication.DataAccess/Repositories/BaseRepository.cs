using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.DataAccess.Config;
using WebApplication.DataAccess.Repositories.Interfaces;
using WebApplication.Entities.Entities.Interfaces;

namespace WebApplication.DataAccess.Repositories
{
	public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : IBaseEntity
	{
		protected ApplicationContext _context;

		public BaseRepository(ApplicationContext context)
		{
			_context = context;
		}

		public async Task Add(TEntity entity)
		{
			await _context.Set<TEntity>().AddAsync(entity);
			await _context.SaveChangesAsync();
		}

		public async Task<TEntity> Get(string id)
		{
			return await _context.Set<TEntity>().FindAsync(id);
		}

		public async Task<IEnumerable<TEntity>> GetAll()
		{
			return _context.Set<TEntity>();
		}

		public async Task Remove(string id)
		{
			var entity = await Get(id);
			_context.Set<TEntity>().Remove(entity);
			await _context.SaveChangesAsync();
		}

		public async Task Update(TEntity entity)
		{
			_context.Set<TEntity>().Update(entity);
			await _context.SaveChangesAsync();
		}
	}
}
