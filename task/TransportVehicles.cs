using System.Drawing;

namespace task;
// ConcreteFlyweight (TransportVehicles) - конкретный приспособленец.
// Реализует интерфейс класса Flyweight и добавляет при необходимости внутреннее состояние.
// Объект класса ConcreteFlyweight должен быть разделяемым.
// Любое сохраняемое им состояние должно быть внутренним, то есть не зависящим от контекста.

// Транспортные автомашины.
internal class TransportVehicles : CombatUnit
{
    // Конструктор.
    public TransportVehicles()
    {
        Picture = @"
     _____   _____   __
    |_____|_|_____|-|Щ_\
    `0 - 0  `0 - 0`  0  
";
        Speed = 70;
        Strength = 0;
    }

    public override void Show(Point position)
    {
        Console.WriteLine("Транспортные автомашины на позиции {0} {1}", position.X, position.Y);
        Console.WriteLine(Picture);
    }
}