using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using WebApplication.BusinessLogic.Services;
using WebApplication.BusinessLogic.Services.Interfaces;
using WebApplication.DataAccess.Config;

namespace WebApplication.BusinessLogic.Config
{
	public static class ConfigureBusinessLogic
	{
		public static void InjectBusinessLogicDependency(this IServiceCollection services, IConfiguration сonfiguration)
		{
			var config = new AutoMapper.MapperConfiguration(c =>
			{
				c.AddProfile(new MapperProfile());
			});
			var mapper = config.CreateMapper();
			services.AddSingleton(mapper);

			services.InjectDataAccessDependency(сonfiguration);

		
			services.AddScoped<IDropDownService, DropDownService>();
			services.AddScoped<IProductService, ProductService>();
		}

	}
}
