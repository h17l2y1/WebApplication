using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.DataAccess.Config;
using WebApplication.DataAccess.Repositories.Interfaces;
using WebApplication.Entities.Entities;

namespace WebApplication.DataAccess.Repositories
{
	public class ProductRepository : BaseRepository<Product>, IProductRepository
	{
		public ProductRepository(ApplicationContext context) : base(context)
		{
		}

		public async Task<IEnumerable<Product>> GetProductByCategory(string categoryId)
		{
			//IEnumerable<Product> list = _context.
			return null;
		}
	}
}
