using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MonthandMultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //single dimensional arrays

            //declare
            int[] numbers;
            //initialize
            numbers = new int[5];
            //declare and initialize
            int[] numbers1 = new int[5];
            //giving values
            numbers[0] = 1;
            numbers[1] = 2;
            //
            int[] numbers2 = { 9, -11, 6, 12, 1 };

            int middle = numbers2[2];

            //using months example

            string[] months = new string[12];

            for (int month = 1; month <= 12; month++)
            {
                DateTime firstDay = new DateTime(DateTime.Now.Year, month, 1);
                string name = firstDay.ToString("MMMM",
                    CultureInfo.CreateSpecificCulture("en"));
                months[month - 1] = name;

            }

            foreach (string month in months)
            {
                Console.WriteLine($"-> {month}");
            }
            Console.ReadLine();

            //multi dimensional arrays
            //declare and initialize
            //int[,] numero = new int[5, 2];
            //three dimentionals
            int[,,] numeros = new int[5, 4, 3];
            //combination
            int[,] numero = new int[,]
            {
                {9, 5, -9},
                {-11, 4, 0},
                {6, 115, 3},
                {-12, -9, 71},
                {1, -6, -1}
            };

            //multiplication table
            int[,] results = new int[10, 10];
            for ( int i = 0; i < results.GetLength(0);  i++)
            {
                for (int j = 0; j < results.GetLength(1); j++)
                {
                    results[i, j] = (i + 1) * (j + 1);
                }
            }
            for (int i = 0; i < results.GetLength(0); i++)
            {
                for (int j = 0; j < results.GetLength(1); j++)
                {
                    Console.Write("{0,4}", results[i, j]);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
