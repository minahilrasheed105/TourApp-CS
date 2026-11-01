using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}