using System;
using Läkarbesök.Models;
using LäkarbesökHjälp;

namespace Läkarbesök
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating our first human!");

            Human human1 = new Human();
            human1.Name = "Robert Winston Leonard Jesko Paul Christian Mayer";
            human1.EyeColor = Color.Brown;
            human1.Position = new Coords(0, 0);

            human1.SetAge(32);


            Human human2 = new Human()
            {
                Name = "Robert Mayer",
                EyeColor = Color.Brown,
                Position = new Coords(0, 0)
            };
            human2.SetAge(32);


            Console.WriteLine("Human2 Age: " + human2.GetAge());


        }
    }
}
