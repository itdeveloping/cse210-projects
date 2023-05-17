/*You program should contain two classes one for a Job and one for the Resume itself, as follows:

Class: Job
Responsibilities:
Keeps track of the company, job title, start year, and end year.
Behaviors:
Displays the job information in the format "Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022".
Class: Resume
Responsibilities:
Keeps track of the person's name and a list of their jobs.
Behaviors:
Displays the resume, which shows the name first, followed by displaying each one of the jobs.*/

public class Job
{
    public string _company;
    public string _jobTitle;
    public string _startYear;
    public string _endYear;
    
    //Add a Display method to the Job class
    public void Displays()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}