namespace Tzadanie512
{
    internal class Program
    {
        static int[] CreateRandomArray(int size, int min, int max)
        {
            int[] array = new int[size];
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

        static double AverageOddIndices(int[] array)
        {
            int sum = 0;
            int count = 0;

            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
                count++;
            }

            return count > 0 ? (double)sum / count : 0;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = CreateRandomArray(n, 1, 100);
            Console.WriteLine("Сгенерированный массив:");
            PrintArray(array);

            Console.WriteLine($"Среднее арифметическое элементов с нечетными индексами: {AverageOddIndices(array):F2}");
        }
    }
}