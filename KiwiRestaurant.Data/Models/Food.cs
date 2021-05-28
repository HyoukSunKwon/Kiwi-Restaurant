using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiwiRestaurant.Data.Models
{
    public class Food
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(0.01, 1000.00, 
            ErrorMessage = "Price must be between 0.01 and  100.00")]
        [DisplayName("Price ($)")]
        [Required]
        public float Price { get; set; }

        [DisplayName("Type of Food")]
        [Required]
        public FoodType FoodType { get; set; }

        [DisplayName("Image of Food")]
        //[Required]
        public string FoodImg { get; set; }

        [StringLength(1024)]
        [Required]
        public string Description { get; set; }
    }
}
