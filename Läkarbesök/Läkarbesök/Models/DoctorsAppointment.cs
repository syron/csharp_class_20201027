using System;
using System.Collections.Generic;
using System.Text;

namespace Läkarbesök.Models
{
    public class DoctorsAppointment : Appointment
    {
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }

        public DoctorsAppointment(Patient patient, Doctor doctor, DateTime dateTime)
            : base(dateTime)
        {
            Patient = patient;
            Doctor = doctor;
        }
    }
}
