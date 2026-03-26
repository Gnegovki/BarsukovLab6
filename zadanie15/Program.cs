namespace zadanie15
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

        static int[] RemoveLastKElements(int[] array, int k)
        {
            if (k >= array.Length)
                return new int[0];

            int newSize = array.Length - k;
            int[] result = new int[newSize];

            for (int i = 0; i < newSize; i++)
            {
                result[i] = array[i];
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n (n > 4): ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 4)
            {
                Console.WriteLine("Ошибка: n должно быть больше 4");
                return;
            }

            Console.WriteLine("Введите элементы массива:");
            int[] array = ReadArrayFromConsole(n);

            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            int[] newArray = RemoveLastKElements(array, 4);
            Console.WriteLine("Новый массив (без последних 4 элементов):");
            PrintArray(newArray);
        }
    }
}