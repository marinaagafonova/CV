using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserStore.BLL.DTO;

namespace UserStore.BLL.Interfaces
{
	public interface IOrderService : IDisposable
	{
		void Update(OrderDTO dto);
		void Add(OrderDTO dto);
		void Delete(int? id);

		OrderDTO Get(int? id);
		IEnumerable<OrderDTO> GetAll();
	}
}
