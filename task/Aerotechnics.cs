using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    // ConcreteFlyweight (Aerotechnics) - конкретный приспособленец.
    // Реализует интерфейс класса Flyweight и добавляет при необходимости внутреннее состояние.
    // Объект класса ConcreteFlyweight должен быть разделяемым.
    // Любое сохраняемое им состояние должно быть внутренним, то есть не зависящим от контекста.

    // Авиатехника.
    internal class Aerotechnics : CombatUnit
    {
        public override void Show(Point position)
        {
            Console.WriteLine("Воздушная техника на позиции {0} {1}", position.X, position.Y);
            Console.WriteLine(Picture);
        }

        // Конструктор.
        public Aerotechnics()
        {
            Picture = @"
       A 
      /x\
     //|\\
    /A | A\
      /.\ 
";
            Speed = 300;
            Strength = 100;
        }
    }
}