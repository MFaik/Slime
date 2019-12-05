using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Entities;

namespace Tut
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D sprite;
        Vector2 position;
        Player player;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            this.TargetElapsedTime = new System.TimeSpan(0, 0, 0, 0, 16); // 16.666ms = 60fps
        }

        protected override void Initialize()
        {
            base.Initialize();
            player = new Player(Vector2.Zero,sprite);
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            sprite = Content.Load < Texture2D >("ISBD");
        }

        protected override void UnloadContent()
        {
            Content.Unload();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            if (IsActive)
            {
            }
            base.Update(gameTime);
        }

        protected override void OnActivated(object sender, System.EventArgs args)
        {
            this.Window.Title = "Active Application";
            base.OnActivated(sender, args);
        }

        protected override void OnDeactivated(object sender, System.EventArgs args)
        {
            this.Window.Title = "InActive Application";
            base.OnActivated(sender, args);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin(sortMode: SpriteSortMode.FrontToBack);
            //spriteBatch.Draw(sprite,new Rectangle(0,0,114,114),Color.White);
            player.render(spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}