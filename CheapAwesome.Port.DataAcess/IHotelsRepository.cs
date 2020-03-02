using CheapAwesome.Entities;
using System.Collections.Generic;

namespace CheapAwesome.Port.DataAcess
{
	public interface IHotelsRepository
	{
		List<Hotel> GetBargains(int destinationId, int nights);
	}
}
