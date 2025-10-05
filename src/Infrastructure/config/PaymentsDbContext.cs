using Microsoft.EntityFrameworkCore;
using Domain.Payments.Merchant;
using Domain.Payments.Payment;

namespace Infrastructure.config;
public class PaymentsDbContext(DbContextOptions<PaymentsDbContext> options) :
    DbContext(options)
{
    public DbSet<Merchant> Merchants {get; set;}
    public DbSet<Payment> Payments {get; set;}
}