
﻿using GameTeamWork.NPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameTeamWork.Npc
{
    public class NPCQuester //: NPC_Base
    {   
        public bool IsAttackable;
        public Image Image;
        public NPCQuestText QuestText;
        [XmlIgnore]
        public string TextToDisplay;

        private bool goAhead;
        private SpriteFont font;
        private ContentManager content;
        private int counter = 0;
        private bool end = false;
        private bool first = true;
           
        public NPCQuester()
        {
            IsAttackable = false;
            goAhead = false;
            TextToDisplay = String.Empty;
        }

        public void LoadContent()
        {
            content = new ContentManager(ScreenManager.Instance.Content.ServiceProvider, "Content");
            font = content.Load<SpriteFont>("Fonts/Arial");
            Image.LoadContent();
        }

        public void UnloadContent()
        {
            Image.UnloadContent();
        }

        public void Update(GameTime gameTime, ref Player player)
        {
           // System.Diagnostics.Debug.WriteLine(player.Image.Position);
            goAhead = false;
            
        }

        public void Draw(SpriteBatch spriteBatch, ref Player player)
        {
            try
            {
                 TextToDisplay = QuestText.QuesterText[counter];
            }
            catch (Exception e)
            {
                end = true;
            }

            if (Image.Position.X >= player.Image.Position.X - 35 && Image.Position.X <= player.Image.Position.X + 35 &&
                Image.Position.Y >= player.Image.Position.Y - 35 && Image.Position.Y <= player.Image.Position.Y + 35 &&
                InputManager.Instance.KeyPressed(Keys.Space) && !goAhead)
            {
                goAhead = true;
                first = false;
                counter++;
            }

            if (!end && !first)
            {
                spriteBatch.DrawString(font, TextToDisplay, new Vector2(350, 200), Color.Azure);
            }

            Image.Draw(spriteBatch);
        }

       // private void Say

/*        public string GiveQuest()
        {
            //TODO: Implement quest giving logic
                //return this.questText;            
        }*/
    }
}