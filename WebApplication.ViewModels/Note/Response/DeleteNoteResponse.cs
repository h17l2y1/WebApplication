namespace WebApplication.ViewModels.Note.Response
{
	public class DeleteNoteResponse
	{
		public string Id { get; set; }
		public bool IsRemoved { get; set; }

		public DeleteNoteResponse(string removedId)
		{
			Id = removedId;
			IsRemoved = true;
		}
	}
}
