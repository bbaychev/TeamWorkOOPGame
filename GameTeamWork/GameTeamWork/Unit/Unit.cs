﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameTeamWork.Item;
namespace GameTeamWork.Unit
{
    public  class Unit : IUnit
    {
        private int health;
        private List<IItem> backpack = new List<IItem> { };
        private bool isAlive = true;

        public bool IsAlive
        {
            get { return isAlive; }
            set {
 
                isAlive = value; 

            }
        }
        
        public Unit(int health, int damage)
        {
            this.Health = health;
            this.Damage = damage;
        }
        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                this.Health = value;
                if (this.Health < 1)
                {
                    isAlive = false;
                }
            }
        }

        public int Damage
        {
            get;
            set;
        }

        public void Attack(Unit target)
        {
            target.Health = target.Health - this.Damage;
        }

        public List<IItem> Backpack
        {
            get
            {
                return this.backpack;
            }
            set
            {
                this.backpack = value;
            }
        }

        public void AddItem(IItem item)
        {
            this.Damage += item.DamageBonus;
            this.Health += item.HealthBonus;
        }

        public void RemoveItem(ItemAbstract item)
        {
            this.Damage -= item.DamageBonus;
                //If by chance when the  item is removed and without it the unit-s health goes below 0, we don't want him to die
            if (this.Health - item.HealthBonus < 0)
            {
                this.Health = 1;

            }
            else
            {
                this.Health -= item.HealthBonus;
            }
        }
    }
}
