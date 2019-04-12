using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Drink : Product
    {
        public string SubCategory { get; set; }
        public enum size { Mug = 0, Flagon = 1, Tankard = 2, Bottle = 3, Keg = 4 }
        public decimal price;
        public string Origin;
        Drink drink = new Drink();
        public static List<Drink> drinks = new List<Drink>();
        

    }
}
