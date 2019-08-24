using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using UserStore.Models.Product;

namespace UserStore.Models.Order
{
	public class OrderEditModel
	{
		[Display(Name = "Покупатель")]
		public int CustomerId { get; set; }

		[Display(Name = "Дата оформления")]
		[Required]
		public DateTime Date { get; set; }

		[Display(Name = "Цена")]
		[Required]
		[Range(0, int.MaxValue, ErrorMessage = "Укажите корректную цену")]
		public decimal Price { get; set; }

		[Display(Name = "Товары")]
		public ICollection<ProductViewModel> Products { get; set; }

		private List<int> _selectedProducts;

		public List<int> SelectedProducts
		{
			get
			{
				if (Products == null)
					Products = new List<ProductViewModel>();

				if (_selectedProducts == null)
				{
					_selectedProducts = Products.Select(m => m.Id).ToList();
				}
				return _selectedProducts;
			}
			set { _selectedProducts = value; }
		}

		public IEnumerable<SelectListItem> ProductsSelectList { get; set; }
	}
}