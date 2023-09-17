using System;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int PrelimGrade { get; set; }
    public int FinalGrade { get; set; }

    public double SemGrade
    {
        get { return (PrelimGrade + FinalGrade) / 2.0; }
    }

    public string TransmutedGrade
    {
        get
        {
            double semGrade = SemGrade;

            if (semGrade >= 90)
                return "1.00";
            else if (semGrade >= 85)
                return "1.25";
            else if (semGrade >= 80)
                return "1.50";
            else if (semGrade >= 75)
                return "1.75";
            else if (semGrade >= 70)
                return "2.00";
            else if (semGrade >= 65)
                return "2.25";
            else if (semGrade >= 60)
                return "2.50";
            else if (semGrade >= 55)
                return "2.75";
            else
                return "5.00";  // Failed
        }
    }
}
