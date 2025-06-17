using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Main program class for managing students and faculties.
/// </summary>
class Program
{
    /// <summary>
    /// List of students.
    /// </summary>
    public List<Student> Students = new List<Student>();

    /// <summary>
    /// List of faculties.
    /// </summary>
    public List<Faculty> Faculties = new List<Faculty>();

    /// <summary>
    /// Event triggered when data changes.
    /// </summary>
    public event Action DataChanged;

    /// <summary>
    /// Entry point of the application.
    /// </summary>
    static void Main()
    {
        Program p = new Program();
        p.LoadTestData();

        // Subscribe to data recalculation on change
        p.DataChanged += p.ShowLinqData;
        p.DataChanged?.Invoke();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1 - Add student");
            Console.WriteLine("2 - Remove student");
            Console.WriteLine("3 - Rename faculty");
            Console.WriteLine("4 - Revoke scholarships from underperforming students (by faculty)");
            Console.WriteLine("0 - Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": p.MenuAddStudent(); break;
                case "2": p.MenuRemoveStudent(); break;
                case "3": p.MenuRenameFaculty(); break;
                case "4": p.MenuRevokeScholarships(); break;
                case "0": return;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }

    /// <summary>
    /// Loads test data for faculties and students.
    /// </summary>
    public void LoadTestData()
    {
        Faculty f1 = new Faculty("Computer Science");
        Faculty f2 = new Faculty("Mathematics");
        Faculty f3 = new Faculty("Physics");

        Faculties.AddRange(new[] { f1, f2, f3 });

        Students.Add(new Student("Nikita", 4.5, 1500, f1));
        Students.Add(new Student("Boris", 4.2, 1300, f2));
        Students.Add(new Student("Vika", 2.9, 1700, f3));
        Students.Add(new Student("Gleb", 2.5, 1400, f3));
        Students.Add(new Student("Dina", 4.6, 1600, f1));
    }

    /// <summary>
    /// Menu for adding a new student.
    /// </summary>
    public void MenuAddStudent()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Average grade: ");
        double.TryParse(Console.ReadLine(), out double grade);
        Console.Write("Scholarship: ");
        double.TryParse(Console.ReadLine(), out double scholarship);

        Console.WriteLine("Select faculty:");
        for (int i = 0; i < Faculties.Count; i++)
            Console.WriteLine($"{i}: {Faculties[i].Name}");

        if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < Faculties.Count)
        {
            Students.Add(new Student(name, grade, scholarship, Faculties[index]));
            DataChanged?.Invoke();
        }
        else
        {
            Console.WriteLine("Faculty selection error.");
        }
    }

    /// <summary>
    /// Menu for removing a student by name.
    /// </summary>
    public void MenuRemoveStudent()
    {
        Console.Write("Enter the name of the student to remove: ");
        string name = Console.ReadLine();

        var found = Students.FirstOrDefault(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (found != null)
        {
            Students.Remove(found);
            DataChanged?.Invoke();
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

    /// <summary>
    /// Menu for renaming a faculty.
    /// </summary>
    public void MenuRenameFaculty()
    {
        Console.WriteLine("Faculties:");
        for (int i = 0; i < Faculties.Count; i++)
            Console.WriteLine($"{i}: {Faculties[i].Name}");

        Console.Write("Enter the faculty number: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < Faculties.Count)
        {
            Console.Write("New faculty name: ");
            string newName = Console.ReadLine();
            Faculties[index].ChangeName(newName);
            DataChanged?.Invoke();
        }
        else
        {
            Console.WriteLine("Invalid faculty number.");
        }
    }

    /// <summary>
    /// Menu for revoking scholarships from underperforming students in a faculty.
    /// </summary>
    public void MenuRevokeScholarships()
    {
        Console.WriteLine("Faculties:");
        for (int i = 0; i < Faculties.Count; i++)
            Console.WriteLine($"{i}: {Faculties[i].Name}");

        Console.Write("Enter the faculty number to revoke scholarships from underperforming students: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < Faculties.Count)
        {
            Faculties[index].RevokeScholarships();
            DataChanged?.Invoke();
        }
        else
        {
            Console.WriteLine("Invalid faculty number.");
        }
    }

    /// <summary>
    /// Displays LINQ data and provides search/filter options.
    /// </summary>
    public void ShowLinqData()
    {
        Console.WriteLine("\nTotal number of students: " + Students.Count);

        var sorted = Students.OrderBy(s => s.Name).ToList();
        Console.WriteLine("\nStudents by name:");
        foreach (var s in sorted)
            s.Print();

        Console.Write("\nSearch by name: ");
        string surname = Console.ReadLine();
        var found = Students.FirstOrDefault(s => s.Name.Equals(surname, StringComparison.OrdinalIgnoreCase));
        if (found != null)
        {
            Console.WriteLine("\nFound student:");
            found.Print();
        }
        else
        {
            Console.WriteLine("No student found with that name.");
        }

        Console.Write("\nEnter minimum scholarship: ");
        if (double.TryParse(Console.ReadLine(), out double minS))
        {
            var filtered = Students.Where(s => s.Scholarship > minS).ToList();
            Console.WriteLine($"Students with scholarship > {minS}:");
            foreach (var s in filtered)
                s.Print();
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}
