using System;
using System.Diagnostics;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userInput;
        List<int> list = new List<int>();
        do
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());
            list.Add(userInput);
        } while (userInput != 0);

        int sum = 0;
        double average;
        int max = int.MinValue;
        for (int i = 0; i < list.Count; i++)
        {
            sum = sum + list[i];
            if (list[i] > max)
            {
                max = list[i];
            }
        }
        average = (double)sum / (list.Count-1);

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {max}");
    }
}