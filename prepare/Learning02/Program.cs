using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Michaelsoft Binbows";
        job1._endYear = 2011;
        job1._startYear = 2001;
        //Console.WriteLine(job1.DisplayJobDetails());

        Job job2 = new Job();
        job2._jobTitle = "Human Resources";
        job2._company = "Kermit Research and Development";
        job2._endYear = 2015;
        job2._startYear = 2003;
        //Console.WriteLine(job2.DisplayJobDetails());

        Resume myResume = new Resume();
        myResume._name = "Bob Iger";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        //Console.WriteLine(myResume._jobs[0]._jobTitle);

        myResume.Display();
    }
}