using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStore.Models.Product
{
	public class ProductEditModel
	{
		[Display(Name = "Название")]
		[Required]
		public string Name { get; set; }

		[Display(Name = "Цена")]
		[Required]
		[Range(0, int.MaxValue, ErrorMessage = "Укажите корректную цену")]
		public decimal Price { get; set; }
	}
}