using System;
using System.Collections.Generic;
using System.Text;

namespace part_02.Enrollment
{
    public class CourseEnrollmentFacade
    {
        private readonly PaymentGateway _paymentGateway;
        private readonly SeatInventory _seatInventory;
        private readonly InvoiceGenerator _invoiceGenerator;
        private readonly EmailService _emailService;

        public CourseEnrollmentFacade()
        { 
            _paymentGateway = new PaymentGateway();
            _seatInventory = new SeatInventory();
            _invoiceGenerator = new InvoiceGenerator();
            _emailService = new EmailService();
        }
        public void Enroll(string studentId, string courseId, decimal amount)
        {
            _paymentGateway.Charge(studentId, amount);

            _seatInventory.Reserve(courseId, studentId);

            string invoiceId =
                _invoiceGenerator.Create(studentId, amount);

            _emailService.Send(
                studentId,
                "Course Enrollment",
                $"Your invoice is {invoiceId}"
            );

        }
    }
}
