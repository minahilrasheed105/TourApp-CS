using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourApp.Tour;

namespace TourApp.Tour
{
    public class TourService
    {
        private TourRepo tourRepo;

        public TourService()
        {
            tourRepo = new TourRepo();
        }

        public List<TourModel> GetAllTours()
        {
            return tourRepo.GetAllTours();
        }

        public void AddTour(TourModel tour)
        {
            tourRepo.AddTour(tour);
        }

        public bool RemoveTour(string t_id)
        {
            return tourRepo.RemoveTour(t_id);
        }

        public static string GetTourTitleById(string tourId)
        {
            TourRepo tourRepo = new TourRepo();
            TourModel? tour = tourRepo.GetAllTours().FirstOrDefault(t => t.TourId == tourId);
            return tour != null ? tour.Title : "Unknown Tour";
        }

        public static string GetTourPlaceById(string tourId)
        {
            TourRepo tourRepo = new TourRepo();
            TourModel? tour = tourRepo.GetAllTours().FirstOrDefault(t => t.TourId == tourId);
            return tour != null ? tour.Place : "Unknown Place";
        }
        public static void ViewToursByPrice()
        {
            TourRepo tourRepo = new TourRepo();

            var sortedTours = tourRepo.GetAllTours().OrderBy(t => t.Price).ToList();
              

            foreach (TourModel tour in sortedTours)
            {
                Console.WriteLine("ID: " + tour.TourId);
                Console.WriteLine("Title: " + tour.Title);
                Console.WriteLine("Place: " + tour.Place);
                Console.WriteLine("Price: " + tour.Price);

            }
        }
    }
}










//}public void UpdateTour(TourModel updatedTour)
//{
// TourModel? tour = tours.FirstOrDefault(
//  t => t.TourId == updatedTour.TourId);

//   if (tour != null)
//  {
//   tour.Title = updatedTour.Title;
//  tour.Place = updatedTour.Place;

//tourFile.SaveTours(tours);
//  }
//}

//