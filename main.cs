using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPerfect(number))
        {
            Console.WriteLine($"{number} is a perfect number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a perfect number.");
        }
    }
    static bool IsPerfect(int number)
    {
        int sum = 1; 

        for (int i = 2; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }

        return sum == number;
    }
}