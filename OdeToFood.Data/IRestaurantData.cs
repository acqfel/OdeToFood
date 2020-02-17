using System;
using System.Collections.Generic;
using System.Text;
using OdeToFood.Core;
using System.Linq;

namespace OdeToFood.Data
{
	public interface IRestaurantData
	{
		IEnumerable<Restaurant> GetAll();
	}

	public class InMemoryRestaurantData : IRestaurantData
	{
		List<Restaurant> restaurants;

		public InMemoryRestaurantData()
		{
			restaurants = new List<Restaurant>()
			{ 
				new Restaurant { Id = 1, Name = "Scott's Pizza", Location = "Maryland", Cuisine = CuisineType.Italian },
				new Restaurant { Id = 2, Name = "Andy's Taco", Location = "Miami", Cuisine = CuisineType.Mexican },
				new Restaurant { Id = 1, Name = "Indian Food X", Location = "New York", Cuisine = CuisineType.Indian }
			};
		}

		public IEnumerable<Restaurant> GetAll()
		{
			return from r in restaurants
				   orderby r.Name
				   select r;
		}
	}
}
