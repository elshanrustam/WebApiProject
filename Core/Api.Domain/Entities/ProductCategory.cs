﻿using Api.Domain.Common;

namespace Api.Domain.Entities;

public class ProductCategory : IBaseEntity
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    public Product Product { get; set; }
    public Category Category { get; set; }
}
