namespace zadanie59
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

        static (int maxValue, int maxIndex) FindMaxInRange(int[] array, int a, int b)
        {
            int start = Math.Max(0, a);
            int end = Math.Min(b, array.Length - 1);

            int maxValue = array[start];
            int maxIndex = start;

            for (int i = start + 1; i <= end; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    maxIndex = i;
                }
            }

            return (maxValue, maxIndex);
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

            var result = FindMaxInRange(array, a, b);
            Console.WriteLine($"Максимальный элемент с {a} по {b} индекс: {result.maxValue} (индекс {result.maxIndex})");
        }
    }
}