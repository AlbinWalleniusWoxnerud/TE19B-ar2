using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MyGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        Texture2D narwhalTexture;
        Vector2 narwhalPos = new Vector2(100, 100);
        MouseState mousemouse = Mouse.GetState();
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            IsMouseVisible = true;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            narwhalTexture = Content.Load<Texture2D>("narwhal");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            mousemouse = Mouse.GetState();
            float this1X = (narwhalPos.X + (narwhalTexture.Width / 2));
            float this1Y = (narwhalPos.Y + (narwhalTexture.Height / 2));
            float thisX = mousemouse.X - this1X;
            float thisY = mousemouse.Y - this1Y;
            narwhalPos.X += thisX * 0.001f;
            narwhalPos.Y += thisY * 0.001f;

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(narwhalTexture, narwhalPos, Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
