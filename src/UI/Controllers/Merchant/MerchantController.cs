using Microsoft.AspNetCore.Mvc;
using Infrastructure.config;
using Domain.Payments.Merchant;
using Microsoft.EntityFrameworkCore;

namespace UI.Controllers;

[Route("[controller]")]
[ApiController]
public class MerchantController(PaymentsDbContext connections) : ControllerBase
{
	[HttpGet("")]
	public async Task<IActionResult> ListOfMerchants ()
	{
		var result = await connections.Merchants.Select(x => new Merchant
		{
			Id = x.Id,
			ApiKey = x.ApiKey,
			CreatedAt = x.CreatedAt,
			Name = x.Name,
		}).ToListAsync();
		
		return Ok(result);
	}
	
	[HttpPost("create")]
	public async Task<IActionResult> CreateMerchant ([FromBody] Merchant merchant)
	{
		connections.Merchants.Add(merchant);
		await connections.SaveChangesAsync();
		
		return Ok(merchant);
	}
}