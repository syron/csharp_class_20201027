using System;
using System.Collections.Generic;
using System.Text;

namespace Läkarbesök.Models
{
    public class Doctor : Human 
    {

        public Doctor(string name) 
        {
        }


        public override void Move(int x, int y)
        {
            base.Move(x, y, 2);
        }

    }
}
