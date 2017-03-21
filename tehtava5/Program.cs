using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Ohjelma();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        static void Ohjelma()
        {

            try
            {
                double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
                Console.WriteLine("Sum = {0:00.00}", ArrayCalcs.Sum(array));
                Console.WriteLine("Avg = {0:00.00}", ArrayCalcs.Average(array));
                Console.WriteLine("Min = {0:0.00}", ArrayCalcs.Min(array));
                Console.WriteLine("Max = {0:00.00}", ArrayCalcs.Max(array));
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}