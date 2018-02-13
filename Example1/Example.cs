using System;

class ProgrammExamples
{
    static void Main()
    {
        int origNum, num;
        int i, j;
        int[] factors = new int[10];

        for (origNum = 4; origNum <= 20; origNum++)
        {
            num = origNum;

            //Обнуляем массив множителей
            for (j = 0; j < factors.Length; j++)
                factors[j] = 1;

            //разложить число num на множители
            for (i = 2, j = 0; (i <= origNum) && (j < factors.Length); i++)
            {
                if ((num % i) == 0)
                {
                    factors[j] = i;
                    j++;

                    num = num / i;

                    //Проверяем есть ли еще множитель i
                    for (; ((num % i) == 0) && (j < factors.Length); num = num / i)
                    {
                        factors[j] = i;
                        j++;
                    }
                }
            }

            Console.WriteLine("Множители числа: " + origNum);
            for (j = 0; j < factors.Length; j++)
                Console.Write(factors[j] + " ");

            Console.WriteLine();
            Console.WriteLine();
        }
    }

}