using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(amstrong(124));
        }
        public static bool amstrong(int n)
        {
            bool Flag = true;
            int count;
            count = (int)(Math.Log10(n) + 1);
            double sum = 0;
            int rem;
            int temp = n;
            while (n != 0)
            {
                rem = n % 10; ;
                sum = sum + (Math.Pow(rem, count));
                n = n / 10;
            }
            if (sum == temp)
            {
                return Flag;
            }
            else
            {
                return false;
            }
        }
    }
}
