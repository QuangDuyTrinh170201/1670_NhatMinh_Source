using System.ComponentModel.DataAnnotations;

namespace _1670_NhatMinh_Source.Models
{
	public class Comment
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Content { get; set; }
		[Required]
		public DateTime Date { get; set; }
		public int BookId { get; set; }
		public Book Book { get; set; }
	}
}
