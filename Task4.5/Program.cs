using System;

namespace Task4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int valueOfRandom = 9;
            int[] arrayOfNumbers = new int[valueOfRandom];

            for (int i = 0; i < arrayOfNumbers.Length;i++)
                arrayOfNumbers[i] = random.Next(valueOfRandom);

            Shuffle(arrayOfNumbers);
        }

        static void Shuffle(int[] array)
        {
            Random random = new Random();
            Console.WriteLine("Массив:");

            foreach (int number in array)
                Console.Write(number + " ");

            Console.WriteLine("\nПеремешанный массив:");

            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = random.Next(i);
                int tempNumber = array[i];
                array[i] = array[j];
                array[j] = tempNumber;
            }

            foreach (int number in array)
                Console.Write(number + " ");

            Console.WriteLine();
        }
    }
}
