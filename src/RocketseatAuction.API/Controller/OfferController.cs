using Microsoft.AspNetCore.Mvc;
using RocketseatAuction.API.Communication.Requests;
using RocketseatAuction.API.Filters;
using RocketseatAuction.API.UseCases.Auctions.Offers.CreateOffer;

namespace RocketseatAuction.API.Controller;


[ServiceFilter(typeof(AuthenticationUserAttribute))]
public class OfferController : RocketseatAuctionBaseController
{
    [HttpPost]
    [Route("{itemid}")]
    public IActionResult CreateOffer(
        [FromRoute]int itemid,
        [FromBody] RequestCreateOfferJson request,
        [FromServices] CreateOfferUseCase useCase)
    {
        var id = useCase.Execute(itemid, request);

        return Created(string.Empty, id);

    }
}
