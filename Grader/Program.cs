using System;

namespace HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 4, 6, 1, 3, 9, 0, -1, -6, 11 };
            int[] array2 = { -9, -7 -5, -11, -7, -88, -5, -10 };


            Console.WriteLine("Maximum: " + FindMax(array1));
            Console.WriteLine();
            Console.WriteLine("Maximum2: " + FindMax(array2));

            float[] avg1 = { 1, 2, 3, 4, 5, 6, 8, 10 };
            Console.WriteLine("Avg: " + FindAvg(avg1));
        }

        static int FindMax(int[] param)
        {
            int max = param[0];

            for (int i = 0; i < param.Length; i++)
            {
                if (max < param[i])
                {
                    max = param[i];
                }
                
            }
            return max;

        }

        static float FindAvg(float[] avg)
        {
            float NumAvg = 0;

            for (int i = 0; i < avg.Length; i++)
            {
                NumAvg += avg[i];
                
            }
            NumAvg/= avg.Length;
            return NumAvg;
        }
    }
}