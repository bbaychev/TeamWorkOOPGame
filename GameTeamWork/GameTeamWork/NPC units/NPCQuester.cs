
﻿using GameTeamWork.NPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameTeamWork.Npc
{
    public class NPCQuester //: NPC_Base
    {   
        [XmlElement("QuestText")]
        public List<string> QuestText;
        [XmlElement("PlayerText")]
        public List<string> PlayerText;
        public bool IsAttackable;
        public Image Image;

        private bool goAhead;
           
        public NPCQuester()
        {
            QuestText = new List<string>();
            IsAttackable = false;
            PlayerText = new List<string>();
            goAhead = false;
        }

        public void LoadContent()
        {
            //TODO: Implement quest giving logic
        //        return this.questText;
        
            Image.LoadContent();
        }

        public void UnloadContent()
        {
            Image.UnloadContent();
        }

        public void Update(GameTime gameTime, ref Player player)
        {
            if (Image.SourceRect.Intersects(player.Image.SourceRect) && 
                InputManager.Instance.KeyDown(Keys.Space) && !goAhead)
            {
                goAhead = true;
                StartConversation();
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Image.Draw(spriteBatch);
        }

        private void StartConversation()
        {
            for (int i = 0; i < QuestText.Count; i++)
            {

            }
        }

       // private void Say

/*        public string GiveQuest()
        {
            //TODO: Implement quest giving logic
                //return this.questText;            
        }*/
    }
}