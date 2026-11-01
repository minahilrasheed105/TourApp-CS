using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourApp.Tour;

namespace TourApp.Enrollment
{
    public class EnrollmentModel
    {
        public string EnrollmentId { get; set; }
        public string ClientId { get; set; }
        public string TourId { get; set; }

        public string GetTourTitle()
        {
            // Assuming you have a method to get the tour title by tour ID
            return TourService.GetTourTitleById(TourId);
        }

        public string GetTourPlace()
        {
            // Assuming you have a method to get the tour place by tour ID
            return TourService.GetTourPlaceById(TourId);
        }
    }

}