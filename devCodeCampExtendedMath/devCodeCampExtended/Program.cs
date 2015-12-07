using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devCodeCampExtendedMath
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            List<int> happynums = new List<int>();

            while (happynums.Count < 8)
            {
                if (ishappy(num))
                {
                    happynums.Add(num);
                }
                num++;
            }
            Console.WriteLine("First 8 happy numbers : " + string.Join(",", happynums));
        }
    }
    
}
