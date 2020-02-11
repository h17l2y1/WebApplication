using WebApplication.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebApplication.DataAccess.Config
{
	public class ApplicationContext : IdentityDbContext<User>
	{
		public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
		{
		}

		public DbSet<Category> Categories { get; set; }

		public DbSet<Product> Products { get; set; }



		protected override void OnModelCreating(ModelBuilder builder)
		{
			var init = new AutoComplete();

			builder.Entity<Category>().HasData(init.CreateDefaultCategories().ToArray());

			base.OnModelCreating(builder);
		}
	}
}
