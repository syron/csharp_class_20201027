using System;
using System.Collections.Generic;
using System.Text;

namespace Läkarbesök.Models
{
    public class Appointment
    {
        public DateTime Date { get; set; }
        public Human Patient { get; set; }
        public Human Doctor { get; set; }

        public Appointment() { }

        /// <summary>
        /// Patient ringer vårdcentralen, har ingen läkare, behöver tid.
        /// </summary>
        /// <param name="patient"></param>
        public void Book(Human patient) 
        {
            Patient = patient;
        }

        /// <summary>
        /// Patient ringer vårdcentralen, har läkare, behöver tid
        /// </summary>
        /// <param name="doctor"></param>
        /// <param name="patient"></param>
        public void Book(Human doctor, Human patient)
        {
            Patient = patient;
            Doctor = doctor;
        }

        /// <summary>
        /// Patient bokar tid med sin läkare.
        /// </summary>
        /// <param name="doctor"></param>
        /// <param name="patient"></param>
        /// <param name="dateTime"></param>
        public void Book(Human doctor, Human patient, DateTime dateTime)
        {

        }


    }
}
