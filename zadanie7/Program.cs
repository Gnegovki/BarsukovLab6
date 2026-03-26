namespace zadanie7
{
    internal class Program
    {
        static int[] CreateFibonacciArray(int size)
        {
            int[] array = new int[size];

            if (size >= 1) array[0] = 0;
            if (size >= 2) array[1] = 1;

            for (int i = 2; i < size; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
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

        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n: ");
            int n = int.Parse(Console.ReadLine());

            int[] fibonacciArray = CreateFibonacciArray(n);
            Console.WriteLine($"Массив чисел Фибоначчи (первые {n} чисел):");
            PrintArray(fibonacciArray);
        }
    }
}