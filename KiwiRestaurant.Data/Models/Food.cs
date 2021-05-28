using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiwiRestaurant.Data.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public FoodType FoodType { get; set; }
        public string FoodImg { get; set; }
        public string Description { get; set; }
    }
}
