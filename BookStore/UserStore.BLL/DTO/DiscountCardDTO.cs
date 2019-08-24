using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStore.BLL.DTO
{
	public class DiscountCardDTO
	{
		public int Id { get; set; }
		public string Code { get; set; }

		public int CustomerId { get; set; }
		public string CustomerName { get; set; }
	}
}
