using APIAuction.API.Entities;
using APIAuction.API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace APIAuction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentActionUseCase
{
  public Auction? Execute()
  {
    var repository = new APIAuctionDbContext();

    var today = new DateTime(2024, 01, 28);

    return repository
      .Auctions
      .Include(auction => auction.Items) 
      .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
  }
}