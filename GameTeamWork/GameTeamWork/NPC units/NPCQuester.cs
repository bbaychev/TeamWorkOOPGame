
﻿using GameTeamWork.NPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameTeamWork.Npc
{
    public class NPC_Quester : NPC_Base
    {   
        private string questText;
        
           
        public NPC_Quester(string id, bool isAttackable, int health, string questText)
            :base(id,isAttackable, health)
        {
            this.questText = questText;
        }

        public virtual string GiveQuest()
        {
            //TODO: Implement quest giving logic
                return this.questText;
            

            
        }
    }
}