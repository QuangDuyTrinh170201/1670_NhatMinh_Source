namespace _1670_NhatMinh_Source.Models
{
	public class Category
	{
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }

		public ICollection<Book> Books { get; set; }
	}
}
