using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice.Properties
{
    class Digit
    {
        static void Main(string[] args)
        {
            int num = 12345;
            while(num>0)
            {
                int digi = num % 10;
                Console.WriteLine(digi);
                num /= 10;
            }
            
        }
    }
}
