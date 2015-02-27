using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameTeamWork.Npc
{
    public class NPCQuestText
    {
        [XmlElement("QuesterText")]
        public List<string> QuesterText;
        [XmlElement("PlayerText")]
        public List<string> PlayerText;
        public Image Image;

        public NPCQuestText()
        {
            QuesterText = new List<string>();
            PlayerText = new List<string>();
        }

        public void LoadContent()
        {
            Image.LoadContent();
        }

        public void UnloadContent()
        {
            Image.UnloadContent();
        }

        public void Update(GameTime gameTime)
        {
            Image.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Image.Draw(spriteBatch);
        }
    }
}
