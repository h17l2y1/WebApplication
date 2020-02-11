using Microsoft.AspNetCore.Identity;

namespace WebApplication.Entities.Entities
{
	public class UserRole : IdentityRole
	{
		public UserRole()
		{
		}

		public UserRole(string name) : base(name)
		{
		}
	}
}
