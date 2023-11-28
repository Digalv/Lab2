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

        /*Заполнить массив из двадцати элементов следующим образом: 20, 19, ..., 1.
*/
        static int[] task6()
        {
            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr.Length - i;
            }
            return arr;
        }
        /*Найти сумму всех элементов массива целых чисел, удовлетворяющих условию: остаток от деления на 2 равен 3.
*/
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
        /*В массивах А[К] и B[L] хранятся коэффициенты двух многочленов степеней K и L. Поместить в массив С[М] коэффициенты их произведения. (Числа К, L, М — натуральные, М = K + L; элемент массива с индексом i содержит коэффициент при х в степени i.)
*/
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

        /*Дан массив целых чисел M1. Вводим массив M2, размер которого значительно меньше, чем у M1. Определить, сколько раз массив M2 встречается в M1.
*/
        static int task160(int[] m1, int[] m2)
        {
            if (m1.Length > m2.Length)
            {
                return m1.Length / m2.Length;
            }
            return 0;
        }
        /*Задан массив вещественных чисел и натуральные числа R и H < R. Создать и заполнить массив номеров таких чисел исходного массива, которые отличаются от R не более чем на Н.*/
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
