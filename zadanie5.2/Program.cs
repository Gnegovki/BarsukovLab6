namespace zadanie52
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

        static int? FindMinPositive(int[] array)
        {
            int? min = null;
            foreach (int num in array)
            {
                if (num > 0 && (min == null || num < min))
                {
                    min = num;
                }
            }
            return min;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = CreateRandomArray(n, -20, 50);
            Console.WriteLine("Сгенерированный массив:");
            PrintArray(array);

            int? minPositive = FindMinPositive(array);
            if (minPositive.HasValue)
                Console.WriteLine($"Минимальный положительный элемент: {minPositive}");
        }
    }
}