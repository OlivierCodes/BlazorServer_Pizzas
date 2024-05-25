using BlazorPizzas.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorPizzas.Services
{
	public interface IPizzaManager
	{
		Task<IEnumerable<Pizza>> GetPizzas();

		Task AddOrUpdate(Pizza p);
	}
}
