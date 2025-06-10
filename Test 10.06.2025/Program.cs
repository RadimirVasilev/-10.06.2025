namespace Test_10._06._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] UniqueNums = { 4, 3, 2, 36, 6, 12, 11, 23, 5, 8, 1, 7 };
            List<int> SaveNums = new List<int>();
            bool swapped;
    //          Сортиране на масива с помощта на BubbleSort
    //                              |
    //                              V
            do
            {
                swapped = false;
                for (int i = 0; i < UniqueNums.Length-1; i++)
                {
                    if(Less(UniqueNums[i], UniqueNums[i + 1]))
                    {
                        Swap(UniqueNums, i, i + 1);
                        swapped = true;
                    }
                    
                }



            }
            while (swapped);
    //                 Намиране на поредицата
    //                           |
    //                           V
            for (int i = 0; i < UniqueNums.Length-1; i++)
            {
                if (UniqueNums[i] + 1 == UniqueNums[i+ 1]) 
                {
                    SaveNums.Add(UniqueNums[i]);
                }
                else if (UniqueNums[i] !=  UniqueNums[i+ 1])
                {
                    SaveNums.Add(UniqueNums[i]);
                    break;
                }
                else
                {
                    break;
                }
            }
    //                  Печатане на масива:
    //                           |
    //                           V
            Console.Write("Подреден масив: ");
            for (int i =0; i < UniqueNums.Length ;i++)
            {
                Console.Write(UniqueNums[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Най-дълга поредицата от най-малкото: ");
            Console.WriteLine(string.Join(" ", SaveNums));

            Console.WriteLine($"Дължина: {SaveNums.Count()}");
        }
    //              Метод за проверка
    //                      |
    //                      V
        public static bool Less(int first, int second) 
        {
            return first.CompareTo(second) > 0;
        }
    //           Метод за смяна в масива
    //                      |
    //                      V
        public static void Swap(int[] a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;

        }
    }
}
