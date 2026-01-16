using ConsoleApp.Models;

namespace ConsoleApp.Interfaces;

/// <summary>
/// Rozhraní pro pozorovatele (zájemce).
/// </summary>
public interface IObserver
{
    string Name { get; } 
    void Update(string itemName, decimal newPrice);
    void Update(AuctionItem auctionItem);
}