using DashaTasks.Task12;
using DashaTasks.Task13;
using NUnit.Framework;

namespace DashaTasks.UnitTests.Task13;

public class UsedCarTests
{
    [Test]
    public void UsedCar_ValidArguments_CreateCar()
    {
        var usedCar = new UsedCar("Hundai", 2000, "12345678901234567", BodyType.Sedan, 1000, CarCondition.Excellent);
        
        Assert.That(usedCar.Brand, Is.EqualTo("Hundai"));
        Assert.That(usedCar.YearOfRelease, Is.EqualTo(2000));
        Assert.That(usedCar.VIN, Is.EqualTo("12345678901234567"));
        Assert.That(usedCar.BodyType, Is.EqualTo(BodyType.Sedan));
        Assert.That(usedCar.Mileage, Is.EqualTo(1000));
        Assert.That(usedCar.Condition, Is.EqualTo(CarCondition.Excellent));
    }

    [Test]
    public void GetInfo_UsedCar_ReturnsCorrectString()
    {
        const string expectedString = "Марка: Hundai. Год выпуска: 2000. VIN: 12345678901234567. Тип кузова: Седан\n"
                                      + "Цена: 0. Дата продажи: 01.01.0001. ФИО покупателя: \n"
                                      + "Пробег: 1000. Состояние: Отличное";
        var usedCar = new UsedCar("Hundai", 2000, "12345678901234567", BodyType.Sedan, 1000, CarCondition.Excellent);

        var result = usedCar.GetInfo();
        
        Assert.That(result, Is.EqualTo(expectedString));
    }
}