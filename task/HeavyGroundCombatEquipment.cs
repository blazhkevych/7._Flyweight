using System.Drawing;

namespace task;
// ConcreteFlyweight (HeavyGroundCombatEquipment) - конкретный приспособленец.
// Реализует интерфейс класса Flyweight и добавляет при необходимости внутреннее состояние.
// Объект класса ConcreteFlyweight должен быть разделяемым.
// Любое сохраняемое им состояние должно быть внутренним, то есть не зависящим от контекста.

// Тяжелая наземная боевая техника.
internal class HeavyGroundCombatEquipment : CombatUnit
{
    // Конструктор.
    public HeavyGroundCombatEquipment()
    {
        Picture = @"
         ______
     ___|-|___
    /ooooooooo\
";
        Speed = 15;
        Strength = 150;
    }

    public override void Show(Point position)
    {
        Console.WriteLine("Тяжелая наземная боевая техника на позиции {0} {1}", position.X, position.Y);
        Console.WriteLine(Picture);
    }
}