using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice.Properties
{
    class ListOfPalindrome
    {
        public static int Reverse(int num)
        {
            int rev = 0;
            while(num>0)
            {
                rev =rev* 10 + num % 10;
                num /= 10;
            }
            return rev;
        }
        public static bool IsPalindrome(int num)
        {
            return num == Reverse(num);
        }
        public static string ListPalindrome(int start , int end)
        {
            string pal = string.Empty;
            for (int i = start; i <=end; i++)
            {
                if(IsPalindrome(i))
                {
                    pal =pal+ i + ",";
                }
            }
            return pal.Substring(0,pal.Length-1)+".";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ListPalindrome(10 , 100));
        }
    }
}
