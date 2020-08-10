using System;

namespace UclidsProject
{
    class Program
    {
        public static int GCD(int a,int b)
        {
            if (b == 0)
            {
                return a;
            }
            return GCD(b, a % b);
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter two numbers to find gcd :");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("GCD is: "+GCD(a,b));
        }
    }
}
