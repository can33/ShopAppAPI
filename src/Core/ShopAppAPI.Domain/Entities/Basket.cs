﻿using ShopAppAPI.Domain.Entities;

namespace ShopAppAPI.Domain;

public class Basket : BaseEntity
{
    public Basket() => Products = new List<Product>();

    public Guid Id { get; set; }

    // User Relation
    public string UserId { get; set; }
    public AppUser User { get; set; }

    // Product Relation
    public ICollection<Product> Products { get; set; }
}
