namespace zadanie514
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

        static int[] GetEvenElements(int[] array)
        {
            int size = (array.Length + 1) / 2;
            int[] result = new int[size];

            for (int i = 0; i < array.Length; i += 2)
            {
                result[i / 2] = array[i];
            }

            return result;
        }

        static int[] GetOddElements(int[] array)
        {
            int size = array.Length / 2;
            int[] result = new int[size];

            for (int i = 1; i < array.Length; i += 2)
            {
                result[i / 2] = array[i];
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = CreateRandomArray(n, 1, 100);
            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            int[] even = GetEvenElements(array);
            int[] odd = GetOddElements(array);

            Console.WriteLine("Массив элементов с четными индексами:");
            PrintArray(even);

            Console.WriteLine("Массив элементов с нечетными индексами:");
            PrintArray(odd);
        }
    }
}