using Xunit;

using Moq;
using APIAuction.API.Contracts;
using APIAuction.API.Entities;
using Bogus;
using APIAuction.API.UseCases.Auctions.CreateOffer;
using APIAuction.API.Communication.Requests;
using APIAuction.API.Services;
using FluentAssertions;

namespace UseCases.Test.Auctions.CreateOffer;

public class CreateOfferUseCaseTest
{
  [Theory]
  [InlineData(1)]
  [InlineData(2)]
  [InlineData(3)]
  public void Success(int itemId)
  {
    //ARRANGE
    var request = new Faker<RequestCreateOfferJson>()
      .RuleFor(request => request.Price, f => f.Random.Decimal(1, 700)).Generate();

    var offerRepository = new Mock<IOfferRepository>();
    var loggedUser = new Mock<ILoggedUser>();
    loggedUser.Setup(i => i.User()).Returns(new User());

    var useCase = new CreateOfferUseCase(loggedUser.Object, offerRepository.Object);

    //ACT
    var act = () => useCase.Execute(itemId, request);

    //ASSERT
    act.Should().NotThrow();

  }
}