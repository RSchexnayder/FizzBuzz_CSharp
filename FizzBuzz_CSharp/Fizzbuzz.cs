
using System;

namespace FizzBuzz_CSharp 

{
    class FizzBuzz
    {
        public static void printFizzBuzz(int startNumber, int endNumber)
        {
            for (int i = startNumber;i <= endNumber; i++)
            {
                if (isDivisible(i, 3) && !isDivisible(i, 5))
                {
                    Console.WriteLine("Fizz");
                } else if (!isDivisible(i, 3) && isDivisible(i, 5))
                {
                    Console.WriteLine("Buzz");
                } else if (isDivisible(i, 3) && isDivisible(i, 5))
                {
                    Console.WriteLine("FizzBuzz");
                } else 
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool isDivisible(int number, int divisibleBy)
        {
            if (number % divisibleBy == 0)
            {
                return true;
            } else 
            {
                return false;
            }
        }
    }
}