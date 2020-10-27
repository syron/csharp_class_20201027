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
            human1.Age = 32;
            human1.EyeColor = Color.Brown;
            human1.X = 0;
            human1.Y = 0;

            Human human2 = new Human()
            {
                Name = "Robert Mayer",
                Age = 32,
                EyeColor = Color.Brown,
                X = 0,
                Y = 0
            };
        }
    }
}
