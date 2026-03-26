namespace Tzadanie55
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

        static int SumEvenPositiveInRange(int[] array, int a, int b)
        {
            int sum = 0;
            int start = Math.Max(0, a);
            int end = Math.Min(b, array.Length - 1);

            for (int i = start; i <= end; i++)
            {
                if (array[i] > 0 && array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = CreateRandomArray(n, -20, 100);
            Console.WriteLine("Сгенерированный массив:");
            PrintArray(array);

            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Сумма четных положительных элементов с {a} по {b} индекс: {SumEvenPositiveInRange(array, a, b)}");
        }
    }
}