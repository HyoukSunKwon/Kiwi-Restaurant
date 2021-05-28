using KiwiRestaurant.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiwiRestaurant.Data.Services
{
    public class InMemoryFoodData : IFoodData
    {
        List<Food> foods;

        public InMemoryFoodData()
        {
            foods = new List<Food>()
            {
                new Food {Id = 1 , Name = " Hawaiian Pizza", Price = 12 , FoodImg = " " , Description = " Delicious" , FoodType = FoodType.Pizza},
                new Food {Id = 2 , Name = " Sea Food Pasta", Price = 12 , FoodImg = " " , Description = " Delicious" , FoodType = FoodType.Pasta},
            };
        }

        public IEnumerable<Food> GetAll()
        {
            return foods.OrderBy(f => f.Name);
        }
    }
}
