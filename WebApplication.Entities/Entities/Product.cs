using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Entities.Entities
{
	public class Product : BaseEntity
	{
		public string Name { get; set; }
		public string CategoryId { get; set; }

		[ForeignKey("CategoryId")]
		[NotMapped]
		public virtual Category Category { get; set; }
	}
}
