using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class CPatient : CommonClass, IDisplayData, IRegisterData
    {
        public int patientID { get; set; }
        public string patientName { get; set; }
        public int age { get; set; }

        public string concern { get; set; }

        public override void registerData()
        {
            Console.WriteLine("Please enter patient's detail");
            Console.WriteLine("Enter Patient Id Number");
            patientID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            patientName = Console.ReadLine();
            base.registerData();
            Console.WriteLine("Enter Age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Concern");
            concern = Console.ReadLine();
        }

        public virtual void displayData()
        {
            Console.WriteLine($"Check patient's details\nID : {patientID}\nName : {patientName}\nPhone Number : {phoneNumber}\nEmail Id : {emailId}\nAddress : {address}\nGender : {gender}\nAge : {age}\nPlease Enter your Concern : {concern}");

        }
    }
}
