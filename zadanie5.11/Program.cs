namespace zadanie511
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

        static (int minValue, int minIndex) FindMinInRange(int[] array, int a, int b)
        {
            int start = Math.Max(0, a);
            int end = Math.Min(b, array.Length - 1);

            int minValue = array[start];
            int minIndex = start;

            for (int i = start + 1; i <= end; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                    minIndex = i;
                }
            }

            return (minValue, minIndex);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = CreateRandomArray(n, -50, 100);
            Console.WriteLine("Сгенерированный массив:");
            PrintArray(array);

            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());

            var result = FindMinInRange(array, a, b);
            Console.WriteLine($"Минимальный элемент с {a} по {b} индекс: {result.minValue} (индекс {result.minIndex})");
        }
    }
}