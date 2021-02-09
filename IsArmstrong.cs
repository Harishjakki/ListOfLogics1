using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice.Properties
{
    class IsArmstrong
    {
        public static int Count(int number)
        {
            int ctr = 0;
            while(number>0)
            {
                int digit = number % 10;
                ctr++;
                number /= 10;
            }
            return ctr;
        }
        public static int Power(int num1, int num2)
        {
            int sum = 0;
            while (num2 > 0)
            {
                int pavl = 1;
                int digit = num2 % 10;
                 for (int i = 0; i < num1; i++)
                 {
                    pavl  *= digit;
                 }
                sum += pavl;
                num2 /= 10;
            }
            return sum;
        }
        public static int Sum(int num)
        {
            return num;
        }
        public static bool IsArmstrongs(int num)
        {
            return num == Sum(Power(Count(num),num));
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsArmstrongs(153));
        }
    }
}
