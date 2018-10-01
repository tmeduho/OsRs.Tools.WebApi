using System;
namespace OsRs.Tools.WebApi.Models
{
  public class ExchangeItem
  {
    public ExchangeItem()
    {
    }

    public long Id { get; set; }
    public string Name { get; set; }
    public bool IsMembers { get; set; }
    public int StorePrice { get; set; }
    public int BuyAverage { get; set; }
    public long BuyQuantity { get; set; }
    public int SellAverage { get; set; }
    public long SellQuantity { get; set; }
    public int OverallAverage { get; set; }
    public long OverallQuantity { get; set; }
  }
}

//{"2":{
  //  "id":2,
  //  "name":"Cannonball",
  //  "members":true,
  //  "sp":5,
  //  "buy_average":206,
  //  "buy_quantity":748244,
  //  "sell_average":206,
  //  "sell_quantity":991287,
  //  "overall_average":206,
  //  "overall_quantity":1739531
  //}