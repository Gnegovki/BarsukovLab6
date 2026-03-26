namespace zadanie56
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

        static double AverageEven(int[] array)
        {
            int sum = 0;
            int count = 0;

            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = CreateRandomArray(n, 1, 100);
            Console.WriteLine("Сгенерированный массив:");
            PrintArray(array);

            Console.WriteLine($"Среднее значение четных элементов: {AverageEven(array):F2}");
        }
    }
}