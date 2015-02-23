using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace TileMapEditor
{
    class Editor : GraphicsDeviceControl
    {
        private Map map;
        private ContentManager content;
        private SpriteBatch spriteBatch;

        public Editor()
        {
            map = new Map();
        }

        protected override void Initialize()
        {
            content = new ContentManager(Services, "Content");
            spriteBatch = new SpriteBatch(GraphicsDevice);

            XmlSerializer xml = new XmlSerializer(map.GetType());
            Stream stream = File.Open("Load/Map.xml", FileMode.Open);
            map = (Map)xml.Deserialize(stream);
            map.Initialize(content);
        }

        protected override void Draw()
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            map.Draw(spriteBatch);
            spriteBatch.End();
        }
    }
}
