using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._jobTitle =  "Software Engineer";
        job1._company = "Miscrosoft";
        job1._startYear = 2019;
        job1._endYear_ = 2022;


        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear_ = 2023;
        

        Resume myResume = new Resume();
        myResume._name = "Qwesi Morgan";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}