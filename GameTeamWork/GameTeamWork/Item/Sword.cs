using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameTeamWork.Item
{
    public class Sword : ItemAbstract
    {
        public Sword(int damageBonus, int healthBonus, int itemId)
            : base(2, 0, itemId)
        {

        }
    }
}
