﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameTeamWork.Item
{
   public  class Item : IItem
    {   //TODO: Write more methods
        public int DamageBonus { get; set; }
        public int HealthBonus { get; set; }

        public Item(int damageBonus, int healthBonus)
        {
            this.DamageBonus = damageBonus;
            this.HealthBonus = healthBonus;
        }
     
    }
}
