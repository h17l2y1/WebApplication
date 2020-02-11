using System.Collections.Generic;
using WebApplication.Entities.Entities;

namespace WebApplication.DataAccess.Config
{
	public class AutoComplete
	{
		public List<Category> CreateDefaultCategories()
		{
			var list = new List<Category>();

			list.Add(new Category { Name = "Samsung" });
			list.Add(new Category { Name = "Apple" });
			list.Add(new Category { Name = "Meizu" });

			return list;
		}
	}
}
