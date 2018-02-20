using System;

namespace Example3
{
    /*Продемонстрировать применение параметров в методе, 
     на примере распознавания простое ли число и выявления общего наименьшего множетеля двух чисел*/

    class ParmDemo
    {
        static void Main()
        {
            ChkNum ob = new ChkNum();
            int a, b;

            for (int i = 1; i < 15; i++)
            {
                if (ob.IsPrime(i))
                {
                    Console.WriteLine("Число {0} -- простое.", i);
                }
                else
                {
                    Console.WriteLine("Число {0} -- непростое.", i);
                }
            }

            for (a = 2, b = 20; a <= b; a++, b--)
            {
                Console.WriteLine("Для чисел {0} и {1} наименьшим общим множителем является число " 
                    + ob.LeastComFact(a, b), a, b);
            }
        }
    }
}