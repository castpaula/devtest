using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Service : Product
    {
        public string SubCategory { get; set; }
        public enum size { SingleRoom = 0; DoubleRoom = 1; CommonRoom = 2, Bath = 3, Charity = 4 }
        public decimal price;
        Service service = new Service();
        public List<Service> services = new List<Service>;

    }
}
