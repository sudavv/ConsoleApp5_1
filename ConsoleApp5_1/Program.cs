using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {            
            double[] array = new double[7];

            Console.WriteLine("Введите числа для массива");
            for (int i = 0; i < 7; i++)
            {
                try
            {
                    array[i] = Convert.ToDouble(Console.ReadLine());                     
            }
            catch
            {
                Console.WriteLine("Не число");
                    i--;
                    continue;                    
            }
            }

            double sum = 0;
            foreach (double element in array)
            {
                sum += element;
            }
            sum = sum / array.Length;

                Console.WriteLine("Среднее арифметическое: " + sum);
                Console.ReadLine();
                Run();
            Environment.Exit(0);
        }
    }
}