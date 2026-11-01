using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourApp.Tour
{
    public class TourRepo
    {
        private List<TourModel> tours;
        private TourFile tourFile;

        public TourRepo()
        {
            tourFile = new TourFile();
            tours = tourFile.LoadTours();
        }
        public List<TourModel> GetAllTours()
        {
            return tours;
        }
        public void AddTour(TourModel tour)
        {
            tours.Add(tour);
            tourFile.SaveTours(tours);
        }

        public bool RemoveTour(string t_id)
        {
            foreach(TourModel tour in tours)
            {
                if(tour.TourId == t_id)
                {
                    tours.Remove(tour);
                    return true;
                }
            }
            return false;
        }
    }
}
