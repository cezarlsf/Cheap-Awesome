using System.Collections.Generic;

namespace CheapAwesome.Entities
{
	public class Hotel
	{
		public int PropertyId { get; set; }

		public string Name { get; set; }

		public int GeoId { get; set; }

		public int Rating { get; set; }

		public List<Rate> Rates { get; set; }
	}
}
