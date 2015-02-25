using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameTeamWork.Item;
namespace GameTeamWork.Unit
{
    public interface IUnit
    {
         int Health { get; set; }
         int Damage { get; set; }
         bool IsAlive { get; set; }
         void Attack(Unit target);
         List<IItem> Backpack { get; set; }
         void AddItem(IItem item);
         void RemoveItem(Item.Item item);
    }
}
