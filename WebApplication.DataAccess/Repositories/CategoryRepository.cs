using WebApplication.DataAccess.Config;
using WebApplication.DataAccess.Repositories.Interfaces;
using WebApplication.Entities.Entities;

namespace WebApplication.DataAccess.Repositories
{
	public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
	{
		public CategoryRepository(ApplicationContext context) : base(context)
		{
		}
	}
}
