using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Food : Product
    {
        public string SubCategory { get; set; }
        public enum size { Normal = 0; Kid = 1; Charity = 2, TakeAway = 3, Catering = 4 }
        public decimal price;
        public string Origin;
        Food food = new Food();
        public static List<Food> Foods = new List<Food>();
    }
}
