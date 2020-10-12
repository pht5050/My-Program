using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculate_
{
    class Character:Calculate
    {
        public string Addition(string a, string b)
        {
            string c;
            c = a + b;
            return c;
        }
        //当用户选择减法操作时，可以从用户输入的第一个字符串中去除第二个字符串
        public string Subtraction(string a, string b)
        {
            int i = a.IndexOf(b);    //i= a字符串中第一次出现b字符串的位置
            string c = a.Remove(i,b.Length);//c= 从字符串a中第i个位置移除b.length个字符
            return c;
        }
    }
}
