using System;
using Xunit;
using FluentAssertions;
using sssunum.Entities;

namespace sssunum.Tests.Personnels
{
    public class PersonnelEntityTests
    {
        [Fact]
        public void Personnel_ShouldBeCreatable()
        {
            // Act
            var entity = new Personnel();

            // Assert
            entity.Should().NotBeNull();
        }

        [Fact]
        public void Personnel_ShouldHaveDefaultValues()
        {
            // Act
            var entity = new Personnel();

            // Assert
            entity.Id.Should().Be(default(long));

        }

        [Fact]
        public void Personnel_FirstName_ShouldAcceptValue()
        {
            var entity = new Personnel { FirstName = "Test Value" };
            entity.FirstName.Should().Be("Test Value");
        }

        [Fact]
        public void Personnel_LastName_ShouldAcceptValue()
        {
            var entity = new Personnel { LastName = "Test Value" };
            entity.LastName.Should().Be("Test Value");
        }

        [Fact]
        public void Personnel_BadgeNumber_ShouldAcceptValue()
        {
            var entity = new Personnel { BadgeNumber = "Test Value" };
            entity.BadgeNumber.Should().Be("Test Value");
        }

    }
}
