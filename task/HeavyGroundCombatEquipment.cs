using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    // ConcreteFlyweight (HeavyGroundCombatEquipment) - конкретный приспособленец.
    // Реализует интерфейс класса Flyweight и добавляет при необходимости внутреннее состояние.
    // Объект класса ConcreteFlyweight должен быть разделяемым.
    // Любое сохраняемое им состояние должно быть внутренним, то есть не зависящим от контекста.

    // Тяжелая наземная боевая техника.
    internal class HeavyGroundCombatEquipment : CombatUnit
    {
        public override void Show(Point position)
        {
            Console.WriteLine("Тяжелая наземная боевая техника на позиции {0} {1}", position.X, position.Y);
            Console.WriteLine(Picture);
        }

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
    }
}