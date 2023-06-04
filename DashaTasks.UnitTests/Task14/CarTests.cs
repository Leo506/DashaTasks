using System.Collections.Generic;
using DashaTasks.Task12;
using NUnit.Framework;

namespace DashaTasks.UnitTests.Task14;

public class CarTests
{
    [Test]
    public void CompareTo_BrandIsSame_CompareByPrice()
    {
        var firstCar = new Car("Hundai", 2000, "12345678901234567", BodyType.Sedan)
        {
            Price = 100_000
        };

        var secondCar = new Car("Hundai", 2000, "12345678901234567", BodyType.Sedan)
        {
            Price = 200_000
        };

        var result = firstCar.CompareTo(secondCar);
        
        Assert.That(result, Is.LessThan(0));
    }

    [Test]
    public void CompareTo_BrandIsDifferent_CompareByBrand()
    {
        var firstCar = new Car("Skoda", 2000, "12345678901234567", BodyType.Sedan)
        {
            Price = 100_000
        };

        var secondCar = new Car("Hundai", 2000, "12345678901234567", BodyType.Sedan)
        {
            Price = 200_000
        };

        var result = firstCar.CompareTo(secondCar);
        
        Assert.That(result, Is.GreaterThan(0));
    }

    [Test]
    public void SortListOfCar_OrderIsCorrect()
    {
        var firstCar = new Car("Skoda", 2000, "12345678901234567", BodyType.Sedan)
        {
            Price = 100_000
        };

        var secondCar = new Car("Hundai", 2000, "12345678901234567", BodyType.Sedan)
        {
            Price = 200_000
        };

        var thirdCar = new Car("Hundai", 2000, "12345678901234567", BodyType.Sedan)
        {
            Price = 400_000
        };

        var cars = new List<Car> { firstCar, secondCar, thirdCar };

        cars.Sort();
        
        Assert.That(cars[0], Is.EqualTo(secondCar));
        Assert.That(cars[1], Is.EqualTo(thirdCar));
        Assert.That(cars[2], Is.EqualTo(firstCar));
    }

    [Test]
    public void Equals_VINIsSame_ReturnsTrue()
    {
        var firstCar = new Car("Skoda", 2000, "12345678901234567", BodyType.Sedan);
        var secondCar = new Car("Hundai", 2000, "12345678901234567", BodyType.Sedan);

        var result = firstCar.Equals(secondCar);
        
        Assert.True(result);
    }
    
    [Test]
    public void Equals_VINIsDifferent_ReturnsTrue()
    {
        var firstCar = new Car("Skoda", 2000, "12345678901234567", BodyType.Sedan);
        var secondCar = new Car("Hundai", 2000, "09876543210987654", BodyType.Sedan);

        var result = firstCar.Equals(secondCar);
        
        Assert.False(result);
    }
}