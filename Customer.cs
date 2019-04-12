using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Customer
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        private string postCode;

        public string PostCode
        {
            get { return postCode; }
            set { postCode = value; }
        }

        private int nif;

        protected string Nif
        {
            set { nif = value; }
        }

    }
}
