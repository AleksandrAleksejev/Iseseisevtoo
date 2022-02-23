using System;
using System.Collections.Generic;
using System.Text;

namespace Iseseisevtoo
{
    class Строка_произвольной_длинны
    {
        static void Main(string[] args)
        {
            //1

            Console.WriteLine("Введите символы : ");
            string str = Console.ReadLine();
            Console.WriteLine("Введите символ для того что бы найти процент : ");
            char sum = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int l = str.Length;
            char[] strArr = str.ToCharArray();
            int count = 0;
            for (int i = 0; i < l; i++)
            {
                if (strArr[i] == sum)
                {
                    count++;
                }
            }
            double lDouble = Convert.ToDouble(l);
            double countDouble = Convert.ToDouble(count);
            double p = (countDouble / lDouble) * 100;
            Console.WriteLine($"Процент вхождения символа {sum} равен {p}%");


            Console.ReadKey();
        }

        }
    }
