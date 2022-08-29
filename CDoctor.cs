using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class CDoctor : CommonClass, IDisplayData, IRegisterData
    {
        public int doctorID { get; set; }

        public string doctorName { get; set; }
        public int yearExperience { get; set; }

        public override void registerData()
        {
            Console.WriteLine("Please enter doctor's detail");
            Console.WriteLine("Enter Doctor Id Number");
            doctorID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            doctorName = Console.ReadLine();
            
            base.registerData();
            Console.WriteLine("Enter Experience");
            yearExperience = int.Parse(Console.ReadLine());

        }

        public void displayData()
        {
            Console.WriteLine($"Check Doctor's details\nID : {doctorID}\nName : {doctorName}\nPhone Number : {phoneNumber}\nEmail Id : {emailId}\nAddress : {address}\nGender : {gender}\nyearsExperience : {yearExperience}");

        }
    }
}
