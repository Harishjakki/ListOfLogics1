using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice.Properties
{
    class ListOfPerfect
    {
        public static int Factors(int num)
        {
            int sum = 0;
            for (int i = 1; i <num ; i++)
            {
                if(num%i==0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        public static string ListPerfect(int start , int end)
        {
            string res = string.Empty;
            for (int i = start; i <=end; i++)
            {
                if(IsPerfect(i))
                {
                    res =res+ i + ",";
                }
            }
            return res;
        }
        public static bool IsPerfect(int num)
        {
            return num == Factors(num);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ListPerfect(1,10000));
        }
    }
}
