using System.ComponentModel.DataAnnotations.Schema;
using APIAuction.API.Enums;

namespace APIAuction.API.Entities;

[Table("Items")]
public class Item
{
  public int Id {get; set;}
  public string Name {get; set;} = string.Empty;
  public string Brand {get; set;} = string.Empty;
  public Condition Condition {get; set;}
  public int BasePrice {get; set;}
  public int AuctionId {get; set;}
}    
