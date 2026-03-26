namespace zadanie21
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

        static int[] CyclicShiftLeft(int[] array, int m)
        {
            int n = array.Length;
            m = m % n;
            if (m == 0) return (int[])array.Clone();

            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = array[(i + m) % n];
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите элементы массива:");
            int[] array = ReadArrayFromConsole(n);

            Console.Write("Введите m (сдвиг): ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            int[] shifted = CyclicShiftLeft(array, m);
            Console.WriteLine($"Массив после циклического сдвига влево на {m} элементов:");
            PrintArray(shifted);
        }
    }
}