using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        //   Perfect Number
        //  perfect Number is sum of its diviser number
        //  28 is divide by 1,2,4,7,14
        //  1 + 2 + 4 + 7 + 14 = 28
        static void Main(string[] args)
        {
            int n = 28, sum = 0;
            for (int i = 1; i < n; i++)
            {
                if ( n % i ==0)
                {
                    sum = sum + i;
                }
            }

            if (sum == n)
                Console.WriteLine("This is Perfect Number");
        }
    }


