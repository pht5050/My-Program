using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate__
{
     class Solve:Calculate    //抽象方法实现
    {
        public override double Addition(double a, double b)
        {
            return a + b;
        }
        public override double Subtraction(double a, double b)
        {
            return a - b;
        }
        public override double Multiplication(double a, double b)
        {
            return a * b;
        }
        public override double Division(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("0不能作为除数!");
                return 0;
            }
            else
                return a / b;
        }
        public override bool Equals(double a, double b)
        {
            if (a == b)
                return true;
            else
                return false;
        }
        public override double Surplus(double a, double b)
        {
            double c = a % b;
            return c;
        }
        public override int And(int a, int b)
        {
            int c = a & b;
            return c;
        }
    }
}
