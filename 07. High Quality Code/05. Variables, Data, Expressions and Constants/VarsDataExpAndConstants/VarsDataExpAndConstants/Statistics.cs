namespace VarsDataExpAndConstants
{
    using System;
    using System.Linq;

    public class Statistics
    {
        static void Main()
        {
            double[] arr = { 2, 3, 4, 5, 6, 7, 89, 2, 3 };
            PrintStatistics(arr, arr.Length);
        }

        public static void PrintStatistics(double[] arr, int count)
        {
            double max = double.MinValue;
            double tmp;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine("The biggest number in this array is: " + max);

            tmp = 0;
            max = double.MaxValue;
            for (int i = 0; i < count; i++)
            {
                if (arr[i] < max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine("The smalles number in this array is: " + max);

            tmp = 0;
            for (int i = 0; i < count; i++)
            {
                tmp += arr[i];
            }

            Console.WriteLine("The average number in this array is: " + tmp / count);
        }
    }
}
