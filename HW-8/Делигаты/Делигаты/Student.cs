/// <summary>
/// Represents a student with a name, faculty, average grade, and scholarship.
/// </summary>
class Student
{
    /// <summary>
    /// Gets the student's name.
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Gets the name of the faculty the student belongs to.
    /// </summary>
    public string FacultyName { get; private set; }

    /// <summary>
    /// Gets the student's average grade.
    /// </summary>
    public double AverageGrade { get; private set; }

    /// <summary>
    /// Gets the student's scholarship amount.
    /// </summary>
    public double Scholarship { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Student"/> class.
    /// Subscribes to faculty events for name changes and scholarship revocation.
    /// </summary>
    /// <param name="name">Student's name.</param>
    /// <param name="avg">Student's average grade.</param>
    /// <param name="scholarship">Student's scholarship amount.</param>
    /// <param name="faculty">Faculty the student belongs to.</param>
    public Student(string name, double avg, double scholarship, Faculty faculty)
    {
        Name = name;
        AverageGrade = avg;
        Scholarship = scholarship;
        FacultyName = faculty.Name;

        // Subscribe to faculty events
        faculty.NameChanged += OnFacultyRenamed;
        faculty.ScholarshipRevoked += OnScholarshipRevoked;
    }

    /// <summary>
    /// Handles the faculty name change event.
    /// Updates the student's faculty name.
    /// </summary>
    private void OnFacultyRenamed(object sender, string newName)
    {
        FacultyName = newName;
    }

    /// <summary>
    /// Handles the scholarship revoked event.
    /// Sets the scholarship to zero if the average grade is below 3.0.
    /// </summary>
    private void OnScholarshipRevoked(object sender, EventArgs e)
    {
        if (AverageGrade < 3.0)
            Scholarship = 0;
    }

    /// <summary>
    /// Prints the student's information to the console.
    /// </summary>
    public void Print()
    {
        Console.WriteLine($"{Name,-10} | {FacultyName,-15} | {AverageGrade,5:F2} | {Scholarship,6:F0}");
    }
}
