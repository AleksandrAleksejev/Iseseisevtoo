using System;
using System.Linq;

namespace Iseseisevtoo
{
    class Program
    {

        //массив действительных чисел размерности 10х10
        static int[] SumArray(int[,] arr)
            {
                int[] sum = new int[10];
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    for (int i = 0; i <= arr.GetUpperBound(1); i++)
                    {
                        sum[j] += arr[i, j];
                    }
                }
                return sum;
            }
            static int[] ProductOfNumbers(int[,] arr)
            {
                int[] pr = Enumerable.Repeat(1, 10).ToArray();
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        pr[j] *= arr[j, i];
                    }
                }
                return pr;
            }
            static int MaxEl(int[,] arr)
            {
                int maxelement = 0;
                for (int i = 0; i <= arr.GetUpperBound(1); i++)
                {
                    if (maxelement < arr[i, i])
                        maxelement = arr[i, i];
                }
                return maxelement;
            }
            static void PrintSum(int[,] arr)
            {
                Console.WriteLine("Количество всех элементов в массиве: " + arr.Length);
                Console.Write("Сумма элементов каждой строки: ");
                int[] sum = new int[10];
                sum = SumArray(arr);
                for (int i = 0; i < sum.Length; i++)
                {
                    Console.Write(sum[i] + " ");
                }
                Console.WriteLine();
            }
            static void PrintProduct(int[,] arr)
            {
                Console.Write("Произведения элементов каждого столбца: ");
                int[] pr = new int[10];
                pr = ProductOfNumbers(arr);
                for (int i = 0; i < pr.Length; i++)
                {
                    Console.Write(pr[i] + " ");
                }
                Console.WriteLine();
            }
            static void PrintMaxEl(int[,] arr)
            {
                Console.Write("Максимальный элемент главной диагонали(не индекс, а просто число): ");
                Console.WriteLine(MaxEl(arr));
            }

            static void Main(string[] args)
            {
                int[,] arr = new int[10, 10]
                {
                {1, 3, 2, 3, 7, 3, 9, 5, 1, 1},
                {3, 5, 9, 4, 2, 6, 3, 8, 1, 3},
                {3, 4, 1, 3, 7, 1, 7, 2, 1, 4},
                {2, 1, 6, 1, 9, 1, 4, 1, 3, 7},
                {3, 2, 4, 1, 5, 1, 5, 2, 1, 2},
                {3, 4, 1, 1, 6, 2, 7, 3, 5, 1},
                {3, 1, 5, 1, 3, 1, 1, 1, 1, 3},
                {5, 6, 2, 5, 6, 2, 5, 1, 3, 5},
                {2, 1, 4, 1, 1, 1, 1, 1, 4, 1},
                {2, 4, 1, 6, 6, 6, 6, 3, 6, 3}
                };
                PrintMaxEl(arr);
                PrintProduct(arr);
                PrintSum(arr);
                Console.ReadKey();
                
            
        }
    }
}
