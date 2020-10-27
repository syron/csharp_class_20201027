using System;
using System.Collections.Generic;
using System.Text;

namespace Läkarbesök.Models
{
    public struct Coords
    {
        public int X { get; }
        public int Y { get; }

        public Coords(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
