using ConsoleApp.Interfaces;

namespace ConsoleApp.Models;

/// <summary>
/// Konkrétní dražený pøedmìt.
/// </summary>
public class AuctionItem : ISubject
{
    private readonly List<IObserver> _observers;
    private decimal _price;
    public string Name { get; }
    public decimal Price
    {
        get => _price;
        set
        {
            if (_price != value)
            {
                _price = value;
                Notify();
            }
        }
    }

    public AuctionItem(string name, decimal price)
    {
        Name = name;
        _price = price;
        _observers = new List<IObserver>();
    }

    public void Attach(IObserver observer)
    {
        if (!_observers.Contains(observer))
            _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        if (_observers.Contains(observer))
            _observers.Remove(observer);
    }

    private void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(this);
        }
    }

    public string GetAllBidderNames()
    {
        return string.Join(", ", _observers.Select(o => o.Name));
    }
}