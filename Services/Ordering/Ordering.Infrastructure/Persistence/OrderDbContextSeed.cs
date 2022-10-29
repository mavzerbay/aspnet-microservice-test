using Microsoft.Extensions.Logging;
using Ordering.Domain.Entities;

namespace Ordering.Infrastructure.Persistence
{
    public class OrderDbContextSeed
    {
        public static async Task SeedAsync(OrderDbContext orderDbContext, ILogger<OrderDbContextSeed> logger)
        {
            if (!orderDbContext.Orders.Any())
            {
                orderDbContext.Orders.AddRange(GetPreconfiguredOrders());
                await orderDbContext.SaveChangesAsync();
                logger.LogInformation("Seed database associated with context {DbContextName}", typeof(OrderDbContext).Name);
            }
        }

        private static IEnumerable<Order> GetPreconfiguredOrders()
        {
            return new List<Order>
            {
                new Order() {
                    UserName = "swn",
                    FirstName = "Erbay",
                    LastName = "Mavzer",
                    EmailAddress = "mavzerbay@gmail.com",
                    AddressLine = "Adatepe",
                    Country = "Turkey",
                    State="İzmir",
                    CardName="EnPara",
                    CardNumber="4242 4242 4242 4242",
                    CVV="000",
                    Expiration="09/10",
                    TotalPrice = 350
                }
            };
        }
    }
}
