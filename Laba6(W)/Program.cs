
abstract class Transport
{
    public abstract double Speed { get; }
    public abstract double PayloadCapacity { get; }
    public abstract double Range { get; }

    public abstract string GetTransportInfo();
}


abstract class Car : Transport
{
    public override string GetTransportInfo()
    {
        return $"Машина с грузоподъемностью {PayloadCapacity} тонн может проехать {Range} км";
    }
}


abstract class Airplane : Transport
{
    public override string GetTransportInfo()
    {
        return $"Самолет с грузоподъемностью {PayloadCapacity} кг может пролететь {Range} км";
    }
}

// Абстрактный класс "Корабль"
abstract class Ship : Transport
{
    public override string GetTransportInfo()
    {
        return $"Корабль с грузоподъемностью {PayloadCapacity} тонн может проплыть {Range} км";
    }
}

// Класс, унаследованный от "Автомобиль"
class Sedan : Car
{
    public override double Speed => 120;
    public override double PayloadCapacity => 1.5;
    public override double Range => 600;
}

// Класс, унаследованный от "Самолет"
class Boeing747 : Airplane
{
    public override double Speed => 900;
    public override double PayloadCapacity => 37000;
    public override double Range => 13600;
}

// Класс, унаследованный от "Корабль"
class CargoShip : Ship
{
    public override double Speed => 25;
    public override double PayloadCapacity => 150000;
    public override double Range => 15000;
}

class Program
{
    static void Main()
    {
        Sedan sedan = new Sedan();
        Console.WriteLine($"Седан: {sedan.GetTransportInfo()}");

        Boeing747 boeing747 = new Boeing747();
        Console.WriteLine($"Boeing 747: {boeing747.GetTransportInfo()}");

        CargoShip cargoShip = new CargoShip();
        Console.WriteLine($"Грузовой корабль: {cargoShip.GetTransportInfo()}");
    }
}
