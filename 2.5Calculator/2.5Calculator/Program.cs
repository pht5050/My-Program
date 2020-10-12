using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._5Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate c=new Calculate();
            Console.WriteLine("请输入两个数字");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0}+{1}={2}",num1,num2,c.Addition(num1,num2));
            Console.WriteLine("{0}-{1}={2}", num1, num2, c.Subtraction(num1, num2));
            Console.WriteLine("{0}x{1}={2}", num1, num2, c.Multiplication(num1, num2));
            Console.WriteLine("{0}/{1}={2}", num1, num2, c.Division(num1, num2));
            Console.WriteLine(c.Equals(num1, num2));
        }
    }
}
