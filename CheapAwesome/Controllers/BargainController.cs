using System.Web;
using CheapAwesome.Ports.Web;
using Microsoft.AspNetCore.Mvc;

namespace CheapAwesome.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class BargainController : ControllerBase
	{
		private readonly IHotelsManager hotelsManager;

		public BargainController(IHotelsManager hotelsManager)
		{
			this.hotelsManager = hotelsManager;
		}
		/// <summary>
		/// Used to get the latest bargains for the specific destination and number of nights
		/// </summary>
		/// <param name="destinationId"> Id of the destination hotel</param>
		/// <param name="nights">Number of nights requested in the bargain</param>
		/// <param name="code">auth code</param>
		/// <returns></returns>
		[HttpGet]
		[Route("/findBargain")]
		public IActionResult FindBargain(int destinationId, int nights, string code)
		{
			var decodedCode = HttpUtility.UrlDecode(code);
			var result = hotelsManager.GetBargains(destinationId, nights, decodedCode);

			return new JsonResult(result);
		}
	}
}
