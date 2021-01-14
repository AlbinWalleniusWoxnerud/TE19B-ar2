using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MyGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        Texture2D snakeTexture;
        public int orgheight = snakeTexture.Height;
        Rectangle snakeRec;
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
            snakeTexture = Content.Load<Texture2D>("snake");
            snakeRec = new Rectangle(100, 200, snakeTexture.Width / 2, snakeTexture.Height / 2);
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            if (snakeTexture.Height == orgheight * 2)
            {
                snakeRec.X -= 1;
                snakeRec.Y -= 1;
            }
            if (snakeTexture.Height == orgheight)
            {
                snakeRec.X += 1;
                snakeRec.Y += 1;
            }
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(snakeTexture, snakeRec, Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
