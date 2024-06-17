using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Rona";
        job1._jobTitle = "Paint Associate";
        job1._startYear = 2024;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._company = "Glenburnie Grocery";
        job2._jobTitle = "Deli";
        job2._startYear = 2024;
        job2._endYear = 2024;

        Resume resume1 = new Resume();
        resume1._name = "Talia Olsen";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);


        resume1.Display();
    }
}