using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRevision
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex1();
        }
        static void Ex1()
        {
            //int min = 1000;
            //int max = 9999;
            int size = 1000;
            Random random = new Random();
            double[] array1 = new double[size];
            for (int i = 0; i < array1.Length; i++)
            {
                double num = random.NextDouble();
                while (array1.Contains(num))
                {
                    num = random.NextDouble(); 
                }
                array1[i] = Math.Round(num, 8);

            }
            //Array.Sort(array1);
            int counter = 0;
            for (int outer = 0; outer < array1.Length; outer++)
            {
                for (int inner = 0; inner < 10; inner++)
                {
                    Console.Write(array1[counter] * 10 + " ");
                    counter++;
                }
                Console.WriteLine('\n');
                outer = outer + 10;
            }
            Console.ReadLine();
        }
    }
}
