using System;
using System.Collections.Generic;
using System.Text;

namespace Läkarbesök.Models.Interfaces
{
    interface IHuman
    {
        void Breath();
        void Move(int x, int y);
        Coords GetCurrentPosition();
    }
}
