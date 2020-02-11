using System.Collections.Generic;

namespace WebApplication.ViewModels.Category.Response
{
	public class GetAllCategoryResponse
	{
		public IEnumerable<GetAllCategoryItem> Categories { get; set; }
	}

	public class GetAllCategoryItem
	{
		public string Id { get; set; }
		public string Name { get; set; }
	}
}
