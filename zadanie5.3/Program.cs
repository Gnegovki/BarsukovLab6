namespace zadanie53
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

        static int FindMin(int[] array)
        {
            int min = array[0];
            foreach (int num in array)
            {
                if (num < min) min = num;
            }
            return min;
        }

        static int FindMax(int[] array)
        {
            int max = array[0];
            foreach (int num in array)
            {
                if (num > max) max = num;
            }
            return max;
        }

        static int SumMinMax(int[] array)
        {
            return FindMin(array) + FindMax(array);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = CreateRandomArray(n, -50, 100);
            Console.WriteLine("Сгенерированный массив:");
            PrintArray(array);

            Console.WriteLine($"Сумма максимального и минимального элементов: {SumMinMax(array)}");
        }
    }
}