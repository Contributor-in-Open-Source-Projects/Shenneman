using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shenneman.Api.Models.Foundetions.Guests;

namespace Shenneman.Api.Configuration
{
    public class GuestConfiguration : IEntityTypeConfiguration<Guest>
    {
        public void Configure(EntityTypeBuilder<Guest> builder)
        {
            builder.HasData(
                new Guest
                {
                    Id = 1,
                    FirstName = "Guest",
                    LastName = "Guest",
                    Address = "Guest",
                    Email = "Guest",
                    PhoneNumber = "1234567890",
                    DateOfBrith = DateTime.Now,
                     Gender = GenderType.Male,
                });
        }
    }
}
