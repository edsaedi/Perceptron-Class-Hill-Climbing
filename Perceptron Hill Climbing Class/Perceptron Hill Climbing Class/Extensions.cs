using System;
using System.Collections.Generic;
using System.Text;

namespace Perceptron_Hill_Climbing_Class
{
    static class Extensions
    {
        public static double NextDouble(this Random @this, double min, double max)
        {
            return @this.NextDouble() * (max - min) + min;
        }
    }
}
