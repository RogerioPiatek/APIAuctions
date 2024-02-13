using APIAuction.API.UseCases.Auctions.GetCurrent;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIAuction.API.Controllers;

[Route("/api/[controller]")]
[ApiController]
public class AuctionController: ControllerBase
{
  [HttpGet]
  public IActionResult GetCurrentAuction()
  {

    var useCase = new GetCurrentActionUseCase();
    var result = useCase.Execute();

    return Ok(result);
  }
}
