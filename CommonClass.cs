using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class CommonClass
    {

        public int phoneNumber { get; set; }

        public string emailId { get; set; }

        public string address { get; set; }

        public string gender { get; set; }

        public virtual void registerData()
        {
        //    Console.WriteLine("Enter Id Number");
        //    id = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Name");
            //name = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            phoneNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Email Id");
            emailId = Console.ReadLine();
            Console.WriteLine("Enter Address");
            address = Console.ReadLine();
            Console.WriteLine("Enter Gender");
            gender = Console.ReadLine();
        }
    }
}
