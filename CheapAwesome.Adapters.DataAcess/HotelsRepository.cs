using CheapAwesome.Entities;
using CheapAwesome.Port.DataAcess;
using System.Collections.Generic;

namespace CheapAwesome.Adapters.DataAcess
{
	public class HotelsRepository : IHotelsRepository
	{
		private readonly string connectionString;

		public HotelsRepository()
		{
			//initialise connection string from app setting or some custom configurations per customer
			connectionString = string.Empty;
		}

		public List<Hotel> GetBargains(int destinationId, int nights)
		{
			//here using the micro orm dapper or other microORM or ORM we will get the bargrain list
			//on this example I will go with premade data for simplicity

			// exception handling, here we could throw some usual sql exception or if no results are found some custom exception
			return GetHotels();
		}
		#region harcodedData
		private List<Hotel> GetHotels()
		{
			var hotels = new List<Hotel>();
			var hotel1Rates = new List<Rate>{
				new Rate{RateType="PerNight",
						 BoardType = "No Meals",
						 Value = 207.6},
				new Rate{RateType="PerNight",
						 BoardType = "Half Board",
						 Value = 242.2},
				new Rate{RateType="PerNight",
						 BoardType = "Full Board",
						 Value = 276.8},};
			var firstHotel = new Hotel
			{
				PropertyId = 79732,
				Name = "JAC Canada (CA$)8314",
				GeoId = 279,
				Rating = 3,
				Rates = hotel1Rates
			};

			var hotel2Rates = new List<Rate>{
				new Rate{RateType="PerNight",
						 BoardType = "No Meals",
						 Value = 590.4},
				new Rate{RateType="PerNight",
						 BoardType = "Half Board",
						 Value = 688.8},
				new Rate{RateType="PerNight",
						 BoardType = "Full Board",
						 Value = 787.2},};
			var secondHotel = new Hotel
			{
				PropertyId = 79821,
				Name = "JAC Canada (CA$)8555",
				GeoId = 279,
				Rating = 3,
				Rates = hotel2Rates
			};

			hotels.Add(firstHotel);
			hotels.Add(secondHotel);

			return hotels;
		}

		#endregion
	}
}
