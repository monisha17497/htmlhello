using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divide_reverse_count
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Reverse(1234));
            //Console.WriteLine(divide(36));
            //Console.WriteLine(count(12345));
            //Console.WriteLine(countreverse(123456));
            //Console.WriteLine(evencount(123));
            //Console.WriteLine(amstrong(153));
            //Console.WriteLine(firstdigit(123456));
            // Console.WriteLine(lastdigit(123456));
            //Console.WriteLine(firstlast(12351));
            //Console.WriteLine(palindrome(6226));
            //if (IsPrime(6)==true)
            //{
            //    Console.WriteLine("is prime");
            //}
            //else
            //{
            //    Console.WriteLine("not prime");
            //}
            // Console.WriteLine(SumOFPrimeNumberless(20));

            Console.WriteLine(SumOFPerfectSquare(30));
        }
        public static int Reverse(int n)
        {
            int rev = 0;
            while (n > 0)
            {
                int temp = n % 10;
                rev = rev * 10 + temp;
                n = n / 10;
            }
            return rev;
        }
        public static bool divide(int n)
        {
            int temp = n % 10;
            if (n % temp == 0)
            {
                return true;
            }
            return false;
        }
        public static int count(int n)
        {
            int count = 0;

            while (n > 0)
            {
                n = n / 10;
                count++;
            }

            return count;

        }
        public static int countreverse(int n)
        {
            int count = 0;
            int rev = 0;
            while (n > 0)
            {
                int temp = n % 10;
                rev = rev * 10 + temp;
                n = n / 10;
                count++;
            }

            return count;
        }
        public static int evencount(int n)
        {

            int count = 0;
            int evencount = 0;
            int oddcount = 0;
            // int rev = 0;
            while (n > 0)
            {
                int temp = n % 10;
                // rev = rev * 10 + temp;
                n = n / 10;
                if (temp % 2 == 0)
                {
                    evencount++;
                    Console.WriteLine("even:" + evencount);
                }
                //return evencount;
                else if (temp % 2 != 0)
                {
                    oddcount++;
                    Console.WriteLine("odd:" + oddcount);
                }

            }
            return count;
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
        public static int firstdigit(int n)
        {
            while (n > 10)
            {
                n = n / 10;
            }
            return n;
        }
        public static int lastdigit(int n)
        {
            n = n % 10;
            return n;
        }
        public static bool firstlast(int n)
        {
            bool flag = true;

            if (firstdigit(n) == lastdigit(n))
            {
                return flag;
            }
            return false;

        }
        public static bool palindrome(int n)
        {
            bool flag = true;
            int reverse = 0;
            int rem;
            int temp = n;
            while (n > 0)
            {

                rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n / 10;
            }
            if (temp == reverse)
            {
                return flag;
            }
            else
            {
                return false;
            }
        }
        public static bool IsPrime(int n)
        {

            bool flag = true;
            if (n <= 1)
            {
                return false;
            }
            if (n == 2)
            {
                return flag;
            }
            // for (int i = 2; i < Math.Sqrt(n) + 1; i++)
            int i = 2;
            while (i < Math.Sqrt(n) + 1)
            {
                if (n % i == 0)
                {
                    flag = false;
                }
                i++;
            }
            return flag;
        }
        public static int SumOFPrimeNumberless(int n)
        {

            // bool flag = true;
            int sum = 0;
            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    // Console.WriteLine(i);
                    sum += i;
                }
            }
            return sum;
        }
        public static bool IsPerfectSquare(int n)
        {
            bool flag = true;
            double x = Math.Sqrt(n);
            double y = Math.Round(x);
            if (x - y == 0)
            {
                return flag;
            }
            else
            {

                return false;
            }
        }
        public static int SumOFPerfectSquare(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (IsPerfectSquare(i))
                {
                    sum = sum + i;
                }
            }
            return sum; ;
        }
    }
}
