﻿





using BaseCrudApplicationWirhAuthenticationNETCore9.Core.Models.Account;

namespace BaseCrudApplicationWirhAuthenticationNETCore9.Core.Models.Shop
{
    public class Order : BaseEntity
    {
        public decimal Discount { get; set; }
        public string? Comments { get; set; }

        public string? CashierId { get; set; }
        public ApplicationUser? Cashier { get; set; }

        public int CustomerId { get; set; }
        public required Customer Customer { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; } = [];
    }
}
