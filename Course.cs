public class Course
{
    public string Name; // Fält: Name
    public int MaxSeats; // MaxSeats (max antal platser), använder int eftersom det är heltal.
    public List<Student> Students = new List<Student>(); // Ett fält som lagrar listan över studenter som går kursen. Skapas som tom lista så den alltid finns och är redo att fyllas på.

    public Course(string name, int maxSeats)
    {
        Name = name;
        MaxSeats = maxSeats;
    }
public void Enroll(Student student)
{
    if (Students.Contains(student)) return; // Kolla dubblett FÖRST - tyst avslut, ingen platskoll behövs
    
    if (Students.Count >= MaxSeats) // Kolla plats sen
    {
        Console.WriteLine("Kursen är tyvärr full");
        return;
    }

    Students.Add(student);
    if (!student.Courses.Contains(this))
    {
        student.Courses.Add(this);
    }
}
   public void Remove(Student student) // Metod som tar bort en student från kursen.
    {
        if (!Students.Contains(student)) // Kollar om studenten inte finns i kursen.
        {
            return; // Detta avslutar metoden utan att något kraschar.
        }
        Students.Remove(student); // Tar bort studenten ur kursens egen lista
        student.Courses.Remove(this); // Går till studenten Courses-lista och tar birt den här kursen därifrån också, så de hålls synkade.
        

    }
    public void RollCall() // Skriver ut alla studenter i kursen

    {
        foreach (Student s in Students) // detta använder jag frö att loopa igenom varje student i listan
        {
            Console.WriteLine(s.Name);; // Skriver ut studentens namn
    
        }
    }

    public override string ToString()
    {
        return $"{Name} ({Students.Count}/{MaxSeats} platser)"; // Bygger textsträngen med nman samt aktuellt antal/max platser

    }

}