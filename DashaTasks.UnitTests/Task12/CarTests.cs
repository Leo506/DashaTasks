using DashaTasks.Task12;
using NUnit.Framework;

namespace DashaTasks.UnitTests.Task12;

public class CarTests
{
    [Test]
    public void Car_ArgumentsCorrect_CreateCar()
    {
        var car = new Car("Hundai", 2000, "12345678901234567", BodyType.Sedan);
        
        Assert.That(car.Brand, Is.EqualTo("Hundai"));
        Assert.That(car.YearOfRelease, Is.EqualTo(2000));
        Assert.That(car.VIN, Is.EqualTo("12345678901234567"));
        Assert.That(car.BodyType, Is.EqualTo(BodyType.Sedan));
    }

    [TestCase(0)]
    [TestCase(-1)]
    public void Car_YearOfReleaseLessOrEqualToZero_ThrowsArgumentException(int yearOfRelease)
    {
        TestDelegate action = () => { new Car("Hundai", yearOfRelease, "12345678901234567", BodyType.Sedan); };
        
        Assert.That(action, Throws.ArgumentException);
    }

    [TestCase("1111")]
    [TestCase("12345678901234567890")]
    public void Car_VINHasNot17Characters_ThrowsArgumentException(string vin)
    {
        TestDelegate action = () => { new Car("Hundai", 2000, vin, BodyType.Sedan); };
        
        Assert.That(action, Throws.ArgumentException);
    }

    [Test]
    public void GetInfo_Car_ReturnsCorrectString()
    {
        const string expectedString = "Марка: Hundai. Год выпуска: 2000. VIN: 12345678901234567. Тип кузова: Седан\n"
                                      + "Цена: 0. Дата продажи: 01.01.0001. ФИО покупателя: ";
        var car = new Car("Hundai", 2000, "12345678901234567", BodyType.Sedan);
        
        var result = car.GetInfo();
        
        Assert.That(result, Is.EqualTo(expectedString));
    }
}