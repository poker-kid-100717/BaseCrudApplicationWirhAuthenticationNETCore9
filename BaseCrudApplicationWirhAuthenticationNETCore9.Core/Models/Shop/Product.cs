﻿





namespace BaseCrudApplicationWirhAuthenticationNETCore9.Core.Models.Shop
{
    public class Product : BaseEntity
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? Icon { get; set; }
        public decimal BuyingPrice { get; set; }
        public decimal SellingPrice { get; set; }
        public int UnitsInStock { get; set; }
        public bool IsActive { get; set; }
        public bool IsDiscontinued { get; set; }

        public int? ParentId { get; set; }
        public Product? Parent { get; set; }

        public int ProductCategoryId { get; set; }
        public required ProductCategory ProductCategory { get; set; }

        public ICollection<Product> Children { get; } = [];
        public ICollection<OrderDetail> OrderDetails { get; } = [];
    }
}
