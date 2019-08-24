using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserStore.DAL.Entities
{
	public class Order
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public decimal Price { get; set; }

		public int CustomerId { get; set; }
		public Customer Customer { get; set; }

		public ICollection<Product> Products { get; set; }

		public Order()
		{
			Products = new List<Product>();
		}
	}
}
