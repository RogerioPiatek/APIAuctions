using APIAuction.API.Communication.Requests;
using APIAuction.API.Filters;
using Microsoft.AspNetCore.Mvc;

namespace APIAuction.API.Controllers;

[ServiceFilter(typeof(AuthenticationUserAttribute))]
public class OfferController : APIAuctionBaseController
{
  [HttpPost]
  [Route("{itemId}")]
  public IActionResult CreateOffer([FromRoute] int itemId, [FromBody] RequestCreateOfferJson request)
  {
    return Created();
  }
}