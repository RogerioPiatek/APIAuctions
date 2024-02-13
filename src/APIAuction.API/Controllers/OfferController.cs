using Microsoft.AspNetCore.Mvc;

namespace APIAuction.API.Controllers;

public class OfferController : APIAuctionBaseController
{
  [HttpPost]
  [Route("{itemId}")]
  public IActionResult CreateOffer([FromRoute] int itemId)
  {
    return Created();
  }
}