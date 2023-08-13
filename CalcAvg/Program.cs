using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAvg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] values = { 2.5, 3.7, 1.2, 4.6, 5.9 };
            double sum = 0;

            foreach (double val in values)
            {
                sum += val;
            }

            double average = sum / values.Length;

            Console.WriteLine("Average: " + average);
            Console.ReadLine();
        }
    }
}
