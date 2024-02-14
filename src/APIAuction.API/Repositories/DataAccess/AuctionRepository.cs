using Microsoft.EntityFrameworkCore;
using APIAuction.API.Entities;
using APIAuction.API.Contracts;

namespace APIAuction.API.Repositories.DataAccess;

public class AuctionRepository : IAuctionRepository
{
  private readonly APIAuctionDbContext _dbContext;
  public AuctionRepository(APIAuctionDbContext dbContext) => _dbContext = dbContext;

  public Auction? GetCurrent()
  {
    var today = new DateTime(2024, 01, 28);

    return _dbContext
      .Auctions
      .Include(auction => auction.Items) 
      .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
  }

}