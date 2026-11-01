using System;
using TourApp.Admin;
using TourApp.Client;
using TourApp.Tour;
using TourApp.Enrollment;

namespace TourApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            App app = new App();
            app.Start();


            AdminUI adminUI = new AdminUI();
            ClientUI clientUI = new ClientUI();
            TourUI tourUI = new TourUI();
            EnrollmentUI enrollmentUI = new EnrollmentUI();

            while (true)
            {
                Console.WriteLine("\n===== TOUR APP =====");
                Console.WriteLine("1. Admin Login");
                Console.WriteLine("2. Client Login");
                Console.WriteLine("3. Client Registration");
                Console.WriteLine("4. Exit");

                Console.Write("Enter choice: ");
                string choice = Console.ReadLine()!;

                if (choice == "1")
                {
                    bool result = adminUI.AdminLogin();

                    if (result == true)
                    {
                        adminUI.AdminMenu();
                    }
                }
                else if (choice == "2")
                {
                    ClientModel? cl = clientUI.ClientLogin();

                    if (cl != null)
                    {
                        clientUI.ClientMenu(cl);
                    }
                }
                else if (choice == "3")
                {
                    clientUI.RegisterClient();
                }
                else if (choice == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice!");
                }
            }
        }
    }
}
