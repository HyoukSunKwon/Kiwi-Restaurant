using KiwiRestaurant.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiwiRestaurant.Data.Services
{
    public class FoodDbContext : DbContext
    {
        public DbSet<Food> foods { get; set; }
    }
}
