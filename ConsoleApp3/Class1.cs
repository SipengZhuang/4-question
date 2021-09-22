using System;
using System.Collections.Generic;
using System.Text;

namespace Four
{
    class Fourproblems
    {

        public void Factorial(int num)
        {
            int sum = 0;
            int length = num;

            for (int i = 0; i < length; i++)
            {
                sum = sum + i; 
            }
            Console.WriteLine(sum);


            
        }
        public void Is_prime(int num)
        {
            int length = num; int a = 0;
            for (int i = 0; i < length; i++)
            {
                if (num % i == 0)
                {
                    a++;

                }
                
                if (a == 2)
                {
                    Console.WriteLine("The number is a prime number");
                else
                    {
                        Console.WriteLine("Not a prime number")
                    }
                }
            }
        }
        public void Is_leap(int num)
            
        {
            int length=num;
            if (num % 4 == 0)
            {
                Console.WriteLine("This is a leap year");
            }
            else
            {
                Console.WriteLine("This is not a leap year");
            }
        }
        public void FindLCM(int a, int b) 
        {
            int num1, num2; int LCM = 0;
            if (a > b)
            {
                num1 = a; num2 = b;
            }
            else
            {
                num1 = b; num2 = a;
            }

            for (int i = 1; i <= num2; i++)
            {
                if ((num1 * i) % num2 == 0)
                {
                    LCM= i * num1;
                }
            }
            Console.WriteLine($"The least common multiplier is {LCM}");

        }

    }

   
}
