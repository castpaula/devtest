using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Product
    {
        public enum Categorias { }
      

        #region "Atributes"

        private string id;
        private Categorias category;
        private string brand;

        #region "Properties"

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

       public string Name { get; set; }
       public Categorias Category
        {
            get { return category; }
            set { category = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public short Stock { get; set; }

    }

        




}
