namespace zadanie8
{
    internal class Program
    {
        static double[] CreateAlternatingSeriesArray(int size)
        {
            double[] array = new double[size];

            for (int i = 0; i < size; i++)
            {
                int n = i + 1;
                array[i] = (i % 2 == 0) ? 1.0 / n : -1.0 / n;
            }

            return array;
        }

        static void PrintArray(double[] array)
        {
            foreach (double num in array)
            {
                Console.Write($"{num:F4} ");
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

            double[] array = CreateAlternatingSeriesArray(n);
            Console.WriteLine("Сгенерированный массив:");
            PrintArray(array);

            Console.WriteLine($"Сумма элементов: {SumArray(array):F6}");
        }
    }
}