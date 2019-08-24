using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStore.BLL.DTO
{
	public class CustomerDTO
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }

		public int DiscountCardId { get; set; }
		public string DiscountCardCode { get; set; }

		public ICollection<OrderDTO> Orders { get; set; }
	}
}
