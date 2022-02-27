using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    private static List<Order> _orderList = new List<Order> {};
    private int OrderVendorId {get; set;}
    private string OrderVendorUniqueId {get; set;}
    private string OrderVendorName {get; set;}
    private int Id {get; set;}
    private string OrderId {get; set;}
    private string Title{get; set;}
    private string Description{get; set;}
    private int Price {get; set;}
    private string OrderDate {get; set;}
    private string DeliveryForDate {get; set;}
    private int SourDough{get; set;}
    private int MilkLoaf {get; set;}
    private int Donut {get; set;}
    private int Croissant {get; set;}
    private int Quiche{get; set;}
    private int CheesePuff {get; set;}

    public Order(int orderVendorId, string title, string description, int price, string orderDate, string deliveryForDate, int sourDough, int milkLoaf, int donut, int croissant, int quiche, int cheesePuff)
    {
      _orderList.Add(this);
      Id = ListId();
      // OrderId = "ORDER" + DateTime.Now.ToString("yyyyMMddHHmmss");
      OrderVendorId = orderVendorId;
      OrderVendorUniqueId = Vendor.FindById(orderVendorId).GetVendorId();
      OrderVendorName = Vendor.FindById(orderVendorId).GetVendorName();
      Title = title;
      Description = description;
      Price = price;
      OrderDate = orderDate;
      DeliveryForDate = deliveryForDate;
      SourDough = sourDough;
      MilkLoaf = milkLoaf;
      Donut = donut;
      Croissant = croissant;
      Quiche = quiche;
      CheesePuff = cheesePuff;
    }

    public static void ClearList()
    {
      _orderList.Clear();
    }
    public static List<Order> GetList()
    {
      return _orderList;
    }

    public string GetOrderId()
    {
      return this.OrderId;
    }

    public int GetOrderVendorId()
    {
      return this.OrderVendorId;
    }

    public string GetOrderVendorName()
    {
      return this.OrderVendorName;
    }

    public string GetTitle()
    {
      return this.Title;
    }

    public string GetDescription()
    {
      return this.Description;
    }

    public int GetPrice()
    {
      return this.Price;
    }

    public string GetOrderDate()
    {
      return this.OrderDate;
    }

    public string GetDeliveryForDate()
    {
      return this.DeliveryForDate;
    }

    public int GetSourDough()
    {
      return this.SourDough;
    }

    public int GetMilkLoaf()
    {
      return this.MilkLoaf;
    }

    public int GetDonut()
    {
      return this.Donut;
    }

    public int GetCroissant()
    {
      return this.Croissant;
    }

    public int GetQuiche()
    {
      return this.Quiche;
    }

    public int GetCheesePuff()
    {
      return this.CheesePuff;
    }

    public string GetOrderVendorUniqueId()
    {
      return this.OrderVendorUniqueId;
    }

    public int GetListId()
    {
      return this.Id;
    }

        public int ListId()
    {
      int Num = 0;
      for (int i=1; i <= 10000; i++)
      {
        if(_orderList.Exists(x => x.Id == i))
        {
        }
        else
        {
          return Num += i;
        }
      }
      return Num;
    }
    
    public static List<Vendor> VendorGetList()
    {
      return Vendor.GetList();
    }

    public static Order FindById(int inputId)
    {
      return _orderList[_orderList.FindIndex(x => x.Id == inputId)];
    }

  }
}