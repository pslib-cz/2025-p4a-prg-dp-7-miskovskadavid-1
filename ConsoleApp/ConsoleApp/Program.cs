using ConsoleApp.Models;

// 1. Vytvoření předmětu
var predmet = new AuctionItem("Starožitné hodiny", 1000m);

// 2. Vytvoření účastníků
var zajemce1 = new Bidder("Petr");
var zajemce2 = new Bidder("Jana");

// 3. Registrace k odběru
predmet.Attach(zajemce1);
predmet.Attach(zajemce2);

// 4. První změna ceny (reagují oba)
Console.WriteLine("--- Změna ceny na 1200 Kč ---");
predmet.Price = 1200m;

// 5. Jeden zájemce odchází
predmet.Detach(zajemce1);
Console.WriteLine($"\n[Info] Zájemce {zajemce1.Name} se odhlásil.");
Console.WriteLine($"Zájemci po odhlášení: {predmet.GetAllBidderNames()}"); 

// 6. Druhá změna ceny (reaguje jen Jana)
Console.WriteLine("\n--- Změna ceny na 1500 Kč ---");
predmet.Price = 1500m;
Console.WriteLine($"Aktuální cena je {predmet.Price} Kč.");

Console.WriteLine("\nStiskněte libovolnou klávesu pro ukončení...");
Console.ReadKey();
