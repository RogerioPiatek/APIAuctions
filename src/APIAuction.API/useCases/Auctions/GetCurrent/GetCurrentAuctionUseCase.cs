using APIAuction.API.Entities;
using APIAuction.API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace APIAuction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentActionUseCase
{
  public Auction Execute()
  {
    var repository = new APIAuctionDbContext();

    return repository
    .Auctions
    .Include(auction => auction.Items) 
    .First();
  }
}