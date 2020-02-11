using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.Entities.Entities;

namespace WebApplication.DataAccess.Repositories.Interfaces
{
	public interface IProductRepository : IBaseRepository<Product>
	{
		Task<IEnumerable<Product>> GetProductByCategory(string categoryId);
	}
}
