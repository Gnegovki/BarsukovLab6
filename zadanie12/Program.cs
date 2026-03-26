namespace zadanie12
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

        static int[] MakeAllEven(int[] array)
        {
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    result[i] = array[i];
                else
                    result[i] = array[i] + 1;
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

            int[] newArray = MakeAllEven(array);
            Console.WriteLine("Новый массив (все элементы четные):");
            PrintArray(newArray);
        }
    }
}