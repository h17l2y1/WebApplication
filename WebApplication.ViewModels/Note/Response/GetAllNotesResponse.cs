using System.Collections.Generic;

namespace WebApplication.ViewModels.Note.Response
{
	public class GetAllNotesResponse
	{
		public IEnumerable<GetAllNotesResponseItem> Notes { get; set; }
	}

	public class GetAllNotesResponseItem
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Data { get; set; }
	}
}

