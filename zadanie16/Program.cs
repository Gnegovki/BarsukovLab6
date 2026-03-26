namespace zadanie16
{
    internal class Program
    {
        static int[] ReadArrayFromConsole(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Элемент [{i}]: ");
                array[i] = int.Parse(Console.ReadLine());
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

        static int[] SkipWhileLessThan(int[] array, int threshold)
        {
            int startIndex = 0;
            while (startIndex < array.Length && array[startIndex] < threshold)
            {
                startIndex++;
            }

            if (startIndex >= array.Length)
                return new int[0];

            int newSize = array.Length - startIndex;
            int[] result = new int[newSize];

            for (int i = 0; i < newSize; i++)
            {
                result[i] = array[startIndex + i];
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите элементы массива:");
            int[] array = ReadArrayFromConsole(n);

            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            int[] newArray = SkipWhileLessThan(array, 20);
            Console.WriteLine("Новый массив (пропущены элементы < 20 в начале):");
            PrintArray(newArray);
        }
    }
}