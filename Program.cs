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
                Console.WriteLine("Enter your Choice :\n1 for register Doctor\n2 for register Patient\n3 for book bed for patient\n0 for exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CDoctor oDoctor = new CDoctor();
                        bool isDoctorDetailAvailable = false;
                        int dchoice = 2;
                        while (Convert.ToBoolean(dchoice))
                        {
                            Console.WriteLine("Press 1 for Enter the data\nPress 2 for display the data\nPress 0 for exit");
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
                        bool isPatientDetailAvailable = false;
                        int pchoice = 2;
                        while (Convert.ToBoolean(pchoice))
                        {
                            Console.WriteLine("Press 1 for Enter the data\nPress 2 for display the data\nPress 0 for exit");
                            dchoice = int.Parse(Console.ReadLine());
                            if (dchoice == 1)
                            {
                                oPatient.registerData();
                                isDoctorDetailAvailable = true;
                            }

                            if (dchoice == 2 && isPatientDetailAvailable == true)
                            {
                                oPatient.displayData();
                            }

                            if (dchoice == 2 && isPatientDetailAvailable == false)
                            {
                                Console.WriteLine("You don't have any detail to show. Enter the doctor detail first");
                                Console.ReadLine();
                            }

                        }
                        break;
                    case 3:
                        CBooking oBooking = new CBooking();
                        oBooking.registerData();
                        oBooking.displayData();
                        Console.ReadLine();
                        break;
                        break;

                    default:
                        Console.WriteLine("Please enter a Valid Choice");
                        break;
                }
            }

        }
    }
}
