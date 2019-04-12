using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Sale
    {
        internal bool KeepPurchasing = false;
        public string Vendor { get; set; }
        public DateTime Date { get; set; }
        class Line
        {
            public string lineName;
            public short lineQuantity;
            public decimal linePrice;
            public decimal unitPrice;

            public string LineName { set { lineName = Console.ReadLine(); } }
            public decimal LineQuantity { set { lineQuantity = decimal.Parse(Console.ReadLine()}; }
            public decimal UnitPrice
            {
                get { return unitPrice; }
                set { unitPrice = value; }
            }

            public decimal LinePrice
            {
                get { return UnitPrice; }
                set { linePrice = (decimal)lineQuantity * unitPrice; }

            }

            public Line()
            {
                Console.WriteLine("Select one category " + Drink.drinks.ToString());

                Console.WriteLine("Quantity?");
            }


            
        }
        public static List<Line> lines = new List<Line>();
        Sale()
        {
           Line line = new Line()
           TotalPrice();
            Console.WriteLine("Your Shopping Bag is " + Sale.lines.ToString() + "With a Total of " + TotalPrice.ToStirng());
        }
        public decimal TotalPrice()
        {
            

        };




    }
}
