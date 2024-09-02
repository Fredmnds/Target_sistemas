using System;

class Program
{
    static void Main()
    {

        int number = 6763;

        if (IsFibonacci(number))
        {
            Console.WriteLine($"{number} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{number} não pertence à sequência de Fibonacci.");
        }
    }

    static bool IsFibonacci(int number)
    {
        if (number < 0)
        {
            return false;
        }

        int a = 0, b = 1;

        if (number == a || number == b)
        {
            return true;
        }

        int c = a + b;

        while (c <= number)
        {
            if (c == number)
            {
                return true;
            }

            a = b;
            b = c;
            c = a + b;
        }

        return false;
    }
}