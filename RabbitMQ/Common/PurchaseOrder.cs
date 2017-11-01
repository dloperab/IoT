using System;

namespace RabbitMQ.Commom
{
  [Serializable]
  public class PurchaseOrder
  {
    public decimal AmountToPay;
    public string PoNumber;
    public string CompanyName;
    public int PaymentDayTerms;
  }
}
