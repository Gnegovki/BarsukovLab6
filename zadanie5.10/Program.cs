namespace zadanie510
{
    internal class Program
    {
        static int[] CreateRandomArray(int size, int min, int max)
        {
            int[] array = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(min, max + 1);
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

        static (int minValue, int minIndex) FindMinOnEvenPositions(int[] array)
        {
            int minValue = array[0];
            int minIndex = 0;

            for (int i = 2; i < array.Length; i += 2)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                    minIndex = i;
                }
            }

            return (minValue, minIndex);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = CreateRandomArray(n, -50, 100);
            Console.WriteLine("Сгенерированный массив:");
            PrintArray(array);

            var result = FindMinOnEvenPositions(array);
            Console.WriteLine($"Минимальный элемент на четных позициях: {result.minValue} (индекс {result.minIndex})");
        }
    }
}