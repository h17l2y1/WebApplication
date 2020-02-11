using System.Collections.Generic;

namespace WebApplication.ViewModels.Product.Response
{
	public class GetProductByCategoryResponse
	{
		public IEnumerable<GetProductByCategoryResponseItem> Products { get; set; }
	}

	public class GetProductByCategoryResponseItem
	{
		public string Id { get; set; }
		public string CategoryId { get; set; }
		public string Name { get; set; }
	}
}
