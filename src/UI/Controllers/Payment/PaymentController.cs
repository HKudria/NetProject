using Domain.Payments.Payment;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.config;

namespace UI.Controllers;

[Route("payment")]
public class PaymentController(PaymentsDbContext connections) : Controller
{
    [HttpPost("create")]
    public async Task<IActionResult> New([FromBody] Payment payment)
    {
        connections.Payments.Add(payment);
        await connections.SaveChangesAsync();
		
        return Ok(payment);
    }
}