using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        // "Software Engineer (Microsoft) 2019-2022".
        Job job = new Job();
        job._jobTitle="Software Engineer";
        job._company="Microsoft";
        job._startYear="2019";
        job._endYear="2022";
        job.Displays();

        Resume resume = new Resume();
        resume.jobs[0]._jobTitle="";
        //Add a Display method to the Resume class


    }
}