namespace zadanie3
{
    internal class Program
    {
        static int[] CreateAndFillArray(int length)
        {
            int[] array = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 100);
            }
            return array;
        }
        static void SummOtricatx(int[] array)
        {
            int sum = 0;
            for (int i = 0; i <= array.Length; i++)
            {
                if (i % 2 != 0 && array[i] < 0)
                {
                    sum += array[i];
                }
            }
        }
        static void Main(string[] args)
        {
            
            int n = 10;
            int[] array = CreateAndFillArray(n);
        }
    }
}
