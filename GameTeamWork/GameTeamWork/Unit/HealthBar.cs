﻿using Microsoft.Xna.Framework.Graphics;
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

        public HealthBar(ContentManager content)
        {
            position = new Vector2(100, 100);
            LoadContent(content);
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
            spritebatch.Draw(healthBar, position, Color.White);
        }


    }
}