using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._5Calculator
{
    class Calculate
    {
        public double Addition(double a,double b)
        {
            return a + b;
        }
        public double Subtraction(double a, double b)
        {
            return a - b;
        }
        public double Multiplication(double a, double b)
        {
            return a * b;
        }
        public double Division(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("0不能作为除数!");
                return 0;
            }
            else
                return a / b;
        }
        public bool Equals(double a, double b)
        {
            if (a == b)
                return true;
            else
                return false;
        }
    }
}
