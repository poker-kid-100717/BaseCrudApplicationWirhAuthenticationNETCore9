// ---------------------------------------



// ---------------------------------------

using BaseCrudApplicationWirhAuthenticationNETCore9.Core.Models.Shop;

namespace BaseCrudApplicationWirhAuthenticationNETCore9.Core.Services.Shop
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetTopActiveCustomers(int count);
        IEnumerable<Customer> GetAllCustomersData();
    }
}
