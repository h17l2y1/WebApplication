using Microsoft.Extensions.DependencyInjection;

namespace WebApplication.Api.Extensions
{
	public class CorsExtension
	{
		public static void Add(IServiceCollection services)
		{
			services.AddCors(options =>
			{
				options.AddPolicy("AllowAllPolicy",
					builder => builder.AllowAnyHeader().AllowAnyMethod().AllowCredentials().AllowAnyOrigin().WithExposedHeaders("Token-Expired"));

				options.AddPolicy("OriginPolicy",
					builder => builder.AllowAnyMethod().AllowAnyHeader().AllowCredentials().WithOrigins("http://localhost:4200"));
			});
		}
	}
}
