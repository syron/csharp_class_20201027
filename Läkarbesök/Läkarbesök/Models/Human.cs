using Läkarbesök.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Läkarbesök.Models
{
    public abstract class Human : IHuman
    {
        public string Name { get; set; }
        private int Age { get; set; }
        protected string InsuranceNumber { get; set; }
        public Color EyeColor { get; set; }
        public Coords Position { get; set; }

        public Human()
        {
            Position = new Coords(0, 0);
        }

        public virtual void Move(int x, int y)
        {
            Position = new Coords(x, y);
        }

        public abstract void Jump();

        public void Move(int x, int y, int speed)
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

        public void Breath()
        {
            throw new NotImplementedException();
        }

        public Coords GetCurrentPosition()
        {
            throw new NotImplementedException();
        }
    }
}
