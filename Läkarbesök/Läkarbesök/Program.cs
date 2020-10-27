using System;
using System.Collections.Generic;
using Läkarbesök.Models;
using Läkarbesök.Models.Interfaces;

namespace Läkarbesök
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Our first appointment with our awesome doctor!");

            Patient patient = new Patient("Robert Mayer");
            patient.SetAge(32);
            Doctor doctor = new Doctor(Inriktning.Internist, "Kalle Kula");

            DoctorsAppointment doctorsAppointment = new DoctorsAppointment(patient, doctor, DateTime.Now);
            DoctorsAppointment doctorsAppointment2 = new DoctorsAppointment(patient, doctor, DateTime.Now.AddMonths(1));
            DoctorsAppointment doctorsAppointment3 = new DoctorsAppointment(patient, doctor, DateTime.Now.AddMonths(2));
            DoctorsAppointment doctorsAppointment4 = new DoctorsAppointment(patient, doctor, DateTime.Now.AddMonths(3));
            DoctorsAppointment doctorsAppointment5 = new DoctorsAppointment(patient, doctor, DateTime.Now.AddMonths(4));

            Console.WriteLine("Doctor asks, how old are you?");
            Console.WriteLine("Patient answers: I am " + patient.GetAge() + " years old");
            Console.WriteLine("Doctors says, you are old man!");


            List<DoctorsAppointment> doctorsAppointments = new List<DoctorsAppointment>();
            doctorsAppointments.Add(doctorsAppointment);
            doctorsAppointments.Add(doctorsAppointment2);
            doctorsAppointments.Add(doctorsAppointment3);
            doctorsAppointments.Add(doctorsAppointment4);
            doctorsAppointments.Add(doctorsAppointment5);

            Console.WriteLine("Number of appointments: " + doctorsAppointments.Count);

            doctorsAppointments.Remove(doctorsAppointment);

            Console.WriteLine("Number of appointments: " + doctorsAppointments.Count);

            Console.WriteLine("Meeting number 3, when do we have it: " + doctorsAppointments[2].Date);






















            //Human human2 = new Human("Robert Winston Leonard Jesko Paul Christian Mayer");
            //human2.SetAge(32);



            //Coords coords = new Coords(100, 200);

            //// (x,y)
            //string textForConsole = coords.ToString();


            //Console.WriteLine(textForConsole);









        }

        //static void CreateHumansBeforePolymorphism()
        //{
        //    Human human1 = new Human();
        //    human1.Name = "Robert Winston Leonard Jesko Paul Christian Mayer";
        //    human1.EyeColor = Color.Brown;

        //    human1.SetAge(32);


        //    Human human2 = new Human()
        //    {
        //        Name = "Robert Mayer",
        //        EyeColor = Color.Brown
        //    };
        //    human2.SetAge(32);


        //    Console.WriteLine("Human2 Age: " + human2.GetAge());
        //}
    }
}
