using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string Letter = "";
        Console.WriteLine("What is your grade percentage?");
        int Grade = int.Parse(Console.ReadLine());
        if (Grade >= 90)
        {
            Letter = "an A";
            if (Grade - 90 < 3)
            {
                Letter = Letter + "-";
            }

        }
        else if (Grade >= 80)
        {
            Letter = "a B";
            if (Grade - 80 >= 7)
            {
                Letter = Letter + "+";
            }
            else if (Grade - 80 < 3)
            {
                Letter = Letter + "-";
            }
        }
        else if (Grade >= 70)
        {
            Letter = "a C";
            if (Grade - 70 >= 7)
            {
                Letter = Letter + "+";
            }
            else if (Grade - 70 < 3)
            {
                Letter = Letter + "-";
            }
        }
        else if (Grade >= 60)
        {
            Letter = "a D";
            if (Grade - 60 >= 7)
            {
                Letter = Letter + "+";
            }
            else if (Grade - 60 < 3)
            {
                Letter = Letter + "-";
            }
        }
        else if (Grade < 60)
        {
            Letter = "an F";
        }
        Console.Write($"Your grade is {Letter}");
    }
}