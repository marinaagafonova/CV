using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStore.Models.DiscountCard
{
	public class DiscountCardEditModel
	{
		[Display(Name = "Код карты")]
		[Required]
		public string Code { get; set; }

	

	}
}