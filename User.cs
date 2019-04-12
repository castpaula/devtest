using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class User
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        
        }
        private string userId;

        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        private string passWord;

        protected string PassWord
        {
           set { passWord = value; }
        }

        public bool NewUser = false;

        do
	{
        Console.WriteLine("Please register yourself as user");
        Console.WriteLine("Employee ID number:")
        Name = Console.ReadLine();


	} while (true);

    }
}
