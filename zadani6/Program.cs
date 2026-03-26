namespace zadanie6
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

        static void PrintPrices(int[] prices)
        {
            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine($"Товар {i + 1}: {prices[i]} руб.");
            }
        }

        static (int minPrice, int index) FindMinPrice(int[] prices)
        {
            int minPrice = prices[0];
            int index = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                    index = i;
                }
            }

            return (minPrice, index);
        }

        static void Main(string[] args)
        {
            int[] prices = CreateRandomArray(15, 20, 300);
            Console.WriteLine("Цены на товары:");
            PrintPrices(prices);

            var result = FindMinPrice(prices);
            Console.WriteLine($"\nСамый дешевый товар: {result.minPrice} руб. (порядковый номер {result.index + 1})");
        }
    }
}