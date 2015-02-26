using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameTeamWork
{
    public class InitialGameplayScreen : GameScreen
    {
        private Player player;
        private Map map;
        private List<string> mapSpecs = new List<string>();

        public override void LoadContent()
        {
            base.LoadContent();

            XmlManager<Player> playerLoader = new XmlManager<Player>();
            XmlManager<Map> mapLoader = new XmlManager<Map>();
            //The order of these is important
            //first - the current screen
            mapSpecs.Add("InitialGameplayScreen");
            //second - the screen on top
            mapSpecs.Add("MainGameplayScreen");
            //third - the screen on the right
            mapSpecs.Add("MainGameplayScreen");
            //fourth - the screen on the bottom
            mapSpecs.Add("MainGameplayScreen");
            //fifth - the screen on the left
            mapSpecs.Add("MainGameplayScreen");
            player = playerLoader.Load("Load/Gameplay/Player.xml");
            this.player.Image.Position = new Vector2(340, 230);
            map = mapLoader.Load("Load/Gameplay/Maps/01RoomMap.xml");
            player.LoadContent();
            map.LoadContent();
        }

        public override void UnloadContent()
        {
            base.UnloadContent();
            player.UnloadContent();
            map.UnloadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            //this may not be the best way to do it, but I can't think of anything else
            player.Update(gameTime, mapSpecs);
            map.Update(gameTime, ref player);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
            map.Draw(spriteBatch, "Underlay");
            player.Draw(spriteBatch);
            map.Draw(spriteBatch, "Overlay");
        }
    }
}
