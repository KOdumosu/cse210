using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2024;
        job1._endYear = 2029;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Souls Tech";
        job2._startYear = 2024;
        job2._endYear = 2030;

        Resume myResume = new Resume();
        myResume._name = "Odumosu Kenny";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }

}
