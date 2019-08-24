using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserStore.BLL.DTO;

namespace UserStore.BLL.Interfaces
{
	public interface IDiscountCardService : IDisposable
	{
		void UpdateCard(DiscountCardDTO dto);
		void AddCard(DiscountCardDTO dto);
		DiscountCardDTO GetCard(int? id);

		IEnumerable<DiscountCardDTO> GetCards();
	}
}
