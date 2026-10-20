using TeacherSystem;

// Challenge 5 - Final challenge: TeacherSystem console application
TeacherManager manager = new TeacherManager();
bool running = true;

while (running)
{
    Console.WriteLine();
    Console.WriteLine("=== Teacher System ===");
    Console.WriteLine("1. Add teacher");
    Console.WriteLine("2. Show teachers");
    Console.WriteLine("3. Count teachers");
    Console.WriteLine("4. Average years of experience");
    Console.WriteLine("5. Exit");
    Console.Write("Choose an option: ");

    string? choice = Console.ReadLine();
    if (choice == null)
        break;

    switch (choice.Trim())
    {
        case "1":
            AddTeacher(manager);
            break;
        case "2":
            manager.ShowTeachers();
            break;
        case "3":
            Console.WriteLine($"Number of teachers: {manager.CountTeachers()}");
            break;
        case "4":
            Console.WriteLine($"Average experience: {manager.AverageExperience():F2} years");
            break;
        case "5":
            running = false;
            break;
        default:
            Console.WriteLine("Invalid option, try again.");
            break;
    }
}

Console.WriteLine("Goodbye!");

static void AddTeacher(TeacherManager manager)
{
    Console.Write("Name: ");
    string name = Console.ReadLine() ?? "";
    Console.Write("Subject: ");
    string subject = Console.ReadLine() ?? "";
    Console.Write("Years of experience: ");
    string yearsText = Console.ReadLine() ?? "";

    if (!int.TryParse(yearsText, out int years))
    {
        Console.WriteLine("Years of experience must be a whole number.");
        return;
    }

    try
    {
        manager.AddTeacher(new Teacher(name, subject, years));
        Console.WriteLine("Teacher added.");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"Could not add teacher: {ex.Message}");
    }
}
