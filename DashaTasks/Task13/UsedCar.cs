using DashaTasks.Task12;

namespace DashaTasks.Task13;

public enum CarCondition
{
    Excellent,
    Good,
    Bad
}

public class UsedCar : Car
{
    public double Mileage { get; set; }

    public CarCondition Condition { get; set; }
    
    public UsedCar(string brand, int yearOfRelease, string vin, BodyType bodyType, double mileage, CarCondition condition) : base(brand, yearOfRelease, vin,
        bodyType)
    {
        Mileage = mileage;
        Condition = condition;
    }

    public override string GetInfo()
    {
        return base.GetInfo() + $"\nПробег: {Mileage}. Состояние: {GetConditionString()}";
    }

    private string GetConditionString()
    {
        return Condition switch
        {
            CarCondition.Excellent => "Отличное",
            CarCondition.Good => "Хорошee",
            CarCondition.Bad => "Плохое",
            _ => string.Empty
        };
    }
}