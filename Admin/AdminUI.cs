using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourApp.Tour;
using TourApp.Client;
using TourApp.Enrollment;

namespace TourApp.Admin
{
    public class AdminUI
    {
        public bool AdminLogin()
        {
            Console.Write("Enter Admin ID: ");
            string id = Console.ReadLine()!;

            Console.Write("Enter Password: ");
            string password = Console.ReadLine()!;

            if (id == "1001" && password == "123")
            {
                Console.WriteLine("Admin Login Successful!");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid ID or Password!");
                return false;
            }
        }
        public void AdminMenu()
        {
            while (true)
            {
                Console.WriteLine("\n===== ADMIN MENU =====");
                Console.WriteLine("1. Add Tour");
                Console.WriteLine("2. Remove Tour");
                Console.WriteLine("3. View All Tours");
                Console.WriteLine("4. Search a Tour by ID");
                Console.WriteLine("5. View All Clients");
                Console.WriteLine("6. View All Enrollments");
                Console.WriteLine("7. Logout");

                Console.Write("Enter choice: ");
                string choice = Console.ReadLine()!;

                if (choice == "1")
                {
                    TourUI.AddTour();
                }
                else if (choice == "2")
                {
                    TourUI.RemoveTour();
                }
                else if (choice == "3")
                {
                    TourUI.ViewAllTours();
                }
                else if (choice == "4")
                {
                    TourUI.SearchTour();
                }
                else if (choice == "5")
                {
                    ClientUI.ViewAllClients();
                }
                else if (choice == "6")
                {
                    EnrollmentUI.ViewAllEnrollments();
                }
                else if (choice == "7")
                {
                    Console.WriteLine("Logging out...");
                    break;
                }
               // else if (choice == "8"){Console.WriteLine("View Tours Sorted By Price");

                else
                {
                    Console.WriteLine("Wrong Choice!");
                }
            }
        }
    }
}