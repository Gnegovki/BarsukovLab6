namespace zadanie82
{
    internal class Program
    {
        static double[] CreatePowerSeriesArray(int size, double x)
        {
            double[] array = new double[size];

            for (int i = 0; i < size; i++)
            {
                int power = 2 * i + 1;
                array[i] = Math.Pow(x, power) / power;
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
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());

            double[] array = CreatePowerSeriesArray(n, x);
            Console.WriteLine("Сгенерированный массив:");
            PrintArray(array);

            Console.WriteLine($"Сумма элементов: {SumArray(array):F6}");
        }
    }
}