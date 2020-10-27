using System;
using System.Collections.Generic;
using System.Text;

namespace Läkarbesök.Models
{
    public class Human
    {
        public string Name { get; set; }
        private int Age { get; set; }
        public Color EyeColor { get; set; }
        public Coords Position { get; set; }

        public void Move(int x, int y)
        {
            Position = new Coords(x, y);
        }

        public void SetAge(int age)
        {
            if (age < 0)
            {
                throw new Exception();
            }

            Age = age;
        }

        public int GetAge()
        {
            return Age;
        }

        public Coords GetPosition()
        {
            throw new NotImplementedException();
        }
    }
}
