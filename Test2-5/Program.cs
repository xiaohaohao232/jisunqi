using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_5
{
    class Program
    {
        static int Cheaknum(string num)
        {
            try
            {
                int i = int.Parse(num);
                return i;
            }
            catch (Exception e)
            {
                Console.WriteLine("输入有误，请重新输入：");
                string str = Console.ReadLine();
                return Cheaknum(str);
            }
        }
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine("请输入第一个数:");
            string num1 = Console.ReadLine();
            int number1 = Program.Cheaknum(num1);
            Console.WriteLine("请输入第二个数:");
            string num2 = Console.ReadLine();
            int number2 = Program.Cheaknum(num2);
            math.Equals(number1, number2);
            Console.WriteLine("请选择运算符：1.+ 2. - 3. * 4.%");
            string fun = Console.ReadLine();
            math.GetResult(fun, number1, number2);
            
        }
    }
}
