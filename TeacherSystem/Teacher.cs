namespace TeacherSystem;

public class Teacher
{
    private string name = "";
    private string subject = "";
    private int yearsOfExperience;

    public Teacher(string name, string subject, int yearsOfExperience)
    {
        Name = name;
        Subject = subject;
        YearsOfExperience = yearsOfExperience;
    }

    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty.");
            name = value.Trim();
        }
    }

    public string Subject
    {
        get => subject;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Subject cannot be empty.");
            subject = value.Trim();
        }
    }

    public int YearsOfExperience
    {
        get => yearsOfExperience;
        set
        {
            if (value < 0)
                throw new ArgumentException("Years of experience cannot be negative.");
            yearsOfExperience = value;
        }
    }

    public void ShowProfile()
    {
        Console.WriteLine($"Name: {Name}, Subject: {Subject}, Experience: {YearsOfExperience} years");
    }
}
