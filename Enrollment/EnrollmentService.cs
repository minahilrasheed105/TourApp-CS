using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourApp.Enrollment
{
    public class EnrollmentService
    {
        private EnrollmentRepo enrollmentRepo;

        public EnrollmentService()
        {
            enrollmentRepo = new EnrollmentRepo();
        }
        public List<EnrollmentModel> GetAllEnrollments()
        {
            return enrollmentRepo.GetAllEnrollments();
        }
        public void AddEnrollment(EnrollmentModel enrollment)
        {
            enrollmentRepo.AddEnrollment(enrollment);
        }
        public List<EnrollmentModel> GetEnrollmentsByClientId(string clientId)
        {
            return enrollmentRepo.GetEnrollmentsByClientId(clientId);
        }
    }
}
