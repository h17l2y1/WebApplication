using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplication.DataAccess.Repositories;
using WebApplication.DataAccess.Repositories.Interfaces;
using WebApplication.Entities.Entities;

namespace WebApplication.DataAccess.Config
{
	public static class ConfigureDataAccess
	{
		public static void InjectDataAccessDependency(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddIdentity<User, UserRole>().AddEntityFrameworkStores<ApplicationContext>();

			services.AddDbContext<ApplicationContext>(options =>
			options.UseSqlServer(configuration.GetSection("ConnectionStrings:DefaultConnection").Value));


			services.AddTransient<ICategoryRepository, CategoryRepository>();
			services.AddTransient<IProductRepository, ProductRepository>();
		}
	}
}
