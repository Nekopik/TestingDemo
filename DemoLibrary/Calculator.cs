using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public static class Calculator
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Subtract(double x, double y)
        {
            return x - y;
        }

        public static double Multiply(double x, double y)
        {
            if(x != double.MaxValue && y != double.MinValue)
            {
                return x * y;
            }
            else
            {
                return double.MaxValue; //custom business logic for multiply by MaxValue
            }
            
        }

        public static double Divide(double x, double y)
        {
            if (y != 0)
            {
                return x / y; 
            }
            else
            {
                // Custom business logic for divide by zero
                return 0;
            }
        }
    }
}
