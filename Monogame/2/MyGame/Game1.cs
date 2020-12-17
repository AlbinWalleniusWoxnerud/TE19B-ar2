using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MyGame
{
    public class Game1 : Game
    {
        Texture2D hippoTexture, crocodileTexture, bearTexture, whaleTexture;
        Vector2 whalePos = new Vector2(100, 100);
        Vector2 crocodilePos = new Vector2(200, 200);
        Vector2 hippoPos = new Vector2(300, 300);
        Vector2 bearPos = new Vector2(400, 400);
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            bearTexture = Content.Load<Texture2D>("bear");
            whaleTexture = Content.Load<Texture2D>("whale");
            crocodileTexture = Content.Load<Texture2D>("crocodile");
            hippoTexture = Content.Load<Texture2D>("hippo");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(bearTexture, bearPos, Color.White);
            _spriteBatch.Draw(whaleTexture, whalePos, Color.White);
            _spriteBatch.Draw(crocodileTexture, crocodilePos, Color.White);
            _spriteBatch.Draw(hippoTexture, hippoPos, Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
