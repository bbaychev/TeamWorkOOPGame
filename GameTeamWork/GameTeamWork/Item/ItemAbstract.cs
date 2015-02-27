using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameTeamWork.Item
{
    public abstract class ItemAbstract : IItem
    {
        //TODO: Write more methods

        public int DamageBonus { get; set; }
        public int HealthBonus { get; set; }
        public int ItemId { get; set; }

        public ItemAbstract(int damageBonus, int healthBonus, int itemId)
        {
            this.DamageBonus = damageBonus;
            this.HealthBonus = healthBonus;
            this.ItemId = itemId;
        }
    }
}