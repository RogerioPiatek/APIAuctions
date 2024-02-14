using APIAuction.API.Entities;

namespace APIAuction.API.Contracts;

public interface IAuctionRepository
{
   Auction? GetCurrent();
}