using System.Collections.Generic;
using DesignPatterns.notification;

namespace DesignPatterns.order
{
  public class Order : IObservable
  {
    public long _orderNumber { get; set; }
    private HashSet<IObserver> _registeredObservers = new HashSet<IObserver>();
    public OrderStatus _orderStatus { get; set; }

    public Order(long orderNumber, OrderStatus orderStatus)
    {
      _orderNumber = orderNumber;
      _orderStatus = orderStatus;
    }

    public void RegisterObserver(IObserver observer)
    {
      _registeredObservers.Add(observer);
    }

    public void UnregisterObserver(IObserver observer)
    {
      _registeredObservers.Remove(observer);
    }

    public void NotifyObservers()
    {
      foreach (var observer in _registeredObservers)
      {
        observer.Update(this);
      }
    }

    public void ChangedOrderStatus(OrderStatus orderStatus)
    {
      _orderStatus = orderStatus;
      NotifyObservers();
    }
  }
}