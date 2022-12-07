using System.Drawing;

namespace task;
// ConcreteFlyweight (LightInfantry) - конкретный приспособленец.
// Реализует интерфейс класса Flyweight и добавляет при необходимости внутреннее состояние.
// Объект класса ConcreteFlyweight должен быть разделяемым.
// Любое сохраняемое им состояние должно быть внутренним, то есть не зависящим от контекста.

// Легкая пехота.
internal class LightInfantry : CombatUnit
{
    // Конструктор.
    public LightInfantry()
    {
        Picture = @"
    \O/
     |
    / \ 
";
        Speed = 20;
        Strength = 10;
    }

    public override void Show(Point position)
    {
        Console.WriteLine("Легкая пехота на позиции {0} {1}", position.X, position.Y);
        Console.WriteLine(Picture);
    }
}