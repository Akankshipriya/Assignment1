using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class CBooking: CPatient, IDisplayData
    {
        public int bedBookingId { get; set; }
        public DateTime bookingTime { get; set; }

        public override void registerData()
        {
            Random rd = new Random();
            Console.WriteLine("Enter the following to book your appointment");
            bedBookingId = rd.Next(100, 999);
            Console.WriteLine("Enter patient Name");
            patientName = Console.ReadLine();
            Console.WriteLine("Enter the time when you want to book the Bed(Format: 1/1/2010 12:10:15 PM)");
            bookingTime =Convert.ToDateTime(Console.ReadLine());
        }

        public override void displayData()
        {
            Console.WriteLine($"Booking Detail\n Id : {bedBookingId}\nPatient Name : {patientName}\nPatient Age:{age}\nTime : {bookingTime}");
        }

    }
}
