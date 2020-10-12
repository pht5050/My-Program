using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate__
{
    class Program
    {
        static void Main(string[] args)
        {
            Solve c = new Solve();
            Console.WriteLine("请分别输入两个数字");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0}+{1}={2}", num1, num2, c.Addition(num1, num2));
            Console.WriteLine("{0}-{1}={2}", num1, num2, c.Subtraction(num1, num2));
            Console.WriteLine("{0}x{1}={2}", num1, num2, c.Multiplication(num1, num2));
            Console.WriteLine("{0}/{1}={2}", num1, num2, c.Division(num1, num2));
            Console.WriteLine("{0}%{1}={2}", num1, num2, c.Surplus(num1, num2));
            Console.WriteLine(c.Equals(num1, num2));
            Character ch = new Character();
            Console.WriteLine("请分别输入两个字符串");
            string a = Convert.ToString(Console.ReadLine());
            string b = Convert.ToString(Console.ReadLine());
            Console.WriteLine("{0}+{1}={2}", a, b, ch.Addition(a, b));
            Console.WriteLine("{0}-{1}={2}", a, b, ch.Subtraction(a, b));
            Console.WriteLine("请分别输入两个整数");
            int num3 = Convert.ToInt16(Console.ReadLine());
            int num4 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("{0}&{1}={2}", num3, num4, c.And(num3, num4));
        }
    }
}
