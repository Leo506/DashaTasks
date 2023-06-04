using System.Collections.Generic;
using DashaTasks.Task12;
using DashaTasks.Task14;
using NUnit.Framework;

namespace DashaTasks.UnitTests.Task14;

public class DealershipTests
{
    [Test]
    public void DealerShip_ValidParameters_CreateDealership()
    {
        var cars = new List<Car>
        {
            new("Hundai", 2000, "12345678901234567", BodyType.Sedan) { Price = 100_000 },
            new("Skoda", 2000, "09876543210987654", BodyType.Sedan) { Price = 100_000 }
        };
        var dealerShip = new Dealership("Название", "Ленина 6", cars);
        
        Assert.That(dealerShip.Name, Is.EqualTo("Название"));
        Assert.That(dealerShip.Address, Is.EqualTo("Ленина 6"));
        Assert.That(dealerShip.CarCount, Is.EqualTo(cars.Count));
    }

    [Test]
    public void DealerShip_ThereAreCarDuplicates_IgnoreDuplicates()
    {
        var cars = new List<Car>
        {
            new("Hundai", 2000, "12345678901234567", BodyType.Sedan) { Price = 100_000 },
            new("Skoda", 2000, "12345678901234567", BodyType.Sedan) { Price = 100_000 }
        };
        var dealerShip = new Dealership("Название", "Ленина 6", cars);
        
        Assert.That(dealerShip.CarCount, Is.EqualTo(1));
    }
}