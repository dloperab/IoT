using System;

namespace RabbitMQ.Commom
{
  [Serializable]
  public class Payment
  {
    public decimal AmountToPay;
    public string CardNumber;
    public string Name;
  }
}
