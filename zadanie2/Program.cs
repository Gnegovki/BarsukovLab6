namespace zadanie2
{
    internal class Program
    {
        static double[] ReadArray(int lenght)
        {
            double[] array = new double[lenght];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Элемент [{i}]: ");
                array[i] = double.Parse(Console.ReadLine());
            }
            return array;
        }

        static void PrintArray(double[] array)
        {
            foreach (double num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static double AveragePositive(double[] array)
        {
            double sum = 0;
            int count = 0;

            foreach (double num in array)
            {
                if (num > 0)
                {
                    sum += num;
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите 8 вещественных чисел:");
            double[] array = ReadArray(8);

            Console.WriteLine("Введенный массив:");
            PrintArray(array);

            double average = AveragePositive(array);
            Console.WriteLine($"Среднее арифметическое положительных элементов: {average}");
        }
    }
}