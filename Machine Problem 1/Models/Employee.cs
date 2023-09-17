using System;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime Birthday { get; set; }
    public bool IsTenured { get; set; }
    public double SalaryPerHour { get; set; }
    public string Email { get; set; }

    public int Age
    {
        get
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - Birthday.Year;
            if (currentDate < Birthday.AddYears(age)) age--;
            return age;
        }
    }

    public double SalaryPerDay
    {
        get { return SalaryPerHour * 8; }
    }

    public double SalaryPerMonth
    {
        get { return SalaryPerDay * 30; }
    }

    public string EmploymentStatus
    {
        get { return IsTenured ? "Permanent" : "Probationary"; }
    }

    public string GetEmailDomain()
    {
        int atIndex = Email.IndexOf('@');
        if (atIndex >= 0)
        {
            string domain = Email.Substring(atIndex + 1);
            return domain;
        }
        return "";
    }

    public string GetEmailUsername()
    {
        int atIndex = Email.IndexOf('@');
        if (atIndex >= 0)
        {
            string username = Email.Substring(0, atIndex);
            return username;
        }
        return "";
    }
}
