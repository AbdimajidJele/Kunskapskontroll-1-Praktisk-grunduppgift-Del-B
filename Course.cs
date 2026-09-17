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

}