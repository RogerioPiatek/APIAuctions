using APIAuction.API.Communication.Requests;
using APIAuction.API.Filters;
using APIAuction.API.UseCases.Auctions.CreateOffer;
using Microsoft.AspNetCore.Mvc;

namespace APIAuction.API.Controllers;

[ServiceFilter(typeof(AuthenticationUserAttribute))]
public class OfferController : APIAuctionBaseController
{
  [HttpPost]
  [Route("{itemId}")]
  public IActionResult CreateOffer(
   [FromRoute] int itemId,
   [FromBody] RequestCreateOfferJson request,
   [FromServices] CreateOfferUseCase useCase)
  {

    var id = useCase.Execute(itemId, request);

    return Created(string.Empty, id);
  }
}