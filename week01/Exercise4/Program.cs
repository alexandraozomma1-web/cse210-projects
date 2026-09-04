using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum of the numbers is: {sum}");

        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average of the numbers is: {average}");

        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
           {
            max = num;
            }
        }
            Console.WriteLine($"The maximum number is: {max}");
        
        int smallestPositive = int.MaxValue;
        foreach (int num in numbers)
        {
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            }
        }
        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("There are no positive numbers.");
        }

        numbers.Sort();
        Console.WriteLine("The numbers in ascending order are:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }


    }
}