namespace Challenges;

// Challenges 1, 2 and 4: Teacher class with a ShowProfile method and validated properties
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

    // Challenge 4: Subject should not be empty
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

    // Challenge 4: YearsOfExperience should not be negative
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

    // Challenge 2
    public void ShowProfile()
    {
        Console.WriteLine($"Name: {Name}, Subject: {Subject}, Experience: {YearsOfExperience} years");
    }
}
