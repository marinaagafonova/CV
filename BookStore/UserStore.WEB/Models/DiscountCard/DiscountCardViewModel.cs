using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStore.Models.DiscountCard
{
    public class DiscountCardViewModel
    {
		public int Id { get; set; }

		[Display(Name = "Имя покупателя")]
		public string CustomerName { get; set; }

		[Display(Name = "Код карты")]
		public string Code { get; set; }

	}
}
