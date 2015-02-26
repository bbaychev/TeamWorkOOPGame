using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace GameTeamWork.NPC
{
    public class NPC_Base
    {
        private string ID;
        
        private bool isAttackable;
        private int health = 1;

        public NPC_Base(string id, bool isAttackable, int health)
        {
            this.ID = id;
            
            this.isAttackable = isAttackable;
            this.health = health;
        }


    }
}
