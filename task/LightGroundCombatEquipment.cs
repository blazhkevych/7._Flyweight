﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    // ConcreteFlyweight (LightGroundCombatEquipment) - конкретный приспособленец.
    // Реализует интерфейс класса Flyweight и добавляет при необходимости внутреннее состояние.
    // Объект класса ConcreteFlyweight должен быть разделяемым.
    // Любое сохраняемое им состояние должно быть внутренним, то есть не зависящим от контекста.

    // Легкая наземная боевая техника.
    internal class LightGroundCombatEquipment : CombatUnit
    {
        public override void Show(Point position)
        {
            Console.WriteLine("Легкая наземная боевая техника на позиции {0} {1}", position.X, position.Y);
            Console.WriteLine(Picture);
        }

        // Конструктор.
        public LightGroundCombatEquipment()
        {
            Picture = @"
    l_v__v_D
     о -- о
";
            Speed = 15;
            Strength = 150;
        }
    }
}