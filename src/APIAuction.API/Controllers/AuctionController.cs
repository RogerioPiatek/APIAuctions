using APIAuction.API.Entities;
using APIAuction.API.UseCases.Auctions.GetCurrent;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIAuction.API.Controllers;

[Route("[controller]")]
[ApiController]
public class AuctionController: ControllerBase
{
  [HttpGet]
  [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK )]
  [ProducesResponseType(StatusCodes.Status204NoContent)]
  public IActionResult GetCurrentAuction()
  {

    var useCase = new GetCurrentActionUseCase();

    var result = useCase.Execute();

    if(result is null)
      return NoContent();
    

    return Ok(result);
  }
}
