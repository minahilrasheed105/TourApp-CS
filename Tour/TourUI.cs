using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourApp.Tour
{
    public class TourUI
    {
        private static TourService tourService;

        public TourUI()
        {
            tourService = new TourService();
        }

        public static void AddTour()
        {
            TourModel tour = new TourModel();

            Console.Write("Enter Tour ID: ");
            tour.TourId = Console.ReadLine()!;

            Console.Write("Enter Tour Title: ");
            tour.Title = Console.ReadLine()!;

            Console.Write("Enter Place: ");
            tour.Place = Console.ReadLine()!;

            Console.Write("Enter Date: ");
            tour.Date = Console.ReadLine()!;

            Console.Write("Enter Capacity: ");
            tour.Capacity = int.Parse(Console.ReadLine()!);

            Console.Write("Enter Tour Price: ");
            tour.Price = (Console.ReadLine()!);


            tourService.AddTour(tour);

            Console.WriteLine("Tour added successfully!");
        }

        public static void RemoveTour()
        {
            string t_id;
            Console.Write("Enter Tour ID: ");
            t_id = Console.ReadLine()!;

            bool result = tourService.RemoveTour(t_id);

            if (result)
            {
                Console.WriteLine("Tour Removed Successfully!");
            }
            else
            {
                Console.WriteLine("Tour Was not removed");
            }
        }

        public static void ViewAllTours()
        {
            Console.WriteLine("All Tours:");
            foreach (TourModel t in tourService.GetAllTours())
            {
                Console.WriteLine("ID: " + t.TourId);
                Console.WriteLine("Title: " + t.Title);
                Console.WriteLine("Place: " + t.Place);
                Console.WriteLine("Date: " + t.Date);
                Console.WriteLine("Capacity: " + t.Capacity);
                Console.WriteLine("Price: " + t.Price);
                Console.WriteLine();
            }
        }
        
       // public static void SearchTour()
       // {
           // string t_id;
           // Console.Write("Enter Tour ID: ");
           // t_id = Console.ReadLine()!;

           // List<TourModel> tours = tourService.GetAllTours();
            //foreach (TourModel t in tours)
          //  {
              //  if (t_id.Equals(t.TourId))
              //  {
                  //  Console.WriteLine("ID: " + t.TourId);
                   // Console.WriteLine("Title: " + t.Title);
                   // Console.WriteLine("Place: " + t.Place);
                   // Console.WriteLine("Date: " + t.Date);
                   // Console.WriteLine("Capacity: " + t.Capacity);
                   // Console.WriteLine("Price: " + t.Price);
                   // Console.WriteLine();
                  //  return;
               // }
           // }
            //Console.WriteLine("This tour doesn't exist!");
       // }


        public static void SearchToursbyPrice()
        {
            string writelowPrice;
            Console.Write("Enter lowest Price: ");
            writelowPrice = Console.ReadLine();

            string writeHighPrice;
            Console.Write("Enter  Price: ");
            writeHighPrice = Console.ReadLine()!;

            List<TourModel> tours = tourService.ViewToursByPrice();
            {
                foreach (TourModel t in tours)
                {

                }
            }
        }
        // get tour by id Exact Match
        public static void GettingTourbyId()
        {
            string t_id;
            Console.Write("Enter Tour ID: ");
            t_id = Console.ReadLine()!;

            List<TourModel> tours = tourService.GetAllTours();
            foreach (TourModel t in tours)
            {
                if (t_id.Equals(t.TourId))
                {
                    Console.WriteLine("ID: " + t.TourId);
                    Console.WriteLine("Title: " + t.Title);
                    Console.WriteLine("Place: " + t.Place);
                    Console.WriteLine("Date: " + t.Date);
                    Console.WriteLine("Capacity: " + t.Capacity);
                    Console.WriteLine("Price: " + t.Price);
                    Console.WriteLine();
                    return;
                }
            }
            Console.WriteLine("This tour doesn't exist!");
        }

        public static void SearchToursbyName()
        {
            string writelowPrice;
            Console.Write("Enter lowest Price: ");
            writelowPrice = Console.ReadLine();

            string writeHighPrice;
            Console.Write("Enter  Price: ");
            writeHighPrice = Console.ReadLine()!;

            List<TourModel> tours = tourService.ViewToursName();
            {
                foreach (TourModel t in tours)
                {

                }
            }
        }
    }
}