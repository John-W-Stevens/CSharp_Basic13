using System;

namespace Basic13
{
    class Program
    {
        public static void PrintNumbers()
        {
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintOdds()
        {
            for (int i = 1; i <= 255; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintSum()
        {
            int Sum = 0;
            for (int i = 1; i <= 255; i++)
            {
                Sum += i;
                Console.WriteLine($"New number: {i} Sum: {Sum}");
            }
        }

        public static void LoopArray(int[] numbers)
        {
            foreach (int Number in numbers)
            {
                Console.WriteLine(Number);
            }
        }

        public static int FindMax(int[] numbers)
        {
            int Max = numbers[0];
            foreach (int Number in numbers)
            {
                if (Number > Max)
                {
                    Max = Number;
                }
            }
            return Max;
        }

        public static void GetAverage(int[] numbers)
        {
            int Sum = 0;
            foreach (int Value in numbers)
            {
                Sum += Value;
            }
            Console.WriteLine(Sum / numbers.Length);
        }

        public static int[] OddArray()
        {
            int[] Output = new int[128];
            int j = 0;
            for (int i = 1; i <= 255; i += 2)
            {
                Output[j] = i;
                j += 1;
            }
            return Output;
        }

        public static int GreaterThanY(int[] numbers, int y)
        {
            int Count = 0;
            foreach (int Value in numbers)
            {
                if (Value > y)
                {
                    Count += 1;
                }
            }
            return Count;
        }

        public static void SquareArrayValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= numbers[i];
            }
            foreach (int Value in numbers)
            {
                Console.WriteLine(Value);
            }
        }

        public static void EliminateNegatives(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        public static void MinMaxAverage(int[] numbers)
        {
            int Min = numbers[0];
            int Max = numbers[0];
            int Sum = 0;

            foreach (int Value in numbers)
            {
                Sum += Value;
                if (Value < Min) { Min = Value; }
                else if (Value > Max) { Max = Value; }
            }

            Console.WriteLine($"Min: {Min}");
            Console.WriteLine($"Max: {Max}");
            Console.WriteLine($"Average: {Sum / numbers.Length}");


        }

        public static void ShiftValues(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i - 1] = numbers[i];
            }
            numbers[numbers.Length - 1] = 0;
        }

        public static object[] NumToString(int[] numbers)
        {
            object[] Output = new object[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                     Output[i] = "Dojo"; 
                }
                else { Output[i] = numbers[i]; }
            }

            return Output;

        }


        static void Main(string[] args)
        {
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();

            // int[] Numbers = { 1, 2, 3, 4, 5 };
            // LoopArray(Numbers);

            // int[] Numbers = { 10, 20, 30, 99, 1001, 24, 5 };
            // Console.WriteLine(FindMax(Numbers));

            // int[] Numbers = { 2, 10, 3 };
            // GetAverage(Numbers);

            // int[] MyOddArray = OddArray();
            // foreach (int Value in MyOddArray)
            // {
            //     Console.WriteLine(Value);
            // }

            // int[] Numbers = { 1, 3, 5, 7 };
            // Console.WriteLine(GreaterThanY(Numbers, 3));

            // int[] Numbers = { 1, 2, 3, 4, 5, 6 };
            // SquareArrayValues(Numbers);

            // int[] Numbers = { 1, 5, 10, -2 };
            // EliminateNegatives(Numbers);
            // foreach(int Value in Numbers)
            // {
            //     Console.WriteLine(Value);
            // }

            // int[] Numbers = { 1, 5, 10, -2 };
            // MinMaxAverage(Numbers);

            // int[] Numbers = { 1, 5, 10, 7, -2 };
            // ShiftValues(Numbers);
            // foreach(int Value in Numbers)
            // {
            //     Console.WriteLine(Value);
            // }

            // int[] Numbers = { -1, -3, 2 };
            // object[] NewArray = NumToString(Numbers);

            // foreach (var Value in NewArray)
            // {
            //     Console.WriteLine(Value);
            // }

        }
    }
}
