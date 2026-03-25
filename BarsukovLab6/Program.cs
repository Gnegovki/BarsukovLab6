namespace BarsukovLab6
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число M");
            int M = int.Parse(Console.ReadLine());
            int n = 10;
            int[] array = new int[n];
            for (int i = 0; i < 10; i++)
            {
                array[i] = M;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
