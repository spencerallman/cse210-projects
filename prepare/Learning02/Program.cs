using System;

class Program
{
    static void Main(string[] args)
    {
      Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Intel";
        job1._startYear = 2018;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Nintendo";
        job2._jobTitle = "Game Developer";
        job2._startYear = 2022;
        job2._endYear = 2025;

        Resume newResume = new Resume();
        newResume._name = "Spencer Allman";
        newResume._jobs.Add(job1);
        newResume._jobs.Add(job2);

        newResume.Display();
    }
}