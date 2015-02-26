using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameTeamWork
{
    public class Player
    {
        public Image Image;
        public Vector2 Velocity;
        public float MoveSpeed;

        private bool isTransitioning;

        public Player()
        {
            Velocity = Vector2.Zero;
        }

        public void LoadContent()
        {
            Image.LoadContent();
        }

        public void UnloadContent()
        {
            Image.UnloadContent();
        }

        public void Update(GameTime gameTime, List<string> mapSpecs)
        {
            Image.IsActive = true;

            //this is to lock the movement, so the player won't move diagonally
            if (Velocity.X == 0)
            {
                if (InputManager.Instance.KeyDown(Keys.Down))
                {
                    Velocity.Y = MoveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                    Image.SpriteSheetEffect.CurrentFrame.Y = 0;
                }
                else if (InputManager.Instance.KeyDown(Keys.Up))
                {
                    Velocity.Y = -MoveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                    Image.SpriteSheetEffect.CurrentFrame.Y = 3;
                }
                else
                {
                    Velocity.Y = 0;
                }
            }

            if (Velocity.Y == 0)
            {
                if (InputManager.Instance.KeyDown(Keys.Right))
                {
                    Velocity.X = MoveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                    Image.SpriteSheetEffect.CurrentFrame.Y = 2;
                }
                else if (InputManager.Instance.KeyDown(Keys.Left))
                {
                    Velocity.X = -MoveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                    Image.SpriteSheetEffect.CurrentFrame.Y = 1;
                }
                else
                {
                    Velocity.X = 0;
                }
            }

            if (Velocity.X == 0 && Velocity.Y == 0)
            {
                Image.IsActive = false;
            }

            if (Image.Position.Y < 0)
            {
                Image.Position.Y = 0;
            }

            if (Image.Position.X < 0)
            {
                Image.Position.X = 0;
            }

            if (Image.Position.Y > ScreenManager.Instance.Dimensions.Y - 34)
            {
                Image.Position.Y = ScreenManager.Instance.Dimensions.Y - 34;
            }

            if (Image.Position.X > ScreenManager.Instance.Dimensions.X - 32)
            {
                Image.Position.X = ScreenManager.Instance.Dimensions.X - 32;
            }

            if (mapSpecs[0].Equals("InitialGameplayScreen"))
            {
                //Event to send the player in MainGamePlay
                if (Image.Position.Y == 352 && !isTransitioning)
                {
                    isTransitioning = true;
                    ScreenManager.Instance.ChangeScreens("MainGameplayScreen");
                }
            }
            else if (mapSpecs[0].Equals("MainGameplayScreen"))
            {
                if (Image.Position.Y == 0 && !isTransitioning) //InputManager.Instance.KeyDown(Keys.Space) && 
                {
                    isTransitioning = true;
                    ScreenManager.Instance.ChangeScreens(mapSpecs[1]);
                }
                
                if (Image.Position.X == 0 && !isTransitioning)
                {
                    isTransitioning = true;
                    ScreenManager.Instance.ChangeScreens(mapSpecs[4]);
                }
                
                if (Image.Position.X == ScreenManager.Instance.Dimensions.X - 32 && !isTransitioning)
                {
                    isTransitioning = true;
                    ScreenManager.Instance.ChangeScreens(mapSpecs[2]);
                }
                
                if (Image.Position.Y == ScreenManager.Instance.Dimensions.Y - 34 && !isTransitioning)
                {
                    isTransitioning = true;
                    ScreenManager.Instance.ChangeScreens(mapSpecs[3]);
                }
            }
            

            Image.Update(gameTime);
            Image.Position += Velocity;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Image.Draw(spriteBatch);
        }
    }
}
