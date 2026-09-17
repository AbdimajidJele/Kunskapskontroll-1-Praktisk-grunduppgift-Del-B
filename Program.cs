Course mai26 = new Course ("MAI26", 2); // Skapar en kurs MAI26 med plats för 2 studenter
Student abdimajid = new Student("Abdimajid");
Student bertil = new Student("Bertil");
Student ahmed = new Student("Ahmed");

mai26.Enroll(abdimajid); // Anmäler Abdimajid via kursens metod
bertil.Join(mai26); // Anmäler Bertil via studentens metod - testar att båda hållen fungerar
mai26.Enroll(ahmed); // Kursen är nu full (2/2) -> Då ska den skriva "Kursen är tyvärr full"
bertil.Join(mai26); // Bertil redan anmäld dvs det ska inte skapa dubblett