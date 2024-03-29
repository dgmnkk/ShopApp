﻿using DataAccess.Data.Entities;

namespace ShopApp.Data.Entities
{
    public class Advertisement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Brand { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public int Views { get; set; }
        public DateTime PublicationDate { get; set; }
        public int ConditionId { get; set; }
        public Condition? Condition { get; set; }
        public string? SellerId { get; set; }
        public User? Seller { get; set; }
        public string ImageUrl { get; set; }
		public Location? Location { get; set; }
		public int? LocationId { get; set; }
		public ICollection<Attribute>? Attributes { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}
