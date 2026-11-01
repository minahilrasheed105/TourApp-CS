using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace TourApp.Enrollment
{
    public class EnrollmentRepo
    {
        private List<EnrollmentModel> enrollments;
        private EnrollmentFile enrollmentFile;

        public EnrollmentRepo()
        {
            enrollmentFile = new EnrollmentFile();
            enrollments = enrollmentFile.LoadEnrollments();
        }

        public List<EnrollmentModel> GetAllEnrollments()
        {
            return enrollments;
        }

        public void AddEnrollment(EnrollmentModel enrollment)
        {
            enrollments.Add(enrollment);
            enrollmentFile.SaveEnrollments(enrollments);
        }

        public List<EnrollmentModel> GetEnrollmentsByClientId(string clientId)
        {
            return enrollments.FindAll(e => e.ClientId == clientId);
        }
    }
}