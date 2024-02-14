using APIAuction.API.Contracts;
using APIAuction.API.Entities;
using APIAuction.API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace APIAuction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{

  private readonly IAuctionRepository _repository;
  public GetCurrentAuctionUseCase(IAuctionRepository repository) => _repository = repository;

  public Auction? Execute()
  {
    return _repository.GetCurrent();
  }
}