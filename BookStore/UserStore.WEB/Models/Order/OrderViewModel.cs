using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserStore.Models.Product;

namespace UserStore.Models.Order
{
	public class OrderViewModel
	{
		[Display(Name = "ID")]
		public int Id { get; set; }

		[Display(Name = "ID покупателя")]
		public int CustomerId { get; set; }

		[Display(Name = "Имя покупателя")]
		public string CustomerName { get; set; }

		[Display(Name = "Дата оформления")]
		public DateTime Date { get; set; }

		[Display(Name = "Цена")]
		public decimal Price { get; set; }

		[Display(Name = "Товары")]
		public ICollection<ProductViewModel> Products { get; set; }
	}
}