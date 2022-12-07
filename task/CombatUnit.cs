using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    // Flyweight (CombatUnit) - объявляет интерфейс, с помощью которого приспособленцы могут получать внешнее состояние.
    internal abstract class CombatUnit
    {
        // Внутреннее состояние.
        // Картинка для отображения.
        protected string Picture { get; set; }
        // Скорость перемещения.
        protected double Speed { get; set; }
        // Коэффициент силы.
        protected double Strength { get; set; }

        // Внешнее состояние.
        // Метод Show, который принимает в качестве параметра позицию объекта.
        public abstract void Show(Point position);
    }
}
