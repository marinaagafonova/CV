using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStore.Models.Product
{
	public class CustomerEditModel
	{
		[Display(Name = "Имя")]
		[Required]
		public string Name { get; set; }

		[Display(Name = "Адрес")]
		[Required]
		public string Address { get; set; }
	}
}