using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
namespace GameTeamWork.Unit
{
    public class HealthBar
    {
        private Texture2D healthBar;
        private Vector2 position;
        private int currentHealth;

        public HealthBar(ContentManager content, int currentHealth)
        {
            position = new Vector2(10, 10);
            LoadContent(content);
            this.currentHealth = currentHealth;
        }

        private void LoadContent(ContentManager content)
        {
            healthBar = content.Load<Texture2D>("Health_Bar");
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(healthBar, position,new Rectangle((int) position.X,(int) position.Y, currentHealth, healthBar.Height) ,Color.White);
        }


    }
}