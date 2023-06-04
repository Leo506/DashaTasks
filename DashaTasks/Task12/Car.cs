using System;
using System.IO;

namespace DashaTasks.Task12;

public enum BodyType
{
    Sedan,
    Hatchback,
    StationWagon,
    Carbiolet
}

public class Car
{
    public readonly string VIN;

    public string Brand { get; set; }

    public int YearOfRelease { get; set; }

    public BodyType BodyType { get; set; }

    public decimal Price { get; set; }

    public DateTime DateOfSale { get; set; }

    public string CustomerFullName { get; set; }
    
    public Car(string brand, int yearOfRelease, string vin, BodyType bodyType)
    {
        Brand = brand;
        if (yearOfRelease <= 0)
            throw new ArgumentException();
        YearOfRelease = yearOfRelease;

        if (vin.Length < 17)
            throw new ArgumentException();
        VIN = vin;
        BodyType = bodyType;
    }

    public string GetInfo()
    {
        return $"Марка: {Brand}. Год выпуска: {YearOfRelease}. VIN: {VIN}. Тиа кузова: {GetBodyTypeName()}\n" +
               $"Цена: {Price}. Дата продажи: {DateOfSale.ToShortDateString()}. ФИО покупателя: {CustomerFullName}";
    }

    private string GetBodyTypeName()
    {
        return BodyType switch
        {
            BodyType.Sedan => "Седан",
            BodyType.Hatchback => "Хэтчбек",
            BodyType.Carbiolet => "Кабриолет",
            BodyType.StationWagon => "Универсал",
            _ => string.Empty
        };
    }
}