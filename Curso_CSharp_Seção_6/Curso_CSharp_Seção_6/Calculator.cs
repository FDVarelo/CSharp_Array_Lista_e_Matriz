using System;

namespace Curso_CSharp_Seção_6
{
    internal class Calculator
    {
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for(int i = 1; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        public static void Triple(ref int x)
        {
            x *= 3;
        }
        public static void Double(int origin, out int destination)
        {
            destination = origin * 2;
        }
    }
}
