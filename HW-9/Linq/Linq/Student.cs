/// <summary>
/// Represents a student with name, faculty, average grade, and scholarship.
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
    /// </summary>
    /// <param name="name">Student's name.</param>
    /// <param name="avg">Average grade.</param>
    /// <param name="scholarship">Scholarship amount.</param>
    /// <param name="faculty">Faculty object.</param>
    public Student(string name, double avg, double scholarship, Faculty faculty)
    {
        Name = name;
        AverageGrade = avg;
        Scholarship = scholarship;
        FacultyName = faculty.Name;

        faculty.NameChanged += OnFacultyRenamed;
        faculty.ScholarshipRevoked += OnScholarshipRevoked;
    }

    /// <summary>
    /// Handles the event when the faculty is renamed.
    /// </summary>
    /// <param name="sender">Event sender.</param>
    /// <param name="newName">New faculty name.</param>
    private void OnFacultyRenamed(object sender, string newName)
    {
        FacultyName = newName;
    }

    /// <summary>
    /// Handles the event when scholarships are revoked.
    /// </summary>
    /// <param name="sender">Event sender.</param>
    /// <param name="e">Event arguments.</param>
    private void OnScholarshipRevoked(object sender, EventArgs e)
    {
        if (AverageGrade < 3.0)
            Scholarship = 0;
    }

    /// <summary>
    /// Prints student information to the console.
    /// </summary>
    public void Print()
    {
        Console.WriteLine($"{Name,-10} | {FacultyName,-15} | {AverageGrade,5:F2} | {Scholarship,6:F0}");
    }
}
