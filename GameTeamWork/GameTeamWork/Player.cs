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
                if (InputManager.Instance.KeyPressed(Keys.Space) && Image.Position.Y == 352)
                {
                    ScreenManager.Instance.ChangeScreens("MainGameplayScreen");
                }

                if (InputManager.Instance.KeyPressed(Keys.Space) && Image.Position.Y == 0)
                {
                    ScreenManager.Instance.ChangeScreens("MainGameplayScreen");
                }
            }
            else if (mapSpecs[0].Equals("MainGameplayScreen"))
            {

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
