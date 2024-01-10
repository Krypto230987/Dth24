using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homm24
{
    internal class Program
    {
        static void Main()
        {
            int[] intArray = { 4, 2, 6, 1, 5, 3 };
            GenericArray<int> genericIntArray = new GenericArray<int>(intArray);

            Console.WriteLine("Оригинал");
            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            genericIntArray.Sort();

            Console.WriteLine("По порядку");
            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            genericIntArray.Reverse();

            Console.WriteLine("С конца");
            foreach (int i in intArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
