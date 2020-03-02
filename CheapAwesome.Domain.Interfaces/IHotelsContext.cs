using CheapAwesome.Entities;
using System.Collections.Generic;

namespace CheapAwesome.Domain.Interfaces
{
	public interface IHotelsContext
	{
		List<Hotel> GetBargains(int destinationId, int nights, string code);
	}
}
