using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplication.DataAccess.Repositories;
using WebApplication.DataAccess.Repositories.Interfaces;

namespace WebApplication.DataAccess.Config
{
	public static class ConfigureDataAccess
	{
		public static void InjectDataAccessDependency(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddSingleton<INoteRepository, NoteRepository>();
		}
	}
}
