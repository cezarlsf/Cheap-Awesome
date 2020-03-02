using CheapAwesome.Domain;
using CheapAwesome.Domain.Interfaces;
using CheapAwesome.Entities;
using CheapAwesome.Port.DataAcess;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace CheapAwesomeDomain
{
	public class HotelsContext : IHotelsContext
	{
		private readonly IHotelsRepository hotelsRepository;
		private readonly ILogger<IHotelsContext> logger;

		public HotelsContext(ILogger<IHotelsContext> logger ,IHotelsRepository hotelsRepository)
		{
			//here we either initialise a context services or the repository for simplicity 
			this.logger = logger;
			this.hotelsRepository = hotelsRepository;
		}

		public List<Hotel> GetBargains(int destinationId, int nights, string code)
		{
			try
			{
				Validators.ValidateCode(code);
				return hotelsRepository.GetBargains(destinationId, nights);
			}
			catch (Exception ex)
			{
				//here we can either log the error and throw it further
				logger.LogError(ex.Message);
				throw;
			}
		}
	}
}
