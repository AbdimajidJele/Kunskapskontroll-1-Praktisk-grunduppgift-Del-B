Course mai26 = new Course ("MAI26", 2); // Skapar en kurs MAI26 med plats för 2 studenter
Student abdimajid = new Student("Abdimajid");
Student bertil = new Student("Bertil");
Student ahmed = new Student("Ahmed");

mai26.Enroll(abdimajid); // Anmäler Abdimajid via kursens metod
bertil.Join(mai26); // Anmäler Bertil via studentens metod - testar att båda hållen fungerar
mai26.Enroll(ahmed); // Kursen är nu full (2/2) -> Då ska den skriva "Kursen är tyvärr full"
bertil.Join(mai26); // Bertil redan anmäld dvs det ska inte skapa dubblett

Console.WriteLine(mai26); // Ska skriva "MAI26 (2/2 platser)"
Console.WriteLine("RollCall");
mai26.RollCall();

Console.WriteLine("Schema");
abdimajid.Schedule(); // Ska skriva ut MAI26

bertil.Leave(mai26); // DVS Bertil lämnar kursen
Console.WriteLine(mai26); // Ska nu skriva "MAI26 (1/2 platser)"

mai26.Remove(ahmed); // Ahmed var aldrig anmäld och den ska inte behöva krascha
Console.WriteLine("Programmet är fortfarande igång trots borttagning av oanmäld student");