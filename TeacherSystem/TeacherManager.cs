namespace TeacherSystem;

// Keeps the list of teachers and the operations on it
public class TeacherManager
{
    private readonly List<Teacher> teachers = new List<Teacher>();

    public void AddTeacher(Teacher teacher)
    {
        teachers.Add(teacher);
    }

    public void ShowTeachers()
    {
        if (teachers.Count == 0)
        {
            Console.WriteLine("No teachers yet.");
            return;
        }

        for (int i = 0; i < teachers.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            teachers[i].ShowProfile();
        }
    }

    public int CountTeachers()
    {
        return teachers.Count;
    }

    public double AverageExperience()
    {
        if (teachers.Count == 0)
            return 0;

        int total = 0;
        foreach (Teacher teacher in teachers)
        {
            total += teacher.YearsOfExperience;
        }
        return (double)total / teachers.Count;
    }
}
