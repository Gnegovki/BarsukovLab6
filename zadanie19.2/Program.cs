namespace zadanie192
{
    internal class Program
    {
        static int[] ReadArrayFromConsole(string name, int size)
        {
            int[] array = new int[size];
            Console.WriteLine($"Введите элементы массива {name}:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Элемент [{i}]: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }

        static void PrintArray(int[] array, string name)
        {
            Console.Write($"{name}: ");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static int[] GetIntersection(int[] first, int[] second)
        {
            List<int> result = new List<int>();

            foreach (int num in first)
            {
                foreach (int secondNum in second)
                {
                    if (num == secondNum && !result.Contains(num))
                    {
                        result.Add(num);
                        break;
                    }
                }
            }

            return result.ToArray();
        }

        static void Main(string[] args)
        {
            Console.Write("Введите размер первого массива n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите размер второго массива m: ");
            int m = int.Parse(Console.ReadLine());

            int[] first = ReadArrayFromConsole("A", n);
            int[] second = ReadArrayFromConsole("B", m);

            PrintArray(first, "Массив A");
            PrintArray(second, "Массив B");

            int[] result = GetIntersection(first, second);
            PrintArray(result, "Элементы в обоих массивах");
        }
    }
}