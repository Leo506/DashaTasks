using DashaTasks.Task12;
using DashaTasks.Task13;
using NUnit.Framework;

namespace DashaTasks.UnitTests.Task13;

public class CommissionCarTests
{
    [Test]
    public void CommissionCar_ValidArguments_CreateCar()
    {
        var commissionCar = new CommissionCar("Hundai", 2000, "12345678901234567", BodyType.Sedan, 1000,
            CarCondition.Excellent, "Иванов Ива Иванович", "Ленина 6", "123");
        
        Assert.That(commissionCar.Brand, Is.EqualTo("Hundai"));
        Assert.That(commissionCar.YearOfRelease, Is.EqualTo(2000));
        Assert.That(commissionCar.VIN, Is.EqualTo("12345678901234567"));
        Assert.That(commissionCar.BodyType, Is.EqualTo(BodyType.Sedan));
        Assert.That(commissionCar.Mileage, Is.EqualTo(1000));
        Assert.That(commissionCar.Condition, Is.EqualTo(CarCondition.Excellent));
        Assert.That(commissionCar.OwnerFullName, Is.EqualTo("Иванов Ива Иванович"));
        Assert.That(commissionCar.OwnerAddress, Is.EqualTo("Ленина 6"));
        Assert.That(commissionCar.ContractNumber, Is.EqualTo("123"));
    }

    [Test]
    public void GetInfo_CommissionCar_ReturnsCorrectString()
    {
        const string expectedString = "Марка: Hundai. Год выпуска: 2000. VIN: 12345678901234567. Тип кузова: Седан\n"
                                      + "Цена: 0. Дата продажи: 01.01.0001. ФИО покупателя: \n"
                                      + "Пробег: 1000. Состояние: Отличное\n"
                                      + "ФИО владельца: Иванов Ива Иванович. Адрес владельца: Ленина 6. Номер договора о реализации: 123.";
        var commissionCar = new CommissionCar("Hundai", 2000, "12345678901234567", BodyType.Sedan, 1000,
            CarCondition.Excellent, "Иванов Ива Иванович", "Ленина 6", "123");

        var result = commissionCar.GetInfo();
        
        Assert.That(result, Is.EqualTo(expectedString));
    }
}