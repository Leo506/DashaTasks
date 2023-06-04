using DashaTasks.Task12;

namespace DashaTasks.Task13;

public class CommissionCar : UsedCar
{
    public string OwnerFullName { get; set; }
    
    public string OwnerAddress { get; set; }
    
    public string ContractNumber { get; set; }

    public CommissionCar(string brand, int yearOfRelease, string vin, BodyType bodyType, double mileage,
        CarCondition condition, string ownerFullName, string ownerAddress, string contractNumber) : base(brand,
        yearOfRelease, vin, bodyType, mileage, condition)
    {
        OwnerFullName = ownerFullName;
        OwnerAddress = ownerAddress;
        ContractNumber = contractNumber;
    }

    public override string GetInfo()
    {
        return base.GetInfo() +
               $"\nФИО владельца: {OwnerFullName}. Адрес владельца: {OwnerAddress}. Номер договора о реализации: {ContractNumber}.";
    }
}