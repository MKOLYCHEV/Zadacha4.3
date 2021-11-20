using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, Ca = 0, Cb = 0, nCa = 0, nCab = 0;
            Console.WriteLine("Введите число A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число C");
            C = Convert.ToInt32(Console.ReadLine());
            if (A <= 0 || B <= 0 || C <= 0)
            {
                Console.WriteLine("Ошибка! Введенные числа должны быть положительными.");
            }
            else
            {
                while (A >= (Ca + C))
                {
                    Ca = Ca + C;
                    nCa++;
                }
                while (B >= (Cb + C))
                {
                    Cb = Cb + C;
                    nCab += nCa;
                }
                Console.WriteLine("Максимально возможное количество квадратов со строной С, которое можно разместить на прямоугольнике А х В, равно {0}", nCab);
            }
            Console.ReadKey();
        }
    }
}
