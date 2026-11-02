using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TourApp.Tour
{
    public class TourFile
    {
        private string filePath = "tours.txt";

        public void SaveTours(List<TourModel> tours)
        {
            List<string> lines = new List<string>();

            foreach (TourModel tour in tours)
            {
                string line = tour.TourId + "|" +
                              tour.Title + "|" +
                              tour.Place + "|" +
                              tour.Date + "|" +
                              tour.Capacity + "|" +
                              tour.Price;


                lines.Add(line);
            }

            File.WriteAllLines(filePath, lines);
        }

        public List<TourModel> LoadTours()
        {
            List<TourModel> tours = new List<TourModel>();

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] data = line.Split('|');

                    TourModel tour = new TourModel();

                    tour.TourId = data[0];
                    tour.Title = data[1];
                    tour.Place = data[2];
                    tour.Date = data[3];
                    tour.Capacity = int.Parse(data[4]);
                    tour.Price = data[5];

                    tours.Add(tour);
                }
            }

            return tours;
        }
    }
}