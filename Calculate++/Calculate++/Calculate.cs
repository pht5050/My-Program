using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate__
{
    abstract class Calculate     //抽象类
    {
        public abstract double Addition(double a, double b);

        public abstract double Subtraction(double a, double b);

        public abstract double Multiplication(double a, double b);     //抽象方法声明

        public abstract double Division(double a, double b);

        public abstract bool Equals(double a, double b);

        public abstract double Surplus(double a, double b);

        public abstract int And(int a, int b);
    }
}
