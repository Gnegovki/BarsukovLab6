namespace zadanie11
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

        static int[] RemoveOddElements(int[] array)
        {
            int count = 0;
            foreach (int num in array)
            {
                if (num % 2 == 0) count++;
            }

            int[] result = new int[count];
            int index = 0;
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    result[index++] = num;
                }
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

            int[] newArray = RemoveOddElements(array);
            Console.WriteLine("Новый массив (без нечетных элементов):");
            PrintArray(newArray);
        }
    }
}