using System;
using System.Collections.Generic;
using System.Text;

namespace Läkarbesök.Models
{
    public class Patient : Human
    {
        public bool Headache { get; set; }

        public Patient(string name)
        {
           
        }

        public void HasHeadache()
        {
            Headache = true;
        }

        public override void Jump()
        {
            throw new NotImplementedException();
        }
    }
}
