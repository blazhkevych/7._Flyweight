using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    /*
    FlyweightFactory (CombatUnitFactory) - фабрика приспособленцев:
    - создает объекты-приспособленцы и управляет ими;
    - обеспечивает должное разделение приспособленцев. Когда клиент запрашивает приспособленца,
    объект FlyweightFactory предоставляет существующий экземпляр или создает новый, если готового еще нет.
    */
    internal class CombatUnitFactory
    {
        // Словарь для хранения приспособленцев.
        private Dictionary<string, CombatUnit> _combatUnits = new Dictionary<string, CombatUnit>();

        // Метод для получения приспособленца.
        public CombatUnit GetCombatUnit(string key)
        {
            // Если приспособленец с таким ключом уже есть в словаре, то возвращаем его.
            if (_combatUnits.ContainsKey(key))
            {
                return _combatUnits[key];
            }
            // Иначе создаем новый приспособленец, добавляем его в словарь и возвращаем.
            else
            {
                CombatUnit combatUnit = null;
                switch (key)
                {
                    case "Aerotechnics":
                        combatUnit = new Aerotechnics();
                        break;
                    case "LightGroundCombatEquipment":
                        combatUnit = new LightGroundCombatEquipment();
                        break;
                    case "HeavyGroundCombatEquipment":
                        combatUnit = new HeavyGroundCombatEquipment();
                        break;
                    case "TransportVehicles":
                        combatUnit = new TransportVehicles();
                        break;
                    case "LightInfantry":
                        combatUnit = new LightInfantry();
                        break;
                }
                _combatUnits.Add(key, combatUnit);
                return combatUnit;
            }
        }
    }
}
