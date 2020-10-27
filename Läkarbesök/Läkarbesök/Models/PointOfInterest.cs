using System;
using System.Collections.Generic;
using System.Text;

namespace Läkarbesök.Models
{
    public class PointOfInterest
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public Coords Position { get; set; }
    }
}
