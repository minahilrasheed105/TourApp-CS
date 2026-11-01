using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourApp.Enrollment
{
    public class EnrollmentFile
    {
        private string filePath = "enrollment.txt";
        public void SaveEnrollments(List<EnrollmentModel> enrollments)
        {
            List<string> lines = new List<string>();

            foreach (EnrollmentModel enrollment in enrollments)
            {
                string line = enrollment.EnrollmentId + "|" +
                             enrollment.ClientId + "|" +
                             enrollment.TourId;

                lines.Add(line);
            }
            File.WriteAllLines(filePath, lines);
        }
        public List<EnrollmentModel> LoadEnrollments()
        {
            List<EnrollmentModel> enrollments = new List<EnrollmentModel>();
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] data = line.Split('|');

                    EnrollmentModel enrollment = new EnrollmentModel();

                    enrollment.EnrollmentId = data[0];
                    enrollment.ClientId = data[1];
                    enrollment.TourId = data[2];

                    enrollments.Add(enrollment);
                }
            }
            return enrollments;

        }



    }
}
