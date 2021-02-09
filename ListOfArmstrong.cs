using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice.Properties
{
    class ListOfArmstrong
    {
        public static string ListArmstrong(int num,int num1)
        {
            string str=string.Empty;
            for (int i = num; i < num1; i++)
            {
                if(IsArmstrong.IsArmstrongs(i))
                {
                    str += i + ",";
                }
            }
            return str;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ListArmstrong(1,1000000));
        }
    }
}
