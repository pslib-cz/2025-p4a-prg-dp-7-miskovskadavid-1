using ConsoleApp.Interfaces;

namespace ConsoleApp.Models;

public class Bidder : IObserver
{
    public string Name { get; }

    public Bidder(string name)
    {
        Name = name;
    }

    public void Update(string itemName, decimal newPrice)
    {
        Console.WriteLine($"[Zájemce {Name}] Notifikace: Cena pøedmìtu '{itemName}' je nyní {newPrice} Kè.");
    }

    public void Update(AuctionItem auctionItem)
    {
        Update(auctionItem.Name, auctionItem.Price);
    }
}