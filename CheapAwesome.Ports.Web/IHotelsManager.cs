using CheapAwesome.Entities;
using System;
using System.Collections.Generic;

namespace CheapAwesome.Ports.Web
{
	public interface IHotelsManager
	{
		List<Hotel> GetBargains(int destinationId, int nights, string code);
	}
}
