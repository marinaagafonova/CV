using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserStore.DAL.Entities
{
	public class Customer
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }

		public DiscountCard DiscountCard { get; set; }

		public ICollection<Order> Orders { get; set; }

		public Customer()
		{
			Orders = new List<Order>();
		}
	}
}
