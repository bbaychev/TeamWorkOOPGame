using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Game
{
    public class ScreenManager
    {
        public GraphicsDevice GraphicsDevice;
        public SpriteBatch SpriteBatch;
        private static ScreenManager instance;
        XmlManager<GameScreen> xmlGameScreenManager;
        GameScreen currentScreen;

        private ScreenManager() 
        {
            Dimensions = new Vector2(920, 560);
            currentScreen = new SplashScreen();
            xmlGameScreenManager = new XmlManager<GameScreen>();
            xmlGameScreenManager.Type = currentScreen.Type;
            currentScreen = xmlGameScreenManager.Load("Content/Load/SplashScreen.xml");
        }

        public Vector2 Dimensions { get; private set; }
        public ContentManager Content { get; private set; }

        public static ScreenManager Instance 
        { 
            get 
            {
                if (instance == null)
                {
                    instance = new ScreenManager();
                }

                return instance;
            }
        }

        public void LoadContent(ContentManager content)
        {
            this.Content = new ContentManager(content.ServiceProvider, "Content");
            currentScreen.LoadContent();
        }

        //I guess there should be an attribute here...
        public void UnloadContent()
        {
            currentScreen.UnloadContent();
        }

        public void Update(GameTime gameTime)
        {
            currentScreen.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            currentScreen.Draw(spriteBatch);
        }
    }
}
