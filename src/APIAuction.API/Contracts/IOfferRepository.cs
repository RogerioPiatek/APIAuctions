using APIAuction.API.Entities;

namespace APIAuction.API.Contracts;

public interface IOfferRepository
{
  public void Add(Offer offer);
}