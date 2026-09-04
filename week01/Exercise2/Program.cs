using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What is your grade? ");
        string input = Console.ReadLine();
        int score = int.Parse(input);

        string letter;

        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string sign = " ";
        int lastDigit = score % 10;

        if (lastDigit >= 7)
        {
            sign = "";
        }
        else if (lastDigit <= 3)
        {
            sign = "-";
        }

        if (letter == "A" && sign == "+")
        {
            sign = "+";
        }
        else if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

         if (score >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Not quite there yet, but you’re closer than before and you can do better next time!");
        }
    }
}