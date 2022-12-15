﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOILD.Liskov_Substitution
{
    abstract class Bird 
    {
        public double Altitude { set; get; }

        public abstract void Fly();
    }
}
