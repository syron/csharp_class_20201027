using System;
using Läkarbesök.Models;
using Läkarbesök.Models.Interfaces;

namespace Läkarbesök
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating our first human!");

            Patient patient = new Patient("Robert Mayer");
            patient.EyeColor = Color.SaddleBrown;





            switch (patient.EyeColor)
            {
                case Color.SaddleBrown:
                    Console.WriteLine("Eye Color - Color: Saddle Brown");
                    break;
                default:
                    Console.WriteLine("Eye Color - Color:" + (int)patient.EyeColor);
                    break;
            }

            



            
            Appointment appointment = new Appointment();
            Console.WriteLine("Get appoint date time: " + appointment.Date);

            Appointment appointment1 = new Appointment(DateTime.Now.AddDays(1));
            Console.WriteLine("Get appoint date time: " + appointment1.Date);

            DoctorsAppointment appointment2 = new DoctorsAppointment(patient, new Doctor("Karl"), DateTime.Now);
            Console.WriteLine("Get appoint date time: " + appointment2.Date);








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
