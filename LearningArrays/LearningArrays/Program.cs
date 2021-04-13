using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Click any key to read string array\n");
            Console.ReadKey();

            string[] flowers = { "Rose", "Daisy", "Violet", "Tulip", "Orchid"};

            for (int i = 0; i < flowers.Length; i++)
            {
                Console.Write(flowers[i] + " ");
            }

            Console.WriteLine("\n\n\nClick any key to read integer array\n");
            Console.ReadKey();

            int[] numbers = new int[20];

            for (int j = 0; j < numbers.Length; j++)
            {
                numbers[j] = j + 1;
            }

            for (int k = numbers.Length - 1; k >= 0; k--)
            {
                Console.Write(numbers[k] + " ");
            }

            Console.WriteLine("\n\n\nClick any key to exit");
            Console.ReadKey();
        }
    }
}
