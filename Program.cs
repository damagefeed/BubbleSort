class BubbleSort
{
    static void Main()
    {
        Console.Write($"Enter the amount of the array elements:\t");
        int arrayAmounnt = int.Parse(Console.ReadLine());
        int[] array = new int[arrayAmounnt];
        Random rnd = new Random();

        for (int i = 0; i <= array.Length - 1; i++)
        {
            array[i] = rnd.Next(-100, 100);
            Console.WriteLine($"Element position: {i}, element value: {array[i]}");
        }

        int[] outputArray = BSort(array);
        Console.WriteLine($"\nSorted array:\t{String.Join(", ", outputArray)}");
    }

    static int[] BSort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int k = 0; k < array.Length - 1 - i; k++)
            {
                if (array[k] > array[k + 1])
                {
                    int replacingNum = array[k];
                    array[k] = array[k + 1];
                    array[k + 1] = replacingNum;
                }
            }
        }
        return array;
    }
}