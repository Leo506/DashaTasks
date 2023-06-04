using System;
using DashaTasks.Task12;

namespace DashaTasks.Task13;

public class NewCar : Car
{
    public string Factory { get; set; }
    
    public TimeSpan GuaranteeTime { get; set; }

    public NewCar(string brand, int yearOfRelease, string vin, BodyType bodyType, string factory,
        TimeSpan guaranteeTime) : base(brand, yearOfRelease, vin, bodyType)
    {
        Factory = factory;
        GuaranteeTime = guaranteeTime;
    }

    public override string GetInfo()
    {
        return base.GetInfo() + $"\nЗавод-производитель: {Factory}. Гарантийный срок: {GuaranteeTime.TotalDays} дней";
    }
}