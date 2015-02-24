using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameTeamWork.Item;
namespace GameTeamWork.Unit
{
    public  class Unit : IUnit
    {
        private int health;
        private int damage;
        private List<IItem> backpack = new List<IItem> { };
        public int Health
        {
            get;
            set;
        }

        public int Damage
        {
            get;
            set;
        }

        public void Attack(IUnit target)
        {
            throw new NotImplementedException();
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

        public void AddItem(Item.IItem item)
        {
            throw new NotImplementedException();
        }
    }
}
