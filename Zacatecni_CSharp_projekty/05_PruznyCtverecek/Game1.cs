using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace _05_PruznyCtverecek
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D mojeTextura;

        private int poziceX;
        private int poziceY;
        private int Sirka;
        private int Vyska;
        private Color barva = Color.Green;
        private float rychlostY;
        private float gravitece;
        private float pruznost;
        private bool gravitaceOn;
        


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            //Rozměry čtverce
            poziceX = 200;
            poziceY = 200;
            Sirka = 50;
            Vyska = 50;

            //Vlastnosti čtverce
            gravitece = 0.5f;
            rychlostY = 0f;
            pruznost = 0.7f;
            gravitaceOn = true;
            
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            mojeTextura = new Texture2D(GraphicsDevice, Sirka, Vyska);
            Color[] barvy = new Color[Sirka * Vyska];
            for (int i = 0; i < barvy.Length; i++)
            {
                barvy[i] = barva;
            }
            mojeTextura.SetData(barvy);
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
            _spriteBatch.Draw(mojeTextura, new Rectangle(poziceX, poziceY, Sirka, Vyska), Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
