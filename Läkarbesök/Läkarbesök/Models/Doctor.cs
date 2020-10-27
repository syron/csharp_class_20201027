using System;
using System.Collections.Generic;
using System.Text;

namespace Läkarbesök.Models
{
    public class Doctor : Human 
    {
        public Inriktning Inriktning { get; set; }

        public Doctor(Inriktning inriktning, string name) 
        {
            Name = name;
            Inriktning = inriktning;
        }

        public override void Jump()
        {
            throw new NotImplementedException();
        }
    }
}
