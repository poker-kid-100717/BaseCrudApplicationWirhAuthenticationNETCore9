// ---------------------------------------



// ---------------------------------------

using Microsoft.EntityFrameworkCore;
using BaseCrudApplicationWirhAuthenticationNETCore9.Core.Infrastructure;
using BaseCrudApplicationWirhAuthenticationNETCore9.Core.Models.Shop;

namespace BaseCrudApplicationWirhAuthenticationNETCore9.Core.Services.Shop
{
    public class CustomerService(ApplicationDbContext dbContext) : ICustomerService
    {
        public IEnumerable<Customer> GetTopActiveCustomers(int count) => throw new NotImplementedException();

        public IEnumerable<Customer> GetAllCustomersData() => dbContext.Customers
                .Include(c => c.Orders).ThenInclude(o => o.OrderDetails).ThenInclude(d => d.Product)
                .Include(c => c.Orders).ThenInclude(o => o.Cashier)
                .AsSingleQuery()
                .OrderBy(c => c.Name)
                .ToList();
    }
}
