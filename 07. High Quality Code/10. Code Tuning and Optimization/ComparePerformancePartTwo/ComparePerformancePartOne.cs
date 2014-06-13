namespace ComparePerformance
{
    using System;
    using System.Diagnostics;

    class ComparePerformancePartOne
    {
        static void Main(string[] args)
        {
            int power = 50;
            int repeats = 10000;
            int value = 5;

            ComparePerformance(() => IntAddition(value, repeats), "Integer addition");
            ComparePerformance(() => LongAddition(value, repeats), "Long addition");
            ComparePerformance(() => DoubleAddition(value, repeats), "Double addition");
            ComparePerformance(() => FloatAddition(value, repeats), "Float addition");
            ComparePerformance(() => DecimalAddition(value, repeats), "Decimal addition");
            
            Console.WriteLine(new string('*', 10));
            ComparePerformance(() => IntSubtraction(value, repeats), "Integer subtraction");
            ComparePerformance(() => LongSubtraction(value, repeats), "Long subtraction");
            ComparePerformance(() => DoubleSubtraction(value, repeats), "Double subtraction");
            ComparePerformance(() => FloatSubtraction(value, repeats), "Float subtraction");
            ComparePerformance(() => DecimalSubtraction(value, repeats), "Decimal subtraction");
           
            Console.WriteLine(new string('*', 10));
            ComparePerformance(() => IntIncrementation(value, repeats), "Integer incrementation");
            ComparePerformance(() => LongIncrementation(value, repeats), "Long incrementation");
            ComparePerformance(() => DoubleIncrementation(value, repeats), "Double incrementation");
            ComparePerformance(() => FloatIncrementation(value, repeats), "Float incrementation");
            ComparePerformance(() => DecimalIncrementation(value, repeats), "Decimal incrementation");
           
            Console.WriteLine(new string('*', 10));
            ComparePerformance(() => IntMultiplication(value, power), "Integer multiplication");
            ComparePerformance(() => LongMultiplication(value, power), "Long multiplication");
            ComparePerformance(() => DoubleMultiplication(value, power), "Double multiplication");
            ComparePerformance(() => FloatMultiplication(value, power), "Float multiplication");
            ComparePerformance(() => DecimalMultiplication(value, power), "Decimal multiplication");

            Console.WriteLine(new string('*', 10));
            ComparePerformance(() => IntDivision(value, repeats), "Integer division");
            ComparePerformance(() => LongDivision(value, repeats), "Long division");
            ComparePerformance(() => DoubleDivision(value, repeats), "Double division");
            ComparePerformance(() => FloatDivision(value, repeats), "Float division");
            ComparePerformance(() => DecimalDivision(value, repeats), "Decimal division");
        }

        public static void ComparePerformance(Action method, string name)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            method();
            stopwatch.Stop();
            Console.WriteLine(name + " finished in: " + stopwatch.Elapsed.TotalMilliseconds + "ms");
        }

        #region Additions
        public static void IntAddition(int value, int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                value += 5;
            }
        }

        public static void LongAddition(long value, int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                value += 5L;
            }
        }

        public static void FloatAddition(float value, int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                value += 5.0f;
            }
        }

        public static void DoubleAddition(double value, int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                value += 5.0d;
            }
        }

        public static void DecimalAddition(decimal value, int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                value += 5.0m;
            }
        }
        #endregion

        #region Subtractions
        public static void IntSubtraction(int value, int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                value -= 1;
            }
        }

        public static void LongSubtraction(long value, int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                value -= 1L;
            }
        }

        public static void FloatSubtraction(float value, int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                value -= 1.0f;
            }
        }

        public static void DoubleSubtraction(double value, int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                value -= 1.0d;
            }
        }
        public static void DecimalSubtraction(decimal value, int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                value -= 1.0m;
            }
        }
        #endregion

        #region Incrementations
        public static void IntIncrementation(int value, int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                value += 1;
            }
        }

        public static void LongIncrementation(long value, int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                value += 1L;
            }
        }

        public static void FloatIncrementation(float value, int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                value += 1.0f;
            }
        }

        public static void DoubleIncrementation(double value, int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                value += 1.0d;
            }
        }
        public static void DecimalIncrementation(decimal value, int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                value += 1.0m;
            }
        }
        #endregion

        #region Multiplications
        public static void IntMultiplication(int value, int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                value *= 2;
            }
        }

        public static void LongMultiplication(long value, int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                value *=2L;
            }
        }

        public static void FloatMultiplication(float value, int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                value *= 2.0f;
            }
        }

        public static void DoubleMultiplication(double value, int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                value *= 2.0d;
            }
        }
        public static void DecimalMultiplication(decimal value, int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                value *= 2.0m;
            }
        }
        #endregion

        #region Divisions
        public static void IntDivision(int value, int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                value /= 2;
            }
        }

        public static void LongDivision(long value, int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                value /= 2L;
            }
        }

        public static void FloatDivision(float value, int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                value/= 2.0f;
            }
        }

        public static void DoubleDivision(double value, int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                value /= 2.0d;
            }
        }
        public static void DecimalDivision(decimal value, int repeats)
        {
            for (int i = 0; i < repeats; i++)
            {
                value /= 2.0m;
            }
        }
        #endregion
    }
}
