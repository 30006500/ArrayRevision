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
            //double min = 0;
            //double max = 0.99;
            int size = 1000;
            Random random = new Random();
            double[] array1 = new double[size];
            for (int i = 0; i < array1.Length; i++)
            {
                double num = random.NextDouble() * 10;
                while (array1.Contains(num))
                {
                    num = random.NextDouble() * 10; 
                }
                array1[i] = num;

            }            
                foreach (double x in array1)
                {                
                    Console.Write("{0} ", x);
                }            
            Console.ReadLine();
        }
    }
}
