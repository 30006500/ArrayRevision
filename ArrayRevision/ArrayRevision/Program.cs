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
                double num = random.NextDouble() * 10;
                while (array1.Contains(num))
                {
                    num = random.NextDouble(); 
                }
                array1[i] = Math.Round(num, 8);

            }
            Array.Sort(array1);
            Console.WriteLine("Array 1 Contents");
            Console.WriteLine("Press Enter To Display");
            Console.ReadLine();
            DisplayArray(array1);
            Console.WriteLine("");

            double[] array2 = new double[array1.Length];
            array1.CopyTo(array2, 0);
            Console.WriteLine("Array 2 Contents");
            Console.WriteLine("Press Enter To Display");
            Console.ReadLine();
            DisplayArray(array2);

            var greaterThan2 =
                from number in array2
                where (number > 2)
                select number;
            Console.WriteLine("Display Numbers Greater Than 2 Ascending");
            Console.ReadLine();
            double[] gt2 = greaterThan2.ToArray();
            DisplayArray(gt2);
            Console.WriteLine("Display Numbers Great Than 2 Descending");
            Console.ReadLine();
            Array.Reverse(gt2);
            DisplayArray(gt2);
            Console.ReadLine();
        }

        public static void DisplayArray(double[] _array)
        {
            int counter = 0;
            for (int outer = 0; outer < _array.Length; outer++)
            {
                for (int inner = 0; inner < 10; inner++)
                {
                    Console.Write(_array[counter] + " ");
                    counter++;
                }
                Console.WriteLine('\n');
                outer = outer + 10;
            }
            Console.WriteLine("Press Enter To Continue");
            Console.ReadLine();
        }        
    }
}
