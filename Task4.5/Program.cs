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

            WriteArray(arrayOfNumbers, "Массив:");
            Shuffle(arrayOfNumbers);
            WriteArray(arrayOfNumbers, "Массив после перемешки:");
        }

        static void WriteArray(int[] arrayOfNumbers, string text)
        {
            Console.WriteLine(text);

            foreach (int number in arrayOfNumbers)
                Console.Write(number + " ");

            Console.WriteLine();
        }

        static void Shuffle(int[] arrayOfNumbers)
        {
            Random random = new Random();

            for (int i = arrayOfNumbers.Length - 1; i > 0; i--)
            {
                int index = random.Next(i);
                int tempNumber = arrayOfNumbers[i];
                arrayOfNumbers[i] = arrayOfNumbers[index];
                arrayOfNumbers[index] = tempNumber;
            }
        }
    }
}
