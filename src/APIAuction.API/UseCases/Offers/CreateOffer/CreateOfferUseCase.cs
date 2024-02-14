using APIAuction.API.Communication.Requests;
using APIAuction.API.Contracts;
using APIAuction.API.Entities;
using APIAuction.API.Repositories;
using APIAuction.API.Services;

namespace APIAuction.API.UseCases.Auctions.CreateOffer;

public class CreateOfferUseCase
{
    private readonly LoggedUser _loggedUser;
    private readonly IOfferRepository _repository;

    public CreateOfferUseCase(LoggedUser loggedUser, IOfferRepository repository)
    {
      _loggedUser = loggedUser;
      _repository = repository;
    } 

    public int Execute(int itemId, RequestCreateOfferJson request)
  {
    var user = _loggedUser.User();

    var offer = new Offer
    {
      ItemId = itemId,
      Price = request.Price,
      UserId = user.Id,
      CreatedOn = DateTime.Now
    };

    _repository.Add(offer);

    return offer.Id;
  }
}