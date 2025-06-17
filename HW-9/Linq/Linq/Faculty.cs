/// <summary>
/// Represents a faculty with a name and related events.
/// </summary>
class Faculty
{
    /// <summary>
    /// Gets the name of the faculty.
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Occurs when the faculty name is changed.
    /// </summary>
    public event EventHandler<string> NameChanged;

    /// <summary>
    /// Occurs when scholarships are revoked for this faculty.
    /// </summary>
    public event EventHandler ScholarshipRevoked;

    /// <summary>
    /// Initializes a new instance of the <see cref="Faculty"/> class.
    /// </summary>
    /// <param name="name">The name of the faculty.</param>
    public Faculty(string name)
    {
        Name = name;
    }

    /// <summary>
    /// Changes the name of the faculty and raises the <see cref="NameChanged"/> event.
    /// </summary>
    /// <param name="newName">The new name for the faculty.</param>
    public void ChangeName(string newName)
    {
        Name = newName;
        NameChanged?.Invoke(this, newName);
    }

    /// <summary>
    /// Raises the <see cref="ScholarshipRevoked"/> event to revoke scholarships for this faculty.
    /// </summary>
    public void RevokeScholarships()
    {
        ScholarshipRevoked?.Invoke(this, EventArgs.Empty);
    }
}
