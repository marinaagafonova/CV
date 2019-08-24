using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using UserStore.Models.Product;

namespace UserStore.Models.Customer
{
	public class CustomerViewModel
	{
		[Display(Name = "ID")]
		public int Id { get; set; }

		[Display(Name = "Имя")]
		public string Name { get; set; }

		[Display(Name = "Адрес")]
		public string Address { get; set; }

		[Display(Name = "ID скидочной карты")]
		public int DiscountCardId { get; set; }

		[Display(Name = "Номер скидочной карты")]
		public string DiscountCardCode { get; set; }

		[Display(Name = "Число заказов")]
		public int OrdersCount
		{
			get { return (OrdersNames != null) ? OrdersNames.Count : 0; }
		}

		public ICollection<string> OrdersNames { get; set; }

	}
}