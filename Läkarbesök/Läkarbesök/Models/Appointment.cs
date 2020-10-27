using System;
using System.Collections.Generic;
using System.Text;

namespace Läkarbesök.Models
{
    public class Appointment
    {
        public DateTime Date { get; set; }

        public Appointment() 
        {
            Date = DateTime.Now.AddMonths(1);
        }

        public Appointment(DateTime dateTime)
        {
            Date = dateTime;
        }
    }
}
