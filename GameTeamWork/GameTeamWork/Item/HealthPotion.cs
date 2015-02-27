using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameTeamWork.Item
{
    public class HealthPotion : ItemAbstract
    {
        public HealthPotion(int damageBonus, int healthBonus, int itemId)
            : base(damageBonus, healthBonus, itemId)
        {

        }
    }
}
