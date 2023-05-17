using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        // "Software Engineer (Microsoft) 2019-2022".
        Job job = new Job();
        job._jobTitle = "Software Engineer";
        job._company = "Microsoft";
        job._startYear = "2019";
        job._endYear = "2022";
        job.Displays();

        Resume resume = new Resume();
        resume._personName = "Allison Rose";
        resume._jobs[0]._jobTitle = "Software Engineer";
        resume._jobs[0]._company = "Microsoft";
        resume._jobs[0]._startYear = "2019";
        resume._jobs[0]._endYear = "2022"; 
        resume._jobs[1]._jobTitle = "Manager";
        resume._jobs[1]._company = "Apple";
        resume._jobs[1]._startYear = "2022";
        resume._jobs[1]._endYear = "2023";
        //Add a Display method to the Resume class


    }
}