using System;

namespace Danylo_lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine(string.Join(", ", task6()));
            Console.WriteLine(task67(rnd.Next(0, 100)));
            Console.WriteLine(string.Join(", ", task153(rnd.Next(0, 20), rnd.Next(0, 20))));
            Console.WriteLine(task160(new int[10], new int[2]));
            Console.WriteLine(string.Join(", ", task179(new double[rnd.Next(0, 20)], rnd.Next(0, 20), rnd.Next(0, 20))));
        }
        static int[] task6()
        {
            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr.Length - i;
            }
            return arr;
        }
        static int task67(int lengthArr)
        {
            int[] arr = new int[lengthArr];
            int answer = 0;
            Random rnd = new Random();
            for (int i = 0; i < lengthArr; i++)
            {
                arr[i] = rnd.Next(0, 1000);
                if (arr[i] % 3 == 2)
                {
                    answer += arr[i];
                }
            }
            return answer;
        }
        static int[] task153(int k, int l)
        {
            int[] arrA = new int[k];
            int[] arrB = new int[l];
            int[] arrC = new int[k + l];
            Random rnd = new Random();
            for (int i = 0; i < k; i++)
            {
                arrA[i] = rnd.Next(0, 20);
            }
            for (int i = 0; i < l; i++)
            {
                arrB[i] = rnd.Next(0, 20);
            }
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    arrC[i + j] += arrA[i] * arrB[j];
                }
            }
            return arrC;
        }
        static int task160(int[] m1, int[] m2)
        {
            if (m1.Length > m2.Length)
            {
                return m1.Length / m2.Length;
            }
            return 0;
        }
        static double[] task179(double[] arr, double R, double H)
        {
            int count = 0;
            Random rnd = new Random();
            
            for(int i  = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.NextDouble() * 100;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i] - R) <= H)
                {
                    count++;
                }
            }

            double[] result = new double[count];
            int resultIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i] - R) <= H)
                {
                    result[resultIndex] = i;
                    resultIndex++;
                }
            }

            return result;
        }
    }
}