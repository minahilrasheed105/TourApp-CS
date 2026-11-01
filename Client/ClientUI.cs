using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

using TourApp.Tour;
using TourApp.Enrollment;

namespace TourApp.Client
{
    public class ClientUI
    {
        private static ClientService clientService;

        public ClientUI()
        {
            clientService = new ClientService();
        }

        public void RegisterClient()
        {
            ClientModel client = new ClientModel();

            Console.Write("Enter Client ID: ");
            client.ClientId = Console.ReadLine()!;

            Console.Write("Enter Password: ");
            client.Password = Console.ReadLine()!;

            Console.Write("Enter Name: ");
            client.ClientName = Console.ReadLine()!;

            Console.Write("Enter Email: ");
            client.Email = Console.ReadLine()!;

            Console.Write("Enter Phone: ");
            client.Phone = Console.ReadLine()!;

            clientService.RegisterClient(client);

            Console.WriteLine("Client registered successfully!");
        }
        
        public ClientModel? ClientLogin()
        {
            Console.Write("Enter Client ID: ");
            string id = Console.ReadLine()!;

            Console.Write("Enter Password: ");
            string password = Console.ReadLine()!;

            List<ClientModel> clients = clientService.GetAllClients();

            foreach (ClientModel client in clients)
            {
                if (client.ClientId == id && client.Password == password)
                {
                    Console.WriteLine("Login Successful!");
                    return client;
                }
            }

            Console.WriteLine("Invalid ID or Password!");
            return null;
        }
        public void ClientMenu(ClientModel client)
        {
            while (true)
            {
                Console.WriteLine("\n===== CLIENT MENU =====");
                Console.WriteLine("1. View All Tours");
                Console.WriteLine("2. Enroll in a Tour");
                Console.WriteLine("3. View My Enrollments");
                Console.WriteLine("4. Logout");

                Console.Write("Enter choice: ");
                string choice = Console.ReadLine()!;
                if(choice == "1")
                {
                    TourUI.ViewAllTours();
                }
                else if (choice == "2")
                {
                    EnrollmentUI.AddEnrollment(client.ClientId);
                }
                else if (choice == "3")
                {
                    EnrollmentUI.ViewClientEnrollments(client.ClientId);
                }
                else if (choice == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong Choice!");
                }
            }
        }
        public static void ViewAllClients()
        {
            Console.WriteLine("All Clients:");
            foreach (ClientModel c in clientService.GetAllClients())
            {
                Console.WriteLine("ID: " + c.ClientId);
                Console.WriteLine("Name: " + c.ClientName);
                Console.WriteLine("Email: " + c.Email);
                Console.WriteLine("Phone: " + c.Phone);
                Console.WriteLine();
            }
        }
    }
}