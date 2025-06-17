using System;
using System.Collections.Generic;

/// <summary>
/// The main program class for managing faculties and students.
/// </summary>
class Program
{
    /// <summary>
    /// List of faculties.
    /// </summary>
    List<Faculty> Faculties = new List<Faculty>();

    /// <summary>
    /// List of students.
    /// </summary>
    List<Student> Students = new List<Student>();

    /// <summary>
    /// The main entry point of the application.
    /// </summary>
    static void Main()
    {
        Program p = new Program();
        p.LoadTestData();

        Console.WriteLine("Student list:");
        p.PrintStudents();

        Console.WriteLine("\nFaculties:");
        p.PrintFaculties();

        Console.Write("\nEnter the faculty number you want to rename: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < p.Faculties.Count)
        {
            Console.Write("Enter the new faculty name: ");
            string newName = Console.ReadLine();

            p.Faculties[index].ChangeName(newName);

            Console.WriteLine("\nUpdated student list:");
            p.PrintStudents();
        }
        else
        {
            Console.WriteLine("Invalid faculty number.");
        }

        Console.Write("\nEnter the faculty number to revoke scholarships from underachievers: ");
        if (int.TryParse(Console.ReadLine(), out int index2) && index2 >= 0 && index2 < p.Faculties.Count)
        {
            p.Faculties[index2].RevokeScholarships();
            Console.WriteLine("\nStudent list after scholarships revoked:");
            p.PrintStudents();
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    /// <summary>
    /// Loads test data for faculties and students.
    /// </summary>
    public void LoadTestData()
    {
        Faculty f1 = new Faculty("Computer Science");
        Faculty f2 = new Faculty("Mathematics");
        Faculty f3 = new Faculty("Physics");

        Faculties.Add(f1);
        Faculties.Add(f2);
        Faculties.Add(f3);

        Students.Add(new Student("Nikita", 4.5, 1500, f1));
        Students.Add(new Student("Boris", 2.0, 1300, f2));
        Students.Add(new Student("Vika", 4.8, 1700, f3));
        Students.Add(new Student("Gleb", 2.5, 1400, f3));
        Students.Add(new Student("Dina", 4.6, 1600, f1));
    }

    /// <summary>
    /// Prints the list of students.
    /// </summary>
    void PrintStudents()
    {
        Console.WriteLine("Name      | Faculty         | Grade | Scholarship");
        Console.WriteLine("-----------------------------------------------");
        foreach (var student in Students)
            student.Print();
    }

    /// <summary>
    /// Prints the list of faculties.
    /// </summary>
    void PrintFaculties()
    {
        for (int i = 0; i < Faculties.Count; i++)
        {
            Console.WriteLine($"{i}: {Faculties[i].Name}");
        }
    }
}
