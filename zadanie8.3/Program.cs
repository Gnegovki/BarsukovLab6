namespace zadanie83
{
    internal class Program
    {
        static long Factorial(int n)
        {
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        static double[] CreateFactorialSeriesArray(int size)
        {
            double[] array = new double[size];

            for (int i = 0; i < size; i++)
            {
                int k = i + 1;
                array[i] = 1.0 / Factorial(k);
            }

            return array;
        }

        static void PrintArray(double[] array)
        {
            foreach (double num in array)
            {
                Console.Write($"{num:F6} ");
            }
            Console.WriteLine();
        }

        static double SumArray(double[] array)
        {
            double sum = 0;
            foreach (double num in array)
            {
                sum += num;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n: ");
            int n = int.Parse(Console.ReadLine());

            double[] array = CreateFactorialSeriesArray(n);
            Console.WriteLine("Сгенерированный массив:");
            PrintArray(array);

            Console.WriteLine($"Сумма элементов: {SumArray(array):F6}");
        }
    }
}