﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOILD.Open_Closed.Bad
{
    class AreaCalculator
    {
        public static double CalculateArea(Rectangle rect)
        {
            return rect.Length * rect.Width;
        }
        public static double CalculateArea(Circle circle)
        {
            return circle.Radius * circle.Radius * Math.PI;
        }

    }
}