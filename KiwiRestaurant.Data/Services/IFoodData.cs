using KiwiRestaurant.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiwiRestaurant.Data.Services
{
    public interface IFoodData
    {
        IEnumerable<Food> GetAll();
    }


}
