using System;

namespace ThreeNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int min = 0;
            int aver = 0;
            int max = 0;

            if (num > num1 && num > num2)
            {
                max = num;

                if (num1 > num2)
                {
                    aver = num1;
                    min = num2;
                }
                else
                {
                    aver = num2;
                    min = num1;
                }
            }
            else if (num1 > num && num1 > num2)
            {
                max = num1;

                if (num > num2)
                {
                    aver = num;
                    min = num2;
                }
                else
                {
                    aver = num2;
                    min = num;
                }
            }
            else if (num2 > num && num2 > num1)
            {
                max = num2;

                if (num > num1)
                {
                    aver = num;
                    min = num1;
                }
                else
                {
                    aver = num1;
                    min = num;
                }
            }

            Console.WriteLine($"{max} {aver} {min}");
        }
    }
}
