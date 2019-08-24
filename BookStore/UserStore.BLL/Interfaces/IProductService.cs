using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserStore.BLL.DTO;

namespace UserStore.BLL.Interfaces
{
	public interface IProductService : IDisposable
	{
		void Update(ProductDTO dto);
		void Add(ProductDTO dto);
		void Delete(int? id);

		ProductDTO Get(int? id);
		IEnumerable<ProductDTO> GetAll();
	}
}
