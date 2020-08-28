using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceForSummerSchool
{
    interface IPoint
    {
        // Property signatures:
        int X
        {
            get;
            set;
        }

        int Y
        {
            get;
            set;
        }

        double Distance
        {
            get;
        }
    }
}
