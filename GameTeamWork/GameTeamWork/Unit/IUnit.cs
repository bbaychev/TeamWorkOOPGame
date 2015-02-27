using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameTeamWork.Item;
using System.Xml.Serialization;

namespace GameTeamWork.Unit
{
    public interface IUnit
    {
        [XmlIgnore]
        int Health { get; set; }
        [XmlIgnore]
        int Damage { get; set; }
        [XmlIgnore]
        bool IsAlive { get; set; }
        void Attack(Unit target);
        [XmlIgnore]
        List<IItem> Backpack { get; set; }
        void AddItem(IItem item);
        void RemoveItem(ItemAbstract item);
    }
}
