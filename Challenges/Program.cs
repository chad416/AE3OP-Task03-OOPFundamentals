using Challenges;

// Challenge 1 - Create a class: create 2 teachers and print their information
Console.WriteLine("=== Challenge 1: Create a class ===");
Teacher teacher1 = new Teacher("Anna Novak", "Mathematics", 12);
Teacher teacher2 = new Teacher("Peter Svoboda", "Physics", 5);

Console.WriteLine($"{teacher1.Name} teaches {teacher1.Subject} ({teacher1.YearsOfExperience} years)");
Console.WriteLine($"{teacher2.Name} teaches {teacher2.Subject} ({teacher2.YearsOfExperience} years)");

// Challenge 2 - Add a method: ShowProfile()
Console.WriteLine();
Console.WriteLine("=== Challenge 2: Add a method ===");
teacher1.ShowProfile();
teacher2.ShowProfile();

// Challenge 3 - Use a list: show all teachers
Console.WriteLine();
Console.WriteLine("=== Challenge 3: Use a list ===");
List<Teacher> teachers = new List<Teacher>
{
    teacher1,
    teacher2,
    new Teacher("Eva Dvorak", "Programming", 8)
};

foreach (Teacher teacher in teachers)
{
    teacher.ShowProfile();
}

// Challenge 4 - Encapsulation: invalid values are rejected
Console.WriteLine();
Console.WriteLine("=== Challenge 4: Encapsulation ===");
try
{
    teacher1.YearsOfExperience = -3;
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Rejected: {ex.Message}");
}

try
{
    teacher2.Subject = "";
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Rejected: {ex.Message}");
}

Console.WriteLine("Values after the invalid attempts:");
teacher1.ShowProfile();
teacher2.ShowProfile();
