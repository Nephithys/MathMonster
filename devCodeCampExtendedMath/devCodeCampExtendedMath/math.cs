using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace devCodeCampExtendedMath
{
    public static class Maths
    {
        public static bool ishappy(int n)
        {
            List<int> cache = new List<int>();
            int sum = 0;
            while (n != 1)
            {
                if (cache.Contains(n))
                {
                    return false;
                }
                cache.Add(n);
                while (n != 0)
                {
                    int digit = n % 10;
                    sum += digit * digit;
                    n /= 10;
                }
                n = sum;
                sum = 0;
            }
            return true;
        }
        public static void HappyNumbers(int numToChange = 34)
        {
            int num = 1;
            List<int> happynums = new List<int>();

            while (happynums.Count < numToChange)
            {
                if (ishappy(num))
                {
                    happynums.Add(num);
                }
                num++;
            }
            Console.WriteLine("First 34 happy numbers : " + string.Join(",", happynums));
            
        }
        public static void GCD(int a = 1, int b = 1)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            if (a == 0)
                Console.WriteLine(b);
            else
                Console.WriteLine(a);

        }
    }
}
