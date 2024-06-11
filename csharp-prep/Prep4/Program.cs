using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, when finished type 0.");
        int userIn = 0;
        int sum = 0;
        float avg = 0;
        int largest = 0;
        int smallestPos = 9999999;
        List<int> numbers = new List<int>();
        do
        {
            userIn = int.Parse(Console.ReadLine());
            if (userIn > largest)
            {
                largest = userIn;
            }
            if (userIn < smallestPos && userIn > 0)
            {
                smallestPos = userIn;
            }
            if (userIn != 0)
            {
                numbers.Add(userIn);
                sum += userIn;
            }
        }
        while (userIn != 0);
        avg = (float)sum / (numbers.Count);
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallestPos}");
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}