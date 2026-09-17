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
    public void Enroll(Student student) // Detta anmäler en student till kursen
    {
        if (Students.Count >= MaxSeats) // Detta kollar om kursen redan är full
        {
            Console.WriteLine("Kursen är tyvärr full"); // Meddelar istället för att lägga till
            return ; // Avbryter metoden här dvs inget mer kommer köras.
        }
        if (Students.Contains(student)) return; // Redan anmäld - avbryt, ingen dubblett.

        Students.Add(student); // Lägg till studenten i kursens lista
        if (!student.Courses.Contains(this)) // Kollar att kursen inte redan finns hos studenten.
        {
            student.Courses.Add(this); // Detta lägger til kursen i studentens lista också - båda hållen ska stämma.
        }
}
   public void Remove(Student student) // Metod som tar bort en student från kursen.
    {
        if (!Students.Contains(student)) // Kollar om studenten inte finns i kursen.
        {
            return; // Detta avslutar metoden utan att något kraschar.
        }
    }
}