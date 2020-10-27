using System;
using Läkarbesök.Models;

namespace Läkarbesök
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating our first human!");

            //Human human1 = new Human("Robert Winston Leonard Jesko Paul Christian Mayer", 32);
            //Human human2 = new Human("Robert Winston Leonard Jesko Paul Christian Mayer");
            //human2.SetAge(32);



            //Coords coords = new Coords(100, 200);

            //// (x,y)
            //string textForConsole = coords.ToString();


            //Console.WriteLine(textForConsole);









        }

        static void CreateHumansBeforePolymorphism()
        {
            Human human1 = new Human();
            human1.Name = "Robert Winston Leonard Jesko Paul Christian Mayer";
            human1.EyeColor = Color.Brown;

            human1.SetAge(32);


            Human human2 = new Human()
            {
                Name = "Robert Mayer",
                EyeColor = Color.Brown
            };
            human2.SetAge(32);


            Console.WriteLine("Human2 Age: " + human2.GetAge());
        }
    }
}
