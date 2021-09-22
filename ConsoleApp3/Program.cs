using System;
using Four;



namespace ConsoleApp3
{
    class Program
    {
        Fourproblems solution = new Fourproblems();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            solution.Factorial(5);
            solution.FindLCM(4,7);
            solution.Is_leap(2020);
            solution.Is_prime(88);

        }
    }
    }
