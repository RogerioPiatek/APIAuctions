using APIAuction.API.Contracts;
using APIAuction.API.Entities;

namespace APIAuction.API.Repositories.DataAccess;


public class OfferRepository : IOfferRepository
{

  private readonly APIAuctionDbContext _dbContext;
  public OfferRepository(APIAuctionDbContext dbContext) => _dbContext = dbContext;

  public void Add(Offer offer)
  {
    _dbContext.Offers.Add(offer);

    _dbContext.SaveChanges();
  }

}