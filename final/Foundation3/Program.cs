using System;

class Program
{
    static void Main(string[] args)
    {
        Address genericAddress = new Address("1234 Event place", "City", "Province", "Country");

        Lecture lecture = new Lecture("TED Talk on Space", "A ted talk on space and all that stuff", "July 20th, 2024", "11:00 am", genericAddress, "Jan Smith", 500);
        Reception reception = new Reception("Lisa's Wedding", "Lisa's wedding reception.", "October 4th, 2024", "5:00 pm", genericAddress, "LisaHolley@gmail.com");
        Outdoor outdoor = new Outdoor("Jason's Farewell", "Jason's mission farewell", "August 14th, 2024", "1:00 pm", genericAddress, "Mixed Sun and Clouds");

        Console.WriteLine();
        Console.WriteLine("Standard");
        lecture.StandardDetails();
        Console.WriteLine("Short");
        lecture.ShortDescription();
        Console.WriteLine("Full");
        lecture.FullDetails();

        Console.WriteLine();
        Console.WriteLine("Standard");
        reception.StandardDetails();
        Console.WriteLine("Short");
        reception.ShortDescription();
        Console.WriteLine("Full");
        reception.FullDetails();


        Console.WriteLine();
        Console.WriteLine("Standard");
        outdoor.StandardDetails();
        Console.WriteLine("Short");
        outdoor.ShortDescription();
        Console.WriteLine("Full");
        outdoor.FullDetails();
    }
}