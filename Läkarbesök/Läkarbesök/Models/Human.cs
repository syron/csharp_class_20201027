using System;
using System.Collections.Generic;
using System.Text;

namespace Läkarbesök.Models
{
    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Color EyeColor { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
