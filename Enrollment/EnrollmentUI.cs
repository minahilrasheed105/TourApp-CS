using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourApp.Enrollment
{
    public class EnrollmentUI
    {
        private static EnrollmentService enrollmentService;

        public EnrollmentUI()
        {
            enrollmentService = new EnrollmentService();
        }

        public static void AddEnrollment(string cl_id)
        {
            EnrollmentModel enrollment = new EnrollmentModel();

            Console.Write("Enter Enrollment ID: ");
            enrollment.EnrollmentId = Console.ReadLine()!;

            enrollment.ClientId = cl_id;

            Console.Write("Enter Tour ID: ");
            enrollment.TourId = Console.ReadLine()!;

            enrollmentService.AddEnrollment(enrollment);

            Console.WriteLine("Enrollment added successfully!");
        }

        public static void ViewAllEnrollments()
        {
            List<EnrollmentModel> enrollments = enrollmentService.GetAllEnrollments();
            Console.WriteLine("\n===== ALL ENROLLMENTS =====");
            foreach (EnrollmentModel enrollment in enrollments)
            {
                Console.WriteLine($"Enrollment ID: {enrollment.EnrollmentId}, Client ID: {enrollment.ClientId}, Tour ID: {enrollment.TourId}");
            }
        }

        public static void ViewClientEnrollments(string clientId)
        {
            List<EnrollmentModel> enrollments = enrollmentService.GetEnrollmentsByClientId(clientId);
            Console.WriteLine($"\n===== ENROLLMENTS FOR CLIENT {clientId} =====");
            foreach (EnrollmentModel enrollment in enrollments)
            {
                Console.WriteLine($"Enrollment ID: {enrollment.EnrollmentId}, Tour ID: {enrollment.TourId}, Title: {enrollment.GetTourTitle()}, Place: {enrollment.GetTourPlace()}");
            }
        }
    }
}