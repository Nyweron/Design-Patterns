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

/*
PROBLEMS:
1. If we changed order then we need again init 3 objects textMessage, mobileApp and email
2. If we add new notification class then we should new class and this cause a lot of duplicated code...
3. In notification classes we use the same method...

HOW TO FIX:
1. Use DesignPattern Observer
 */