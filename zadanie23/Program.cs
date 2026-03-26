namespace zadanie23
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

        static int SumOfDigits(int num)
        {
            int sum = 0;
            num = Math.Abs(num);
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        static void SortByDigitSum(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (SumOfDigits(array[j]) > SumOfDigits(array[j + 1]))
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите элементы массива:");
            int[] array = ReadArrayFromConsole(n);

            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            SortByDigitSum(array);
            Console.WriteLine("Отсортированный массив (по сумме цифр):");
            PrintArray(array);
        }
    }
}