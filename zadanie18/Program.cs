namespace zadanie18
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

        static int[] GetUniqueElements(int[] array)
        {
            List<int> unique = new List<int>();

            foreach (int num in array)
            {
                if (!unique.Contains(num))
                {
                    unique.Add(num);
                }
            }

            return unique.ToArray();
        }

        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите элементы массива:");
            int[] array = ReadArrayFromConsole(n);

            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            int[] uniqueArray = GetUniqueElements(array);
            Console.WriteLine("Новый массив (уникальные элементы):");
            PrintArray(uniqueArray);
        }
    }
}