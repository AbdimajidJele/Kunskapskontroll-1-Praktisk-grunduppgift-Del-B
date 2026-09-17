// Två parallella listor
// Använder listor istället för objekt eftersom det står så i uppgiften.
List<string> names = new List<string>();
List<int> prices = new List<int>();

// Oändlig loop - programmet ska hela tiden visa listan och ta emot ny input.
while (true)
{
    decimal total = 0; // nollställs varje omgång så summan inte samlas felaktig.
    
    // Loopar igenom listan och skriver ut varje vara numerad
    for (int i = 0; i < names.Count; i++)
    {
        // i + 1 så numreringen börjar på 1 istället för 0, det blir enklare för oss att läsa.
        Console.WriteLine($"{i + 1}. {names[i]} - {prices[i]} kr");
        total += prices[i]; // Summerar priset samtidigt som vi skriver ut 
    }
    Console.WriteLine($"Totalt: {total} kr");

    Console.WriteLine("Ange vara eller nummer: ");
    string? input = Console.ReadLine();

    // TryParse istället före Parse - kraschar inte om input är ett tal
    // Om inputen är ett tal: då användaren vill ta bort en vara

    if (int.TryParse(input, out int number))
    {
        // number - 1 eftersom användaren räknar från 1, listan är 0-indexerad
        int index = number - 1;
        if (index >= 0 && index < names.Count)
        {
            names.RemoveAt(index);
            prices.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Det numret finns inte i listan.");
        }
    }
    else
    {
        Console.Write("Pris: ");
        string? priceInput = Console.ReadLine();
        if (int.TryParse(priceInput, out int price))
        {
            names.Add(input ?? "");
            prices.Add(price);
        }
        else
        {
            Console.WriteLine("Ogiltigt pris, varan lades inte till.");
        }
    }
}