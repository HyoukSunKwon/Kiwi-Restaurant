using KiwiRestaurant.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiwiRestaurant.Data.Services
{
    public class SqlFoodData : IFoodData
    {
        private readonly FoodDbContext db;

        public SqlFoodData(FoodDbContext db)
        {
            this.db = db;
        }
        public void Add(Food food)
        {
            db.foods.Add(food);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Food Get(int id)
        {
            return db.foods.FirstOrDefault(f => f.Id == id);
        }

        public IEnumerable<Food> GetAll()
        {
            return from f in db.foods
                   orderby f.Name
                   select f;
        }

        public void Update(Food food)
        {
            var entry = db.Entry(food);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
