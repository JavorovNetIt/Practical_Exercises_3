using System;

namespace Multiply5Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counterOfNegativeNumbers = 0;

            for (int i = 0; i < 5; i++)
            {
                int num1 = int.Parse(Console.ReadLine());

                if (num1 < 0)
                {
                    counterOfNegativeNumbers++;
                }
                else if (num1 == 0)
                {
                    Console.WriteLine("The result is zero");
                    return;
                }
            }

            if (counterOfNegativeNumbers % 2 == 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }


        }
    }
}
