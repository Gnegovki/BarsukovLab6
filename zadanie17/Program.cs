namespace zadanie17
{
    internal class Program
    {
        static int[] ReadArrayFromConsole(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Элемент [{i}]: ");
                array[i] = int.Parse(Console.ReadLine());
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
        
        static int[] TakeWhileLessThan(int[] array, int threshold)
        {
            int count = 0;
            while (count < array.Length && array[count] < threshold)
            {
                count++;
            }
            
            int[] result = new int[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = array[i];
            }
            
            return result;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n: ");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите элементы массива:");
            int[] array = ReadArrayFromConsole(n);
            
            Console.WriteLine("Исходный массив:");
            PrintArray(array);
            
            int[] newArray = TakeWhileLessThan(array, 20);
            Console.WriteLine("Новый массив (элементы из начала, пока < 20):");
            PrintArray(newArray);
        }
    }
}