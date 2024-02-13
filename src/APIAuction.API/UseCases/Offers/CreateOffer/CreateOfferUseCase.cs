using APIAuction.API.Communication.Requests;
using APIAuction.API.Entities;
using APIAuction.API.Repositories;
using APIAuction.API.Services;
using Microsoft.EntityFrameworkCore;

namespace APIAuction.API.UseCases.Auctions.CreateOffer;

public class CreateOfferUseCase
{
    private readonly LoggedUser _loggedUser;

    public CreateOfferUseCase(LoggedUser loggedUser) => _loggedUser = loggedUser;

    public int Execute(int itemId, RequestCreateOfferJson request)
  {
    var repository = new APIAuctionDbContext();

    var user = _loggedUser.User();

    var offer = new Offer
    {
      ItemId = itemId,
      Price = request.Price,
      UserId = user.Id,
      CreatedOn = DateTime.Now
    };

    repository.Offers.Add(offer);

    repository.SaveChanges();

    return offer.Id;
  }
}