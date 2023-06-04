using System;
using DashaTasks.Task12;
using DashaTasks.Task13;
using NUnit.Framework;

namespace DashaTasks.UnitTests.Task13;

public class NewCarTests
{
    [Test]
    public void NewCar_ValidArguments_CreateNewCar()
    {
        var newCar = new NewCar("Hundai", 2000, "12345678901234567", BodyType.Sedan, "Factory 1",
            TimeSpan.FromDays(365));
        
        Assert.That(newCar.Brand, Is.EqualTo("Hundai"));
        Assert.That(newCar.YearOfRelease, Is.EqualTo(2000));
        Assert.That(newCar.VIN, Is.EqualTo("12345678901234567"));
        Assert.That(newCar.BodyType, Is.EqualTo(BodyType.Sedan));
        Assert.That(newCar.Factory, Is.EqualTo("Factory 1"));
        Assert.That(newCar.GuaranteeTime, Is.EqualTo(TimeSpan.FromDays(365)));
    }

    [Test]
    public void GetInfo_NewCar_ReturnsCorrectString()
    {
        const string expectedString = "Марка: Hundai. Год выпуска: 2000. VIN: 12345678901234567. Тип кузова: Седан\n"
                                      + "Цена: 0. Дата продажи: 01.01.0001. ФИО покупателя: \n"
                                      + "Завод-производитель: Factory 1. Гарантийный срок: 365 дней";
        
        var newCar = new NewCar("Hundai", 2000, "12345678901234567", BodyType.Sedan, "Factory 1",
            TimeSpan.FromDays(365));

        var result = newCar.GetInfo();
        
        Assert.That(result, Is.EqualTo(expectedString));
    }
}