using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserStore.BLL.DTO;

namespace UserStore.BLL.Interfaces
{
	public interface ICustomerService : IDisposable
	{
		void Update(CustomerDTO dto);
		void Add(CustomerDTO dto);
		void Delete(int? id);

		CustomerDTO Get(int? id);
		IEnumerable<CustomerDTO> GetAll();
	}
}