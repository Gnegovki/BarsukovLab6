namespace zadanie515
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

        static int[] GetEvenElementsWithOdd(int[] array)
        {
            int count = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                if (array[i] % 2 == 0) count++;
            }

            int[] result = new int[count];
            int index = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                if (array[i] % 2 == 0)
                {
                    result[index++] = array[i];
                }
            }

            return result;
        }

        static int[] GetOddElementsWithEven(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                if (array[i] % 2 != 0) count++;
            }

            int[] result = new int[count];
            int index = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                if (array[i] % 2 != 0)
                {
                    result[index++] = array[i];
                }
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

            int[] evenOnOdd = GetEvenElementsWithOdd(array);
            int[] oddOnEven = GetOddElementsWithEven(array);

            Console.WriteLine("Четные элементы с нечетными индексами:");
            PrintArray(evenOnOdd);

            Console.WriteLine("Нечетные элементы с четными индексами:");
            PrintArray(oddOnEven);
        }
    }
}