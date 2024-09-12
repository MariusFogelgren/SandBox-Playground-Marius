using System;

namespace EvenOROdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int Pnumber;
            Console.WriteLine("Enter a number to check if it is even or odd");
            Pnumber = Convert.ToInt32(Console.ReadLine());

            if (Pnumber % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }

        }
    }
}