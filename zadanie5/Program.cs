namespace zadanie5
{
    internal class Program
    {
        static int[] CreateRandomArray(int lenght, int min, int max)
        {
            int[] array = new int[lenght];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(min, max);
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

        static int SumIndices(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                sum += array[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = CreateRandomArray(n, -50, 100);
            Console.WriteLine("Сгенерированный массив:");
            PrintArray(array);

            Console.WriteLine($"Сумма элементов с четными индексами: {SumIndices(array)}");
        }
    }
}