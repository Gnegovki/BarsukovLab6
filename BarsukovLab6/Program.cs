namespace BarsukovLab6
{
    internal class Program
    {
        static int[] CreateArray(int lenght, int m)
        {
            int[] array = new int[lenght];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = m;
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
            Console.Write("Введите число M: ");
            int m = int.Parse(Console.ReadLine());

            int[] array = CreateArray(10, m);
            Console.WriteLine("Полученный массив:");
            PrintArray(array);
        }
    }
}