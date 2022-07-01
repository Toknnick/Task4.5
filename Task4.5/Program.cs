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

            for (int i = 0; i < arrayOfNumbers.Length; i++)
                arrayOfNumbers[i] = random.Next(valueOfRandom);

            WriteArrayBeforeShuffle(arrayOfNumbers);
            Shuffle(arrayOfNumbers);
            WriteArrayAftereShuffle(arrayOfNumbers);
        }

        static void WriteArrayBeforeShuffle(int[] arrayOfNumbers)
        {
            Console.WriteLine("Массив:");
            WriteArray(arrayOfNumbers);
        }

        static void WriteArray(int[] arrayOfNumbers)
        {
            foreach (int number in arrayOfNumbers)
                Console.Write(number + " ");
            Console.WriteLine();
        }

        static void WriteArrayAftereShuffle(int[] arrayOfNumbers)
        {
            Console.WriteLine("\nПеремешанный массив:");
            WriteArray(arrayOfNumbers);
        }

        static int[] Shuffle(int[] arrayOfNumbers)
        {
            Random random = new Random();

            for (int i = arrayOfNumbers.Length - 1; i > 0; i--)
            {
                int number = random.Next(i);
                int tempNumber = arrayOfNumbers[i];
                arrayOfNumbers[i] = arrayOfNumbers[number];
                arrayOfNumbers[number] = tempNumber;
            }

            return arrayOfNumbers;
        }
    }
}
