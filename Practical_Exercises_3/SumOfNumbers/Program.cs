using System;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int basket = 0;

            number = int.Parse(Console.ReadLine());

            while (number != 0)
            {
                basket += number;

                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(basket);
        }
    }
}
