using Api.Domain.Entities;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Persistence.Configurations;

public class BrandConfig : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.Property(x => x.Name).HasMaxLength(256);

        Faker faker = new("az");

        Brand brand1 = new()
        {
            Id = 1,
            Name = faker.Commerce.Department(),
            CreatedDate = DateTime.Now,
            IsDeleted = false
        };

        Brand brand2 = new()
        {
            Id = 2,
            Name = faker.Commerce.Department(),
            CreatedDate = DateTime.Now,
            IsDeleted = false
        };

        Brand brand3 = new()
        {
            Id = 3,
            Name = faker.Commerce.Department(),
            CreatedDate = DateTime.Now,
            IsDeleted = true
        };
        builder.HasData(brand1, brand2, brand3);

    }
}
