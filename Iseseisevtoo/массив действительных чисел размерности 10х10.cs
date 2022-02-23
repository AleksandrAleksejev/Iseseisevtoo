using System;
using System.Linq;

namespace Iseseisevtoo
{
    class Program
    {

        // Ü 2.Задан массив действительных чисел размерности 10х10. Найти суммы элементов каждой строки,
        // произведения элементов каждого столбца, и максимальный элемент главной диагонали
        // (подсказка: все элементы, для которых номер строки совпадает с номером столбца).
        static int[] SuAr(int[,] ar)
            {
                int[] sum = new int[10];
                for (int j = 0; j < ar.GetLength(0); j++)
                {
                    for (int i = 0; i <= ar.GetUpperBound(1); i++)
                    {
                        sum[j] += ar[i, j];
                    }
                }
                return sum;
            }
            static int[] PrOfNu(int[,] ar)
            {
                int[] pr = Enumerable.Repeat(1, 10).ToArray();
                for (int j = 0; j <= ar.GetUpperBound(1); j++)
                {
                    for (int i = 0; i < ar.GetLength(0); i++)
                    {
                        pr[j] *= ar[j, i];
                    }
                }
                return pr;
            }
            static int Maxelement(int[,] ar)
            {
                int maxelement = 0;
                for (int i = 0; i <= ar.GetUpperBound(1); i++)
                {
                    if (maxelement < ar[i, i])
                        maxelement = ar[i, i];
                }
                return maxelement;
            }
            static void PrinSu(int[,] ar)
            {
                Console.WriteLine("Количество всех элементов в массиве: " + ar.Length);
                Console.Write("Сумма элементов каждой строки: ");
                int[] sum = new int[10];
                sum = SuAr(ar);
                for (int i = 0; i < sum.Length; i++)
                {
                    Console.Write(sum[i] + " ");
                }
                Console.WriteLine();
            }
            static void PrinPr(int[,] ar)
            {
                Console.Write("Произведения элементов каждого столбца: ");
                int[] pr = new int[10];
                pr = PrOfNu(ar);
                for (int i = 0; i < pr.Length; i++)
                {
                    Console.Write(pr[i] + " ");
                }
                Console.WriteLine();
            }
            static void PrinMaxelement(int[,] ar)
            {
                Console.Write("Максимальный элемент главной диагонали(не индекс, а просто число): ");
                Console.WriteLine(Maxelement(ar));
            }

            static void Main(string[] args)
            {
                int[,] ar = new int[10, 10]
                {
                {4, 3, 2, 3, 2, 1, 8, 5, 1, 2},
                {3, 1, 9, 4, 2, 8, 3, 8, 1, 3},
                {3, 4, 2, 3, 7, 1, 7, 2, 1, 4},
                {2, 1, 6, 1, 9, 1, 4, 1, 3, 7},
                {3, 2, 4, 1, 4, 1, 5, 2, 1, 8},
                {3, 4, 1, 1, 5, 2, 2, 3, 8, 1},
                {3, 1, 5, 1, 3, 1, 3, 1, 1, 3},
                {3, 6, 2, 5, 6, 2, 5, 1, 3, 5},
                {2, 1, 4, 1, 1, 1, 1, 1, 4, 1},
                {2, 4, 1, 6, 4, 6, 6, 3, 6, 3}
                };
                PrinMaxelement(ar);
                PrinPr(ar);
                PrinSu(ar);
                Console.ReadKey();
                
            
        }
    }
}
