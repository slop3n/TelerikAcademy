namespace ComparePerformancePartTwo
{
    using System;
    using System.Diagnostics;

    class ComparePerformancePartTwo
    {
        static void Main(string[] args)
        {
            int repeats = 100000;
            ComparePerformance(() => FloatSquareRoot(repeats), "Float square root");
            ComparePerformance(() => DoubleSquareRoot(repeats), "Double square root");
            ComparePerformance(() => DecimalSquareRoot(repeats), "Decimal square root");

            Console.WriteLine(new string('*', 10));
            ComparePerformance(() => FloatLogarithm(repeats), "Float logarithm");
            ComparePerformance(() => DoubleLogarithm(repeats), "Double logarithm");
            ComparePerformance(() => DecimalLogarithm(repeats), "Decimal logarithm"); 
            
            Console.WriteLine(new string('*', 10));
            ComparePerformance(() => FloatSin(repeats), "Float sinus");
            ComparePerformance(() => DoubleSin(repeats), "Double sinus");
            ComparePerformance(() => DecimalSin(repeats), "Decimal sinus");

        }

        public static void ComparePerformance(Action method, string name)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            method();
            stopwatch.Stop();
            Console.WriteLine(name + " finished in: " + stopwatch.Elapsed.TotalMilliseconds + "ms");
        }

        #region Squares
        public static void FloatSquareRoot(int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                Math.Sqrt(i);
            }
        }

        public static void DoubleSquareRoot(int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                Math.Sqrt(i);
            }
        }

        public static void DecimalSquareRoot(int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                Math.Sqrt(i);
            }
        }
        #endregion

        #region Logarithms
        public static void FloatLogarithm(int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                Math.Log(i);
            }
        }

        public static void DoubleLogarithm(int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                Math.Log(i);
            }
        }

        public static void DecimalLogarithm(int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                Math.Log(i);
            }
        }
        #endregion

        #region Sinuses
        public static void FloatSin(int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                Math.Sin(i);
            }
        }

        public static void DoubleSin(int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                Math.Sin(i);
            }
        }

        public static void DecimalSin(int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                Math.Sin(i);
            }
        }
        #endregion
    }
}
