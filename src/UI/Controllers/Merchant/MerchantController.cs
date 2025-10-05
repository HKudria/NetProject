using Application;
using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace UI.Controllers;

[Route("merchant")]
[ApiController]
public class MerchantController(IMediator mediator) : ControllerBase
{
	[HttpGet("")]
	public async Task<IActionResult> ListOfMerchants ()
	{
		var result = await mediator.Send(new QueryMerchantsList());
		return Ok(result);
	}
	
	[HttpPost("create")]
	public async Task<IActionResult> CreateMerchant ([FromBody] MerchantRequest req)
	{
		var merchantCreate = new CreateMerchant(req.Name, req.ApiKey);
		var result = await mediator.Send(merchantCreate);
		
		return Ok(result);
	}
}