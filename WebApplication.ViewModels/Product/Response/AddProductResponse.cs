namespace WebApplication.ViewModels.Product.Response
{
	public class AddProductResponse
	{
		public string Id { get; set; }

		public AddProductResponse()
		{
		}

		public AddProductResponse(string id)
		{
			Id = id;
		}
	}
}
