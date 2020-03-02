using CheapAwesome.Domain.Interfaces;
using CheapAwesome.Entities;
using CheapAwesome.Ports.Web;
using System.Collections.Generic;

namespace CheapAwesome.Adapters.Web
{
	public class HotelsManager : IHotelsManager
	{
		private readonly IHotelsContext hotelsContext;
		public HotelsManager(IHotelsContext hotelsContext)
		{
			//here we either initialise a context services or the repository for simplicity 
			this.hotelsContext = hotelsContext;
		}
		public List<Hotel> GetBargains(int destinationId, int nights,string code)
		{
			return this.hotelsContext.GetBargains(destinationId, nights, code);
		}
	}
}
