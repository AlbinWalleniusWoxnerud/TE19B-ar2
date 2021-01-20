using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MyGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        Texture2D snakeTexture;
        public int oHeight;
        public int x = 1;

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
            snakeRec = new Rectangle(10, 20, snakeTexture.Width / 2, snakeTexture.Height / 2);
            oHeight = snakeTexture.Height;

            // TODO: use this.Content to load your game content here
        }
        protected override void Update(GameTime gameTime)
        {

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            if (snakeRec.Height == oHeight * 2)
            {
                x = -1;
            }
            System.Console.WriteLine(snakeRec.Height);
            System.Console.WriteLine(snakeRec.Width);
            if (snakeRec.Height == oHeight)
            {
                x = 1;
            }
            snakeRec.Width += 1 * x;
            snakeRec.Height += 1 * x;
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
