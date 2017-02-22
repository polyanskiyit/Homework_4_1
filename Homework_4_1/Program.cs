using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4_1
{
    class Program
    {
        private static double indexOfTheNumber(double[] a, double n)
        {
            double indexNum = 0;
            //double[] ii = new double[maxArray];
            for (int i = 0; i < 10; i++)
            {
                if(a[i] == n)
                {
                    //indexNum = ii[i] = i;
                    indexNum = i;
                }
            }

            if(indexNum == 0)
            {
                indexNum = -1;
            }
            return indexNum;
        }


        static void Main(string[] args)
        {
            double n = 1;
            int maxArray = 10;

            double[] a = new double[maxArray];
            Random r = new Random();

            for (int i = 0; i < maxArray; i++)
            {
                a[i] = r.Next(-1, 15);
            }

            for (int i = 0; i < maxArray; i++)
            {
                Console.Write(a[i] + " ");
            }


            Console.WriteLine("\nindex of the " + n + " is " + indexOfTheNumber(a, n));
           
            Console.Read();
        }

    }
}
