using System;
using DesignPatterns.notification;
using DesignPatterns.order;

namespace DesignPatterns
{
  class Program
  {
    static void Main(string[] args)
    {
      var order = new Order(110, OrderStatus.Registered);

      var textMessage = new TextMessage();
      var mobileApp = new MobileApp();
      var email = new Email();

      textMessage.UpdateOrderStatus(order);
      mobileApp.UpdateOrderStatus(order);
      email.UpdateOrderStatus(order);
    }
  }
}