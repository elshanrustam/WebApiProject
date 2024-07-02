﻿using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Persistence.Configurations;

public class ProductCategoryConfig : IEntityTypeConfiguration<ProductCategory>
{
    public void Configure(EntityTypeBuilder<ProductCategory> builder)
    {
        builder.HasKey(x => new { x.ProductId, x.CategoryId });

        builder.HasOne(p => p.Product)
            .WithMany(pc => pc.ProductCategories)
            .HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Cascade);


        builder.HasOne(c => c.Category)
            .WithMany(pc => pc.ProductCategories)
            .HasForeignKey(c => c.CategoryId).OnDelete(DeleteBehavior.Cascade);
    }
}
