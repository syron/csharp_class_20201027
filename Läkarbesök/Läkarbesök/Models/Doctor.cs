﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Läkarbesök.Models
{
    public class Doctor : Human 
    {
        public string Inriktning { get; set; }

        public Doctor(string name) 
        {
        }

        public override void Jump()
        {
            throw new NotImplementedException();
        }
    }
}
