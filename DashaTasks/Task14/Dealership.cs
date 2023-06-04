using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DashaTasks.Task12;

namespace DashaTasks.Task14;

public class Dealership : IEnumerable<Car>
{
    private readonly List<Car> _cars;

    public string Name { get; set; }

    public string Address { get; set; }

    public int CarCount => _cars.Count;

    public Dealership(string name, string address, IEnumerable<Car> cars)
    {
        Name = name;
        Address = address;
        _cars = cars.Distinct().ToList();
    }

    public IEnumerator<Car> GetEnumerator() => _cars.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_cars).GetEnumerator();
}