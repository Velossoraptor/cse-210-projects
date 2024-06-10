using System;

class Program
{
    static void Main(string[] args)
    {
        int grade;
        string letter = "";

        Console.Write("What is your percentage grade?: ");
        grade = int.Parse(Console.ReadLine());

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade < 90 && grade >= 80)
        {
            letter = "B";
        }
        else if (grade < 80 && grade >= 70)
        {
            letter = "C";
        }
        else if (grade < 70 && grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        if (grade % 10 >= 7)
        {
            letter += "+";
        }
        else if (grade % 10 < 3)
        {
            letter += "-";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("You passed! Congratulations!!");
        }
        else
        {
            Console.WriteLine("You'll get it next time :)");
        }
    }
}