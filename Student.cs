public class Student // Klassen - självaste mallen.
{
    public string Name; // Studentens namn, text
    public List<Course> Courses = new List<Course>(); // Lista över kurser studenten går, tom fån start.

    public Student(string name) // Konstruktor - körs automatiskt när man skapar en ny student.
    {
        Name = name;
    }
}