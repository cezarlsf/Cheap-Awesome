using AutoFixture;
using CheapAwesome.Domain;
using CheapAwesome.Domain.Interfaces;
using CheapAwesome.Entities;
using CheapAwesome.Port.DataAcess;
using CheapAwesomeDomain;
using FakeItEasy;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using System.Collections.Generic;

namespace CheapAwesome.Tests
{
	public class Tests
	{
		private readonly Fixture fixture = new Fixture();

		[Test]
		public void Test1()
		{
			//Arrange
			var destinationId = fixture.Create<int>();
			var nights = fixture.Create<int>();
			var code = fixture.Create<string>();
			var fakeRepository = A.Fake<IHotelsRepository>();
			A.CallTo(() => fakeRepository.GetBargains(destinationId, nights)).Returns(GetHotels());
			var context = new HotelsContext(A.Fake<ILogger<IHotelsContext>>(), fakeRepository);


			//Act
			var result = context.GetBargains(destinationId,nights,code);

			//Assert
			Assert.That(result.Count, Is.GreaterThan(0));
			A.CallTo(() => fakeRepository.GetBargains(A<int>.Ignored, A<int>.Ignored)).MustHaveHappened();
			//various data validators
		}

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
	}
}