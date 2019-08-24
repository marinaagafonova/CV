using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserStore.BLL.DTO
{
	public class OrderDTO
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }

		public decimal Price { get; set; }
		public int CustomerId { get; set; }

		public string CustomerName { get; set; }
	
		public ICollection<ProductDTO> Products { get; set; }
	}
}
