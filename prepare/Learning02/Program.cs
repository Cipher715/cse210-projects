using System;


class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Developer";
        job1._startYear = 2000;
        job1._endYear = 2012;
        job2._company = "Apple";
        job2._jobTitle = "Infrastructure Engineer";
        job2._startYear = 2012;
        job2._endYear = 2022;
        //job1.Display();
        //job2.Display();

        Resme myResme = new Resme();
        myResme._name = "Atsushi Karino";
        myResme._jobs.Add(job1);
        myResme._jobs.Add(job2);
        myResme.Display();
    }
}

