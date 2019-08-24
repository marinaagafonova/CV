using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStore.Models.Product
{
	public class ProductViewModel
	{
		[Display(Name = "ID")]
		public int Id { get; set; }

		[Display(Name = "Название")]
		public string Name { get; set; }

		[Display(Name = "Цена")]
		public decimal Price { get; set; }
	}
}