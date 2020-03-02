using CheapAwesome.Adapters.DataAcess;
using CheapAwesome.Adapters.Web;
using CheapAwesome.Domain.Interfaces;
using CheapAwesome.Port.DataAcess;
using CheapAwesome.Ports.Web;
using CheapAwesomeDomain;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheapAwesome.DI
{
	public static class ServiceExtensions
	{
		public static IServiceCollection AddServices(this IServiceCollection services)
		{
			services.AddTransient<IHotelsRepository, HotelsRepository>();
			services.AddTransient<IHotelsContext, HotelsContext>();
			services.AddTransient<IHotelsManager, HotelsManager>();
			return services;
		}
	}
}
