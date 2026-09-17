public class Student // Klassen - självaste mallen.
{
    public string Name; // Studentens namn, text
    public List<Course> Courses = new List<Course>(); // Lista över kurser studenten går, tom fån start.

    public Student(string name) // Konstruktor - körs automatiskt när man skapar en ny student.
    {
        Name = name;
    }

    public void Join(Course course) // Detta gör så att jag går med i en kurs.
    {
        course.Enroll(this); // återanvänder Enroll-logiken - this = dvs den här studenten.
    }
    public void Leave(Course course) // lämnar kursen
    {
        course.Remove(this); // Återanvänder Remove-logiken 
    }

    public void Schedule() // Skriver ut vilka kurser studenten går i.
{
        foreach (Course c in Courses) // Loopar igenom varje kurs i listan
        {
            Console.WriteLine(c.Name); // Skriver ut kursens namn
        }
    }

    public override string ToString() // Studentens namn, istället för standardtexten C# annars visar
    {
        return Name;
    }
