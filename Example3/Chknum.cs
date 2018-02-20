using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class ChkNum
    {
        //Проверить, простое ли число х. 
        //Возвращает true, если число простое, false - если непростое.
        public bool IsPrime(int x) 
        {
            for (int i = 2; i <= x / 2; i++)
            {
                if ((x < 1) || ((x % i) == 0))
                {
                    return false;
                }
            }

            return true;
        }

        //Найти наименьший общий множитель чисел а и б.
        //Возвращает наименьший множитель 
        //или 1, если числа взаимно простые.
        public int LeastComFact(int a, int b)
        {
            int max;

            if ((IsPrime(a)) || (IsPrime(b)))
            {
                return 1;
            }

            max = a < b ? a : b;

            for (int i = 2; i <= max; i++)
            {
                if ((a % i) == 0 && (b % i) == 0)
                {
                    return i;
                }
            }
            return 1;
        }
    }
}
