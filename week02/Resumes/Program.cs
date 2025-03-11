using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._companyName = "Microsoft";
        job1._year = "2019-2022";
        //job1.DisplayJobDetails();
        // Console.WriteLine(job1._jobTitle);
        // Console.WriteLine(job1._companyName);

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._companyName = "Apple";
        job2._year = "2022-2023";
        //job2.DisplayJobDetails();
        //Console.WriteLine(job2._companyName);

        Resume resume = new Resume();
        resume._name = "Arthur Weale";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        //Console.WriteLine(resume._jobs[0]._jobTitle);
        resume.DisplayResume();
    }
}