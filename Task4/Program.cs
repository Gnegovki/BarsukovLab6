namespace Task4
{
    internal class Program
    {
        static int[] CreateRandomArray(int lenght, int min, int max)
        {
            int[] array = new int[lenght];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(min, max + 1);
            }
            return array;
        }

        static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static double AverageOddPositive(int[] array)
        {
            int sum = 0;
            int count = 0;

            foreach (int num in array)
            {
                if (num > 0 && num % 2 != 0)
                {
                    sum += num;
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            int[] array = CreateRandomArray(17, -30, 100);
            Console.WriteLine("Массив:");
            PrintArray(array);

            double average = AverageOddPositive(array);
            Console.WriteLine($"Среднее значение нечетных положительных элементов: {average:F2}");
        }
    }
}
