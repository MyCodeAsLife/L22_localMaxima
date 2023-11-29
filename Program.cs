using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L22_localMaxima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] mainArray = new int[30];
            int minNumber = 0;
            int maxNumber = 100;
            int lastElement = mainArray.Length - 1;

            Console.WriteLine("Массив:");

            for (int i = 0; i < mainArray.Length; i++)
            {
                mainArray[i] = random.Next(minNumber, maxNumber + 1);
                Console.Write(mainArray[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("\nЛокальные максимумы:");

            if (mainArray[0] > mainArray[1])
                Console.Write(mainArray[0] + " ");

            for (int i = 1; i < mainArray.Length - 1; i++)
            {
                if (mainArray[i] > mainArray[i - 1] && mainArray[i] > mainArray[i + 1])
                    Console.Write(mainArray[i] + " ");
            }

            if (mainArray[lastElement] > mainArray[lastElement - 1])
                Console.Write(mainArray[lastElement] + " ");

            Console.WriteLine();
        }
    }
}
