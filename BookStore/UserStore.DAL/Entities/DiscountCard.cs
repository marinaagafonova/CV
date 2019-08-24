using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserStore.DAL.Entities
{
	public class DiscountCard
	{
		[Key]
		[ForeignKey("Customer")]
		public int Id { get; set; }

		public string Code { get; set; }
		public Customer Customer { get; set; }
	}
}
