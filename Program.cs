using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 2;
            while (Convert.ToBoolean(choice))
            {
                Console.Clear();
                Console.WriteLine("Enter your Choice :\n1 for register Doctor\n2 for register Patient\n3 for book bed for patient");
                choice = int.Parse(Console.ReadLine());
                bool isPatientDetailAvailable = false;
                switch (choice)
                {
                    case 1:
                        CDoctor oDoctor = new CDoctor();
                        bool isDoctorDetailAvailable = false;
                        int dchoice = 2;
                        while (Convert.ToBoolean(dchoice))
                        {
                            Console.WriteLine("Press 1 for Enter the data\nPress 2 for display the data");
                            dchoice = int.Parse(Console.ReadLine());
                            if (dchoice == 1)
                            {
                                oDoctor.registerData();
                                isDoctorDetailAvailable = true;
                            }
                                
                            if (dchoice == 2 && isDoctorDetailAvailable==true)
                            {
                                oDoctor.displayData();
                            }

                            if (dchoice == 2 && isDoctorDetailAvailable == false)
                            {
                                Console.WriteLine("You don't have any detail to show. Enter the doctor detail first");
                                Console.ReadLine();
                            }

                        }
                        break;
                    case 2:
                        CPatient oPatient = new CPatient();
                        int pchoice = 2;
                        while (Convert.ToBoolean(pchoice))
                        {
                            Console.WriteLine("Press 1 for Enter the data\nPress 2 for display the data");
                            pchoice = int.Parse(Console.ReadLine());
                            if (pchoice == 1)
                            {
                                oPatient.registerData();
                                isPatientDetailAvailable = true;
                            }

                            if (pchoice == 2 && isPatientDetailAvailable == true)
                            {
                                oPatient.displayData();
                            }

                            if (pchoice == 2 && isPatientDetailAvailable == false)
                            {
                                Console.WriteLine("You don't have any detail to show. Enter the Patient detail first");
                                Console.ReadLine();
                            }

                        }
                        break;
                    case 3:
                        CBooking oBooking = new CBooking();
                        int bchoice = 2;
                        bool isBookingDetailAvailable = false;
                        while (Convert.ToBoolean(bchoice))
                        {
                            Console.WriteLine("Press 1 for Enter the data\nPress 2 for display the data");
                            bchoice = int.Parse(Console.ReadLine());
                            if (bchoice == 1)
                            {
                                oBooking.registerData();
                                isBookingDetailAvailable = true;
                            }

                            if (bchoice == 2 && isBookingDetailAvailable == true)
                            {
                                oBooking.displayData();
                            }

                            if (bchoice == 2 && isBookingDetailAvailable == false)
                            {
                                Console.WriteLine("You don't have any detail to show. Enter the Booking detail first");
                                Console.ReadLine();
                            }

                        }
                        break;

                    default:
                        Console.WriteLine("Please enter a Valid Choice");
                        break;
                }
            }

        }
    }
}
