using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_5
{
    class Math
    {
       
        public void Equals(int num1,int num2)
        {
            if (num1 == num2)
            { Console.WriteLine("两个整数相等"); }
        }
      
        public void GetResult(string fun,int num1,int num2)
        {
            int jie = 0;
            string fu = "";
            switch (fun)
            {
                case "1":
                    jie = num1 + num2;
                    fu = "+";
                    break;
                case "2":
                    jie = num1 - num2;
                    fu = "-";
                    break;
                case "3":
                    jie = num1 * num2;
                    fu = "*";
                    break;
                case "4":
                    jie = num1 /num2;
                    fu = "/";
                    break;
                default:
                    Console.WriteLine("输入有误，请重新输入");
                    string str = Console.ReadLine();
                    GetResult(str, num1, num2);
                    return;
            }
            Console.WriteLine("{0}{3}{1}={2}", num1, num2, jie, fu);
        }
        public void GetResult(string fun, string num1, string num2)
        {
            string jie = " ";
            string fu = "";
            switch (fun)
            {
                case "1":
                    jie = num1 + num2;
                    fu = "+";
                    break;
                case "2":


                    jie = num1.Replace(num2,"");
                    fu = "-";
                    break;           
                default:
                    Console.WriteLine("输入有误，请重新输入");
                    string str = Console.ReadLine();
                    GetResult(str, num1, num2);
                    return;
            }
            Console.WriteLine("{0}{3}{1}={2}", num1, num2, jie, fu);
        }

    }
}
