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

        public void Add(Food food)
        {
            foods.Add(food);
            food.Id = foods.Max(f => f.Id) + 1;
        }

        public Food Get(int id)
        {
            return foods.FirstOrDefault(f => f.Id == id);
        }

        public IEnumerable<Food> GetAll()
        {
            return foods.OrderBy(f => f.Name);
        }

        public void Update(Food food)
        {
            var existing = Get(food.Id);
            if(existing != null)
            {
                existing.Name = food.Name;
                existing.Price = food.Price;
                existing.FoodType = food.FoodType;
                existing.FoodImg = food.FoodImg;
                existing.Description = food.Description;
            }

        }
    }
}
