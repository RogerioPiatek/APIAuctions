using APIAuction.API.Entities;

namespace APIAuction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentActionUseCase
{
  public Auction Execute()
  {

    return new Auction
    {
      Id = 1,
      Name = "Test",
      Starts = DateTime.Now,
      Ends = DateTime.Now,
    };

  }
}