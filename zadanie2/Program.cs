namespace zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] array = new double[8];
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                array[i] = double.Parse(Console.ReadLine());
            }
            double sum = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                    count++;
                }
            }
            double sredn = sum / count;
            Console.WriteLine($"Среднее арифметическое равно: {sredn}");
        }
    }
}
